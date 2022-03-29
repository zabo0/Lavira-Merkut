using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavira_Merkut.Model
{
    public class IncomingData
    {

        double velocity;
        double temperature;
        double pressure;
        double moisture;
        double altitude;
        Location location;
        Acceleration acceleration;

        public double Velocity { get => velocity; set => velocity = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public double Pressure { get => pressure; set => pressure = value; }
        public double Moisture { get => moisture; set => moisture = value; }
        public double Altitude { get => altitude; set => altitude = value; }
        internal Location Location { get => location; set => location = value; }
        internal Acceleration Acceleration { get => acceleration; set => acceleration = value; }
    }
}
