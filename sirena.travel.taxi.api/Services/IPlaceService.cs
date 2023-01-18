using sirena.travel.taxi.api.Models;

namespace sirena.travel.taxi.api.Services.TaxiServices
{
    public interface IPlaceService
	{
		Task<IEnumerable<Place>> FindPlacesAsync(string term);
	}
}
