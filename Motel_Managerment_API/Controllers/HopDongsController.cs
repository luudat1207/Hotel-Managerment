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
    public class HopDongsController : ControllerBase
    {
        private DBNhaTroContext _context;
        private IMapper _mapper;

        public HopDongsController(DBNhaTroContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllHopDongByHopDongKetThuc/{checkBoxHopDongKetThuc}")]
        public IActionResult GetAllHopDongByHopDongKetThuc(bool checkBoxHopDongKetThuc)
        {
            List<Hopdong> hopdongs = new List<Hopdong>();
            if (checkBoxHopDongKetThuc == true)
            {
                 hopdongs = _context.Hopdongs
                    .Include(x => x.CccdNavigation)
                    .Include(x => x.IdcnNavigation)
                    .Include(x => x.MaPhongNavigation)
                    .Where(x => x.DaKetThuc == true)
                    .OrderBy(x => x.SoHopDong).ToList();
            }
            else
            {
                 hopdongs = _context.Hopdongs
                    .Include(x => x.CccdNavigation)
                    .Include(x => x.IdcnNavigation)
                    .Include(x => x.MaPhongNavigation)
                    .Where(x => x.DaKetThuc == false)
                    .OrderBy(x => x.SoHopDong).ToList();
            }
            return Ok(_mapper.Map<List<HopDongDTO>>(hopdongs));
        }

        [HttpGet]
        [Route("GetAllHopDongByInfor/{checkBoxHopDongKetThuc}/{information}")]
        public IActionResult GetAllHopDongByInfor(bool checkBoxHopDongKetThuc, string information)
        {
            List<Hopdong> hopdongs = new List<Hopdong>();
            if (checkBoxHopDongKetThuc == true)
            {
                hopdongs = _context.Hopdongs
                   .Include(x => x.CccdNavigation)
                   .Include(x => x.IdcnNavigation)
                   .Include(x => x.MaPhongNavigation)
                   .Where(x => x.DaKetThuc == true && x.SoHopDong.Contains(information))
                   .OrderBy(x => x.SoHopDong).ToList();
            }
            else
            {
                hopdongs = _context.Hopdongs
                   .Include(x => x.CccdNavigation)
                   .Include(x => x.IdcnNavigation)
                   .Include(x => x.MaPhongNavigation)
                   .Where(x => x.DaKetThuc == false && x.SoHopDong.Contains(information))
                   .OrderBy(x => x.SoHopDong).ToList();
            }
            return Ok(_mapper.Map<List<HopDongDTO>>(hopdongs));
        }
       
        [HttpGet]
        [Route("GetChuNhaByHoTen/{hoten}")]
        public IActionResult GetChuNhaByHoTen(string? hoten)
        {
            List<Chunha> chunhas = new List<Chunha>();

             chunhas = _context.Chunhas.Where(x => x.HoTen.Contains(hoten)).ToList();

            return Ok(_mapper.Map<List<ChuNhaxHopDongDTO>>(chunhas));
        } 

        [HttpGet]
        [Route("GetKhachThueByHoTen/{hoten}")]
        public IActionResult GetKhachThueByHoTen(string? hoten)
        {
            List<Khachthue> khachthues = new List<Khachthue>();

            khachthues = _context.Khachthues.Where(x => x.HoTen.Contains(hoten)).ToList();

            return Ok(_mapper.Map<List<KhachThuexHopDongDTO>>(khachthues));
        } 

        [HttpGet]
        [Route("GetPhongTroByMaPhong/{maphong}")]
        public IActionResult GetPhongTroByMaPhong(string? maphong)
        {
            List<Phongtro> phongtros = new List<Phongtro>();

            phongtros = _context.Phongtros.Where(x => x.MaPhong.Contains(maphong)).ToList();

            return Ok(_mapper.Map<List<PhongTroxHopDongDTO>>(phongtros));
        }

        [HttpGet]
        [Route("GetChuNha")]
        public IActionResult GetChuNha()
        {
            List<Chunha> chunhas = new List<Chunha>();

            chunhas = _context.Chunhas.ToList();

            return Ok(_mapper.Map<List<ChuNhaxHopDongDTO>>(chunhas));
        }

        [HttpGet]
        [Route("GetKhachThue")]
        public IActionResult GetKhachThue()
        {
            List<Khachthue> khachthues = new List<Khachthue>();

            khachthues = _context.Khachthues.ToList();

            return Ok(_mapper.Map<List<KhachThuexHopDongDTO>>(khachthues));
        }

        [HttpGet]
        [Route("GetPhongTro")]
        public IActionResult GetPhongTro()
        {
            List<Phongtro> phongtros = new List<Phongtro>();

            phongtros = _context.Phongtros.ToList();

            return Ok(_mapper.Map<List<PhongTroxHopDongDTO>>(phongtros));
        }

        [HttpDelete]
        [Route("DeleteHopDongById/{id}")]
        public IActionResult DeleteHopDongById(string id)
        {
            try
            {
                Hopdong hopdong = _context.Hopdongs.Where(x => x.SoHopDong.Equals(id)).SingleOrDefault();
                if (hopdong == null)
                {
                    return NotFound();
                }
                _context.Hopdongs.Remove(hopdong);
                _context.SaveChanges();

                return Ok("delete success");
            }
            catch (Exception e)
            {
                return Conflict("There was an unknown error when performing data deletion.");
            }
        }

        [HttpPost]
        [Route("AddHopDong")]
        public IActionResult AddHopDong([FromBody] HopDongDTO hopdong)
        {
            try
            {
                try
                {

                    _context.Hopdongs.Add(_mapper.Map<Hopdong>(hopdong));
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
        [Route("UpdateHopDongById")]
        public IActionResult UpdateHopDongById([FromBody] HopDongDTO hopdong)
        {
            try
            {
                try
                {
                    _context.Entry<Hopdong>(_mapper.Map<Hopdong>(hopdong)).State = EntityState.Modified;
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
        [HttpGet]
        [Route("KetThucHopDongById/{id}")]
        public IActionResult KetThucHopDongById( string id)
        {
            try
            {
                try
                {
                    Hopdong hopdong = _context.Hopdongs.Where(x => x.SoHopDong.Equals(id)).SingleOrDefault();
                    if (hopdong == null)
                    {
                        return NotFound();
                    }
                    hopdong.NgayTra = DateTime.Now;
                    hopdong.DaKetThuc = true;
                    _context.Entry<Hopdong>(_mapper.Map<Hopdong>(hopdong)).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
                return Ok("kết thúc hợp đồng success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
