using Calculator.Business;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FahrenheitToCelsiusController : ControllerBase
    {

        // POST: api/FahrenheitToCelsius
        [HttpPost]
        public string Post([FromBody] string value)
        {
            DegreeConverter convert = new DegreeConverter();
            Log.Information("Post received. Fahrenheit value: {0}", value);
            return convert.ToCelsius(Convert.ToDecimal(value)).ToString();
        }

    }
}
