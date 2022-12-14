using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarsDal : IEntityRepository<Cars>
    {

        List<CarDetailsDto> GetCarsDetails();

	}

}


	

    

