using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Motel_Managerment_API.Models;

namespace Motel_Managerment_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private DBNhaTroContext _context = new DBNhaTroContext();

        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            List<User> users = new List<User>();
            using (_context = new DBNhaTroContext())
            {
                users = _context.Users.ToList();
            }
            return Ok(users);
        }

        [HttpGet("getUsersByUserName")]
        public IActionResult getUsersByUserName(string? username)
        {
            try
            {
                if (username == null) return NoContent();
                User user = new User();
                 user = _context.Users.Where(x => x.Username.Equals(username)).SingleOrDefault();
                if (user == null) return NoContent();
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateUsers( User user)
        {
            try
            {
                _context.Entry<User>(user).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok("update success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateUsers(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return Ok("Create success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
