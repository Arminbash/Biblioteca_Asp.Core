using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public  class Autor
    {
        public Autor()
        {
            LibAut = new HashSet<LibAut>();
        }
        [Key]
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public ICollection<LibAut> LibAut { get; private set; }
    }
}
