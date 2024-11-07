namespace BulkyWeb.Data.Repository;

public interface IUnitOfWork
{
    public ICategoryRepository Category { get; }
    
    public void Save();
}