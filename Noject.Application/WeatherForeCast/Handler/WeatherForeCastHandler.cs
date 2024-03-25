using MediatR;
using Noject.Application.WeatherForeCast.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noject.Application.WeatherForeCast.Handler
{
    public class WeatherForeCastHandler : IRequestHandler<GetWeatherForeCastQuery, IEnumerable<WeatherForecast>>
    {
        private static readonly string[] Summaries = new[]
{
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<IEnumerable<WeatherForecast>> Handle(GetWeatherForeCastQuery request, CancellationToken cancellationToken)
        {
                       return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray() as IEnumerable<WeatherForecast>);
        }
    }
}
