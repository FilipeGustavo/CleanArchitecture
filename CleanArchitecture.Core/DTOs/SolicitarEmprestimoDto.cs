using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CleanArchitecture.Core.DTOs
{
    public class SolicitarEmprestimoDto
    {
        //TODO: Aqui implementar atributos necessarios para entrada
        public double ValorDoCredito { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public int IdStautsCredito { get; set; }
        public string DescricaoStautsCredito { get; set; }
        public TipoCredito TipoCreditoSelecionado { get; set; }

        public enum TipoCredito
        {
            CreditoDiretoTaxa2,
            CreditoConsignadoTaxa1,
            CreditoPessoaJuridicaTaxa5,
            CreditoPessoaFisicaTaxa3,
            CreditoImobiliarioTaxa9
        }

    }
}
