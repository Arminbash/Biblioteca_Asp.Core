using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Persistence;


namespace Biblioteca.Persistence.SqlLite
{
    public class SqlLiteBibliotecaDbContext : BibliotecaDbContext
    {
        public SqlLiteBibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
