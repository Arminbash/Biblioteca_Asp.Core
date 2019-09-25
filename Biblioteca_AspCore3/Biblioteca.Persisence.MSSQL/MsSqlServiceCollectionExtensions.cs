using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca.Persistence;

namespace Biblioteca.Persisence.MSSQL
{
    public static class MsSqlServiceCollectionExtensions
    {
        public static IServiceCollection AddMssqlDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            serviceCollection.AddDbContext<BibliotecaDbContext, MsSqlBibliotecaDbContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("BibliotecaDbContext"), b => b.MigrationsAssembly("Biblioteca.Persistence.MSSQL"));
            });
            return serviceCollection;
        }
    }
}
