using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class KhachThuexHopDongMapping : Profile
    {
        public KhachThuexHopDongMapping()
        {
            CreateMap<Khachthue, DTO.KhachThuexHopDongDTO>();
            CreateMap<DTO.KhachThuexHopDongDTO, Khachthue>();
        }
    }
}
