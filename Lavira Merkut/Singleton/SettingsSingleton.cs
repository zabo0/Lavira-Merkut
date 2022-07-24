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

        string incomingDataPortInfo;
        string rocketSimulationPortInfo;
        string sendingDataPortInfo;

        bool isSendDataToHYI = false;
        bool isSendDataToRocket = false;

        byte teamID;

        byte whichAcionic;

        public string IncomingDataPort { get => incomingDataPort; set => incomingDataPort = value; }
        public string SendingDataPort { get => sendingDataPort; set => sendingDataPort = value; }
        public string RocketSimulationPort { get => rocketSimulationPort; set => rocketSimulationPort = value; }
        public bool IsSendDataToHYI { get => isSendDataToHYI; set => isSendDataToHYI = value; }
        public bool IsSendDataToRocket { get => isSendDataToRocket; set => isSendDataToRocket = value; }
        public string IncomingDataPortInfo { get => incomingDataPortInfo; set => incomingDataPortInfo = value; }
        public string RocketSimulationPortInfo { get => rocketSimulationPortInfo; set => rocketSimulationPortInfo = value; }
        public string SendingDataPortInfo { get => sendingDataPortInfo; set => sendingDataPortInfo = value; }
        public byte TeamID { get => teamID; set => teamID = value; }
        public byte WhichAcionic { get => whichAcionic; set => whichAcionic = value; }
    }
}
