namespace BulkyWeb.Data.Repository;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category category);
    void Save();
    
}