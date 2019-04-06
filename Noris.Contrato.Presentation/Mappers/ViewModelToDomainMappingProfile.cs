using AutoMapper;
using Noris.Contrato.Model;
using Noris.Contrato.Presentation.ViewModels;

namespace Noris.Contrato.Presentation.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ContratoCompraVenda, ContratoCompraVendaViewModel>();
        }
    }
}