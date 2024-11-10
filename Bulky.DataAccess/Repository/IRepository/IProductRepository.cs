using Bulky.Models;

namespace BulkyWeb.Data.Repository;

public interface IProductRepository : IRepository<Category>
{
    void Update(Product category);
    void Save();
    
}