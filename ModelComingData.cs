using System;
using System.ComponentModel;

public class ModelComingData : INotifyPropertyChanged
{

	private double velocity;
	private double temperature;
	private double pressure;
	private double moistrue;
	private double acceleration;
	private double altitude;
	private ModelLocation location;

    public double Velocity { get => velocity; set { velocity = value; OnPropertyChanged("Velocity"); } }
    public double Temperature { get => temperature; set { temperature = value; OnPropertyChanged("Temperature"); } }
    public double Pressure { get => pressure; set { pressure = value; OnPropertyChanged("Pressure"); } }
    public double Moistrue { get => moistrue; set { moistrue = value; OnPropertyChanged("Moistrue"); } }
    public double Acceleration { get => acceleration; set { acceleration = value; OnPropertyChanged("Acceleration"); } }
    public double Altitude { get => altitude; set { altitude = value; OnPropertyChanged("Altitude"); } }
    public ModelLocation Location { get => location; set { location = value; OnPropertyChanged("Location"); } }
}
