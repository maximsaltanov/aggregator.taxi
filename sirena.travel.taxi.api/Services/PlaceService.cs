using sirena.travel.taxi.api.Models;
using sirena.travel.taxi.api.Services.TaxiServices;

namespace sirena.travel.taxi.api.Services
{
    public class PlaceService : IPlaceService
	{
		public Task<IEnumerable<Place>> FindPlacesAsync(string term)
		{
			// TODO: need to implement a search for a place by name (probably using a third-party API or delegate to a separate microservice)
			throw new NotImplementedException();
		}
	}
}
