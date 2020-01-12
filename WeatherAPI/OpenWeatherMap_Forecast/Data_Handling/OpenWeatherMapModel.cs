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
        public double tempt { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public double pressure { get; set; }
        public double sea_level { get; set; }
        public double grnd_level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string descirption { get; set; }
        public string icon { get; set; }
    }

    public class Clouds
    {
        
    }
}
