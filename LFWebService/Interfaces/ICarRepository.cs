using LFWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFWebService.Interfaces
{
    public interface ICarRepository
    {
        IList<CarModels> GetCarDetails(int year);
        void SaveCars(int id, string name, string color, int year);
        void UpdateCars(int id, string name, string color, int year);
    }
}
