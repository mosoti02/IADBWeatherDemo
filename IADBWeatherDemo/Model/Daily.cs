using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Model
{
    public class Daily : Current
    {
        public long moonrise { get; set; }
        public long moonset { get; set; }
        public double moon_phase { get; set; }
        public double pop { get; set; }
        public new Temp temp { get; set; }

        public new FeelsLike feels_like { get; set; }

    }
}
