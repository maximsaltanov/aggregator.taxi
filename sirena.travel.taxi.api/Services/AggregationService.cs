using sirena.travel.taxi.api.Models;
using sirena.travel.taxi.api.Services.TaxiServices;

namespace sirena.travel.taxi.api.Services
{
    public class AggregationService : IAggregationService
    {
        private readonly IEnumerable<ITaxiAggregatorService> _taxiServices;
        private readonly ITaxiServiceFactory _taxiServiceFactory;

        public AggregationService(IEnumerable<ITaxiAggregatorService> taxiServices, ITaxiServiceFactory taxServiceFactory)
        {
            _taxiServices = taxiServices;
            _taxiServiceFactory = taxServiceFactory;
        }

        public async Task<IEnumerable<RideProduct>> GetProductsAsync(float latitude, float longitude)
        {
            // get products from all taxi aggregators
            var productsFromAllTaxiAggregators = new List<RideProduct>();
            foreach (var service in _taxiServices)
            {
                var products = await service.GetProductsAsync(latitude, longitude);
                if (!products.Any())
                    continue;

                productsFromAllTaxiAggregators.AddRange(products);
            }

            var filteredProducts = FilterProducts(productsFromAllTaxiAggregators);

            return filteredProducts;
        }

        public async Task<RideOrder> CreateOrderAsync(RideProduct request)
        {
			// TODO: implement the logic - as example:
			// 1. send a request to aggregator on ability of order creation
			// 2. if the product and cost still actual we need to create a pre-order in the sirena.taxi db
			// 3. send the create order request to aggregator
			// 4. update status of the created pre-order 

			// for now we just resend create order to the aggregator system
			return await _taxiServiceFactory.CreateService(request.Partner).CreateOrderAsync(request);
        }

        public async Task CancelOrderAsync(string requestId)
        {
            var aggregatorRequest = GetAggregatorRequest(requestId);
            await _taxiServiceFactory.CreateService(aggregatorRequest.Item1).CancelOrderAsync(aggregatorRequest.Item2);
        }

        private static (Partner, string) GetAggregatorRequest(string requestId)
        {
            // TODO: we need to get the order from sirena.taxi db and return aggregator type and request id
            // just for the testing purposes
            return (Partner.TaxiAggregator1, requestId);
        }

		/// <summary>
		/// It should implement the filtering logic of unique products from various aggregators by criterias
		// (it could be a lowest cost / or may be max comission for the order)
		/// </summary>
		/// <param name="products"></param>
		/// <returns></returns>
		private static IEnumerable<RideProduct> FilterProducts(IEnumerable<RideProduct> products)
        {
            // TODO: not implemented yet
            return products;
        }
    }
}
