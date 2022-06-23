using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavira_Merkut.Singleton
{
    class IncomingDataSingleton
    {
        private static IncomingDataSingleton instance;
        private IncomingDataSingleton() { }

        public static IncomingDataSingleton GetInstance()
        {
            return instance ?? (instance = new IncomingDataSingleton());
        }


        string teamID;
        string counter;
        string altitude;
        string gps_altitude;
        string gps_latitude;
        string gps_longitude;
        string payload_gps_altitude;
        string payload_gps_latitude;
        string payload_gps_longitude;
        string gyroscope_X;
        string gyroscope_Y;
        string gyroscope_Z;
        string acceleration_X;
        string acceleration_Y;
        string acceleration_Z;
        string angle;
        string airPressure;
        string velocity;
        string state;
        string crc;

        public string TeamID { get => teamID; set => teamID = value; }
        public string Counter { get => counter; set => counter = value; }
        public string Altitude { get => altitude; set => altitude = value; }
        public string Gps_altitude { get => gps_altitude; set => gps_altitude = value; }
        public string Gps_latitude { get => gps_latitude; set => gps_latitude = value; }
        public string Gps_longitude { get => gps_longitude; set => gps_longitude = value; }
        public string Payload_gps_altitude { get => payload_gps_altitude; set => payload_gps_altitude = value; }
        public string Payload_gps_latitude { get => payload_gps_latitude; set => payload_gps_latitude = value; }
        public string Payload_gps_longitude { get => payload_gps_longitude; set => payload_gps_longitude = value; }
        public string Gyroscope_X { get => gyroscope_X; set => gyroscope_X = value; }
        public string Gyroscope_Y { get => gyroscope_Y; set => gyroscope_Y = value; }
        public string Gyroscope_Z { get => gyroscope_Z; set => gyroscope_Z = value; }
        public string Acceleration_X { get => acceleration_X; set => acceleration_X = value; }
        public string Acceleration_Y { get => acceleration_Y; set => acceleration_Y = value; }
        public string Acceleration_Z { get => acceleration_Z; set => acceleration_Z = value; }
        public string Angle { get => angle; set => angle = value; }
        public string AirPressure { get => airPressure; set => airPressure = value; }
        public string Velocity { get => velocity; set => velocity = value; }
        public string State { get => state; set => state = value; }
        public string Crc { get => crc; set => crc = value; }
    }
}
