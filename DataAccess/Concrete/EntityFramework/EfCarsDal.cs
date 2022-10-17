using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarsDal : EfEntityRepositoryBase<Cars, MsSqlContext>, ICarsDal
    {
        public List<CarDetailsDto> GetCarsDetails()
        {
            using (MsSqlContext context =new MsSqlContext())
            {
                var result = from a in context.Car
                             join c in context.Color on a.ColorId equals c.ColorId
                             join d in context.Brand on a.BrandId equals d.BrandId
                             select new CarDetailsDto
                             {
                                 CarId=a.CarId,BrandName=d.BrandName,ColorName=c.ColorName
                             };
                return result.ToList();
            }
        }
    }
}
