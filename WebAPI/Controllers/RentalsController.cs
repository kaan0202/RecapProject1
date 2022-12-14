using Business.Abstract;
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
    public class RentalsController : ControllerBase
    {
        IRentalsService _rentalsService;

        public RentalsController(IRentalsService rentalsService)
        {
            _rentalsService = rentalsService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            else
                return BadRequest(result.Messages);
        }

            [HttpPost("add")]
            
            public IActionResult Add(Rentals rentals)
            {
                var result = _rentalsService.Add(rentals);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest(result.Messages);
            }
            [HttpGet("update")]
            public IActionResult Update(Rentals rentals)
            {
                  var result = _rentalsService.Update(rentals);
                  if (result.Success)
                   return Ok(result);
                  else
                   return BadRequest(result.Messages);
            }
        [HttpGet("delete")]
        public IActionResult Delete(Rentals rentals)
        {
            var result = _rentalsService.Delete(rentals);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Messages);
        }
    }
    }

