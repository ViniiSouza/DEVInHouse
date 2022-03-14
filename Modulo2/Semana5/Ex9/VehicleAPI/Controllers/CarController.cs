using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        
    }
}
