using FizzAPI.Domain.Enum;
using FizzAPI.Service.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzAPI.Controllers
{
    [Route("api/v{version:apiVersion}/Fizz")]
    [ApiVersion("1.0")]
    [ApiController]
    public class FizzController : ControllerBase
    {
        private readonly IFizzService _fizzService;
        private readonly ILogger<FizzController> _logger;
        public FizzController(IFizzService fizzService, ILogger<FizzController> logger)
        {
            _fizzService = fizzService ?? throw new ArgumentNullException(nameof(fizzService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        /// API to get Fizz API result based on the number supplied.
        /// Returns "FizzBuzz" if number is multiple of 3 and 5.
        /// Returns "Fizz" if number is multiple of 3.
        /// Returns "Buzz" if number is multiple of 5.
        /// Returns the number if it's not a multiple of 3 or 5;
        /// </summary>
        /// <param name="number"></param>
        [HttpGet("{number}")]
        public ActionResult GetFizzResult(int number)
        {
            return Ok(_fizzService.DetermineFizz(number));
        }
    }
}
