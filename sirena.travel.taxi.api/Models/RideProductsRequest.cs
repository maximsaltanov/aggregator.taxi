namespace sirena.travel.taxi.api.Models
{
    /// <summary>
    /// Specifies locations (origin / destination) to search for ride products
    /// </summary>
    public class RideProductsRequest
    {
        /// <summary>
        /// Origin Place
        /// </summary>
        public Location StartPoint { get; set; }
		/// <summary>
		/// Destination Place (could be optional in a case if final destination not defined)
		/// </summary>
		public Location? FinishPoint { get; set; }

        // it could be extended with additional parameters (like specifying of a flightNumber for Airport placeType etc...)
    }
}