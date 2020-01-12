using DocumentFormat.OpenXml.Spreadsheet;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WeatherAPI.OpenWeatherMap_Forecast.Data_Handling
{
    public class OpenWeatherMapList
    {
        //Generating Data 1
        public int dt { get; set; }
        public Main main { get; set; }
        public List<Weather> weather { get; set; }
        public Clouds cloud { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public System sys { get; set; }
        public string dt_txt { get; set; }
    }

    public class Main
    {

    }
}
