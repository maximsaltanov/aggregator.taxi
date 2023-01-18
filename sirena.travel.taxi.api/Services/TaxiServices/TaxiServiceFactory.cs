namespace sirena.travel.taxi.api.Services.TaxiServices
{
    public class TaxiServiceFactory : ITaxiServiceFactory
    {
        public TaxiServiceFactory() { }
        public ITaxiAggregatorService CreateService(Partner partner)
        {
            switch (partner)
            {
                case Partner.TaxiAggregator1:
                    return new TaxiAggregator1Service();
                case Partner.TaxiAggregator2:
                    return new TaxiAggregator2Service();
            }

            throw new NotImplementedException();
        }
    }

    public enum Partner { TaxiAggregator1, TaxiAggregator2 }
}
