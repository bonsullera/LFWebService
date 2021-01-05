using LFWebService.Interfaces;
using LFWebService.Models;
using LFWebService.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LFWebService.Controllers
{
    public class CarController : ApiController
    {
        readonly ICarRepository carRepository;

        public CarController(ICarRepository repository)
        {
            this.carRepository = repository;
        }

        public IHttpActionResult GetCars(int year)
        {
            
            var carDetails = carRepository.GetCarDetails(year);

            if (carDetails == null || carDetails.Count() == 0)
            {
                return NotFound();
            }

            return Ok(carDetails);
        }

        public IHttpActionResult PostCars(int id, string name, string color, int year)
        {
            carRepository.SaveCars(id, name, color, year);

            return Ok();
        }

        public IHttpActionResult PatchCars(int id, string name, string color, int year)
        {
            carRepository.UpdateCars(id, name, color, year);
          
            return Ok();
        }


        //public IHttpActionResult GetCars(int year)
        //{
        //    IList<CarModels> cars = null;

        //    using (var context = new localDbEntities())
        //    {               
        //        cars = context.CarsDbs.Where(c => c.Year == year).Select(c => new CarModels()
        //            { 
        //                Id = c.Id,
        //                Name = c.Name,
        //                Color = c.Color,
        //                Year = (int)c.Year
        //             }).ToList<CarModels>();               
        //    }

        //    if (cars == null || cars.Count() == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(cars);
        //}

        //public IHttpActionResult PostCars(int id, string name, string color, int year)
        //{
        //    using (var context = new localDbEntities())
        //    {
        //        context.CarsDbs.Add(new CarsDb()
        //        {
        //            Id = id,
        //            Name = name,
        //            Color = color,
        //            Year = year
        //        });

        //        context.SaveChanges();
        //    }

        //    return Ok();
        //}

        //public IHttpActionResult PatchCars(int id, string name, string color, int year)
        //{
        //    using (var context = new localDbEntities())
        //    {
        //        var carIdentity = context.CarsDbs.Where(c => c.Id == id).FirstOrDefault<CarsDb>();

        //        if (carIdentity != null)
        //        {
        //            carIdentity.Name = name;
        //            carIdentity.Color = color;
        //            carIdentity.Year = year;

        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }               
        //    }

        //    return Ok();
        //}
    }
}
