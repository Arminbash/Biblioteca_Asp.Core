using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
//using Biblioteca.Persistence.Extensions;

namespace Biblioteca.Persistence
{
    public class BibliotecaInitializer
    {
        public static void Initialize(BibliotecaDbContext context)
        {
            var initializer = new BibliotecaInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(BibliotecaDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Set<Autor>().Any())
            {
                return; //Db ha sido creada
            }

            SeedAutors(context);
        }

        public void SeedAutors(BibliotecaDbContext context)
        {
            var Autors = new[]
            {
                new Autor {IdAutor =1 ,Nombre = "Juan",Nacionalidad = "Nicaraguense"}
            };

            context.Set<Autor>().AddRange(Autors);

            context.SaveChanges();
        }
        private static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
    }
}
