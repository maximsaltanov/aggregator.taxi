namespace sirena.travel.taxi.api.Services.TaxiServices
{
    public interface ITaxiServiceFactory
    {
        ITaxiAggregatorService CreateService(Partner partner);
    }
}
