using System;

namespace Biblioteca.Data.Exceptions
{
    public class DeleteFailureException : Exception
    {
            public DeleteFailureException(string name, object key, string message)
                : base($"Borrar de la entidad \"{name}\" ({key}) Fallo. {message}")
            {
            }
    }
}
