using AutoMapper;
using BE_CQRS.Application.DTOs.Command.CreateCommand.Postgre;
using BE_CQRS.Application.DTOs.Command.DeleteCommand.Postgre;
using BE_CQRS.Application.DTOs.Command.UpdateCommand.Postgre;
using BE_CQRS.Models.Entities.Core;

namespace BE_CQRS.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<CreateTypeUnitCommand, TypeUnitPg>().ReverseMap();
            CreateMap<UpdateTypeUnitCommand, TypeUnitPg>().ReverseMap();
            CreateMap<DeleteTypeUnitCommand, TypeUnitPg>().ReverseMap();
        }
    }
}
