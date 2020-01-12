using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    class OpenWeatherMapConfig
    {
        public static readonly String baseURL = ConfigurationManager.AppSettings["base_url"];
    }
}
