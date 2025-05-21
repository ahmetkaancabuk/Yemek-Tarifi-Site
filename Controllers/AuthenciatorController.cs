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
    }
}