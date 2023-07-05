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
    public class KhachThuesController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;

        public KhachThuesController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllKhachThue")]
        public IActionResult GetAllKhachThue()
        {
            List<Khachthue> khachthues = _context.Khachthues.OrderBy(x => x.HoTen).ToList();
            return Ok(_mapper.Map<List<KhachThueDTO>>(khachthues));
        }

        [HttpGet]
        [Route("GetAllKhachThueByInfor/{information}")]
        public IActionResult GetAllKhachThueByInfor(string information)
        {
            List<Khachthue> khachthues = _context.Khachthues
                .Where(x =>
                    x.Cccd.Contains(information) ||
                    x.HoTen.Contains(information) ||
                    x.QueQuan.Contains(information) ||
                    x.DiaChi.Contains(information))
                .OrderBy(x => x.HoTen).ToList();
            return Ok(_mapper.Map<List<KhachThueDTO>>(khachthues));
        }

        [HttpGet]
        [Route("GetKhachThueByCCCD/{id}")]
        public IActionResult GetKhachThueByCCCD(int id)
        {

            Khachthue kt = _context.Khachthues.Where(x => x.Cccd.Equals(id)).SingleOrDefault();
            return Ok(_mapper.Map<KhachThueDTO>(kt));
        }


        [HttpDelete]
        [Route("DeleteKhachThueById/{id}")]
        public IActionResult DeleteKhachThueById(string id)
        {
            try
            {
                var khachthues = _context.Khachthues
                    .Include(c => c.Hopdongs)
                    .Where(x => x.Cccd.Equals(id)).SingleOrDefault();
                if (khachthues == null)
                {
                    return NotFound();
                }

                _context.Khachthues.Remove(khachthues);

                foreach (var hopdongs in khachthues.Hopdongs.ToList())
                {

                    _context.Hopdongs.Remove(hopdongs);
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
        [Route("AddKhachThue")]
        public IActionResult AddKhachThue([FromBody] KhachThueDTO khachthue)
        {
            try
            {
                try
                {

                    _context.Khachthues.Add(_mapper.Map<Khachthue>(khachthue));
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
        [Route("UpdateKhachThueById")]
        public IActionResult UpdateKhachThueById([FromBody] KhachThueDTO khachthue)
        {
            try
            {
                try
                {
                    _context.Entry<Khachthue>(_mapper.Map<Khachthue>(khachthue)).State = EntityState.Modified;
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
