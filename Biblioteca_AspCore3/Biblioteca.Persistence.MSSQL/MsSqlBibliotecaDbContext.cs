using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Biblioteca.Persistence;

namespace Biblioteca.Persisence.MSSQL
{
    //https://www.it-swarm.net/es/c%23/como-configurar-el-tiempo-de-espera-de-la-migracion-de-entity-framework-core/826798191/
    public class MsSqlBibliotecaDbContext : BibliotecaDbContext
    {
        public MsSqlBibliotecaDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
