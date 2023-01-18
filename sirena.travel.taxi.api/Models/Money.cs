namespace sirena.travel.taxi.api.Models
{
	public class Money
	{
		public decimal Price { get; set; }
		public Currency Currency { get; set; }
	}

	public enum Currency { RUB, USD }
}
