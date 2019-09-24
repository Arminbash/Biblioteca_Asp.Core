using Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Persistence.Configurations
{
    public class LibAutConfiguration : EntityTypeConfiguration<LibAut>
    {
        public void Configure(EntityTypeConfiguration<LibAut> builder)
        {

            builder.Property(e => e.IdLibAut).HasColumnName("IdLibAut").HasColumnType("int");

        }
    }
}
