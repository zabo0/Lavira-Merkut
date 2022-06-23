using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxMapWinGIS;
using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.Web;
using CefSharp.WinForms;
using Lavira_Merkut.Singleton;
using MapWinGIS;
using Image = MapWinGIS.Image;
using Point = MapWinGIS.Point;

namespace Lavira_Merkut
{
    public partial class Form1 : Form
    {
        int counterTime = 0;
        string currentTime;

        int milisecond = 0;
        int second = 0;
        int minute = 0;
        int hour = 0;

        IncomingDataSingleton incomingData;

        public string COMPort="COM6";

        bool state = false;

        public static bool resizableWindow;
        SerialPort stream;

        public string strReceived;

        public string[] strData = new string[4];
        public string[] strData_received = new string[4];

        //Simulation sim;

        public Form1()
        {
            InitializeComponent();
            //MarkPoints(axMap1, @"C:\Users\Sabahattin\Desktop\Lavira Rocket\Lavira Merkut Program\MapWinGIS_ShapeFile\");
            var settings = new CefSettings();

            settings.RegisterScheme(new CefCustomScheme
            {
                SchemeName = "google",
                DomainName = "map",
                SchemeHandlerFactory = new FolderSchemeHandlerFactory(
                    rootFolder: @"C:\Users\Sabahattin\Desktop\Lavira Rocket\Lavira Merkut Program\Lavira Merkut\Lavira Merkut\bin\Debug",
                    hostName: "map",
                    defaultPage: "index.html" // will default to index.html
                )
            });

            Cef.Initialize(settings);
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        { 
            browser = new ChromiumWebBrowser("google://map/");
            panel1.Controls.Add(browser); 
            browser.Dock = DockStyle.Fill;
        }

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool MoveWindow(IntPtr Handle, int x, int y, int w, int h, bool repaint);

        static readonly int GWL_STYLE = -16;
        static readonly int WS_VISIBLE = 0x10000000;



        private void Form1_Load(object sender, EventArgs e)
        {
            //burasi 3d roket simulasyonunu baslatir
            //Process p = Process.Start("C:\\Users\\Sabahattin\\Desktop\\LaviraMerkut3D_2.exe");
            //Thread.Sleep(500); // Allow the process to open it's window
            //p.WaitForInputIdle();
            //p.WaitForInputIdle();
            //Thread.Sleep(3000); //sleep for 3 seconds
            //SetParent(p.MainWindowHandle, panel_unity.Handle);
            //SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            //MoveWindow(p.MainWindowHandle, 0, 0, panel_unity.Width, panel_unity.Height, true);
            //MoveWindow(p.MainWindowHandle, 0, 0, 900, 480, true);

            float f = 44.54321f;
            uint u = BitConverter.ToUInt32(BitConverter.GetBytes(f), 0);
            System.Diagnostics.Debug.Assert(u == 0x42322C3F); 
        }


        public void startProcess()
        {
            ////butun sureci baslatacak fonksiyon
            try
            {
                PortAc();
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            incomingData = IncomingDataSingleton.GetInstance();
            timer.Start();
            state = true;
            streamLoop();
            label_timeText.Text = "Time";
            textBox_state.AppendText(currentTime + "\t=====GOREV BASLATILDI=====" + Environment.NewLine);
            InitBrowser();
        }

        public void finishProcess()
        {
            //butun sureci bitirecek fonksiyon
            timer.Stop();
            textBox_state.AppendText(currentTime + "\t=====GOREV BITIRILDI=====" + Environment.NewLine);
            PortKapat();
        }

        private String getTime(int timer)
        {
            //gercek sure ile arasinda ufak fark olabiliyor
            TimeSpan time = TimeSpan.FromMilliseconds(timer);
            string str = time.ToString(@"mm\:ss\.ff"); 
            return str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counterTime++;
            //currentTime = getTime(counterTime);
            currentTime = stopwatch();
            label_timer.Text = currentTime;
            
            setValues(counterTime);
        }

        private void button_start_Click_1(object sender, EventArgs e)
        {
            startProcess();
        }

        private void button_finish_Click_1(object sender, EventArgs e)
        {
            finishProcess();
        }

        private void pictureBox_settings_Click(object sender, EventArgs e)
        {

        }

        private void chart_altitude_Click(object sender, EventArgs e)
        {

        } 

        private void setValues(int iteration)
        {
            //ayarlarda simule et etkinlestirilirse veritabanindan cektigi verileri yazar ayarlar henuz yapilmadi
            if (false)
            {

            }
            else
            {
                //simulation(iteration);
            } 
        }

        string stopwatch()
        {
            milisecond++;
            if (milisecond == 100)
            {
                milisecond = 0;
                second++;
            } if (second == 60)
            {
                milisecond = 0;
                second = 0;
                minute++;
            } if (minute == 60)
            {
                milisecond = 0;
                second = 0;
                minute = 0;
                hour++;

            }


            string time = /*hour + ":" +*/ minute.ToString("00") + ":" + second.ToString("00") + "." + milisecond.ToString("00");
            return time;
        }

        

        //00 teamID
        //01 counter
        //02 altitude
        //03 gps altitude
        //04 gps latitude
        //05 gps longitude
        //06 payload gps altitude
        //07 payload gps latitude
        //08 payload pgs longitude
        //09 gyroscope x
        //10 gyroscope y
        //11 gyroscope z
        //12 acceleration x
        //13 acceleration y
        //14 acceleration z
        //15 air pressure
        //16 angle
        //17 velocity
        //18 state
        //19 crc

        async void streamLoop()
        {
        start:
            if (state)
            {
               try{
                    read: strReceived = stream.ReadLine();
                    await Task.Delay(200);
                    strData = strReceived.Split('_');
                    while (strData.Length != 20) {goto read;}

                    incomingData.TeamID = strData[0];
                    incomingData.Counter = strData[1];
                    incomingData.Altitude = strData[2];
                    incomingData.Gps_altitude = strData[3];
                    incomingData.Gps_latitude = strData[4];
                    incomingData.Gps_longitude = strData[5];
                    incomingData.Payload_gps_altitude = strData[6];
                    incomingData.Payload_gps_latitude = strData[7];
                    incomingData.Payload_gps_longitude = strData[8];
                    incomingData.Gyroscope_X = strData[9];
                    incomingData.Gyroscope_Y = strData[10];
                    incomingData.Gyroscope_Z = strData[11];
                    incomingData.Acceleration_X = strData[12];
                    incomingData.Acceleration_Y = strData[13];
                    incomingData.Acceleration_Z = strData[14];
                    incomingData.AirPressure = strData[15];
                    incomingData.Angle = strData[16];
                    incomingData.Velocity = strData[17];
                    incomingData.State = strData[18];
                    incomingData.Crc = strData[19];

                    textBox_altitude.Text = incomingData.Altitude;
                    textBox_gps_altitude.Text = incomingData.Gps_altitude;
                    textBox_gps_latitude.Text = incomingData.Gps_latitude;
                    textBox_gps_longitude.Text = incomingData.Gps_longitude;
                    textBox_payload_gps_altidue.Text = incomingData.Payload_gps_altitude;
                    textBox_payload_gps_latitude.Text = incomingData.Payload_gps_latitude;
                    textBox_payload_gps_longitude.Text = incomingData.Payload_gps_longitude;
                    textBox_air_pressure.Text = incomingData.AirPressure;
                    textBox_gyroscope_X.Text = incomingData.Gyroscope_X;
                    textBox_gyroscope_Y.Text = incomingData.Gyroscope_Y;
                    textBox_gyroscope_Z.Text = incomingData.Gyroscope_Z;
                    textBox_acceleration_X.Text = incomingData.Acceleration_X;
                    textBox_acceleration_Y.Text = incomingData.Acceleration_Y;
                    textBox_acceleration_Z.Text = incomingData.Acceleration_Z;
                    textBox_angle.Text = incomingData.Angle;
                    chart_velocity.Series["Velocity"].Points.AddXY(currentTime, incomingData.Velocity);
                    chart_altitude.Series["Altitude"].Points.AddXY(currentTime, incomingData.Altitude);

                    browser.EvaluateScriptAsync("setmark("+ incomingData.Gps_latitude + ","+ incomingData.Gps_longitude + ");");

                    //CreatePointShapefile(axMap1, 0, Convert.ToDouble(strData[3]), Convert.ToDouble(strData[2]));

                }
                catch(Exception e) {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                return;
            }
            goto start;
        }

        public void PortAc()
        {
            try
            {
                stream = new SerialPort(COMPort, 9600);
                stream.Open();
                state = true;
            } catch(Exception e)
            {
                throw e;
            }
        }

        public void PortKapat()
        {
            stream.Close();
            state = false;
        }

       

        // <summary>
        // Creates a point shapefile by placing 1000 points randomly
        // </summary>
        public void CreatePointShapefile(AxMap axMap1, int shapeIndex, double langitute, double latitude)
        {
            axMap1.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;

            var sf = new Shapefile();

            // MWShapeId field will be added to attribute table
            bool result = sf.CreateNewWithShapeID("", ShpfileType.SHP_POINT);


            var pnt = new Point();
            double x = 0.0;
            double y = 0.0;
            axMap1.DegreesToProj(langitute, latitude, ref x, ref y);
            pnt.x = x;
            pnt.y = y;

            Shape shp = new Shape();
            shp.Create(ShpfileType.SHP_POINT);

            int index = 0;
            shp.InsertPoint(pnt, ref index);
            sf.EditInsertShape(shp, ref shapeIndex);

            sf.DefaultDrawingOptions.SetDefaultPointSymbol(tkDefaultPointSymbol.dpsStar);

            // adds shapefile to the map
            axMap1.AddLayer(sf, true);

            // save if needed
            //sf.SaveAs(@"c:\points.shp", null);
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
