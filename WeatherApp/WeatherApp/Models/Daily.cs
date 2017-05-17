using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class Daily
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public List<Datum3> Data { get; set; }
    }
}
