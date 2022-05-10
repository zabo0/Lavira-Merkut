using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        Simulation sim;

        public Form1()
        {
            InitializeComponent();
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
            sim = new Simulation();

            //Process p = Process.Start("C:\\Users\\Sabahattin\\Desktop\\LaviraMerkut3D_2.exe");
            ////Thread.Sleep(500); // Allow the process to open it's window
            //p.WaitForInputIdle();
            //p.WaitForInputIdle();
            //Thread.Sleep(3000); //sleep for 3 seconds
            //SetParent(p.MainWindowHandle, panel_unity.Handle);
            //SetWindowLong(p.MainWindowHandle, GWL_STYLE, WS_VISIBLE);
            ////MoveWindow(p.MainWindowHandle, 0, 0, panelUnity.Width, panelUnity.Height, true);
            //MoveWindow(p.MainWindowHandle, 0, 0, 900, 480, true);
        }


        public void startProcess()
        {
            //butun sureci baslatacak fonksiyon
            timer.Start();
            label_timeText.Text = "Time";
        }

        public void finishProcess()
        {
            //butun sureci bitirecek fonksiyon
            timer.Stop();
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
            //ayarlarda simule et etkinlestirilirse veritabanindan cektigi verileri yazar
            if (true)
            {

            }
            else
            {
                simulation(iteration);
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





        void simulation(int iteration)
        {

            if(iteration == 10)
            {

            }

            try
            {
                double altitude = (double)sim.Altitude[iteration];
                chart_altitude.Series["Altitude"].Points.AddXY(iteration, altitude);
                textBox_altitude.Text = altitude.ToString();

                double velocityZ = (double)sim.VelocityZ[iteration];
                chart_velocity.Series["Velocity"].Points.AddXY(iteration, velocityZ);
                textBox_Vz.Text = velocityZ.ToString();
            }
            catch (Exception e)
            {
                finishProcess();
            }
        }


    }
}
