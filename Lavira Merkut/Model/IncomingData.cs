using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavira_Merkut.Model
{
    public class IncomingData
    {
        float teamID;
        float counter;
        float altitude;
        float gps_altitude;
        float gps_latitude;
        float gps_longitude;
        float payload_gps_altitude;
        float payload_gps_latitude;
        float payload_gps_longitude;
        float gyroscope_X;
        float gyroscope_Y;
        float gyroscope_Z;
        float acceleration_X;
        float acceleration_Y;
        float acceleration_Z;
        float angle;
        float airPressure;
        float velocity;
        float crc;

        public float TeamID { get => teamID; set => teamID = value; }
        public float Counter { get => counter; set => counter = value; }
        public float Altitude { get => altitude; set => altitude = value; }
        public float Gps_altitude { get => gps_altitude; set => gps_altitude = value; }
        public float Gps_latitude { get => gps_latitude; set => gps_latitude = value; }
        public float Gps_longitude { get => gps_longitude; set => gps_longitude = value; }
        public float Payload_gps_altitude { get => payload_gps_altitude; set => payload_gps_altitude = value; }
        public float Payload_gps_latitude { get => payload_gps_latitude; set => payload_gps_latitude = value; }
        public float Payload_gps_longitude { get => payload_gps_longitude; set => payload_gps_longitude = value; }
        public float Gyroscope_X { get => gyroscope_X; set => gyroscope_X = value; }
        public float Gyroscope_Y { get => gyroscope_Y; set => gyroscope_Y = value; }
        public float Gyroscope_Z { get => gyroscope_Z; set => gyroscope_Z = value; }
        public float Acceleration_X { get => acceleration_X; set => acceleration_X = value; }
        public float Acceleration_Y { get => acceleration_Y; set => acceleration_Y = value; }
        public float Acceleration_Z { get => acceleration_Z; set => acceleration_Z = value; }
        public float Angle { get => angle; set => angle = value; }
        public float AirPressure { get => airPressure; set => airPressure = value; }
        public float Velocity { get => velocity; set => velocity = value; }
        public float Crc { get => crc; set => crc = value; }
    }
}
