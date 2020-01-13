using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WeatherAPI.OpenWeatherMap_Forecast.HTTP_Manager
{
    class OpenWeatherMapCallManager
    {
        readonly IRestClient client;

        public OpenWeatherMapCallManager()
        {
            client = new RestClient(OpenWeatherMapConfig.baseURL);
        }

        public string GetOpenWeatherMap()
        {
            var reqeust = new RestRequest(OpenWeatherMapConfig.ApiCity
                + "&" + OpenWeatherMapConfig.ApiKey);
            var response = client.Execute(reqeust, Method.GET);
            return response.Content;
        }
    }
}
