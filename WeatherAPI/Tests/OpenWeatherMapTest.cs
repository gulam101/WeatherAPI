﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using WeatherAPI.OpenWeatherMap_Forecast;

namespace WeatherAPI.Tests
{
    [TestFixture]
    public class OpenWeatherMapTest
    {
        private OpenWeatherMapService openWeatherMapForecast = new OpenWeatherMapService();

        [Test]
        public void OpenWeatherMapCod()
        {
            //Testing the internal paramter for code and paramater stay the same
            NUnit.Framework.Assert.AreEqual("200", openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.cod);
        }

        [Test]
        public void OpenWeatherMapMessage()
        {
            //internal paramater changes. therefore the test of message will be to check
            //if the message is greater than 0.0
            NUnit.Framework.Assert.Greater(openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.message, 0.0);
        }

        [Test]
        public void OpenWeatherMapCnt()
        {
            NUnit.Framework.Assert.AreEqual(40, openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.cnt);
        }

        //Test for weather list
        [Test]
        public void OpenWeatherMapListDT()
        {
            //checking the dt length
            int dt = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].dt.ToString().Length;
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.list[0].dt.ToString().Length, dt);
        }

        [Test]
        public void OpenWeatherMapListTempCompare()
        {
            //Compare Temp with Temp min
            double temp = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.temp;
            double tempmin = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_min;
            NUnit.Framework.Assert.AreEqual(temp, tempmin);
        }

        [Test]
        public void OpenWeatherMapListTemp_Min()
        {
            double kelvin = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.temp_max;
            double kelvin2 = 283.13099999999997;
            NUnit.Framework.Assert.That(kelvin2, Is.EqualTo(kelvin));
        }

        public void OpenWeatherMapListPressureCompareWithSeaLevel()
        {
            //Compares pressure with Sea Level
            double pressure = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.pressure;
            double sealevel = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.sea_level;
            NUnit.Framework.Assert.AreEqual(pressure, sealevel);
        }

        [Test]
        public void OpenWeatherMapListGrnd_Level()
        {
            NUnit.Framework.Assert.GreaterOrEqual(openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.list[0].main.grnd_level, 1000);
        }
        
        [Test]
        public void OpenWeatherMapListMainHumditiy()
        {
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.humidity.GetType(), typeof(int));
        }

        [Test]
        public void OpenWeatherMapListTemp_Kf()
        {
            NUnit.Framework.Assert.That(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.temp_kf, Is.LessThan(0.0));
        }

    }
}
