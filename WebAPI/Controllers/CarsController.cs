using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarsService _carsService;

    
        public CarsController(ICarsService carsService)
        {
            _carsService = carsService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _carsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Messages);
            }

        }
        [HttpGet("getcardetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carsService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }
        [HttpPost("add")]
        public IActionResult Add(Cars cars)
        {
            var result = _carsService.Add(cars);
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result.Messages);
        }
        [HttpGet("update")]
        public IActionResult Update(Cars cars)
        {
            var result = _carsService.Update(cars);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Messages);
            {

            }
        }
    }

}
