using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Weather
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Timezone { get; set; }
        public int Offset { get; set; }
        public Currently Currently { get; set; }
        public Minutely Minutely { get; set; }
        public Hourly Hourly { get; set; }
        public Daily Daily { get; set; }
    }
}
