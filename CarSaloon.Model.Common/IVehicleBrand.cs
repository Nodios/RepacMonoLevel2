using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaloon.Model.Common
{
    public interface IVehicleBrand
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }

        List<IVehicleModel> Models { get; set; }
    }
}
