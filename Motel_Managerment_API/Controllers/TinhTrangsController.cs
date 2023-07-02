using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinhTrangsController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;

        public TinhTrangsController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllTinhTrang")]
        public IActionResult GetAllTinhTrang()
        {
            List<Tinhtrang> tinhtrangs = _context.Tinhtrangs.ToList();
            return Ok(tinhtrangs);
        }

    }
}
