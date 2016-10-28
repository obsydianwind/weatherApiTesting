using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using weather.Models;
using weather.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace weather.API
{
    [Route("api/[controller]")]
    public class MakesController : Controller
    {
        private CarService _carService;

        public MakesController(CarService carService)
        {
            _carService = carService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<CarMake> Get()
        {
            return _carService.ListMakes();
        }


    }
}