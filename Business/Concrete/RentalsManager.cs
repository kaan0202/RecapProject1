using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _irentalsdal;
        public RentalsManager(IRentalsDal irentalsDal)
        {
            _irentalsdal = irentalsDal;
        }
        public IResult Add(Rentals rentals)
        {
            ValidationTool.Validate(new RentalValidator(), rentals);
            var rentalCar = _irentalsdal.GetById(r => r.CarId == rentals.CarId && r.ReturnDate==null);
            if (rentalCar != null)
            {
                _irentalsdal.Add(rentals);
                return new SuccessResult("İşlem gerçekleştirildi", true); 
            }
            else
                return new ErrorResult(false, "Hata");
           
           
            
            
        }

        public IResult Delete(Rentals rentals)
        {
            _irentalsdal.Delete(rentals);
            return new SuccessResult("İşlem gerçekleştirildi", true);
        }

        public IDataResult<Rentals> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_irentalsdal.GetAll(), true, "İşlem başarılı");
        }

        public IResult Update(Rentals rentals)
        {
            if (rentals.RentDate != null || rentals.ReturnDate == null)
            {
                _irentalsdal.Update(rentals);
                return new SuccessResult("İşlem gerçekleştirildi", true);
            }
            else
            {
                return new ErrorResult(false, "Araba Kiralanmış!");
            }
        }
    }
}
