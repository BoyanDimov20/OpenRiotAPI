using Microsoft.Extensions.DependencyInjection;

namespace OpenRiotAPI.Extensions
{
    public static class RiotExtensions
    {
        public static IServiceCollection AddRiotClient(this IServiceCollection services,
            Action<RiotClientOptions> options)
        {
            services.Configure<RiotClientOptions>(options)
                .AddScoped<RiotClient>();

            return services;
        }
    }
}