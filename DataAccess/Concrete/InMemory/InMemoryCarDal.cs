using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {

            new Car {Id = 1, BrandId = 2, ColorId = 4, DailyPrice = "250 dolar" , ModelYear = 2020, Description = "Porsche" },
            new Car {Id = 2, BrandId = 2, ColorId = 4, DailyPrice = "200 dolar" , ModelYear = 2019, Description = "Audi" },
            new Car {Id = 3, BrandId = 3, ColorId = 2, DailyPrice = "150 dolar" , ModelYear = 2018, Description = "Bmw" },
            new Car {Id = 4, BrandId = 3, ColorId = 2, DailyPrice = "500 dolar" , ModelYear = 2022, Description = "Mercedes" },
            new Car {Id = 5, BrandId = 3, ColorId = 1, DailyPrice = "100 dolar" , ModelYear = 2018, Description = "Toyota" },
            };
            
           
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
