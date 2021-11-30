using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OniCloud.Api.Cars.Core;
using OniCloud.Api.Cars.Domain.Entities;
using OniCloud.Api.Cars.Domain.Stores;

namespace OniCloud.Api.Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        #region Fields

        private readonly ICarsService _service;

        #endregion

        #region Constructors

        public CarsController(ICarsService service)
        {
            _service = service;
        }

        #endregion

        #region Actions

        [HttpPost]
        public async Task<IActionResult> CreateCar([FromBody]Car car)
        {
            Car savedCar = await _service.SaveCarAsync(car);
            return Ok(savedCar);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(string id)
        {
            bool result = await _service.RemoveCarAsync(id);
            return result ? Ok() : NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCarsAsync()
        {
            // throw new Exception("Da Error is HERE!!!");

            IEnumerable<Car> cars = await _service.FetchAllCarsAsync();

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByIdAsync(string id)
        {
            Car car = await _service.FetchByIdAsync(id);

            return car != null
                ? Ok(car)
                : NotFound();
        }

        [HttpGet("make/{make}")]
        public async Task<IActionResult> GetAllCarsByMakeAsync(string make)
        {
            IEnumerable<Car> cars = await _service.FetchAllCarsByMakeAsync(make);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        [HttpGet("model/{model}")]
        public async Task<IActionResult> GetAllCarsByModelAsync(string model)
        {
            IEnumerable<Car> cars = await _service.FetchAllCarsByModelAsync(model);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }


        [HttpGet("year/{year}")]
        public async Task<IActionResult> GetAllCarsByYearAsync(string year)
        {
            IEnumerable<Car> cars = await _service.FetchAllCarsByYearAsync(year);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        #endregion
    }
}
