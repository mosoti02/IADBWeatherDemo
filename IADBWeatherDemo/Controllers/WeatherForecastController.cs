using IADBWeatherDemo.Model;
using IADBWeatherDemo.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWForecastRepository _WForecastRepository;

        public WeatherForecastController(IWForecastRepository wForecastRepo)
        {
            _WForecastRepository = wForecastRepo;
        }

        [HttpGet]
        public WeatherResponse Get(double lat,double lon, string unit)
        {
            var resp = _WForecastRepository.GetForecast(lat, lon,unit);
            return resp;

        }

    }
}
