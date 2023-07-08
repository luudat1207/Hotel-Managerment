using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class ThanhToanMapping : Profile
    {
        public ThanhToanMapping()
        {
            CreateMap<Thanhtoan, DTO.ThanhToanDTO>();
            CreateMap<DTO.ThanhToanDTO, Thanhtoan>();
        }
    }
}
