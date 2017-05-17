using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Datum2
    {
        public int Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public double PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
        public double Temperature { get; set; }
        public double ApparentTemperature { get; set; }
        public double DewPoint { get; set; }
        public double Humidity { get; set; }
        public double WindSpeed { get; set; }
        public int WindBearing { get; set; }
        public double Visibility { get; set; }
        public double CloudCover { get; set; }
        public double Pressure { get; set; }
        public double Ozone { get; set; }
    }
}
