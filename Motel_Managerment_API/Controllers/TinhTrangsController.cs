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
            return Ok(_mapper.Map<List<TinhTrangDTO>>(tinhtrangs));
        }

        [HttpGet]
        [Route("GetTinhTrangById/{id}")]
        public IActionResult GetTinhTrangById(int id)
        {
            Tinhtrang tt = _context.Tinhtrangs.Where(x => x.MaTinhTrang == id).SingleOrDefault();

            return Ok(_mapper.Map<TinhTrangDTO>(tt));
        }

        [HttpDelete]
        [Route("DeleteTinhTrangById/{id}")]
        public IActionResult DeleteTinhTrangById(int id)
        {
            try
            {
                var tinhtrangs = _context.Tinhtrangs
                    .Include(c => c.Phongtros)
                    .ThenInclude(o => o.Hopdongs)
                    .FirstOrDefault(x => x.MaTinhTrang == id);
                if (tinhtrangs == null)
                {
                    return NotFound();
                }

                _context.Tinhtrangs.Remove(tinhtrangs);

                foreach (var phongtro in tinhtrangs.Phongtros.ToList())
                {
                    foreach (var hopdong in phongtro.Hopdongs.ToList())
                    {
                        _context.Hopdongs.Remove(hopdong);
                    }

                    _context.Phongtros.Remove(phongtro);
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
        [Route("AddTinhTrangById")]
        public IActionResult AddTinhTrangById([FromBody] TinhTrangDTO tinhTrang)
        {
            try
            {
                try
                {
                    _context.Tinhtrangs.Add(_mapper.Map<Tinhtrang>(tinhTrang));
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
        [Route("UpdateTinhTrangById")]
        public IActionResult UpdateTinhTrangById([FromBody] TinhTrangDTO tinhTrang)
        {
            try
            {
                try
                {
                    _context.Entry<Tinhtrang>(_mapper.Map<Tinhtrang>(tinhTrang)).State = EntityState.Modified;
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
