

namespace Noject
{
	public interface IWeatherForcastRepository
	{
		Task<Product> GetAllASync();
	}
}
