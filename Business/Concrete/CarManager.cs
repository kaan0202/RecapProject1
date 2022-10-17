using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarsService
    {
        ICarsDal _icarsDal;
        public CarManager(ICarsDal icarsdal)
        {
            _icarsDal = icarsdal;
        }
        public IResult Add(Cars cars)
        {
            if (cars.CarName.Length > 3)
            {
                _icarsDal.Add(cars);
                return new SuccessResult("İşlem gerçekleştirildi.", true);
            }
            else
            {

                return new ErrorResult(false, "Araba ismi 3 karakterden uzun olmalıdır.");
            }

        }

        public IResult Delete(Cars cars)
        {
          
            
                _icarsDal.Delete(cars);
                return new SuccessResult("İşlem gerçekleştirildi.", true);
          
        }

       

        public IDataResult<List<Cars>> GetAll()
        {
           
            
            return new SuccessDataResult<List<Cars>>(_icarsDal.GetAll(),true, "İşlem gerçekleşti");
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
             
            return new SuccessDataResult<List<CarDetailsDto>>(_icarsDal.GetCarsDetails(),true, "İşlem gerçekleşti");
        }

        public IResult Update(Cars cars)
        {
            if (cars.CarName.Length < 3)
            {
                _icarsDal.Update(cars);
                return new SuccessResult("İşlem gerçekleştirildi.", true);
            }
            else
            {

                return new ErrorResult(false, "Araba ismi 3 karakterden uzun olmalıdır.");
            }
        }
    }

        

       

        

       

      
    }

