using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Interfaces.Repositories
{
    public interface IEmprestimoRepository
    {
        Emprestimo SolicitarEmprestimo(SolicitarEmprestimoDto solicitarEmprestimoProductDto);
    }
}
