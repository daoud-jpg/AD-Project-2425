using System.Linq.Expressions;

public interface IRepository<T>
{
    void Add(T entity);
    void Delete(T entity);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAllByCondition(Expression<Func<T, bool>> predicate);
    T GetByCondition(Expression<Func<T, bool>> predicate);
    T GetById(int id);
    bool SaveChanges();
    void Update(T entity);
}