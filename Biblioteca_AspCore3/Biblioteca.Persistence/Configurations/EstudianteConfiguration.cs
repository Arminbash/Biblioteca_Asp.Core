using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Relational;

namespace Biblioteca.Persistence.Configurations
{
    public class EstudianteConfiguration : IEntityTypeConfiguration<Estudiante>
    {
        public  void Configure(EntityTypeBuilder<Estudiante> builder)
        {

            builder.Property(e => e.IdEstudiante).HasColumnName("IdEstudiante").HasColumnType("Int");

            builder.Property(e => e.CI)
                .IsRequired()
                .HasMaxLength(100).HasColumnType("varchar(100)");

            builder.Property(e => e.Nombre).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Direccion).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Carrera).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Edad).HasColumnType("Int");
        }
    }
}
