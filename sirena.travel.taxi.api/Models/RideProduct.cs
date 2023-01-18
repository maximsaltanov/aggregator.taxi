using sirena.travel.taxi.api.Services.TaxiServices;

namespace sirena.travel.taxi.api.Models
{
	/// <summary>
	/// Pre-order ride description
	/// </summary>
	public class RideProduct
	{
		/// <summary>
		/// Pre-order ride Id
		/// </summary>
		public string RideProductId { get; set; }
		/// <summary>
		/// Aggregator (Partner)
		/// </summary>
		public Partner Partner { get; set; }
		/// <summary>
		/// Product Id from general list of products (standard, comfort, etc.)
		/// </summary>
		public string ProductId { get; set; }
		/// <summary>
		/// Ride planned date / time
		/// </summary>
		public DateTime RideDate { get; set; }
		/// <summary>
		/// Pre-order ride cost / currency
		/// </summary>
		public Money Price { get; set; }
		/// <summary>
		/// Origin Place
		/// </summary>
		public Location StartPlace { get; set; }
		/// <summary>
		/// Destination Place
		/// </summary>
		public Location FinishPlace { get; set; }
		/// <summary>
		/// Car Class Details
		/// </summary>
		public CarClass? CarClass { get; set; }
		/// <summary>
		/// Additional Services List
		/// </summary>
		public IEnumerable<AdditionalService>? AdditionalServices { get; set; }
	}
}
