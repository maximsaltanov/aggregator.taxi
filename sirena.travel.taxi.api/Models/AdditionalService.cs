namespace sirena.travel.taxi.api.Models
{
	/// <summary>
	/// Ride Additional Services (as example: child seat 0-3)
	/// </summary>
	public class AdditionalService
	{
		public int AdditionalServiceId { get; set; }
		public string Name { get; set; }
		public Money Price { get; set; }
	}
}
