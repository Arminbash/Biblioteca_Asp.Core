using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Persistence;

namespace Biblioteca.Persistence.MYSQL
{
   public  class MySqlBibliotecaDbContext : BibliotecaDbContext
    {
        public MySqlBibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
