using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Relational;

namespace Biblioteca.Persistence.Configurations
{
    public class LibAutConfiguration : IEntityTypeConfiguration<LibAut>
    {
        public  void Configure(EntityTypeBuilder<LibAut> builder)
        {

            builder.Property(e => e.IdLibAut).HasColumnName("IdLibAut").HasColumnType("int");

        }
    }
}
