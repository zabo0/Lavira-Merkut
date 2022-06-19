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


        public string COMPort="COM5";

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
            //var settings = new CefSettings();

            //settings.RegisterScheme(new CefCustomScheme
            //{
            //    SchemeName = "google",
            //    DomainName = "map",
            //    SchemeHandlerFactory = new FolderSchemeHandlerFactory(
            //        rootFolder: @"C:/Users/Sabahattin/Desktop/LaviraArayuzTest",
            //        hostName: "map",
            //        defaultPage: "index.html" // will default to index.html
            //    )
            //});

            //Cef.Initialize(settings);
        }

        public ChromiumWebBrowser browser;

        public void InitBrowser()
        { 
            browser = new ChromiumWebBrowser("google://map/");
            panel_3dMap.Controls.Add(browser); 
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
            //MoveWindow(p.MainWindowHandle, 0, 0, panelUnity.Width, panelUnity.Height, true);
            //MoveWindow(p.MainWindowHandle, 0, 0, 900, 480, true);


            float f = 44.54321f;
            uint u = BitConverter.ToUInt32(BitConverter.GetBytes(f), 0);
            System.Diagnostics.Debug.Assert(u == 0x42322C3F); 
        }


        public void startProcess()
        {
            ////butun sureci baslatacak fonksiyon
            //timer.Start();
            //state = true;
            ////veriOku(); streamLoop();
            //label_timeText.Text = "Time";    
            //InitBrowser();
        }

        public void finishProcess()
        {
            //butun sureci bitirecek fonksiyon
            timer.Stop();
            textBox_state.AppendText(currentTime + "\tKurtarma sistemi baslatildi" + Environment.NewLine);
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
            if(milisecond == 100)
            {
                milisecond = 0;
                second++;
            }if(second == 60)
            {
                milisecond = 0;
                second = 0;
                minute++;
            }if(minute == 60)
            {
                milisecond = 0;
                second = 0;
                minute = 0;
                hour++;
                
            }


            string time = /*hour + ":" +*/ minute.ToString("00") + ":" + second.ToString("00") + "." + milisecond.ToString("00");
            return time;
        }
        //"234.54  0
        //_435.63  1
        //_39.925019  2
        //_32.836954  3
        //_1.51  4
        //_0.49  5
        //_0.61  6
        //_0.0411  7
        //_0.0140  8
        //_0.9552  9
        //_5.08  10
        //_3  11
        //async void streamLoop()
        //{
        //    start:
        //    if (state)
        //    {
        //        try
        //        {
        //            Random random = new Random(); 
        //            strReceived = stream.ReadLine();
        //            label2.Text = random.Next(1,1000).ToString();
        //            await Task.Delay(200);
        //            strData = strReceived.Split('_');
        //            label_altitude.Text = strData[0];
        //            label_rocketalt.Text = strData[1];
        //            label_locationX.Text = strData[2];
        //            label_locationY.Text = strData[3];
        //            label_accelerationX.Text = strData[4];
        //            label_accelerationY.Text = strData[5];
        //            label_accelerationZ.Text = strData[6];
        //            label_Vx.Text = strData[7];
        //            label_Vz.Text = strData[8];
        //            label_velocity.Text = strData[9];
        //            label_angle.Text = strData[10];
        //            label_state.Text = strData[11];
        //        }
        //        catch  { } 
        //    }
        //    goto start;
        //}

        public void veriOku()
        {
            stream = new SerialPort(COMPort, 9600);
            stream.Open();
            state = true;  
        }

        private void button_moveCursor_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
        }

        private void button_zoom_in_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
        }

        private void button_zoom_out_Click(object sender, EventArgs e)
        {
            axMap1.CursorMode = MapWinGIS.tkCursorMode.cmMeasure;
            axMap1.Measuring.MeasuringType = MapWinGIS.tkMeasuringType.MeasureArea;
        }

        


        private void button_pan_Click(object sender, EventArgs e)
        {
            double xMin = 29.860;
            double yMin = 40.733;
            double xMax = 30.0;
            double yMax = 40.790;

            int shapeIndex = 0;

            // the location of points will be random
            Random rnd = new Random(DateTime.Now.Millisecond);

            double langitute = xMin + (xMax - xMin) * rnd.NextDouble();
            double latitute = yMin + (yMax - yMin) * rnd.NextDouble();


            for(int i=0; i<1000; i++)
            {
                langitute += 0.0002;
                latitute += 0.0001;
                CreatePointShapefile(axMap1, shapeIndex, langitute, latitute);
            }

            //CreatePointShapefile(axMap1, shapeIndex, langitute, latitute);
            //CreatePointShapefile(axMap1, shapeIndex, 32.852796, 39.910211);
        }

        // <summary>
        // Handles mouse down event and adds the marker
        // </summary>
        private void axMap1_MouseDownEvent(object sender, AxMapWinGIS._DMapEvents_MouseDownEvent e)
        {
            
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
