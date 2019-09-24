using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Data.Interfaces;
using System.Data.Entity;
using Entities;
using Models;
namespace Biblioteca.Persistence
{
    public class BibliotecaDbContext : DbContext, IBibliotecaDbContext
    {
        //https://www.trycatchfail.com/2017/09/12/adding-entity-framework-code-first-type-configs-from-a-namespace/
        public BibliotecaDbContext()
        {

        }

        public BibliotecaDbContext(string conexion)
            : base(conexion)
        {
        }

        public DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(BibliotecaDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
