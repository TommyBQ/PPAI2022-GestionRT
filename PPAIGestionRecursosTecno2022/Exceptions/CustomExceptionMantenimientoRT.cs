using System;

namespace PPAIGestionRecursosTecno2022.Exceptions
{
    public class CustomExceptionMantenimientoRT : Exception
    {
        public CustomExceptionMantenimientoRT()
        {
        }

        public CustomExceptionMantenimientoRT(string message)
            : base(message)
        {
        }

        public CustomExceptionMantenimientoRT(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
