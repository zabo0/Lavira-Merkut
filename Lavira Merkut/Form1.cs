﻿using System;
using System.Diagnostics;
using System.Drawing;
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
        TimeSpan currentTime;
        TimeSpan startTime;
        TimeSpan finishTime;
        TimeSpan elapsedTime; // gecen sure

        static SettingsSingleton settings;

        private bool state = false;
        private bool isMapOpen = false;

        public static bool resizableWindow;
        SerialPort stream_getIncomingData = new SerialPort();
        SerialPort stream_get3DRocketSimData = new SerialPort();
        SerialPort stream_sendDataToHYI = new SerialPort();

        public string strReceived;

        public string[] strData = new string[4];
        public string[] strData_received = new string[4];

        //private byte TEAM_ID = settings.TeamID;
        private byte counter = 0;
        private int logCounter = 0;

        //saved settings to txt
        static string fullPathToAllData = "C:\\Users\\Sabahattin\\Desktop\\Lavira Rocket\\Lavira Merkut Program\\Lavira Merkut\\Lavira Merkut\\incomingData.txt";
        static string fullPathToSettings = "C:\\Users\\Sabahattin\\Desktop\\Lavira Rocket\\Lavira Merkut Program\\Lavira Merkut\\Lavira Merkut\\settings.txt";

        string[] savedSettings = File.ReadAllLines(fullPathToSettings);
        string[] savedIncomingData = File.ReadAllLines(fullPathToAllData);


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
            textBox_logs.ScrollBars = ScrollBars.Vertical;
            textBox_state.ScrollBars = ScrollBars.Vertical;

            settings = SettingsSingleton.GetInstance();

            if (savedSettings.Length == 14)
            {
                if(savedSettings[1] != "" && savedSettings[1] != "none")
                {
                    settings.IncomingDataPort = savedSettings[1].Split('(')[1].TrimEnd(')');
                }
                if (savedSettings[3] != "" && savedSettings[3] != "none")
                {
                    settings.RocketSimulationPort = savedSettings[3].Split('(')[1].TrimEnd(')');
                }
                if (savedSettings[5] != "" && savedSettings[5] != "none")
                {
                    settings.SendingDataPort = savedSettings[5].Split('(')[1].TrimEnd(')');
                }
                settings.IsSendDataToRocket = Convert.ToBoolean(savedSettings[7]);
                settings.IsSendDataToHYI = Convert.ToBoolean(savedSettings[9]);
                settings.TeamID = Convert.ToByte(savedSettings[11]);
                settings.Simulation = Convert.ToBoolean(savedSettings[13]);
            }

            float f = 44.54321f;
            uint u = BitConverter.ToUInt32(BitConverter.GetBytes(f), 0);
            System.Diagnostics.Debug.Assert(u == 0x42322C3F);

        }

        private void button_open3DRocket_Click(object sender, EventArgs e)
        {
            //burasi 3d roket simulasyonunu baslatir
            button_open3DRocket.Visible = false;
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


        private void button_openMAP_Click(object sender, EventArgs e)
        {
            button_openMAP.Visible = false;
            InitBrowser();
            isMapOpen = true;            
        }

        public void finishProcess()
        {
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.TimeOfDay;
            elapsedTime = currentTime.Subtract(startTime);
            label_timer.Text = elapsedTime.ToString(@"hh\:mm\:ss\.ff");
        }

        private void button_start_Click_1(object sender, EventArgs e)
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

                startTime = DateTime.Now.TimeOfDay;
                label_timeText.Text = "Time";
                timer.Start();
                textBox_state.AppendText(elapsedTime.ToString(@"hh\:mm\:ss\.ff") + " - " + startTime.ToString(@"hh\:mm\:ss\.ff") + "\t=====GOREV BASLATILDI=====" + Environment.NewLine);
                //InitBrowser();

                getDataFromCOMportLoop();
                button_start.Enabled = false;
            }
            catch (Exception error)
            {
                textBox_logs.AppendText(logCounter++ + " - " + "startProcess: " + error.ToString() + Environment.NewLine + Environment.NewLine);
                MessageBox.Show("startProcess: " + error.Message);
                return;
            }
            
        }

        private void button_finish_Click_1(object sender, EventArgs e)
        {
            //butun sureci bitirecek fonksiyon

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Finish", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResult == DialogResult.Yes)
            {  
                finishTime = DateTime.Now.TimeOfDay;
                timer.Stop();
                textBox_state.AppendText(elapsedTime.ToString(@"hh\:mm\:ss\.ff") + " - " + finishTime.ToString(@"hh\:mm\:ss\.ff") + "\t=====GOREV BITIRILDI=====" + Environment.NewLine);
                closePort_incomingData();
                closePort_sendData();
                closePort_3DRocketSim();
                button_finish.Enabled = false;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
        //13 air pressure 1
        //14 air pressure 2
        //15 angle
        //16 velocity
        //17 state

        //0.2 crc


        //P BASINCYUKSEKLIK X X_ACISI Y Y_ACISI E ENLEM B BOYLAM Y YUKSEKLIK_GPS
        //P123456 X-15.1456 Y174.5236 E4044.4863 B2953.4156 Y9.8

        async void getDataFromCOMportLoop()
        {
            int i = 0;

            start:
            if (state)
            {
                if (stream_getIncomingData.IsOpen)
                {
                    try
                    {
                    //read:
                        string data;

                        if (settings.Simulation)
                        {
                            data = savedIncomingData[i++];

                            if(i == savedIncomingData.Length)
                            {
                                return;
                            }
                        }
                        else
                        {
                            strReceived = stream_getIncomingData.ReadLine().TrimEnd('\r');
                            data = stringConvert(strReceived);
                            // Write file using StreamWriter  
                            using (StreamWriter writer = File.AppendText(fullPathToAllData))
                            {
                                writer.WriteLine(data);
                                //writer.WriteLine(elapsedTime.ToString(@"hh\:mm\:ss\.ff") + "-" + currentTime.ToString(@"hh\:mm\:ss\.ff") + "/" + data);
                            }
                        }

                        showDataInUI(data);

                        await Task.Delay(200);

                        
                        
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        textBox_logs.AppendText(logCounter++ + " - " + "getDataFromCOMportLoop: " + e.Message + Environment.NewLine + Environment.NewLine);
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        textBox_logs.AppendText(logCounter++ + " - " + "getDataFromCOMportLoop: " + e.Message + Environment.NewLine + Environment.NewLine);
                    }
                    catch (FormatException e)
                    {
                        textBox_logs.AppendText(logCounter++ + " - " + "getDataFromCOMportLoop: " + e.Message + Environment.NewLine + Environment.NewLine);
                    }
                    catch (Exception e)
                    {
                        textBox_logs.AppendText(logCounter++ + " - " + "getDataFromCOMportLoop: " + e.ToString() + Environment.NewLine + Environment.NewLine);
                        MessageBox.Show("getDataFromCOMportLoop: " + e.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please select COM port in senttings.");
                    state = false;
                    return;
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

            //HYI e gondermek icin paket olustur

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
            package[70] = getBytes(float.Parse(newData[15]))[0];
            package[71] = getBytes(float.Parse(newData[15]))[1];
            package[72] = getBytes(float.Parse(newData[15]))[2];
            package[73] = getBytes(float.Parse(newData[15]))[3];
            //state                          
            package[74] = getBytes(float.Parse(newData[17]))[0];
            //crc
            package[75] = calculateCRC(package);
            package[76] = 0x0D;
            package[77] = 0x0A;

            return package;

        }

        public byte[] createPackageTo3DRocket(string[] data)
        {

            //3d roket icin paket olustur

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
        //13 air pressure 1
        //14 air pressure 2
        //15 angle
        //16 velocity
        //17 state

        //P BASINCYUKSEKLIK X X_ACISI Y Y_ACISI E ENLEM B BOYLAM Y YUKSEKLIK_GPS
        //P123456 X-15.1456 Y174.5236 E4044.4863 B2953.4156 Y9.8

        //*P1:1.01 P2:1.00 $GPGGA,052605.000,4044.6038,N,02956.5326,E,1,06,1.24,93.9,M,39.8,M,,*5B
        private string stringConvert(string data)
        {

            //data = data.TrimEnd('\r');
            string[] splittedData = data.Split('$');

            string[] pressures = splittedData[0].TrimEnd().Split(' ');
            string[] gpggaDatas = splittedData[1].TrimEnd().Split(',');

            string pressure1 = pressures[0].Split(':')[1];
            string pressure2 = pressures[1].Split(':')[1];

            string gps_latitude = convertToDegree(gpggaDatas[2]);
            string gps_longitude = convertToDegree(gpggaDatas[4]);
            string gps_altitude = convertToDegree(gpggaDatas[9]);



            string result = 
                "0" +"_" + //00 altitude
                gps_altitude + "_" + //01 gps altitude
                gps_latitude + "_" + //02 gps latitude
                gps_longitude + "_" + //03 gps longitude
                "0" + "_" + //04 payload gps altitude
                "0" + "_" + //05 payload gps latitude
                "0" + "_" + //06 payload pgs longitude
                "0" + "_" + //07 gyroscope x
                "0" + "_" + //08 gyroscope y
                "0" + "_" + //09 gyroscope z
                "0" + "_" + //10 acceleration x
                "0" + "_" + //11 acceleration y
                "0" + "_" + //12 acceleration z
                pressure1 + "_" + //13 air pressure 1
                pressure2 + "_" + //14 air pressure 2
                "0" + "_" + //15 angle
                "0" + "_" + //16 velocity
                "0";        //17 state

            return result;
        }

        private string convertToDegree(string value)
        {
            value = value.Replace('.', ','); //floata cevirebilmek icin noktalar virgule cevrilir
            value = value.TrimStart(new Char[] { '0' }); //bastaki sifirlari sil
            double degree = float.Parse(value.Substring(0, 2)); //tam derece kismini ayir
            double minute = float.Parse(value.Substring(2, value.Length - 2)); // dakika kismini ayir
            double result = degree + minute * 0.0166666667; //dakikayi dereceye cevir ve tam dereceyle topla
            return result.ToString().Replace(',','.'); //haritada dogru bir sekilde gosterilmesi icin virguller noktaya cevrilir
        }



        private void panel_infoText_Paint(object sender, PaintEventArgs e)
        {

        }



        private void showDataInUI(string data)
        {
            strData = data.Split('_');

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

            textBox_main_altitude.Text = strData[0];
            textBox_main_gps_altitude.Text = strData[1];
            textBox_main_gps_latitude.Text = strData[2];
            textBox_main_gps_longitude.Text = strData[3];
            textBox_payload_gps_altitude.Text = strData[4];
            textBox_payload_gps_latitude.Text = strData[5];
            textBox_payload_gps_longitude.Text = strData[6];
            textBox_main_gyroX.Text = strData[7];
            textBox_main_gyroY.Text = strData[8];
            //textBox_gyroscope_Z.Text = strData[9];
            //textBox_acceleration_X.Text = strData[10];
            //textBox_acceleration_Y.Text = strData[11];
            //textBox_acceleration_Z.Text = strData[12];
            textBox_spare_pressure1.Text = strData[13];
            textBox_spare_pressure2.Text = strData[14];
            //textBox_angle.Text = strData[15];
            textBox_main_velocityV.Text = strData[16];
            chart_velocity.Series["Velocity"].Points.AddXY(elapsedTime.ToString(@"hh\:mm\:ss\.ff"), strData[16]);
            chart_altitude.Series["Altitude"].Points.AddXY(elapsedTime.ToString(@"hh\:mm\:ss\.ff"), strData[1]);

            if (isMapOpen)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0: { browser.EvaluateScriptAsync("setmark(" + strData[2] + "," + strData[3] + ");"); break; } //ana aviyonik
                    case 1: { browser.EvaluateScriptAsync("setmark(" + strData[2] + "," + strData[3] + ");"); break; } //yedek aviyonik
                    case 2: { browser.EvaluateScriptAsync("setmark(" + strData[2] + "," + strData[3] + ");"); break; } //payload
                }
            }
        }

        
    }
}
