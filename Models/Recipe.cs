using System.ComponentModel.DataAnnotations;

namespace Yemek_Tarifi_Site.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }
        [Required(ErrorMessage = "Recipe has to have a name!")]
        public string? RecipeName { get; set; }
        [Required(ErrorMessage = "Recipe has to have a explanation!")]
        public string? RecipeExp { get; set; }
        [Required(ErrorMessage = "Recipe has to have materials!")]
        public List<string>? RecipeMaterial { get; set; }
        [Required(ErrorMessage = "It should be known how many people the recipe is for!")]
        public string? RecipeHowPerson { get; set; }
        [Required(ErrorMessage = "It should be known how much time it takes the recipe is for!")]
        public string? RecipePrepTime { get; set; }
    }
}