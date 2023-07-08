using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class HoaDonMapping : Profile
    {
        public HoaDonMapping()
        {
            CreateMap<Hoadon, DTO.HoaDonDTO>();
            CreateMap<DTO.HoaDonDTO, Hoadon>();
        }
    }
}
