using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBilar.Models
{
    public class MVCBilarDbContext : DbContext
    {
        public MVCBilarDbContext(DbContextOptions<MVCBilarDbContext> o) : base(o)
        {

        }

        public DbSet<Car> Car { get; set; }

        /// Metoder i <see cref="Controllers.CarsController"/> ska också ligga här 
        /// 

        internal CarsFormVM[] ListCars()
        {
            return this.Car
                   .Select(c => new CarsFormVM
                   {
                       Brand = c.Brand,
                       Id = c.Id,
                       ShowAsFast = c.TopSpeed > 250
                   })
                   .OrderBy(c => c.Brand)
                   .ToArray();
        }

        internal async void AddCar(CarsCreateVM car)
        {
            await this.Car.AddAsync(new Car
            {
                Brand = car.Brand,
                Doors = car.Doors,
                TopSpeed = car.TopSpeed,
            });
            await this.SaveChangesAsync();
        }

        public CarsDetailsVM GetCarByID(int id)
        {   
            return Car
                .Where(c => c.Id == id)
                .Select(c => new CarsDetailsVM
                {
                    Brand = c.Brand,
                    Doors = c.Doors,
                    TopSpeed = c.TopSpeed,
                    ShowAsFast = c.TopSpeed > 250
                })
                .Single();
        }
        
    }
}
