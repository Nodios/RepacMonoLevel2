using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using System.Configuration;

namespace CarSaloon.DAL
{
    public class ShopContext : DbContext, IShopContext
    {
        //string c = ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString;
        public ShopContext() : base("ShopContext") { }

        public DbSet<VehicleBrandEntity> VehicleBrands { get; set; }
        public DbSet<VehicleModelEntity> VehicleModels { get; set; }

        public System.Data.Entity.DbSet<CarSaloon.Model.VehicleModel> VehicleModels1 { get; set; }
    }
}
