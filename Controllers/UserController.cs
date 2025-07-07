using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RTC.Data;
using RTC.RequestedModels;
using RTC.Models;
using RTC.Services;

namespace RTC.Controllers
{
    [Route("v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _db;

        public UserController(DataContext db)
        {
            _db = db;
        }

        [HttpGet("Get")]
        [Authorize]
        public async Task<ActionResult<List<User>>> Get()
        {
            var users = await _db.Users.AsNoTracking().ToListAsync();
            return users;
        }

        [HttpPost("Add")]
        // [Authorize]
        public async Task<ActionResult<User>> Post([FromBody] User model)
        {
    
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
  
                _db.Users.Add(model);
                await _db.SaveChangesAsync();
                // model.Password = "";
                return model;
            }
            catch
            {
                return BadRequest(new { message = "Something went wrong!" });
            }
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody] UserLogin model)
        {
            var user = await _db.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

            if (user == null)
                return NotFound(new { message = "User not found!" });

            var token = TokenService.GenerateToken(user);
            user.Password = "";

            return new { user, token };
        }

        [HttpPut("EditUser")]
        [Authorize]
        public async Task<ActionResult<User>> Put(int userId, [FromBody] User model)
        {
            // if (!ModelState.IsValid) return BadRequest(ModelState);
            // if (model.Id != userId) return NotFound(new { message = "User not found!" });

            // try
            // {
            //     _db.Users.Entry(model).State = EntityState.Modified;
            //     await _db.SaveChangesAsync();
            //     model.Password = "";
            //     return model;
            // }
            // catch
            // {
            //     return BadRequest(new { message = "Something went wrong!" });
            // }
          return BadRequest(new {message = "Something"});
        }

        [HttpDelete("Remove")]
        [Authorize]
        public async Task<ActionResult> Delete(int userId)
        {
          return BadRequest(new {message = "Something"});
            // var user = await _db.Users.FirstOrDefaultAsync(u => u.Id == userId);
            // if (user == null)
            // {
            //     return NotFound(new { message = "User not found!" });
            // }

            // try
            // {
            //     _db.Users.Remove(user);
            //     await _db.SaveChangesAsync();
            //     return Ok(new { message = "User removed!" });
            // }
            // catch
            // {
            //     return BadRequest(new { message = "Error while removing the user!" });
            // }
        }
    }
}
