using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Estudiante
    {
        public Estudiante()
        {
            Prestamo = new HashSet<Prestamo>();
        }
        [Key]
        public int IdEstudiante { get; set; }
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }
        public ICollection<Prestamo> Prestamo { get; private set; }
    }
}
