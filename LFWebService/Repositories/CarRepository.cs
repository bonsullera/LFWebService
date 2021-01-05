using LFWebService.Interfaces;
using LFWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFWebService.Repositories
{
    public class CarRepository : ICarRepository
    {
        public IList<CarModels> GetCarDetails(int year)
        {
            IList<CarModels> cars = null;

            using (var context = new localDbEntities())
            {
                cars = context.CarsDbs.Where(c => c.Year == year).Select(c => new CarModels()
                {
                    Id = c.Id,
                    Name = c.Name,
                    Color = c.Color,
                    Year = (int)c.Year
                }).ToList<CarModels>();
            }

            return cars;
        }

        public void SaveCars(int id, string name, string color, int year)
        {
            using (var context = new localDbEntities())
            {
                context.CarsDbs.Add(new CarsDb()
                {
                    Id = id,
                    Name = name,
                    Color = color,
                    Year = year
                });

                context.SaveChanges();
            }
        }

        public void UpdateCars(int id, string name, string color, int year)
        {
            using (var context = new localDbEntities())
            {
                var carIdentity = context.CarsDbs.Where(c => c.Id == id).FirstOrDefault<CarsDb>();

                if (carIdentity != null)
                {
                    carIdentity.Name = name;
                    carIdentity.Color = color;
                    carIdentity.Year = year;

                    context.SaveChanges();
                }
            }
        }
    }
}