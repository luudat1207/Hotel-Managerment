using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class KhachThueMapping : Profile
    {
        public KhachThueMapping()
        {
            CreateMap<Khachthue, DTO.KhachThueDTO>();
            CreateMap<DTO.KhachThueDTO, Khachthue>();
        }
    }
}
