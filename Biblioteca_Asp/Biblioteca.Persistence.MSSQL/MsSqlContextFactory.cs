using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Biblioteca.Persistence.MSSQL
{
    public class MsSqlContextFactory : IDesignTimeDbContextFactory<MsSqlNorthwindDbContext>
    {

    }
}
