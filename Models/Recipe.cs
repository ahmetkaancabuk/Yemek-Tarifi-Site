namespace Yemek_Tarifi_Site.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public string? RecipeName { get; set; }
        public string? RecipeExp { get; set; }
        public List<string>? RecipeMaterial { get; set; }
    }
}