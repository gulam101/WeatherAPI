using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherAPI.OpenWeatherMap_Forecast.Data_Handling
{
    public class OpenWeatherMapList
    {
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
    }
}
