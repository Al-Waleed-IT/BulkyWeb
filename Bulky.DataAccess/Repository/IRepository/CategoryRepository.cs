using Bulky.Models;

namespace BulkyWeb.Data.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly ApplicationDbContext _db;
    public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _db = dbContext;
    }

    public void Update(Category category)
    {
        _db.Categories.Update(category);
    }

    public void Save()
    {

        _db.SaveChanges();
    }
}