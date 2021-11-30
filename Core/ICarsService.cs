using OniCloud.Api.Cars.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OniCloud.Api.Cars.Core
{
    public interface ICarsService
    {
        Task<Car> SaveCarAsync(Car car);

        Task<bool> RemoveCarAsync(string id);

        Task<IEnumerable<Car>> FetchAllCarsAsync();

        Task<Car> FetchByIdAsync(string id);
       
        Task<IEnumerable<Car>> FetchAllCarsByMakeAsync(string make);

        Task<IEnumerable<Car>> FetchAllCarsByModelAsync(string model);

        Task<IEnumerable<Car>> FetchAllCarsByYearAsync(string year);
    }
}
