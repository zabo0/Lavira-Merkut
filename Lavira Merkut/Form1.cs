using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavira_Merkut
{
    public partial class Form1 : Form
    {
        int counterTime = 0;
        string currentTime;

        private Button currentButton;

        public Form1()
        {
            InitializeComponent();
        }


       


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        //navigasyon butonlarindan biri secilince rengini degistirir
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = Color.FromArgb(48, 80, 160);
                    currentButton.ForeColor = Color.White;
                }

            }
        }

        //secilen navigasyon butonundan baskasi secilince rengi eski haline getirir
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_navigationButtons.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 0, 128);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }



        public void startProcess()
        {
            //butun sureci baslatacak fonksiyon
            timer.Start();
            label_textTime.Text = "Time";

        }

        public void finishProcess()
        {
            //butun sureci bitirecek fonksiyon
            timer.Stop();
        }

        private String getTime(int timer)
        {
            //gercek sure ile arasinda ufak fark olabiliyor
            TimeSpan time = TimeSpan.FromSeconds(timer);
            string str = time.ToString(@"hh\:mm\.ss");


            return str;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counterTime++;
            currentTime = getTime(counterTime);
            label_currentTime.Text = currentTime;
        }



        private void button_start_Click(object sender, EventArgs e)
        {
            startProcess();
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            finishProcess();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_velocity_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
