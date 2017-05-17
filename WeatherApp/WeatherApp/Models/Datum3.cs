using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Datum3
    {
        public int Time { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public int SunriseTime { get; set; }
        public int SunsetTime { get; set; }
        public double MoonPhase { get; set; }
        public double PrecipIntensity { get; set; }
        public double PrecipIntensityMax { get; set; }
        public float PrecipProbability { get; set; }
        public double TemperatureMin { get; set; }
        public int TemperatureMinTime { get; set; }
        public double TemperatureMax { get; set; }
        public int TemperatureMaxTime { get; set; }
        public double ApparentTemperatureMin { get; set; }
        public int ApparentTemperatureMinTime { get; set; }
        public double ApparentTemperatureMax { get; set; }
        public int ApparentTemperatureMaxTime { get; set; }
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
