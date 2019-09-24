using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Persistence.Configurations
{
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeConfiguration<Autor> builder)
        {

            builder.Property(e => e.IdAutor).HasColumnName("IdAutor").HasColumnType("int");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100).HasColumnName("varchar(100)");

            builder.Property(e => e.Nacionalidad).HasColumnType("varchar(100)").HasMaxLength(100);
        }
    }
}
