using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Data.Interfaces;
using Entities;
using Models;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Persistence.Configurations;
namespace Biblioteca.Persistence
{
    public class BibliotecaDbContext : DbContext, IBibliotecaDbContext
    {
        //https://www.trycatchfail.com/2017/09/12/adding-entity-framework-code-first-type-configs-from-a-namespace/
        public BibliotecaDbContext()
        {

        }

        public BibliotecaDbContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Estudiante> Estudiante { get; set; }
        public virtual DbSet<LibAut> LibAut { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BibliotecaDbContext).Assembly);

            //AutorConfiguration.Configure(modelBuilder.Entity<Autor>().ToTable("Employee"));
            //EstudianteConfiguration.Configure(modelBuilder.Entity<Estudiante>().ToTable("Estudiante"));
            //LibAutConfiguration.Configure(modelBuilder.Entity<LibAut>().ToTable("LibAut"));
            //LibroConfiguration.Configure(modelBuilder.Entity<Libro>().ToTable("Libro"));
            //PrestamoConfiguration.Configure(modelBuilder.Entity<Prestamo>().ToTable("Prestamo"));

            base.OnModelCreating(modelBuilder);
        }

    }
}
