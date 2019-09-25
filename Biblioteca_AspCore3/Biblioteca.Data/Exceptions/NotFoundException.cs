using System;

namespace Biblioteca.Data.Exceptions
{
   public class NotFoundException :Exception
    {
        public NotFoundException(string name, object key)
           : base($"Entidad \"{name}\" ({key}) no se encuentra.")
        {
        }

    }
}
