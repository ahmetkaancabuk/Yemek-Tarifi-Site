using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Yemek_Tarifi_Site.Models;
using Yemek_Tarifi_Site;
using Yemek_Tarifi_Site.DTOs;

namespace Yemek_Tarifi_Site.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public AuController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto model)
        {
            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FullName = model.FullName
            };
            var result = await _userManager.CreateAsync(user, model.Passaword);

            if (result.Succeeded)
            {
                return Ok("Kayit başarili");
            }
            return BadRequest(result.Errors);
        }
    }
}