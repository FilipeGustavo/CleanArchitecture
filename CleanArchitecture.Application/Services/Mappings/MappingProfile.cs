using CleanArchitecture.Application.InputModels;
using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Entities;
using AutoMapper;
using CleanArchitecture.Application.ViewModels;

namespace CleanArchitecture.Application.Services.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmprestimoInputModel, SolicitarEmprestimoDto>().ReverseMap();
            CreateMap<EmprestimoViewModel, SolicitarEmprestimoDto>().ReverseMap();
            CreateMap<EmprestimoViewModel, Emprestimo>().ReverseMap();
        }
    }
}
