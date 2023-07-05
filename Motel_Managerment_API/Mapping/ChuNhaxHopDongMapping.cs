using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class ChuNhaxHopDongMapping : Profile
    {
        public ChuNhaxHopDongMapping()
        {
            CreateMap<Chunha, DTO.ChuNhaxHopDongDTO>();
            CreateMap<DTO.ChuNhaxHopDongDTO, Chunha>();
        }
    }
}
