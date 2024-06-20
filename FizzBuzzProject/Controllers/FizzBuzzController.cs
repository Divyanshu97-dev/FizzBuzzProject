using FizzBuzzProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FizzBuzzProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IDivision _fizzBuzzDivision;

        public FizzBuzzController(IDivision fizzBuzzdivision)
        {
            _fizzBuzzDivision = fizzBuzzdivision;
        }

        [HttpGet("calculate")]
        public ActionResult<string> CalculateFizzBuzz([FromQuery] string input)
        {
            if (string.IsNullOrEmpty(input))
                return BadRequest("Invalid Item");

            if (!int.TryParse(input, out int number))
                return BadRequest("Invalid Item");

            var result = _fizzBuzzDivision.GetFizzBuzzResult(number);
            return Ok(result);
        }
    }
}
