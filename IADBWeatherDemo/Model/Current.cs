using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Model
{
    public class Current
    {
        public long dt { get; set; }
        public DateTime current_dt { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double dew_point { get; set; }
        public double uvi { get; set; }
        public double clouds { get; set; }
        public double visibility { get; set; }
        public double wind_speed { get; set; }
        public double wind_deg { get; set; }
        public double wind_gust { get; set; }
        public List<Weather> weather { get; set; }
        

    }
}



