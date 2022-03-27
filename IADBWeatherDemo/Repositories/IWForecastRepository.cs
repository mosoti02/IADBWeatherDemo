using IADBWeatherDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Repositories
{
    public interface IWForecastRepository
    {
        WeatherResponse GetForecast(double lat, double lon,string unit);
    }
}
