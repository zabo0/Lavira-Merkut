using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.SchemeHandler;
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

        static SettingsSingleton settings;

        bool state = false;

        public static bool resizableWindow;
        SerialPort stream_getIncomingData = new SerialPort();
        SerialPort stream_get3DRocketSimData = new SerialPort();
        SerialPort stream_sendDataToHYI = new SerialPort();

        public string strReceived;

        public string[] strData = new string[4];
        public string[] strData_received = new string[4];

        //private byte TEAM_ID = settings.TeamID;
        private byte counter = 0;

        //saved settings to txt
        static string fullPath = "C:\\Users\\Sabahattin\\Desktop\\Lavira Rocket\\Lavira Merkut Program\\Lavira Merkut\\Lavira Merkut\\settings.txt";
        string[] savedSettings = File.ReadAllLines(fullPath);


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

            if (savedSettings.Length == 14)
            {
                settings.IncomingDataPort = savedSettings[1].Split('(')[1].TrimEnd(')'); ;
                settings.RocketSimulationPort = savedSettings[3].Split('(')[1].TrimEnd(')'); ;
                settings.SendingDataPort = savedSettings[5].Split('(')[1].TrimEnd(')'); ;
                settings.SendDataAutomatic = Convert.ToBoolean(savedSettings[7]);
                settings.IsSendDataToRocket = Convert.ToBoolean(savedSettings[9]);
                settings.IsSendDataToHYI = Convert.ToBoolean(savedSettings[11]);
                settings.TeamID = Convert.ToByte(savedSettings[13]);
            }


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

            try
            {
                openPortToIncomingData(settings.IncomingDataPort);
                if (settings.IsSendDataToRocket)
                {
                    openPortTo3DRocketSim(settings.RocketSimulationPort);
                }
                if (settings.IsSendDataToHYI)
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
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {
                finishProcess();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
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


        //P BASINCYUKSEKLIK X X_ACISI Y Y_ACISI E ENLEM B BOYLAM Y YUKSEKLIK_GPS
        //P123456 X-15.1456 Y174.5236 E4044.4863 B2953.4156 Y9.8

        async void getDataFromCOMportLoop()
        {
        start:
            if (state)
            {
             try{
                read:
                    strReceived = stream_getIncomingData.ReadLine().TrimEnd('\r');

                    string data = stringConvert(strReceived);

                    await Task.Delay(200);

                    strData = data.Split('_');

                    while (strData.Length != 17) {goto read;}

                   
                    if (settings.IsSendDataToHYI)
                    {
                        byte[] package = createPackage(strData);
                        stream_sendDataToHYI.Write(package, 0, package.Length);
                    }

                    if (settings.IsSendDataToRocket)
                    {
                        byte[] package = createPackageTo3DRocket(strData);
                        stream_get3DRocketSimData.Write(package, 0, package.Length);
                    }

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
                    chart_velocity.Series["Velocity"].Points.AddXY(currentTime, strData[15]);
                    chart_altitude.Series["Altitude"].Points.AddXY(currentTime, strData[0]);

                    browser.EvaluateScriptAsync("setmark(" + strData[2] + "," + strData[3] + ");");

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



        public void openPortToIncomingData(string port)
        {
            try
            {
                //stream_getIncomingData = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
                stream_getIncomingData.PortName = port;
                stream_getIncomingData.BaudRate = 9600;
                stream_getIncomingData.Parity = Parity.None;
                stream_getIncomingData.DataBits = 8;
                stream_getIncomingData.StopBits = StopBits.One;
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
                //stream_sendDataToHYI = new SerialPort(port, 19200, Parity.None, 8, StopBits.One);
                stream_sendDataToHYI.PortName = port;
                stream_sendDataToHYI.BaudRate = 19200;
                stream_sendDataToHYI.Parity = Parity.None;
                stream_sendDataToHYI.DataBits = 8;
                stream_sendDataToHYI.StopBits = StopBits.One;
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
                //stream_get3DRocketSimData = new SerialPort(port, 19200, Parity.None, 8, StopBits.One);
                stream_get3DRocketSimData.PortName = port;
                stream_get3DRocketSimData.BaudRate = 19200;
                stream_get3DRocketSimData.Parity = Parity.None;
                stream_get3DRocketSimData.DataBits = 8;
                stream_get3DRocketSimData.StopBits = StopBits.One;
                stream_get3DRocketSimData.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public void closePort_incomingData()
        {
            if (stream_getIncomingData.IsOpen)
            {
                stream_getIncomingData.Close();
                state = false;
            }
        }
        public void closePort_sendData()
        {
            if (stream_sendDataToHYI.IsOpen)
            {
                stream_sendDataToHYI.Close();
                settings.IsSendDataToHYI = false;
            }
            
        }

        public void closePort_3DRocketSim()
        {
            if (stream_get3DRocketSimData.IsOpen)
            {
                stream_get3DRocketSimData.Close();
                settings.IsSendDataToRocket = false;
            }
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

            package[4] = settings.TeamID; //teamID 
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

        //P BASINCYUKSEKLIK X X_ACISI Y Y_ACISI E ENLEM B BOYLAM Y YUKSEKLIK_GPS
        //P123456 X-15.1456 Y174.5236 E4044.4863 B2953.4156 Y9.8

        private string stringConvert(string data)
        {

            data = data.TrimEnd('\r');

            int P = data.IndexOf("P");
            int X = data.IndexOf("X");
            int Y = data.IndexOf("Y");
            int E = data.IndexOf("E");
            int B = data.IndexOf("B");
            int A = data.IndexOf("A");


            string altitude = data.Substring(P + 1, X-P-1);
            string gyroX = data.Substring(X + 1, Y-X-1);
            string gyroY = data.Substring(Y + 1, E-Y-1);
            string gps_latitude = data.Substring(E + 1, B-E-1);
            string gps_longitude = data.Substring(B + 1, A-B-1);
            string gps_altitude = data.Substring(A + 1, data.Length-A-1);

            string result = 
                altitude +"_" + 
                gps_altitude + "_" +
                gps_latitude + "_" + 
                gps_longitude + "_" + 
                "0" + "_" + //payload gps altitude
                "0" + "_" + //payload gps latitude
                "0" + "_" + //06 payload pgs longitude
                gyroX + "_"+
                gyroY + "_"+
                "0" + "_" + //09 gyroscope z
                "0" + "_" + //10 acceleration x
                "0" + "_" + //11 acceleration y
                "0" + "_" + //12 acceleration z
                "0" + "_" + //13 air pressure
                "0" + "_" + //14 angle
                "0" + "_" + //15 velocity
                "0";        //16 state

            return result;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_infoText_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
