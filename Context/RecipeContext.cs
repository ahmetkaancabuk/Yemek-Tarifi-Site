using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Yemek_Tarifi_Site.Models;


namespace Yemek_Tarifi_Site.Models
{
    // Kullanıcı modelini IdentityUser'dan türetiyoruz, ekstra alan ekleyebilirsin
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }

    // DbContext, IdentityDbContext'ten türetiliyor ve kullanıcı modeli ApplicationUser
    public class RecipeContext : IdentityDbContext<ApplicationUser>
    {
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
            
        }

        // Tariflerin olduğu tablo
        public DbSet<Recipe> RecipeList { get; set; }

        // Connection string ayarını Program.cs üzerinden yapacağından OnConfiguring kaldırıldı
    }
}
