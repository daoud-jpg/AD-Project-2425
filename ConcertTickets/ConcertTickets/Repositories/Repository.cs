using ConcertTickets.Repositories;
using ConcertTickets.Data;
using ConcertTickets.Data.Entities;
using System.Linq.Expressions;
public class Repository<T> : IRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext context;

    public Repository(ApplicationDbContext _context)
    {
        context = _context;
    }

    public void Add(T entity)
    {
        context.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        context.Set<T>().Remove(entity);
    }

    public T GetByCondition(Expression<Func<T, bool>> predicate)
    {
        return context.Set<T>().Where(predicate).SingleOrDefault();
    }

    public IEnumerable<T> GetAll()
    {
        return context.Set<T>().ToList();
    }

    public IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> predicate)
    {
        return context.Set<T>().Where(predicate).ToList();
    }

    public T GetById(int id)
    {
        return context.Set<T>().SingleOrDefault(x => x.Id == id);
    }

    public bool SaveChanges()
    {
        return context.SaveChanges() > 0;
    }

    public void Update(T entity)
    {
        context.Set<T>().Update(entity);
    }
}