using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSaloon.Model.Common;

namespace CarSaloon.Model
{
    public class VehicleModel : IVehicleModel
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }

        //Foreign key
        public int VehicleBrandId { get; set; }

        public virtual IVehicleBrand VehicleBrand { get; set; }
    }
}
