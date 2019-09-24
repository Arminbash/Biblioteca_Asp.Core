using System;
using System.Collections.Generic;
using System.Linq;
using Entities;
//using Biblioteca.Persistence.Extensions;

namespace Biblioteca.Persistence
{
    public class BibliotecaInitializer
    {
        private readonly Dictionary<int, Autor> Autors = new Dictionary<int, Autor>();
        private readonly Dictionary<int, Estudiante> Estudiantes = new Dictionary<int, Estudiante>();
        private readonly Dictionary<int, LibAut> LibAuts = new Dictionary<int, LibAut>();
        private readonly Dictionary<int, Libro> Libros = new Dictionary<int, Libro>();
        private readonly Dictionary<int, Prestamo> Prestamos = new Dictionary<int, Prestamo>();
        public static void Initialize(BibliotecaDbContext context)
        {
            var initializer = new BibliotecaInitializer();
            initializer.SeedEverything(context);
        }

        public void SeedEverything(BibliotecaDbContext context)
        {
            context.Database.CreateIfNotExists();

            if (context.Set<Autor>().Any())
            {
                return; // Db has been seeded
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
