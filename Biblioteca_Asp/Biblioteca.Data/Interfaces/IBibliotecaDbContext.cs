using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Biblioteca.Data.Interfaces
{
   public interface IBibliotecaDbContext 
    {
            DbSet<T> Set<T>() where T : class;

            Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
