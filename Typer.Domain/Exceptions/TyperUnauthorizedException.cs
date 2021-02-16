using System;

namespace Typer.Domain.Exceptions
{
    public class TyperUnauthorizedException : Exception
    {
        public TyperUnauthorizedException() { }
        public TyperUnauthorizedException(string message) : base(message) { }
        public TyperUnauthorizedException(string message, Exception innerException) : base(message, innerException) { }
    }
}
