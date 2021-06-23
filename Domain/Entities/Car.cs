using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OniCloud.Api.Cars.Domain.Entities
{
    public class Car
    {
        #region Properties

        public string Id { get; init; } = Guid.NewGuid().ToString();
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        #endregion
    }
}
