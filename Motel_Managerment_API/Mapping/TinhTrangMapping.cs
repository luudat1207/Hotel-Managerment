using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class TinhTrangMapping : Profile
    {
        public TinhTrangMapping()
        {
            CreateMap<Tinhtrang, DTO.TinhTrangDTO>();
            CreateMap<DTO.TinhTrangDTO, Tinhtrang>();
        }
    }
}
