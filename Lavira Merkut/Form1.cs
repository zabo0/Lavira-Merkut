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
            Process p = Process.Start("C:\\Users\\Sabahattin\\Desktop\\LaviraMerkut3D_2.exe");
            Thread.Sleep(500); // Allow the process to open it's window
            p.WaitForInputIdle();
            p.WaitForInputIdle();
            Thread.Sleep(3000); //sleep for 3 seconds
            SetParent(p.MainWindowHandle, panel_unity.Handle);
            SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            MoveWindow(p.MainWindowHandle, 0, 0, panel_unity.Width, panel_unity.Height, true);
            MoveWindow(p.MainWindowHandle, 0, 0, 900, 480, true);


            float f = 44.54321f;
            uint u = BitConverter.ToUInt32(BitConverter.GetBytes(f), 0);
            System.Diagnostics.Debug.Assert(u == 0x42322C3F); 
        }


        public void startProcess()
        {
            ////butun sureci baslatacak fonksiyon
            timer.Start();
            state = true;
            PortAc(); 
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
      
        //00 altitude
        //01 gps altitude
        //02 gps latitude
        //03 gps longitude
        //04 payload gps altitude
        //05 payload gps latitude
        //06 payload pgs longitude
        //07 air pressure
        //08 gyroscope x
        //09 gyroscope y
        //10 gyroscope z
        //11 acceleration x
        //12 acceleration y
        //13 acceleration z
        //14 angle
        //15 state
        //16 velocity
        async void streamLoop()
        {
        start:
            if (state)
            {
               try{
                    Random random = new Random();
                    read: strReceived = stream.ReadLine();
                    await Task.Delay(200);
                    strData = strReceived.Split('_');
                    while (strData.Length != 17) {goto read;  } /*MessageBox.Show(strReceived);*/
                    textBox_altitude.Text = strData[0];
                    textBox_gps_altitude.Text = strData[1];
                    textBox_gps_latitude.Text = strData[2];
                    textBox_gps_longitude.Text = strData[3];
                    textBox_payload_gps_altidue.Text = strData[4];
                    textBox_payload_gps_latitude.Text = strData[5];
                    textBox_payload_gps_longitude.Text = strData[6];
                    textBox_air_pressure.Text = strData[7];
                    textBox_gyroscope_X.Text = strData[8];
                    textBox_gyroscope_Y.Text = strData[9];
                    textBox_gyroscope_Z.Text = strData[10];
                    textBox_acceleration_X.Text = strData[11];
                    textBox_acceleration_Y.Text = strData[12];
                    textBox_acceleration_Z.Text = strData[13];
                    textBox_angle.Text = strData[14];
                    chart_velocity.Series["Velocity"].Points.AddXY(currentTime, strData[16]);
                    chart_altitude.Series["Altitude"].Points.AddXY(currentTime, strData[0]);

                    browser.EvaluateScriptAsync("setmark("+strData[2]+","+ strData[3] + ");");

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
            stream = new SerialPort(COMPort, 9600);
            stream.Open();
            state = true;  
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
