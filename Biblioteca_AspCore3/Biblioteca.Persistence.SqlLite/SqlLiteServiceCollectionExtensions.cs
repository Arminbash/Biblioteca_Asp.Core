using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Biblioteca.Persistence;

namespace Biblioteca.Persistence.SqlLite
{
   public static class SqlLiteServiceCollectionExtensions
    {
        public static IServiceCollection AddSqlliteDbContext(
          this IServiceCollection serviceCollection,
          IConfiguration config = null)
        {
            serviceCollection.AddDbContext<BibliotecaDbContext, SqlLiteBibliotecaDbContext>(options =>
            {
                options.UseSqlite(config.GetConnectionString("BibliotecaDbContext"), b => b.MigrationsAssembly("Biblioteca.Persistence.SqlLite"));
            });
            return serviceCollection;
        }
    }
}
