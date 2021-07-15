using Socoro.Application.Features.Operations.Commands;
using Socoro.Application.DTOs.Operation;
using AutoMapper;
using Socoro.Web.Areas.KAM.Models;

namespace Socoro.Web.Areas.KAM.Mappings
{
    internal class OperationProfile : Profile
    {
        public OperationProfile()
        {
            CreateMap<CreateOperation, OperationViewModel>().ReverseMap();
            CreateMap<UpdateOperation, OperationViewModel>().ReverseMap();
            CreateMap<DeleteOperation, OperationViewModel>().ReverseMap();
            CreateMap<OperationResponse, OperationViewModel>().ReverseMap();
        }
    }
}
