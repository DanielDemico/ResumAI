using Microsoft.AspNetCore.Mvc;
using CurriculumEnhancer.Data;
using CurriculumEnhancer.Models;

namespace CurriculumEnhancer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _AppDbContext;
        public UsersController(AppDbContext appDbContext)
        {
            _AppDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(Users user)
        {
            _AppDbContext.Users.Add(user);
            await _AppDbContext.SaveChangesAsync();
            return Ok(user);
        }

    }
}