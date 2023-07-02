using AutoMapper;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class PhongTroMapping : Profile
    {
        public PhongTroMapping()
        {
            CreateMap<Phongtro, PhongTroDTO>()
            .ForMember(dest => dest.MaTinhTrang, opt => opt.MapFrom(src => src.MaTinhTrangNavigation.MaTinhTrang))
            .ForMember(dest => dest.TinhTrang1, opt => opt.MapFrom(src => src.MaTinhTrangNavigation.TinhTrang1));

            CreateMap<DTO.PhongTroDTO, Phongtro>();
        }
    }
}
