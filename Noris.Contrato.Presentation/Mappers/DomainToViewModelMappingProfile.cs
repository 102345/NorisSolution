using AutoMapper;
using Noris.Contrato.Model;
using Noris.Contrato.Presentation.ViewModels;

namespace Noris.Contrato.Presentation.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ContratoCompraVendaViewModel, ContratoCompraVenda>();
        }
    }
}