using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Persistence.MYSQL;

namespace Biblioteca.Persistence.MYSQL
{
    public class MySqlContextFactory : IDesignTimeDbContextFactory<MySqlBibliotecaDbContext>
    {
        public MySqlBibliotecaDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", false)
                 .AddJsonFile("appsettings.local.json", true)
                 .Build();

            var builder = new DbContextOptionsBuilder<BibliotecaDbContext>();
            builder.UseMySQL(
                config.GetConnectionString(nameof(BibliotecaDbContext)),
                b => b.MigrationsAssembly("Biblioteca.Persistence.MYSQL")
            );
            return new MySqlBibliotecaDbContext(builder.Options);
        }
    }
}
