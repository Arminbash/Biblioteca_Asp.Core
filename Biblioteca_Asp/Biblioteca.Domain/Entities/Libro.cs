using System.Collections.Generic;

namespace Entities
{
    public class Libro
    {
        public Libro()
        {
            LibAut = new HashSet<LibAut>();
            Prestamo = new HashSet<Prestamo>();
        }
        public string IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Area { get; set; }
        public ICollection<LibAut> LibAut { get; private set; }
        public ICollection<Prestamo> Prestamo { get; private set; }
    }
}
