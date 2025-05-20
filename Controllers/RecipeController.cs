using Microsoft.AspNetCore.Mvc;
using Yemek_Tarifi_Site.Models;             //Model ve Context için gerekli namespace

namespace Yemek_Tarifi_Site.Controllers         //Controllerın nereye ait olduğunu belirlemek için
{
    [Route("api/[controller]")]             //Alttaki sınıfın API controller olduğunu belirtir.
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly RecipeContext _context;            //RecipeContext nesnesi

        public RecipeController(RecipeContext context)
        {
            _context = context;                             //Constructor metot ile context buraya getiriliyor.
        }

        [HttpGet]
        public IActionResult GetRecipe()
        {
            var recipe = _context.RecipeList.ToList();          //Veritabanındaki her tarifi tablodan çeker.
            return Ok(recipe);
        }

        [HttpPost]
        public IActionResult PostRecipe([FromBody] Recipe recipe)
        {
            _context.RecipeList.Add(recipe);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetRecipe), new { id = recipe.RecipeId }, recipe);                    //FromBody Json olarak alınan veriyi Recipe türüne dönüştürülür.
        }
    }
}