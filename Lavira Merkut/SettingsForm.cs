using Lavira_Merkut.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavira_Merkut
{
    public partial class SettingsForm : Form
    {

        string[] ports = SerialPort.GetPortNames();
        static string fullPath = "C:\\Users\\Sabahattin\\Desktop\\Lavira Rocket\\Lavira Merkut Program\\Lavira Merkut\\Lavira Merkut\\settings.txt";
        string[] savedSettings = File.ReadAllLines(fullPath);

        SettingsSingleton settings;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

            settings = SettingsSingleton.GetInstance();
            setComboBoxItems();

            if(savedSettings.Length == 14)
            {
                settings.IncomingDataPortInfo = savedSettings[1];
                settings.RocketSimulationPortInfo = savedSettings[3];
                settings.SendingDataPortInfo = savedSettings[5];
                settings.IsSendDataToRocket = Convert.ToBoolean(savedSettings[7]);
                settings.IsSendDataToHYI = Convert.ToBoolean(savedSettings[9]);
                settings.TeamID = Convert.ToByte(savedSettings[11]);
            }

            comboBox_incomingDataComPort.Text = settings.IncomingDataPortInfo;
            comboBox_3dRocketSimulationComPort.Text = settings.RocketSimulationPortInfo;
            comboBox_sendingDataComPort.Text = settings.SendingDataPortInfo;

            checkBox_isSend.Checked = settings.IsSendDataToHYI;
            //checkBox_sendDataAutomatic.Checked = settings.SendDataAutomatic;
            checkBox_sendDataToRocket.Checked = settings.IsSendDataToRocket;

            textBox_teamID.Text = settings.TeamID.ToString();


            //tabControl1.Appearance = TabAppearance.FlatButtons;
            //tabControl1.ItemSize = new Size(0, 1);
            //tabControl1.SizeMode = TabSizeMode.Fixed;
            //tabControl1.SelectedTab = tabPage2;
        }

        private void setComboBoxItems()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_SerialPort"))
            {

                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();

                comboBox_incomingDataComPort.Items.Add("none");
                comboBox_3dRocketSimulationComPort.Items.Add("none");
                comboBox_sendingDataComPort.Items.Add("none");

                foreach (string port in tList)
                {
                    comboBox_incomingDataComPort.Items.Add(port);
                    comboBox_3dRocketSimulationComPort.Items.Add(port);
                    comboBox_sendingDataComPort.Items.Add(port);
                }
            }
        }

        private void comboBox_incomingDataComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_3dRocketSimulationComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_sendingDataComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_isSend_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_sendDataAutomatic_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_sendDataToRocket_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (comboBox_incomingDataComPort.Text != null && comboBox_incomingDataComPort.Text != "" && comboBox_incomingDataComPort.Text != "none")
            {
                settings.IncomingDataPort = comboBox_incomingDataComPort.Text.Split('(')[1].TrimEnd(')');
                settings.IncomingDataPortInfo = comboBox_incomingDataComPort.Text;
            }
            else
            {
                settings.IncomingDataPort = null;
                settings.IncomingDataPortInfo = null;
            }
            

            if(comboBox_3dRocketSimulationComPort.Text != null && comboBox_3dRocketSimulationComPort.Text != "" && comboBox_3dRocketSimulationComPort.Text != "none")
            {
                settings.RocketSimulationPort = comboBox_3dRocketSimulationComPort.Text.Split('(')[1].TrimEnd(')');
                settings.RocketSimulationPortInfo = comboBox_3dRocketSimulationComPort.Text;
            }
            else
            {
                settings.RocketSimulationPort = null;
                settings.RocketSimulationPortInfo = null;
                checkBox_sendDataToRocket.Checked = false;
            }

            if (comboBox_sendingDataComPort.Text != null && comboBox_sendingDataComPort.Text != "" && comboBox_sendingDataComPort.Text != "none")
            {
                settings.SendingDataPort = comboBox_sendingDataComPort.Text.Split('(')[1].TrimEnd(')');
                settings.SendingDataPortInfo = comboBox_sendingDataComPort.Text;
            }
            else
            {
                settings.SendingDataPort = null;
                settings.SendingDataPortInfo = null;
                checkBox_isSend.Checked = false;
            }
            if (checkBox_isSend.Checked)
            {
                settings.IsSendDataToHYI = true;
            }
            else
            {
                settings.IsSendDataToHYI = false;
            }

            //if (checkBox_sendDataAutomatic.Checked)
            //{
            //    settings.SendDataAutomatic = true;
            //}
            //else
            //{
            //    settings.SendDataAutomatic = false;
            //}

            if (checkBox_sendDataToRocket.Checked)
            {
                settings.IsSendDataToRocket = true;
            }
            else
            {
                settings.IsSendDataToRocket = false;
            }
            

            settings.TeamID = byte.Parse(textBox_teamID.Text);

            saveAllPorts();

            this.Close();
        }


        private void textBox_teamID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte.Parse(textBox_teamID.Text);
            }
            catch(Exception error)
            {
                MessageBox.Show("you can only type numbers between 0 and 255\n" + error.Message);
                textBox_teamID.Text = "0";
                textBox_teamID.SelectAll();
            }
        }


        private void saveAllPorts()
        {
            // Write file using StreamWriter  
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine("incomingDataPort");
                writer.WriteLine(comboBox_incomingDataComPort.Text);
                writer.WriteLine("rocketDataPort");
                writer.WriteLine(comboBox_3dRocketSimulationComPort.Text);
                writer.WriteLine("sendToHYIPort");
                writer.WriteLine(comboBox_sendingDataComPort.Text);
                //writer.WriteLine("getDataAutomaticCheckBox");
                //writer.WriteLine(checkBox_sendDataAutomatic.Checked.ToString());
                writer.WriteLine("sendToRocketCheckBox");
                writer.WriteLine(checkBox_sendDataToRocket.Checked.ToString());
                writer.WriteLine("sendDataToHYICheckBox");
                writer.WriteLine(checkBox_isSend.Checked.ToString());
                writer.WriteLine("teamID");
                writer.WriteLine(settings.TeamID.ToString());
            }
            // Read a file  
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
        }

    }
}
