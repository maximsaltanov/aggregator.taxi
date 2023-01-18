using sirena.travel.taxi.api.Models;

namespace sirena.travel.taxi.api.Services.TaxiServices
{
	/// <summary>
	/// Implements the api gateway Aggregator1 service
	/// </summary>
	public class TaxiAggregator1Service : ITaxiAggregatorService
    {
		public async Task<IEnumerable<RideProduct>> GetProductsAsync(float latitude, float longitude)
		{
			throw new NotImplementedException();
		}

		public async Task<RideOrder> CreateOrderAsync(RideProduct product)
		{
			throw new NotImplementedException();
		}

		public async Task CancelOrderAsync(string requestId)
		{
			throw new NotImplementedException();
		}
	}
}
