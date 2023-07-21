using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.ViewModels
{
    public class EmprestimoViewModel
    {
        public EmprestimoViewModel(string status, double valorTotalComJuros, double valorDoJuros)
        {
            Status = status;
            ValorTotalComJuros = valorTotalComJuros.ToString("C");
            ValorDoJuros = valorDoJuros.ToString("C");
        }


        //TODO: Aqui deve ser implementado os atributos de saida
        public string Status { get; set; }
        public string ValorTotalComJuros { get; set; }
        public string ValorDoJuros { get; set; }
    }
}
