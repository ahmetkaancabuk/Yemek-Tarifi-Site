using Microsoft.EntityFrameworkCore;
using MySqlConnector;

namespace Yemek_Tarifi_Site.Models {
    public class RecipeContext : DbContext {
        public RecipeContext() { }
        public RecipeContext(DbContextOptions<RecipeContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=DbYemek;user=root;password=Metsy;", new MySqlServerVersion(new Version(8, 0, 42)));
        }
        public DbSet<Recipe> RecipeList { get; set; }
    }
}