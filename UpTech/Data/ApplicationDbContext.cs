using UpTech.Data.Entities;

namespace UpTech.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        
        public DbSet<CategoryItem> CategoryItems { get; set; }
        
        public DbSet<Content> Contents { get; set; }
        
        public DbSet<MediaType> MediaTypes { get; set; }
        
        public DbSet<UserCategory> UserCategories { get; set; }
    }
}