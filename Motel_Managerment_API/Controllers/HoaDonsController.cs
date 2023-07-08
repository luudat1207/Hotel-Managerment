using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonsController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;

        public HoaDonsController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllHoaDonByHopDong/{sohd}")]
        public IActionResult GetAllHoaDonByHopDong(string sohd)
        {
            List<Hoadon> hoadons = _context.Hoadons.Where(x => x.SoHopDong.Equals(sohd)).OrderBy(x => x.Idhd).ToList();
            return Ok(_mapper.Map<List<HoaDonDTO>>(hoadons));
        }

        [HttpGet]
        [Route("GetAllDichVuConlai/{sohd}")]
        public IActionResult GetAllCTHoaDonByHoaDon(int sohd)
        {
            var dsMaDV = _context.Cthoadons.Where(x => x.Idhd == sohd).Select(x => x.MaDv).ToList();
           List<Dichvu> dv = _context.Dichvus.Where(x => !dsMaDV.Contains(x.MaDv)).ToList();
            return Ok(_mapper.Map<List<DichVuDTO>>(dv));
        }

        [HttpDelete]
        [Route("DeleteHoaDonById/{id}")]
        public IActionResult DeleteHoaDonById(int id)
        {
            try
            {
                var hoadons = _context.Hoadons
                    .Include(c => c.Cthoadons)
                    .FirstOrDefault(x => x.Idhd == id);
                if (hoadons == null)
                {
                    return NotFound();
                }

                _context.Hoadons.Remove(hoadons);

                foreach (var cthoadons in hoadons.Cthoadons.ToList())
                {

                    _context.Cthoadons.RemoveRange(cthoadons);
                }

                _context.SaveChanges();

                return Ok("delete success");
            }
            catch (Exception e)
            {
                return Conflict(e.Message);
            }
        }


        [HttpPost]
        [Route("AddHoaDon")]
        public IActionResult AddHoaDon([FromBody] HoaDonDTO hoadon)
        {
            try
            {
                try
                {

                    _context.Hoadons.Add(_mapper.Map<Hoadon>(hoadon));
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return Ok("add success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("UpdateHoaDon")]
        public IActionResult UpdateHoaDon([FromBody] HoaDonDTO hoadon)
        {
            try
            {
                try
                {
                    _context.Entry<Hoadon>(_mapper.Map<Hoadon>(hoadon)).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return Ok("update success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
