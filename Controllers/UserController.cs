using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Data;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    [ApiController]
    [Route("User")]
    public class UserController:ControllerBase
    {
        private readonly StoreContext context;

        public UserController(StoreContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Login(LoginRequest request)
        {
            var user = await context.Users.FirstOrDefaultAsync(x => x.Username == request.Email && x.Password == request.Password);

            if (user == null)
            {
                return BadRequest("No existe el usuario");
            }
            return Ok(user);
        }
    }
}
