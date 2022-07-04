using Lavira_Merkut.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        SettingsSingleton settings;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            settings = SettingsSingleton.GetInstance();
            setComboBoxItems();

            comboBox_incomingDataComPort.Text = settings.IncomingDataPortInfo;
            comboBox_3dRocketSimulationComPort.Text = settings.RocketSimulationPortInfo;
            comboBox_sendingDataComPort.Text = settings.SendingDataPortInfo;

            checkBox_isSend.Checked = settings.IsSendData;
            checkBox_sendDataAutomatic.Checked = settings.SendDataAutomatic;
            checkBox_sendDataToRocket.Checked = settings.IsSendDataToRocket;

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
            if(comboBox_incomingDataComPort.Text != "none")
            {
                string selectedPort = comboBox_incomingDataComPort.Text.Split('(')[1].TrimEnd(')');
                settings.IncomingDataPort = selectedPort;
                settings.IncomingDataPortInfo = comboBox_incomingDataComPort.Text;
            }
            
        }

        private void comboBox_3dRocketSimulationComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_3dRocketSimulationComPort.Text != "none")
            {
                string selectedPort = comboBox_3dRocketSimulationComPort.Text.Split('(')[1].TrimEnd(')');
                settings.RocketSimulationPort = selectedPort;
                settings.RocketSimulationPortInfo = comboBox_3dRocketSimulationComPort.Text;
            }
            
        }

        private void comboBox_sendingDataComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_sendingDataComPort.Text != "none")
            {
                string selectedPort = comboBox_sendingDataComPort.Text.Split('(')[1].TrimEnd(')');
                settings.SendingDataPort = selectedPort;
                settings.SendingDataPortInfo = comboBox_sendingDataComPort.Text;
            }
           
        }

        private void checkBox_isSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_isSend.Checked)
            {
                settings.IsSendData = true;
            }
            else
            {
                settings.IsSendData = false;
            }
        }

        private void checkBox_sendDataAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_sendDataAutomatic.Checked)
            {
                settings.SendDataAutomatic = true;
            }
            else
            {
                settings.SendDataAutomatic = false;
            }
        }

        private void checkBox_sendDataToRocket_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_isSend.Checked)
            {
                settings.IsSendDataToRocket = true;
            }
            else
            {
                settings.IsSendDataToRocket = false;
            }
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
                settings.IsSendData = true;
            }
            else
            {
                settings.IsSendData = false;
            }

            if (checkBox_sendDataAutomatic.Checked)
            {
                settings.SendDataAutomatic = true;
            }
            else
            {
                settings.SendDataAutomatic = false;
            }

            if (checkBox_sendDataToRocket.Checked)
            {
                settings.IsSendDataToRocket = true;
            }
            else
            {
                settings.IsSendDataToRocket = false;
            }

            this.Close();
        }
    }
}
