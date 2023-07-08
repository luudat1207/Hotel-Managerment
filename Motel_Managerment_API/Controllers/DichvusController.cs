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
    public class DichvusController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;
        public DichvusController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("GetAllDichVus")]
        public IActionResult GetAllDichVus()
        {
            List<Dichvu> dichvus = new List<Dichvu>();
            using (_context = new DBNhaTroContext())
            {
                dichvus = _context.Dichvus.ToList();
            }
            return Ok(_mapper.Map<List<DichVuDTO>>(dichvus));
        }

        [HttpGet]
        [Route("GetDichVuById/{id}")]
        public IActionResult GetDichVuById(int id)
        {
            Dichvu dv = _context.Dichvus.Where(x => x.MaDv == id).SingleOrDefault();

            return Ok(_mapper.Map<DichVuDTO>(dv));
        }

        [HttpDelete]
        [Route("DeleteDichVuById/{id}")]
        public IActionResult DeleteDichVuById(int id)
        {
            try
            {
                var dichvus = _context.Dichvus
                    .Include(c => c.Cthoadons)
                    .Where(x => x.MaDv == id).SingleOrDefault();
                if (dichvus == null)
                {
                    return NotFound();
                }

                _context.Dichvus.Remove(dichvus);

                foreach (var cthoadon in dichvus.Cthoadons.ToList())
                {

                    _context.Cthoadons.Remove(cthoadon);
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
        [Route("AddDichVuById")]
        public IActionResult AddDichVuById([FromBody] DichVuDTO dichvu)
        {
            try
            {
                try
                {

                    _context.Dichvus.Add(_mapper.Map<Dichvu>(dichvu));
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
        [Route("UpdateDichVuById")]
        public IActionResult UpdateDichVuById([FromBody] DichVuDTO dichvu)
        {
            try
            {
                try
                {
                    _context.Entry<Dichvu>(_mapper.Map<Dichvu>(dichvu)).State = EntityState.Modified;
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
