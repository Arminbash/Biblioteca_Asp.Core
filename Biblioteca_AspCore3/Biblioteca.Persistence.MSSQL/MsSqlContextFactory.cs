using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Biblioteca.Persisence.MSSQL;

namespace Biblioteca.Persistence.MSSQL
{
    //https://blog.tonysneed.com/2018/12/20/idesigntimedbcontextfactory-and-dependency-injection-a-love-story/
    public class MsSqlContextFactory : IDesignTimeDbContextFactory<MsSqlBibliotecaDbContext>
    {
        public MsSqlBibliotecaDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                 .AddJsonFile("appsettings.json", false)
                 .AddJsonFile("appsettings.local.json", true)
                 .Build();

            var builder = new DbContextOptionsBuilder<BibliotecaDbContext>();
            builder.UseSqlServer(
                config.GetConnectionString(nameof(BibliotecaDbContext)),
                b => b.MigrationsAssembly("Biblioteca.Persistence.MSSQL")
            );
            return new MsSqlBibliotecaDbContext(builder.Options);
        }
    }
}
