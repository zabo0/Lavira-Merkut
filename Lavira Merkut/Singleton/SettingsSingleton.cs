using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavira_Merkut.Singleton
{
    class SettingsSingleton
    {

        public static SettingsSingleton instance;
        private SettingsSingleton() { }

        public static SettingsSingleton GetInstance()
        {
            return instance ?? (instance = new SettingsSingleton());
        }


        string incomingDataPort;
        string rocketSimulationPort;
        string sendingDataPort;
        bool isSendData = false;
        bool sendDataAutomatic = false;

        public string IncomingDataPort { get => incomingDataPort; set => incomingDataPort = value; }
        public string SendingDataPort { get => sendingDataPort; set => sendingDataPort = value; }
        public string RocketSimulationPort { get => rocketSimulationPort; set => rocketSimulationPort = value; }
        public bool IsSendData { get => isSendData; set => isSendData = value; }
        public bool SendDataAutomatic { get => sendDataAutomatic; set => sendDataAutomatic = value; }
    }
}
