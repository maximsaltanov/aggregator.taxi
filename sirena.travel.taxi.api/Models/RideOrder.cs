namespace sirena.travel.taxi.api.Models
{
	/// <summary>
	/// Ride Order Details
	/// </summary>
	public class RideOrder
	{
		public string UserId { get; set; }
		public string OrderId { get; set; }
		public string Transaction { get; set; }
		public Money Cost { get; set; }
		public DateTime RideDate { get; set; }
		public IEnumerable<Passenger> Passengers { get; set; }
		public string State { get; set; }
	}

	public class Passenger
	{
		public string Name { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
	}
}
