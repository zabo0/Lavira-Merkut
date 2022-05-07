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
        private Form activeForm;

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


        //alt formlari ana formda acar
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_formContainer.Controls.Add(childForm);
            this.panel_formContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Label_LaviraMerkut.Text = childForm.Text;

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
            OpenChildForm(new View.Dashboard(), sender);
        }

        private void button_finish_Click(object sender, EventArgs e)
        {
            finishProcess();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Dashboard(), sender);
        }

        private void button_velocity_Click(object sender, EventArgs e)
        {
            OpenChildForm(new View.Velocity(), sender);
        }

        private void button_Temperature_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_Pressure_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_Moisture_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_acceleration_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_location_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button_altitude_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
