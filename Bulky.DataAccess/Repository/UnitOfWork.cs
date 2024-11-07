namespace BulkyWeb.Data.Repository;

public class UnitOfWork : IUnitOfWork
{
    private ApplicationDbContext _db;
    public ICategoryRepository Category { get; }
    public UnitOfWork(ApplicationDbContext context)
    {
        _db = context;
        Category = new CategoryRepository(_db);
    }

    public void Save()
    {
        _db.SaveChanges();
    }
}