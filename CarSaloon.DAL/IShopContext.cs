using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarSaloon.DAL
{
    public interface IShopContext
    {
        DbSet<VehicleBrandEntity> VehicleBrands { get; set; }
        DbSet<VehicleModelEntity> VehicleModels { get; set; }
    }
}
