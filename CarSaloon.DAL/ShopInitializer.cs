using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarSaloon.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var brands = new List<VehicleBrandEntity>
            {
                new VehicleBrandEntity
                {
                    Id = 1,
                    Name = "Mercedes", 
                    Abrv = "Merc"
                },
                new VehicleBrandEntity
                {
                    Id = 2,
                    Name = "BMW",
                    Abrv = "BMW"
                },
                new VehicleBrandEntity
                {
                    Id = 3,
                    Name = "Ferarri",
                    Abrv = "Fer"
                }                
            };
            brands.ForEach(b => context.VehicleBrands.Add(b));
            context.SaveChanges();

            var models = new List<VehicleModelEntity>
            {
                new VehicleModelEntity {Id=1,Name="AMG", MakeId=123456, VehicleBrandId=1},
                new VehicleModelEntity {Id=2,Name="LaFerarri", MakeId=12126, VehicleBrandId=3},
                new VehicleModelEntity {Id=3,Name="X5", MakeId=12344566, VehicleBrandId=2},
                new VehicleModelEntity {Id=4,Name="CLK", MakeId=12345656, VehicleBrandId=1},
                new VehicleModelEntity {Id=5,Name="Enzo", MakeId=1457456, VehicleBrandId=3},
                new VehicleModelEntity {Id=6,Name="M5", MakeId=12457456, VehicleBrandId=2}
            };
            models.ForEach(m => context.VehicleModels.Add(m));
            context.SaveChanges();
        }
    }
}
