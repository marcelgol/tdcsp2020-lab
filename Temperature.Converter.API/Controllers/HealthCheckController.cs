using Calculator.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Net;

namespace Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthCheckController : ControllerBase
    {

        // POST: api/FahrenheitToCelsius
        [HttpGet]
        public HttpStatusCode Post()
        {
            return HttpStatusCode.OK;
        }

    }
}
