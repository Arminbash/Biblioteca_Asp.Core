﻿using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Relational;

namespace Biblioteca.Persistence.Configurations
{
    public class PrestamoConfiguration : IEntityTypeConfiguration<Prestamo>
    {
        public  void Configure(EntityTypeBuilder<Prestamo> builder)
        {

            builder.Property(e => e.IdPrestamo).HasColumnName("IdPrestamo").HasColumnType("int");

            builder.Property(e => e.FechaPrestamo).HasColumnType("datetime");

            builder.Property(e => e.FechaDevolucion).HasColumnType("datetime");

            builder.Property(e => e.Devolucion).HasColumnType("bit");
        }
    }
}
