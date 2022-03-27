using IADBWeatherDemo.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IADBWeatherDemo.Repositories
{
    public class WForecastRepository : IWForecastRepository
    {
        public WeatherResponse GetForecast(double lat, double lon, string unit)
        {
            using(var httpClient = new HttpClient())
            {
                try
                {
                    string APP_ID = Configuration.Values.OPENWEATHERFREEAPPKEY;
                    var url = $"https://api.openweathermap.org/data/2.5/onecall?lat={lat}&lon={lon}&units={unit}&appid={APP_ID}&exclude=hourly,minutely";
                    using (var response = Task.Run(() => { return httpClient.GetAsync(url); }).Result)
                    {
                        string apiResponse = Task.Run(() => { return response.Content.ReadAsStringAsync(); }).Result;
                        var resp = JsonConvert.DeserializeObject<WeatherResponse>(apiResponse);
                        resp.current.current_dt = DateTimeOffset.FromUnixTimeSeconds(resp.current.dt).DateTime;
                        return resp;
                    }
                }
                catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
