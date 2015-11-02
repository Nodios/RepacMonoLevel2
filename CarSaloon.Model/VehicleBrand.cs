using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSaloon.Model.Common;

namespace CarSaloon.Model
{
    public class VehicleBrand : IVehicleBrand
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public List<IVehicleModel> Models { get; set; }
    }
}
