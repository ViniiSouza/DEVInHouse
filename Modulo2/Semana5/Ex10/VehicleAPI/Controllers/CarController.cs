using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("car")]
    public class CarController : Controller
    {
        [HttpGet]
        public Car GetCar()
        {
            return new Car(1, new User(), DateTime.Now);
        }

        [HttpGet("list")]
        public List<Car> GetCarList()
        {
            var carList = new List<Car>();
            carList.AddRange(new List<Car>(){new Car(1, new User(), DateTime.Now),
                new Car(2, new User(), DateTime.Now),
                new Car(3, new User(), DateTime.Now),
                new Car(4, new User(), DateTime.Now) });
            return carList;
        }

    }
}
