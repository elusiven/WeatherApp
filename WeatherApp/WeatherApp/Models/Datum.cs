using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Datum
    {
        public int Time { get; set; }
        public double PrecipIntensity { get; set; }
        public float PrecipProbability { get; set; }
    }
}
