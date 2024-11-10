using Bulky.Models;

namespace BulkyWeb.Data.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
        _db = dbContext;
    }

    public void Update(Product product)
    {
        _db.Products.Update(product);
    }

    public void Save()
    {

        _db.SaveChanges();
    }
}