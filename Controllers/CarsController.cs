using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OniCloud.Api.Cars.Domain.Entities;
using OniCloud.Api.Cars.Domain.Stores;

namespace OniCloud.Api.Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        #region Fields

        private readonly ICarsStore _store;

        #endregion

        #region Constructors

        public CarsController(ICarsStore store)
        {
            _store = store;
        }

        #endregion

        #region Actions

        [HttpGet]
        public async Task<IActionResult> GetAllCarsAsync()
        {
            IEnumerable<Car> cars = await _store.GetAll();

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarByIdAsync(string id)
        {
            Car car = await _store.GetById(id);

            return car != null
                ? Ok(car)
                : NotFound();
        }

        [HttpGet("make/{make}")]
        public async Task<IActionResult> GetAllCarsByMakeAsync(string make)
        {
            IEnumerable<Car> cars = await _store.GetByMake(make);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        [HttpGet("model/{model}")]
        public async Task<IActionResult> GetAllCarsByModelAsync(string model)
        {
            IEnumerable<Car> cars = await _store.GetByModel(model);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }


        [HttpGet("year/{year}")]
        public async Task<IActionResult> GetAllCarsByYearAsync(string year)
        {
            IEnumerable<Car> cars = await _store.GetByYear(year);

            return cars.Any()
                ? Ok(cars)
                : NoContent();
        }

        #endregion
    }
}
