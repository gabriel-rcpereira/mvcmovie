using AutoMapper;
using Model.DatabaseCore.Entity;
using Service.ApplicationService.Vo;

namespace Service.ApplicationService.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Genre, GenreVo>()
                .ForMember(target => target.Id, source => source.MapFrom(src => src.ID))
                .ForMember(target => target.Name, source => source.MapFrom(src => src.Name));

            CreateMap<GenreVo, Genre>()
                .ForMember(target => target.ID, source => source.MapFrom(src => src.Id))
                .ForMember(target => target.Name, source => source.MapFrom(src => src.Name));
        }
    }
}
