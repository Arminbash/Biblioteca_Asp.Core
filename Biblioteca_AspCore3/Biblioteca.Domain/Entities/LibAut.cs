using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class LibAut
    {
        public LibAut()
        {

        }
        [Key]
        public int IdLibAut { get; set; }
        public Autor Autor { get;  set; }
        public Libro Libro { get;  set; }
    }
}
