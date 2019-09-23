using System;

namespace Entities
{
   public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public string FechaDevolucion { get; set; }
        public bool Devolucion { get; set; }
        public Libro Libro { get;  set; }
        public Estudiante Estudiante { get;  set; }
    }
}
