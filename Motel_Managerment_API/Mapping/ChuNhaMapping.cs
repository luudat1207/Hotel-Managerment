using AutoMapper;
using Motel_Managerment_API.Models;
using System.IO;

namespace Motel_Managerment_API.Mapping
{
    public class ChuNhaMapping : Profile
    {
        public ChuNhaMapping()
        {
            CreateMap<Chunha, DTO.ChuNhaDTO>();
            CreateMap<DTO.ChuNhaDTO, Chunha>();
        }
    }
}
