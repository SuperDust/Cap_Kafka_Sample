
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{

    public static class ServiceCollectionExtensions
    {
        public static void AddCapExtension(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCap(t =>
            {
                t.UseSqlServer(configuration.GetConnectionString("Cap"));
                t.UseKafka(configuration.GetConnectionString("Kafka"));

            });
        }
    }
}