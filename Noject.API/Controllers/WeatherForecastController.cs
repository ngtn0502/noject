using MediatR;
using Microsoft.AspNetCore.Mvc;
using Noject.Application.WeatherForeCast.Queries;

namespace Noject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ISender mediator;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ISender mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            var query = new GetWeatherForeCastQuery();
            var result = await this.mediator.Send(query);

            return result;
        }
    }
}
