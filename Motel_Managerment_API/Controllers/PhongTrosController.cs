using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using System.Linq;

namespace Motel_Managerment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongTrosController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;

        public PhongTrosController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllPhongTro")] 
        public IActionResult GetAllPhongTro()
        {
            List<Phongtro> phongtros = _context.Phongtros.Include(x => x.MaTinhTrangNavigation).OrderBy(x => x.MaPhong).ToList();
            return Ok(_mapper.Map<List<PhongTroDTO>>(phongtros));
        }

        [HttpGet]
        [Route("GetAllPhongTroByInfor/{information}")]
        public IActionResult GetAllPhongTroByInfor(string information)
        {
            double giaphong;
            List<Phongtro> phongtros = _context.Phongtros
                .Include(x => x.MaTinhTrangNavigation)
                .Where(x => x.MaPhong.Contains(information) ||
                       x.GiaPhong.Equals(double.TryParse(information, out giaphong)) ||
                       x.MaTinhTrangNavigation.TinhTrang1.Contains(information))
                .OrderBy(x => x.MaPhong).ToList();
            return Ok(_mapper.Map<List<PhongTroDTO>>(phongtros));
        }

        [HttpGet]
        [Route("GetPhongTroById/{id}")]
        public IActionResult GetPhongTroById(int id)
        {

            Phongtro pt = _context.Phongtros.Where(x => x.MaPhong.Equals(id)).SingleOrDefault();
            return Ok(_mapper.Map<PhongTroDTO>(pt));
        }


        [HttpDelete]
        [Route("DeletePhongTroById/{id}")]
        public IActionResult DeletePhongTroById(string id)
        {
            try
            {
                var phongtros = _context.Phongtros
                    .Include(c => c.Hopdongs)
                    .Where(x => x.MaPhong.Equals(id)).SingleOrDefault();
                if (phongtros == null)
                {
                    return NotFound();
                }

                _context.Phongtros.Remove(phongtros);

                foreach (var hopdongs in phongtros.Hopdongs.ToList())
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
        [Route("AddPhongTro")]
        public IActionResult AddPhongTro([FromBody] PhongTroDTO phongtro)
        {
            try
            {
                try
                {

                    _context.Phongtros.Add(_mapper.Map<Phongtro>(phongtro));
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
        [Route("UpdatePhongTroById")]
        public IActionResult UpdatePhongTroById([FromBody] PhongTroDTO phongtro)
        {
            try
            {
                try
                {
                    _context.Entry<Phongtro>(_mapper.Map<Phongtro>(phongtro)).State = EntityState.Modified;
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
