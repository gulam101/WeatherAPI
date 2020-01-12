﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAPI.OpenWeatherMap_Forecast.Data_Handling;
using WeatherAPI.OpenWeatherMap_Forecast.HTTP_Manager;

namespace WeatherAPI.OpenWeatherMap_Forecast
{
    class OpenWeatherMapService
    {
        //We need DTO
        public OpenWeatherMapDTO openWeatherMapDTO = new OpenWeatherMapDTO();
        //We need Call Manager
        public OpenWeatherMapCallManager openWeatherMapCall = new OpenWeatherMapCallManager();
    }
}
