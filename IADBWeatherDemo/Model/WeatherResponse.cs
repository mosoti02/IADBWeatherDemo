using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Model
{
    public class WeatherResponse
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public double timezone_offset { get; set; }
        public Current current { get; set; }
        public List<Daily> daily { get; set; }

    }

}
