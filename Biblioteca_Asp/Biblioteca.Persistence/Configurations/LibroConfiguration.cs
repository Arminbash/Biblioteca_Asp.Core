using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Persistence.Configurations
{
    public class LibroConfiguration : EntityTypeConfiguration<Libro>
    {
        public void Configure(EntityTypeConfiguration<Libro> builder)
        {

            builder.Property(e => e.IdLibro).HasColumnName("IdLibro").HasColumnType("int");

            builder.Property(e => e.Titulo)
                .IsRequired()
                .HasMaxLength(100).HasColumnName("varchar(100)");

            builder.Property(e => e.Editorial).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Area).HasColumnType("varchar(100)").HasMaxLength(100);
        }
    }
}
