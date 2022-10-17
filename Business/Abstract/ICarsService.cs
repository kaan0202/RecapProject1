using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarsService
    {
        IDataResult<List<Cars>> GetAll();
        IResult Add(Cars cars);
        IResult Delete(Cars cars);
        IResult Update(Cars cars);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        

    }
}
