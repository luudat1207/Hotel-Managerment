using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using System.IO;

namespace Motel_Managerment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChuNhasController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;
        public ChuNhasController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("GetAllChuNhas")]
        public IActionResult GetAllChuNhas()
        {
            List<Chunha> chunhas = new List<Chunha>();
            using (_context = new DBNhaTroContext())
            {
                chunhas = _context.Chunhas.ToList();
            }
            return Ok(_mapper.Map<List<ChuNhaDTO>>(chunhas));
        }

        [HttpGet]
        [Route("GetChuNhaById/{id}")]
        public IActionResult GetChuNhaById(int id)
        {
            Chunha cn = _context.Chunhas.Where(x => x.Idcn == id).SingleOrDefault();

            return Ok(_mapper.Map<ChuNhaDTO>(cn));
        }

        [HttpDelete]
        [Route("DeleteChuNhaById/{id}")]
        public IActionResult DeleteChuNhaById(int id)
        {
            try
            {
                var chunhas = _context.Chunhas
                    .Include(c => c.Hopdongs)
                    .Where(x => x.Idcn == id).SingleOrDefault();
                if (chunhas == null)
                {
                    return NotFound();
                }

                _context.Chunhas.Remove(chunhas);

                foreach (var hopdongs in chunhas.Hopdongs.ToList())
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
        [Route("AddChuNhaById")]
        public IActionResult AddChuNhaById([FromBody] ChuNhaDTO chunha)
        {
            try
            {
                try
                {
                    
                    _context.Chunhas.Add(_mapper.Map<Chunha>(chunha));
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
        [Route("UpdateChuNhaById")]
        public IActionResult UpdateChuNhaById([FromBody] ChuNhaDTO chunha)
        {
            try
            {
                try
                {
                    _context.Entry<Chunha>(_mapper.Map<Chunha>(chunha)).State = EntityState.Modified;
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
