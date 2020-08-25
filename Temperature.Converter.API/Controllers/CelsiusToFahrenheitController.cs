using Calculator.Business;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace Temperature.Converter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CelsiusToFahrenheitController : ControllerBase
    {
        // POST: api/CelsiusToFahrenheit
        [HttpPost]
        public string Post([FromBody] string value)
        {
            DegreeConverter convert = new DegreeConverter();
            Log.Information("Post received. Celsius value: {0}", value);
            return convert.ToFahrenheit(Convert.ToDecimal(value)).ToString();
        }
    }
}