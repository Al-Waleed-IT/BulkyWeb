using Bulky.Models;

namespace BulkyWeb.Data.Repository;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product product);
    void Save();
    
}