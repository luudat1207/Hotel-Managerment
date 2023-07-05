using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class PhongTroxHopDongMapping : Profile
    {
        public PhongTroxHopDongMapping()
        {
            CreateMap<Phongtro, DTO.PhongTroxHopDongDTO>();
            CreateMap<DTO.PhongTroxHopDongDTO, Phongtro>();
        }
    }
}
