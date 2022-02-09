using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ThePerfectNumber.Domain.Entities;
using ThePerfectNumber.Domain.Interface;

namespace ThePerfectNumber.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfectNumbersController : ControllerBase
    {
        private IServiceBase<Numbers> _baseService;

        public PerfectNumbersController(IServiceBase<Numbers> baseService)
        {
            _baseService = baseService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery]Numbers request)
        {

            Numbers numbers = new()
            {
                StartingNumber = request.StartingNumber,
                EndingNumber = request.EndingNumber,
                ResultNumbers = new List<long>()
            };

            var result = Execute(()=>_baseService.CalculateThePerfecNumber(numbers.StartingNumber, numbers.EndingNumber));

            return result;
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
