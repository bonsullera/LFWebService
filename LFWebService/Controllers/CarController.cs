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
    }
}
