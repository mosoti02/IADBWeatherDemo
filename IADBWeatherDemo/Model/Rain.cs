using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Model
{
    public class Rain
    {
        [JsonProperty("1h")]
        public double firstHour { get; set; }
    }
}
