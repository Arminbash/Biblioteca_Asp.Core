﻿using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Data.Interfaces;
using Entities;
using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Biblioteca.Persistence.Configurations;
using Microsoft.EntityFrameworkCore.Relational;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BibliotecaDbContext).Assembly);
        }

    }
}
