using System;

namespace Typer.Domain.Exceptions
{
    public class TyperBadRequestException : Exception
    {
        public TyperBadRequestException() { }
        public TyperBadRequestException(string message) : base(message) { }
        public TyperBadRequestException(string message, Exception innerException) : base(message, innerException) { }
    }
}
