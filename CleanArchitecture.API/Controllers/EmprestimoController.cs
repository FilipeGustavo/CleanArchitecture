using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/[controller]")]
    public class EmprestimoController : ControllerBase
    {
        private readonly IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpPost]
        public EmprestimoViewModel GetById([FromBody] EmprestimoInputModel emprestimoInputModel)
        {
            var emprestimo = _emprestimoService.SolicitarEmprestimo(emprestimoInputModel);

            return emprestimo;
        }
    }
}
