using Microsoft.AspNetCore.Mvc;
using sirena.travel.taxi.api.Models;
using sirena.travel.taxi.api.Services;
using sirena.travel.taxi.api.Services.TaxiServices;

namespace sirena.travel.taxi.api.Controllers
{
    [ApiController]
	[Route("api/v1")]
	public class ApiController : ControllerBase
	{
		private readonly IPlaceService _placeService;
		private readonly IAggregationService _aggregationService;

		public ApiController(IPlaceService placeService, IAggregationService aggregationService)
		{ 
			_placeService = placeService;
			_aggregationService = aggregationService;
		}

		/// <summary>
		/// Find places by term
		/// </summary>
		/// <param name="term"></param>
		/// <returns></returns>
		[HttpGet("places/find")]
		public async Task<IEnumerable<Place>> FindPlaces(string term)
		{
			return await _placeService.FindPlacesAsync(term);
		}

		/// <summary>
		/// Get Ride Products / Prices
		/// </summary>
		/// <param name="latitude"></param>
		/// <param name="longitude"></param>
		/// <returns></returns>
		[HttpGet("prices")]
		public async Task<IEnumerable<RideProduct>> GetRideProducts(float latitude, float longitude)
		{
			return await _aggregationService.GetProductsAsync(latitude, longitude);
		}

		/// <summary>
		/// Create Ride Order
		/// </summary>
		/// <param name="request"></param>
		/// <returns></returns>
		[HttpPost("orders")]
		public async Task<RideOrder> CreateRideOrder(RideProduct request)
		{
			return await _aggregationService.CreateOrderAsync(request);
		}

		/// <summary>
		/// Cancel Ride Order
		/// </summary>
		/// <param name="requestId"></param>
		/// <returns></returns>
		[HttpPut("orders")]
		public async Task CancelOrder(string requestId)
		{
			await _aggregationService.CancelOrderAsync(requestId);
		}
	}
}