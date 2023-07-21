using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        public Emprestimo SolicitarEmprestimo(SolicitarEmprestimoDto solicitarEmprestimoProductDto)
        {
            double valorDoJuros = 0;
            double valorCreditoSemJuros = solicitarEmprestimoProductDto.ValorDoCredito;

            //Calcular Crédito Direto Taxa de 2
            if (solicitarEmprestimoProductDto.TipoCreditoSelecionado == SolicitarEmprestimoDto.TipoCredito.CreditoDiretoTaxa2)
            {
                solicitarEmprestimoProductDto.ValorDoCredito = solicitarEmprestimoProductDto.ValorDoCredito * 1.02;
                valorDoJuros = solicitarEmprestimoProductDto.ValorDoCredito - valorCreditoSemJuros;
            }

            //Calcular Crédito Consignado Taxa de 1%
            if (solicitarEmprestimoProductDto.TipoCreditoSelecionado == SolicitarEmprestimoDto.TipoCredito.CreditoConsignadoTaxa1)
            {
                solicitarEmprestimoProductDto.ValorDoCredito = solicitarEmprestimoProductDto.ValorDoCredito * 1.01;
                valorDoJuros = solicitarEmprestimoProductDto.ValorDoCredito - valorCreditoSemJuros;
            }

            //Calcular Crédito Pessoa Jurídica Taxa de 5%
            if (solicitarEmprestimoProductDto.TipoCreditoSelecionado == SolicitarEmprestimoDto.TipoCredito.CreditoConsignadoTaxa1)
            {
                solicitarEmprestimoProductDto.ValorDoCredito = solicitarEmprestimoProductDto.ValorDoCredito * 1.05;
                valorDoJuros = solicitarEmprestimoProductDto.ValorDoCredito - valorCreditoSemJuros;
            }

            //Calcular Crédito Pessoa Física Taxa de 3%
            if (solicitarEmprestimoProductDto.TipoCreditoSelecionado == SolicitarEmprestimoDto.TipoCredito.CreditoConsignadoTaxa1)
            {
                solicitarEmprestimoProductDto.ValorDoCredito = solicitarEmprestimoProductDto.ValorDoCredito * 1.03;
                valorDoJuros = solicitarEmprestimoProductDto.ValorDoCredito - valorCreditoSemJuros;
            }

            //Calcular Crédito Imobiliário Taxa de 9%
            if (solicitarEmprestimoProductDto.TipoCreditoSelecionado == SolicitarEmprestimoDto.TipoCredito.CreditoConsignadoTaxa1)
            {
                solicitarEmprestimoProductDto.ValorDoCredito = solicitarEmprestimoProductDto.ValorDoCredito * 1.09;
                valorDoJuros = solicitarEmprestimoProductDto.ValorDoCredito - valorCreditoSemJuros;
            }

            return new Emprestimo("Aprovado", solicitarEmprestimoProductDto.ValorDoCredito, valorDoJuros);
        }
    }
}
