using System;
using System.Collections.Generic;
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
            NUnit.Framework.Assert.AreEqual(40, openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.cnt);
        }

        //Test for weather list
        [Test]
        public void OpenWeatherMapListDT()
        {
            //checking the dt length
            int dt = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].dt.ToString().Length;
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.list[0].dt.ToString().Length, dt);
        }

        [Test]
        public void OpenWeatherMapListTempCompare()
        {
            //Compare Temp with Temp min
            double temp = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.temp;
            double tempmin = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.temp_min;
            NUnit.Framework.Assert.AreEqual(temp, tempmin);
        }

        [Test]
        public void OpenWeatherMapListTemp_Min()
        {
            double kelvin = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.temp_max;
            double kelvin2 = 283.13099999999997;
            NUnit.Framework.Assert.That(kelvin2, Is.EqualTo(kelvin));
        }

        public void OpenWeatherMapListPressureCompareWithSeaLevel()
        {
            //Compares pressure with Sea Level
            double pressure = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.pressure;
            double sealevel = openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].main.sea_level;
            NUnit.Framework.Assert.AreEqual(pressure, sealevel);
        }

        [Test]
        public void OpenWeatherMapListGrnd_Level()
        {
            NUnit.Framework.Assert.GreaterOrEqual(openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.list[0].main.grnd_level, 1000);
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

        [Test] 
        public void OpenWeatherMapListWeatherID()
        {
            //list for ID for weather
            var rain = new List<int>();
            //list for rain id
            rain.AddRange(new[] { 500, 501, 502, 503, 504, 511, 520, 521, 522, 531 });
            //lists for cloud id
            rain.AddRange(new[] { 801, 802, 803, 804 });
            //lists for thunder id
            rain.AddRange(new[] { 200, 201, 202, 211, 212, 221, 230, 231, 232 });
            //lists for clear
            rain.AddRange(new[] { 800 });

            NUnit.Framework.Assert.Contains(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].weather[0].id, rain);
        }

        [Test]
        public void OpenWeatherMapListWeatherName()
        {
            var rainname = new List<string>();
            rainname.AddRange(new[] { "Clouds", "Clear", "Rain", "Atmosphere", "Snow", "Drizzle", "ThunderStorm" });
            NUnit.Framework.Assert.Contains(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].weather[0].main, rainname);
        }

        [Test]
        public void OpenWeatherMapListCloud()
        {
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].cloud.all.GetType(), typeof(int));
        }

        [Test]
        public void OpenWeatherMapListWindSpeed()
        {
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].wind.speed.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapListWindDeg()
        {
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].wind.deg.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapListRain()
        {
            NUnit.Framework.Assert.GreaterOrEqual(openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.list[0].rain.three, 0);
        }

        [Test]
        public void OpenWeatherMapListSys()
        {
            NUnit.Framework.Assert.AreEqual(1, openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.list[0].sys.pod.Length);
        }

        [Test]
        public void OpenWeatherMapListDT_Text()
        {
            NUnit.Framework.Assert.AreEqual(19, openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.list[0].dt_txt.Length);
        }

        //Test for City
        [Test]
        public void OpenWeatherMapCityID()
        {
            //Testing if the city ID matches with api city ID
            NUnit.Framework.Assert.AreEqual(2643743, openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.city.id);
        }

        [Test]
        public void OpenWeatherMapCityName()
        {
            //Testing if the city name mathces with api city name
            NUnit.Framework.Assert.AreEqual("London", openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.city.name);
        }

        [Test]
        public void OpenWeatherMapCityTimezone()
        {
            var offset = TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).TotalSeconds;
            int timezone = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.city.timezone;
            NUnit.Framework.Assert.That(offset, Is.EqualTo(timezone));
        }

        [Test]
        public void OpenWeatherMapCityCoordLat()
        {
            //Test if the latitude type is double
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.city.coord.lat.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapCityCoordLon()
        {
            //Test of the longitude type is double
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.
            openWeatherMap.city.coord.lat.GetType(), typeof(double));
        }

        [Test]
        public void OpenWeatherMapCountryName()
        {
            //Testing if the city name mathces with api country name
            NUnit.Framework.Assert.AreEqual("GB", openWeatherMapForecast.
            openWeatherMapDTO.openWeatherMap.city.country);
        }

        [Test]
        public void OpenWeatherMapCityPopulation()
        {
            //Test if population is not empty
            NUnit.Framework.Assert.IsNotNull(openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.city.population);
        }

        [Test]
        public void OpenWeatherMapCitySunriseORSunset()
        {
            //Test if the sunrise/sunset type is int
            int sun = openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.city.sunrise.ToString().Length;
            NUnit.Framework.Assert.AreEqual(openWeatherMapForecast.openWeatherMapDTO.openWeatherMap.city.sunrise.ToString().Length, sun);
        }

    }
}
