using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public interface IEmprestimoService
    {
        EmprestimoViewModel SolicitarEmprestimo(EmprestimoInputModel productInputModel);
    }
}
