using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CleanArchitecture.Application.InputModels
{
    public class EmprestimoInputModel
    {
        public EmprestimoInputModel(double valorDoCredito, TipoCredito tipoCreditoSelecionado, int quantidadeDeParcelas, DateTime dataPrimeiroVencimento, Boolean pessoaJuridica)
        {
            ValorDoCredito = valorDoCredito;
            TipoCreditoSelecionado = tipoCreditoSelecionado;
            QuantidadeDeParcelas = quantidadeDeParcelas;
            DataPrimeiroVencimento = dataPrimeiroVencimento;
            PessoaJuridica = pessoaJuridica;
        }

        //TODO: Aqui implementar atributos necessarios para entrada
        public double ValorDoCredito { get; set; }
        public TipoCredito TipoCreditoSelecionado { get; set; }
        public int QuantidadeDeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
        public Boolean PessoaJuridica { get; set; }

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