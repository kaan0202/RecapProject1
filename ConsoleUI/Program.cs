using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarsDal());
            carManager.Add(
                new Cars
                {
                    
                    BrandId = 2,
                    ColorId = 1,
                    CarName = "Araba",
                    ModelYear = 2011,
                    Description = "Gozel"
                }
            );



            var result = carManager.GetAll();

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName);
            }
            
            Console.ReadLine();
        }
    }
}
