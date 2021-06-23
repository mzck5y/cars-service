using OniCloud.Api.Cars.Domain.Entities;
using OniCloud.Api.Cars.Domain.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OniCloud.Api.Cars.Data.MemoryStores
{
    public class CarsMemoryStore : ICarsStore
    {
        #region Fields

        private readonly List<Car> _cars = new()
        {
            new Car { Make = "Kia", Model = "Sorento", Year = "2016" },
            new Car { Make = "Kia", Model = "Rio", Year = "2020" },
            new Car { Make = "Chevorlet", Model = "Vogager", Year = "1989" },
            new Car { Make = "Chysler", Model = "Pasifica", Year = "2000" },
            new Car { Make = "Chysler", Model = "Neon", Year = "2019" },
            new Car { Make = "Chevrolet", Model = "Spectrum", Year = "1988" },
            new Car { Make = "Doge", Model = "Caliber", Year = "2009" },
            new Car { Make = "Ford", Model = "Taurus", Year = "2020" },
            new Car { Make = "Ford", Model = "Maverick", Year = "2001" },
            new Car { Make = "Nissan", Model = "Terra", Year = "2021" }
        };

        #endregion

        #region Publci Methods

        public Task<Car> GetById(string id)
        {
            Car car = _cars.FirstOrDefault(c => c.Id == id);
            return Task.FromResult(car);
        }

        public Task<IEnumerable<Car>> GetAll()
        {
            return Task.FromResult(_cars.AsEnumerable());
        }

        public Task<IEnumerable<Car>> GetByMake(string make)
        {
            IEnumerable<Car> cars = _cars.Where(c => c.Make.ToLower() == make.ToLower());
            return Task.FromResult(cars);
        }

        public Task<IEnumerable<Car>> GetByModel(string model)
        {
            IEnumerable<Car> cars = _cars.Where(c => c.Model.ToLower() == model.ToLower());
            return Task.FromResult(cars);
        }

        public Task<IEnumerable<Car>> GetByYear(string year)
        {
            IEnumerable<Car> cars = _cars.Where(c => c.Year.ToLower() == year.ToLower());
            return Task.FromResult(cars);
        }

        #endregion
    }
}
