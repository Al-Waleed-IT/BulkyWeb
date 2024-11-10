namespace BulkyWeb.Data.Repository;

public interface IUnitOfWork
{
    public ICategoryRepository Category { get; }
    public IProductRepository Product { get; }
    public void Save();
}