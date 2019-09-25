using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data.Interfaces
{
   public interface IBibliotecaDbContext 
    {
            DbSet<T> Set<T>() where T : class;
            Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
