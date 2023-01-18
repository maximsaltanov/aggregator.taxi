namespace sirena.travel.taxi.api.Models
{
	/// <summary>
	/// Describes the origin or destination of a ride
	/// </summary>
	public class Place
	{
		/// <summary>
		/// Place unique identifier (ex. ABC-12345)
		/// </summary>
		public string PlaceId { get; set; }
		/// <summary>
		/// Place Description (ex. Казанский вокзал, Комсомольская площадь, Москва, Россия)
		/// </summary>
		public string Description { get; set; }
		/// <summary>
		/// Type of the place (address, airport, railway station etc..)
		/// </summary>
		public PlaceType? PlaceType { get; set; }

		/// <summary>
		/// Coordinates (Latitude / Longitude)
		/// </summary>
		public Location Location { get; set; }
	}

	public enum PlaceType { Address, Airport, RailwayStation }

	public class Location 
	{ 
		public float Latitude { get; set; }
		public float Longitude { get; set; }
	}
}
