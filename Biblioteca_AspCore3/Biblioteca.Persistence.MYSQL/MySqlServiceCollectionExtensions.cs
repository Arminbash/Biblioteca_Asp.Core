using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca.Persistence;

namespace Biblioteca.Persistence.MYSQL
{
    public static class MySqlServiceCollectionExtensions
    {
        public static IServiceCollection AddMysqlDbContext(
            this IServiceCollection serviceCollection,
            IConfiguration config = null)
        {
            serviceCollection.AddDbContext<BibliotecaDbContext, MySqlBibliotecaDbContext>(options =>
            {
                options.UseMySQL(config.GetConnectionString("BibliotecaDbContext"), b => b.MigrationsAssembly("Biblioteca.Persistence.MYSQL"));
            });
            return serviceCollection;
        }
    }
}
