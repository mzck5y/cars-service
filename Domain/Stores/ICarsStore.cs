using OniCloud.Api.Cars.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OniCloud.Api.Cars.Domain.Stores
{
    public interface ICarsStore
    {
        Task<Car> GetById(string id);
        Task<IEnumerable<Car>> GetAll();
        Task<IEnumerable<Car>> GetByMake(string make);
        Task<IEnumerable<Car>> GetByModel(string model);
        Task<IEnumerable<Car>> GetByYear(string year);
    }
}
