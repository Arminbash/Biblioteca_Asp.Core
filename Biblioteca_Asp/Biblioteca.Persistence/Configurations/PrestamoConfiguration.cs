using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Persistence.Configurations
{
    public class PrestamoConfiguration : EntityTypeConfiguration<Prestamo>
    {
        public void Configure(EntityTypeConfiguration<Prestamo> builder)
        {

            builder.Property(e => e.IdPrestamo).HasColumnName("IdPrestamo").HasColumnType("int");

            builder.Property(e => e.FechaPrestamo).HasColumnName("datetime");

            builder.Property(e => e.FechaDevolucion).HasColumnName("datetime");

            builder.Property(e => e.Devolucion).HasColumnName("bit");
        }
    }
}
