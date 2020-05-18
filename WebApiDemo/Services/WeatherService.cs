using System;
using System.Collections.Generic;
//using AspNetCoreWebAPI.Models;
using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public class WeatherService
    {
        List<Weather> _WeatherList=  null;

        public WeatherService(){

            _WeatherList = new List<Weather>();
        }

        public List<Weather> GetWeather(){

            return _WeatherList;
        }


        public double GetTemperature(string cityName){
             double citytemp=0;
              foreach(Weather values in _WeatherList)
              {
                    if( values.CityName == cityName)
                       citytemp = values.Temperature;
                   
              }

              return citytemp; 

        }
        public void AddWeather(Weather weather){
            _WeatherList.Add(weather);


        }
    }
}