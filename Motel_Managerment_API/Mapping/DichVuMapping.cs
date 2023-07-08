using AutoMapper;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Mapping
{
    public class DichVuMapping : Profile
    {
        public DichVuMapping()
        {
            CreateMap<Dichvu, DTO.DichVuDTO>();
            CreateMap<DTO.DichVuDTO, Dichvu>();
        }
    }
}
