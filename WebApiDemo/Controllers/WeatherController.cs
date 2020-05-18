using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using AspNetCoreWebAPI.Services;
using WebApiDemo.Services;
using WebApiDemo.Models;
namespace WebApiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
          
        WeatherService _WeatherServices;

        public WeatherController(WeatherService weatherServices){
        this._WeatherServices = weatherServices;
        }

    [HttpGet]
    public ActionResult Get(){
          
          return Ok(this._WeatherServices.GetWeather());
    }

    [HttpGet("{CityName}")]

    public ActionResult Get(string CityName){

        return Ok(_WeatherServices.GetTemperature(CityName));
    }

    [HttpPost]

    public ActionResult Post(Weather weather){
         this._WeatherServices.AddWeather(weather);
        return Ok();
    }    

    }

}        