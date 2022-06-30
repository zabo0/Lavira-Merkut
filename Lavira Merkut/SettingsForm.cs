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
            string selectedPort = comboBox_incomingDataComPort.Text.Split('(')[1].TrimEnd(')');
            settings.IncomingDataPort = selectedPort;
        }

        private void comboBox_3dRocketSimulationComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPort = comboBox_3dRocketSimulationComPort.Text.Split('(')[1].TrimEnd(')');
            settings.RocketSimulationPort = selectedPort;
        }

        private void comboBox_sendingDataComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPort = comboBox_sendingDataComPort.Text.Split('(')[1].TrimEnd(')');
            settings.SendingDataPort = selectedPort;
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
    }
}
