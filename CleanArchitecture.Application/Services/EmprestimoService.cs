using AutoMapper;
using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using CleanArchitecture.Application.Services.Exceptions;
using CleanArchitecture.Core.Entities;

namespace CleanArchitecture.Application.Services
{
    public class EmprestimoService : IEmprestimoService
    {
        //Aqui deve ser implementado os serviços

        private readonly IEmprestimoRepository _productRepository;
        private readonly IMapper _mapper;

        public EmprestimoService(IEmprestimoRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        //As duas buscas abaixo é um exemplo de como deve ser feito os metodos necessário e quando usar o input model e quando usar o view model
        public void Add(EmprestimoInputModel productInputModel)
        {

        }

        public EmprestimoViewModel SolicitarEmprestimo(EmprestimoInputModel productInputModel)
        {
            //O valor máximo a ser liberado para qualquer tipo de empréstimo é de R$ 1.000.000,00;
            if (productInputModel.ValorDoCredito > 1000000.00)
            {
                throw new ArgumentException("O valor máximo de credito é de 1.000.000.00");
            }

            //A quantidade mínima de parcelas é de 5x e máxima de 72x;
            if (productInputModel.QuantidadeDeParcelas < 5 || productInputModel.QuantidadeDeParcelas > 72)
            {
                throw new ArgumentException("A quantidade mínima de parcelas é de 5x e máxima de 72x");
            }

            //Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00;
            if (productInputModel.PessoaJuridica == true && productInputModel.ValorDoCredito < 15000.00)
            {
                throw new ArgumentException("Para o crédito de pessoa jurídica, o valor mínimo a ser liberado é de R$ 15.000,00");
            }

            //A data do primeiro vencimento sempre será no mínimo 15 dias e no máximo 40 dias a partir da data atual.
            DateTime dataAtual = DateTime.Now;
            int diferencaDias = (productInputModel.DataPrimeiroVencimento - dataAtual).Days;

            if (diferencaDias < 15 || diferencaDias > 40)
            {
                throw new ArgumentException("A data do primeiro vencimento sempre será no mínimo 15 dias e no máximo 40 dias a partir da data atual.");
            }

            var solicitarEmprestimoProductDto = _mapper.Map<SolicitarEmprestimoDto>(productInputModel);
            Emprestimo product = _productRepository.SolicitarEmprestimo(solicitarEmprestimoProductDto);
            var productViewModel = _mapper.Map<EmprestimoViewModel>(product);
            //var productViewModel = new ProductViewModel(product.Status, product.ValorTotalComJuros, product.ValorDoJuros);
            return productViewModel;
        }
    }
}
