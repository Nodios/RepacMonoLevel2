using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.DAL
{
    public class VehicleModelEntity
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }

        //Foreign key
        public int VehicleBrandId { get; set; }

        public virtual VehicleBrandEntity VehicleBrand { get; set; }
    }
}
