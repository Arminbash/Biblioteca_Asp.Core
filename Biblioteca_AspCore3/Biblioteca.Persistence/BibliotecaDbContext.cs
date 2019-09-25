using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Data.Interfaces;
using Entities;
using Models;
using Microsoft.EntityFrameworkCore;
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

        public DbSet<Autor> Autor { get; set; }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<LibAut> LibAut { get; set; }
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BibliotecaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
