using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Initial seed data
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
            new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 }
        );

        // List of real movie categories
        var genres = new List<string>
        {
            "Action", "Adventure", "Animation", "Biography", "Comedy", "Crime", "Documentary", 
            "Drama", "Family", "Fantasy", "Film Noir", "History", "Horror", "Musical", 
            "Mystery", "Romance", "SciFi", "Short", "Sport", "Superhero", "Thriller", "War", 
            "Western"
        };

        // Generate 100 unique category entries, cycling through genres if needed
        var categories = new List<Category>();
        for (int i = 3; i <= 102; i++) // Start from 3 to avoid ID conflict
        {
            categories.Add(new Category
            {
                Id = i,
                Name = genres[(i - 3) % genres.Count], // Use modulo to cycle through genres
                DisplayOrder = i
            });
        }

        modelBuilder.Entity<Category>().HasData(categories.ToArray());

        base.OnModelCreating(modelBuilder);
    }


}