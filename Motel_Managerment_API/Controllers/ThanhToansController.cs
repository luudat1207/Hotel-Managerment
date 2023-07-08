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
    public class ThanhToansController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;
        public ThanhToansController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("GetAllThanhToans")]
        public IActionResult GetAllThanhToans()
        {
            List<Thanhtoan> thanhtoans = new List<Thanhtoan>();
            using (_context = new DBNhaTroContext())
            {
                thanhtoans = _context.Thanhtoans.ToList();
            }
            return Ok(_mapper.Map<List<ThanhToanDTO>>(thanhtoans));
        }

        [HttpGet]
        [Route("GetThanhToanById/{id}")]
        public IActionResult GetThanhToanById(int id)
        {
            Thanhtoan tt = _context.Thanhtoans.Where(x => x.Idtt == id).SingleOrDefault();

            return Ok(_mapper.Map<ThanhToanDTO>(tt));
        }

        [HttpDelete]
        [Route("DeleteThanhToanById/{id}")]
        public IActionResult DeleteThanhToanById(int id)
        {
            try
            {
                var thanhtoans = _context.Thanhtoans
                    .Include(c => c.Hoadons)
                    .Where(x => x.Idtt == id).SingleOrDefault();
                if (thanhtoans == null)
                {
                    return NotFound();
                }

                _context.Thanhtoans.Remove(thanhtoans);

                foreach (var hoadon in thanhtoans.Hoadons.ToList())
                {

                    _context.Hoadons.Remove(hoadon);
                }

                _context.SaveChanges();

                return Ok("delete success");
            }
            catch (Exception e)
            {
                return Conflict("There was an unknown error when performing data deletion.");
            }
        }

        [HttpPost]
        [Route("AddThanhToanById")]
        public IActionResult AddThanhToanById([FromBody] ThanhToanDTO thanhtoan)
        {
            try
            {
                try
                {

                    _context.Thanhtoans.Add(_mapper.Map<Thanhtoan>(thanhtoan));
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
        [Route("UpdateThanhToanById")]
        public IActionResult UpdateThanhToanById([FromBody] ThanhToanDTO thanhtoan)
        {
            try
            {
                try
                {
                    _context.Entry<Thanhtoan>(_mapper.Map<Thanhtoan>(thanhtoan)).State = EntityState.Modified;
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
