using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Persistence.SqlLite;
namespace Biblioteca.Persistence.SqlLite
{
   public  class SqlLiteContextFactory : IDesignTimeDbContextFactory<SqlLiteBibliotecaDbContext>
    {
        public SqlLiteBibliotecaDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", false)
                 .AddJsonFile("appsettings.local.json", true)
                 .Build();

            var builder = new DbContextOptionsBuilder<BibliotecaDbContext>();
            builder.UseSqlite(
                config.GetConnectionString(nameof(BibliotecaDbContext)),
                b => b.MigrationsAssembly("Biblioteca.Persistence.SqlLite")
            );
            return new SqlLiteBibliotecaDbContext(builder.Options);
        }
    }
}
