using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services.Exceptions
{
    public class MinhasExceptions : Exception
    {
        public object ObjetoAssociado { get; }

        // Construtor com mensagem e objeto
        public MinhasExceptions(string mensagem, object objetoAssociado) : base(mensagem)
        {
            ObjetoAssociado = objetoAssociado;
        }

        // Construtor com mensagem, objeto e exceção interna
        public MinhasExceptions(string mensagem, object objetoAssociado, Exception innerException) : base(mensagem, innerException)
        {
            ObjetoAssociado = objetoAssociado;
        }
    }
}
