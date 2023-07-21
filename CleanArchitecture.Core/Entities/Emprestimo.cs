using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities
{
    public class Emprestimo
    {
        public Emprestimo(string status, double valorTotalComJuros, double valorDoJuros)
        {
            Status = status;
            ValorTotalComJuros = valorTotalComJuros;
            ValorDoJuros = valorDoJuros;
        }

        public string Status { get; set; }
        public double ValorTotalComJuros { get; set; }
        public double ValorDoJuros { get; set; }
    }
}
