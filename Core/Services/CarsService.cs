using OniCloud.Api.Cars.Domain.Entities;
using OniCloud.Api.Cars.Domain.Stores;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OniCloud.Api.Cars.Core.Services
{
    public class CarsService : ICarsService
    {
        #region Fields

        private readonly ICarsStore _store;

        #endregion

        #region Constructors

        public CarsService(ICarsStore store)
        {
            _store = store;
        }

        #endregion

        #region Public Methods

        public async Task<Car> SaveCarAsync(Car car)
        {
            return await _store.Save(car);
        }

        public async Task<bool> RemoveCarAsync(string id)
        {
            return await _store.Delete(id);
        }

        public async Task<IEnumerable<Car>> FetchAllCarsAsync()
        {
            IEnumerable<Car> cars = await _store.GetAll();
            return cars.Any() ? cars : null;
        }

        public async Task<IEnumerable<Car>> FetchAllCarsByMakeAsync(string make)
        {
            IEnumerable<Car> cars = await _store.GetByMake(make);
            return cars.Any() ? cars : null;
        }

        public async Task<IEnumerable<Car>> FetchAllCarsByModelAsync(string model)
        {
            IEnumerable<Car> cars = await _store.GetByModel(model);
            return cars.Any() ? cars : null;
        }

        public async Task<IEnumerable<Car>> FetchAllCarsByYearAsync(string year)
        {
            IEnumerable<Car> cars = await _store.GetByYear(year);
            return cars.Any() ? cars : null;
        }

        public async Task<Car> FetchByIdAsync(string id)
        {
            return await _store.GetById(id);
        }

        #endregion
    }
}
