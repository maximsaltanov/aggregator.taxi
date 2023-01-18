using sirena.travel.taxi.api.Models;

namespace sirena.travel.taxi.api.Services.TaxiServices
{
    public interface ITaxiAggregatorService
    {
		Task<IEnumerable<RideProduct>> GetProductsAsync(float latitude, float longitude);
		Task<RideOrder> CreateOrderAsync(RideProduct product);
		Task CancelOrderAsync(string requestId);
	}
}
