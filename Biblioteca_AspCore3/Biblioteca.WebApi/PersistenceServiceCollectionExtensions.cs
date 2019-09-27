using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca.Persisence.MSSQL;
using Biblioteca.Persistence.MYSQL;
using Biblioteca.Persistence.SqlLite;
namespace Biblioteca.WebApi
{
    public static class PersistenceServiceCollectionExtensions
    {

        public static IServiceCollection AddConfiguredDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            var persistenceConfig = config?.GetSection("Persistence")?.Get<PersistenceConfiguration>();

            if (persistenceConfig?.Provider == "MSSQL")
            {
                serviceCollection.AddMssqlDbContext(config);
            }
            if (persistenceConfig?.Provider == "MYSQL")
            {
                serviceCollection.AddMysqlDbContext(config);
            }
            if (persistenceConfig?.Provider == "SQLLITE")
            {
                serviceCollection.AddSqlliteDbContext(config);
            }


            return serviceCollection;
        }

    }

    public class PersistenceConfiguration
    {
        public string Provider { get; set; }
    }
}
