using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Persistence.Configurations
{
    public class EstudianteConfiguration : EntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeConfiguration<Estudiante> builder)
        {

            builder.Property(e => e.IdEstudiante).HasColumnName("IdEstudiante").HasColumnType("Int");

            builder.Property(e => e.CI)
                .IsRequired()
                .HasMaxLength(100).HasColumnName("varchar(100)");

            builder.Property(e => e.Nombre).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Direccion).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Carrera).HasColumnType("varchar(100)").HasMaxLength(100);

            builder.Property(e => e.Edad).HasColumnType("Int");
        }
    }
}
