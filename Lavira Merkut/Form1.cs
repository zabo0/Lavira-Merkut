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
using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.Web;
using CefSharp.WinForms;
using Lavira_Merkut.Singleton;

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
        static SettingsSingleton settings;

        bool state = false;

        public static bool resizableWindow;
        SerialPort stream_getIncomingData;
        SerialPort stream_get3DRocketSimData;
        SerialPort stream_sendDataToHYI;

        public string strReceived;

        public string[] strData = new string[4];
        public string[] strData_received = new string[4];

        private byte TEAM_ID = 23;
        private byte counter = 0;

        

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
           


            settings = SettingsSingleton.GetInstance();

            float f = 44.54321f;
            uint u = BitConverter.ToUInt32(BitConverter.GetBytes(f), 0);
            System.Diagnostics.Debug.Assert(u == 0x42322C3F); 
        }

        private void button_open3DRocket_Click(object sender, EventArgs e)
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
        }

        public void startProcess()
        {
            ////butun sureci baslatacak fonksiyon
            incomingData = IncomingDataSingleton.GetInstance();

            try
            {
                openPortToIncomingData(settings.IncomingDataPort);
                if (settings.IsSendDataToRocket)
                {
                    openPortTo3DRocketSim(settings.RocketSimulationPort);
                }
                if (settings.IsSendData)
                {
                    openPortToSendData(settings.SendingDataPort);
                }
                timer.Start();
                if (settings.SendDataAutomatic)
                {
                    getDataFromCOMportLoop();
                }
                label_timeText.Text = "Time";
                textBox_state.AppendText(currentTime + "\t=====GOREV BASLATILDI=====" + Environment.NewLine);
                InitBrowser();

            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                return;
            }

            
        }

        public void finishProcess()
        {
            //butun sureci bitirecek fonksiyon
            timer.Stop();
            textBox_state.AppendText(currentTime + "\t=====GOREV BITIRILDI=====" + Environment.NewLine);
            closePort_incomingData();
            closePort_sendData();
            closePort_3DRocketSim();
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
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
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

        

        //0.0 teamID
        //0.1 counter

        //00 altitude
        //01 gps altitude
        //02 gps latitude
        //03 gps longitude
        //04 payload gps altitude
        //05 payload gps latitude
        //06 payload pgs longitude
        //07 gyroscope x
        //08 gyroscope y
        //09 gyroscope z
        //10 acceleration x
        //11 acceleration y
        //12 acceleration z
        //13 air pressure
        //14 angle
        //15 velocity
        //16 state

        //0.2 crc

        async void getDataFromCOMportLoop()
        {
        start:
            if (state)
            {
             try{
                read:
                    strReceived = stream_getIncomingData.ReadLine();
                    await Task.Delay(200);
                    strData = strReceived.Split('_');
                    while (strData.Length != 17) {goto read;}

                   
                    if (settings.IsSendData)
                    {
                        byte[] package = createPackage(strData);
                        //stream_sendDataToHYI.Write(package, 0, package.Length);
                        textBox_controls.AppendText(package[75].ToString() + Environment.NewLine);
                    }

                    if (settings.IsSendDataToRocket)
                    {
                        byte[] package = createPackageTo3DRocket(strData);
                        stream_get3DRocketSimData.Write(package, 0, package.Length);
                    }

                    incomingData.Altitude = strData[0];
                    incomingData.Gps_altitude = strData[1];
                    incomingData.Gps_latitude = strData[2];
                    incomingData.Gps_longitude = strData[3];
                    incomingData.Payload_gps_altitude = strData[4];
                    incomingData.Payload_gps_latitude = strData[5];
                    incomingData.Payload_gps_longitude = strData[6];
                    incomingData.Gyroscope_X = strData[7];
                    incomingData.Gyroscope_Y = strData[8];
                    incomingData.Gyroscope_Z = strData[9];
                    incomingData.Acceleration_X = strData[10];
                    incomingData.Acceleration_Y = strData[11];
                    incomingData.Acceleration_Z = strData[12];
                    incomingData.AirPressure = strData[13];
                    incomingData.Angle = strData[14];
                    incomingData.Velocity = strData[15];
                    incomingData.State = strData[16];

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

        async void getDataFromCOMport()
        {

            try
            {
                strReceived = stream_getIncomingData.ReadLine();
                await Task.Delay(200);
                strData = strReceived.Split('_');

                if (settings.IsSendData)
                {
                    byte[] package = createPackage(strData);
                    //stream_sendDataToHYI.Write(package, 0, package.Length);
                    textBox_controls.AppendText(package[75].ToString() + Environment.NewLine);
                }

                if (settings.IsSendDataToRocket)
                {
                    byte[] package = createPackageTo3DRocket(strData);
                    stream_get3DRocketSimData.Write(package, 0, package.Length);
                }

                incomingData.Altitude = strData[0];
                incomingData.Gps_altitude = strData[1];
                incomingData.Gps_latitude = strData[2];
                incomingData.Gps_longitude = strData[3];
                incomingData.Payload_gps_altitude = strData[4];
                incomingData.Payload_gps_latitude = strData[5];
                incomingData.Payload_gps_longitude = strData[6];
                incomingData.Gyroscope_X = strData[7];
                incomingData.Gyroscope_Y = strData[8];
                incomingData.Gyroscope_Z = strData[9];
                incomingData.Acceleration_X = strData[10];
                incomingData.Acceleration_Y = strData[11];
                incomingData.Acceleration_Z = strData[12];
                incomingData.AirPressure = strData[13];
                incomingData.Angle = strData[14];
                incomingData.Velocity = strData[15];
                incomingData.State = strData[16];

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

                browser.EvaluateScriptAsync("setmark(" + incomingData.Gps_latitude + "," + incomingData.Gps_longitude + ");");

                //CreatePointShapefile(axMap1, 0, Convert.ToDouble(strData[3]), Convert.ToDouble(strData[2]));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        public void openPortToIncomingData(string port)
        {
            try
            {
                stream_getIncomingData = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
                stream_getIncomingData.Open();
                state = true;
            } catch(Exception e)
            {
                throw e;
            }
        }

        public void openPortToSendData(string port)
        {
            try
            {
                stream_sendDataToHYI = new SerialPort(port, 19200, Parity.None, 8, StopBits.One);
                stream_sendDataToHYI.Open();
                state = true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void openPortTo3DRocketSim(string port)
        {
            try
            {
                stream_get3DRocketSimData = new SerialPort(port, 19200, Parity.None, 8, StopBits.One);
                stream_get3DRocketSimData.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void closePort_incomingData()
        {
            stream_getIncomingData.Close();
            state = false;
        }
        public void closePort_sendData()
        {
            stream_sendDataToHYI.Close();
            settings.IsSendData = false;
        }

        public void closePort_3DRocketSim()
        {
            stream_get3DRocketSimData.Close();
            settings.IsSendDataToRocket = false;
        }

        private byte[] createPackage(string[] data)
        {
            String[] newData = new String[data.Length];

            for(int i=0; i<data.Length; i++)
            {
                newData[i] = data[i].Replace('.', ',');
            }

            byte[] package = new byte[78];

            package[0] = 0xFF;
            package[1] = 0xFF;
            package[2] = 0x54;
            package[3] = 0x52;

            package[4] = TEAM_ID; //teamID 
            package[5] = counter++; //counter

            //altitude
            package[6] = getBytes(float.Parse(newData[0]))[0];
            package[7] = getBytes(float.Parse(newData[0]))[1];
            package[8] = getBytes(float.Parse(newData[0]))[2];
            package[9] = getBytes(float.Parse(newData[0]))[3];
            //gps altitude
            package[10] = getBytes(float.Parse(newData[1]))[0];
            package[11] = getBytes(float.Parse(newData[1]))[1];
            package[12] = getBytes(float.Parse(newData[1]))[2];
            package[13] = getBytes(float.Parse(newData[1]))[3];
            //gps latitude
            package[14] = getBytes(float.Parse(newData[2]))[0];
            package[15] = getBytes(float.Parse(newData[2]))[1];
            package[16] = getBytes(float.Parse(newData[2]))[2];
            package[17] = getBytes(float.Parse(newData[2]))[3];
            //gps longitude
            package[18] = getBytes(float.Parse(newData[3]))[0];
            package[19] = getBytes(float.Parse(newData[3]))[1];
            package[20] = getBytes(float.Parse(newData[3]))[2];
            package[21] = getBytes(float.Parse(newData[3]))[3];
            //payload gps altitude             
            package[22] = getBytes(float.Parse(newData[4]))[0];
            package[23] = getBytes(float.Parse(newData[4]))[1];
            package[24] = getBytes(float.Parse(newData[4]))[2];
            package[25] = getBytes(float.Parse(newData[4]))[3];
            //payload gps latitude             
            package[26] = getBytes(float.Parse(newData[5]))[0];
            package[27] = getBytes(float.Parse(newData[5]))[1];
            package[28] = getBytes(float.Parse(newData[5]))[2];
            package[29] = getBytes(float.Parse(newData[5]))[3];
            //payload gps longitude           
            package[30] = getBytes(float.Parse(newData[6]))[0];
            package[31] = getBytes(float.Parse(newData[6]))[1];
            package[32] = getBytes(float.Parse(newData[6]))[2];
            package[33] = getBytes(float.Parse(newData[6]))[3];
            //kademe gps irtifa (bizde yok)
            package[34] = 0x00;
            package[35] = 0x00;
            package[36] = 0x00;
            package[37] = 0x00;
            //kademe gps enlem (bizde yok)
            package[38] = 0x00;
            package[39] = 0x00;
            package[40] = 0x00;
            package[41] = 0x00;
            //kademe gps boylam (bizde yok)
            package[42] = 0x00;
            package[43] = 0x00;
            package[44] = 0x00;
            package[45] = 0x00;
            //gyroscope x
            package[46] = getBytes(float.Parse(newData[7]))[0];
            package[47] = getBytes(float.Parse(newData[7]))[1];
            package[48] = getBytes(float.Parse(newData[7]))[2];
            package[49] = getBytes(float.Parse(newData[7]))[3];
            //gyroscope y                      
            package[50] = getBytes(float.Parse(newData[8]))[0];
            package[51] = getBytes(float.Parse(newData[8]))[1];
            package[52] = getBytes(float.Parse(newData[8]))[2];
            package[53] = getBytes(float.Parse(newData[8]))[3];
            //gyroscope z                    
            package[54] = getBytes(float.Parse(newData[9]))[0];
            package[55] = getBytes(float.Parse(newData[9]))[1];
            package[56] = getBytes(float.Parse(newData[9]))[2];
            package[57] = getBytes(float.Parse(newData[9]))[3];
            //acceleration x                  
            package[58] = getBytes(float.Parse(newData[10]))[0];
            package[59] = getBytes(float.Parse(newData[10]))[1];
            package[60] = getBytes(float.Parse(newData[10]))[2];
            package[61] = getBytes(float.Parse(newData[10]))[3];
            //acceleration y                   
            package[62] = getBytes(float.Parse(newData[11]))[0];
            package[63] = getBytes(float.Parse(newData[11]))[1];
            package[64] = getBytes(float.Parse(newData[11]))[2];
            package[65] = getBytes(float.Parse(newData[11]))[3];
            //acceleration z                  
            package[66] = getBytes(float.Parse(newData[12]))[0];
            package[67] = getBytes(float.Parse(newData[12]))[1];
            package[68] = getBytes(float.Parse(newData[12]))[2];
            package[69] = getBytes(float.Parse(newData[12]))[3];
            //angle                            
            package[70] = getBytes(float.Parse(newData[14]))[0];
            package[71] = getBytes(float.Parse(newData[14]))[1];
            package[72] = getBytes(float.Parse(newData[14]))[2];
            package[73] = getBytes(float.Parse(newData[14]))[3];
            //state                          
            package[74] = getBytes(float.Parse(newData[16]))[0];
            //crc
            package[75] = calculateCRC(package);
            package[76] = 0x0D;
            package[77] = 0x0A;

            return package;

        }

        public byte[] createPackageTo3DRocket(string[] data)
        {
            String[] newData = new String[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i].Replace('.', ',');
            }

            byte[] package = new byte[12];


            //gyroscope x
            package[0] = getBytes(float.Parse(newData[7]))[0];
            package[1] = getBytes(float.Parse(newData[7]))[1];
            package[2] = getBytes(float.Parse(newData[7]))[2];
            package[3] = getBytes(float.Parse(newData[7]))[3];
            //gyroscope y                      
            package[4] = getBytes(float.Parse(newData[8]))[0];
            package[5] = getBytes(float.Parse(newData[8]))[1];
            package[6] = getBytes(float.Parse(newData[8]))[2];
            package[7] = getBytes(float.Parse(newData[8]))[3];
            //gyroscope z                    
            package[8] = getBytes(float.Parse(newData[9]))[0];
            package[9] = getBytes(float.Parse(newData[9]))[1];
            package[10] = getBytes(float.Parse(newData[9]))[2];
            package[11] = getBytes(float.Parse(newData[9]))[3];

            return package;
        }


        byte calculateCRC(byte[] package)
        {
            int check_sum = 0;
            for (int i = 4; i < 75; i++)
            {
                check_sum += package[i];
            }
            return Convert.ToByte(check_sum % 256);
        }


        private byte[] getBytes(float value)
        {
            var buffer = BitConverter.GetBytes(value);
            if (!BitConverter.IsLittleEndian)
            {
                return buffer;
            }
            return new[] { buffer[0], buffer[1], buffer[2], buffer[3] };
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_infoText_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_getDataOnce_Click(object sender, EventArgs e)
        {
            getDataFromCOMport();
        }

       
    }
}
