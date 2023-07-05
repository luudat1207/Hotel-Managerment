using AutoMapper;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class HopDongMapping : Profile
    {
        public HopDongMapping() {
            CreateMap<Hopdong, HopDongDTO>()
                .ForMember(dest => dest.HoTenChuNha, opt => opt.MapFrom(src => src.IdcnNavigation.HoTen))
                .ForMember(dest => dest.HoTenKhachHang, opt => opt.MapFrom(src => src.CccdNavigation.HoTen))
                .ForMember(dest => dest.ThongTinPhong, opt => opt.MapFrom(src => src.MaPhongNavigation.ThongTin));
            CreateMap<DTO.HopDongDTO, Hopdong>();
        }
    }
}
