using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Relational;

namespace Biblioteca.Persistence.Configurations
{
    public class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {

            builder.Property(e => e.IdAutor).HasColumnName("IdAutor").HasColumnType("int");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(100).HasColumnName("varchar(100)");

            builder.Property(e => e.Nacionalidad).HasColumnType("varchar(100)").HasMaxLength(100);
        }
    }
}
