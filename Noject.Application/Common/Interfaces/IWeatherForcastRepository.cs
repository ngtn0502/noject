

namespace Noject
{
	public interface IWeatherForcastRepository
	{
		Task<WeatherForecast> GetAllASync();
	}
}
