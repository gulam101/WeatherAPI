using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI.OpenWeatherMap_Forecast.Data_Handling
{
    class OpenWeatherMapDTO
    {
        public OpenWeatherMapRoot openWeatherMap { get; set; }
        public void DeserializeOpenWeatherMap(String OpenWeatherMapResponse)
        {
            openWeatherMap = JsonConvert.DeserializeObject<OpenWeatherMapRoot>(OpenWeatherMapResponse);
        }
    }
}
