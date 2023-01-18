using System.Reflection;

namespace sirena.travel.taxi.api.Services.TaxiServices
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
			services.AddScoped<IPlaceService, PlaceService>();
			services.AddScoped<IAggregationService, AggregationService>();
			services.AddScoped<ITaxiServiceFactory, TaxiServiceFactory>();

			services.RegisterAllTypes<ITaxiAggregatorService>(new[] { typeof(Program).Assembly });

			return services;
        }

		public static void RegisterAllTypes<T>(this IServiceCollection services, Assembly[] assemblies,
			ServiceLifetime lifetime = ServiceLifetime.Scoped)
		{
			var typesFromAssemblies = assemblies.SelectMany(a => a.DefinedTypes.Where(x => x.GetInterfaces().Contains(typeof(T))));
			foreach (var type in typesFromAssemblies)
			{
				services.Add(new ServiceDescriptor(typeof(T), type, lifetime));
			}
		}
	}
}