using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.IRepositories;

public interface IGenericRepository<V, M, K> 
    where V : class
{
    Task<IEnumerable<V>> GetAll(List<Expression<Func<M, object>>>? includes = null, Expression<Func<M, bool>>? criteria = null, string? orderByDirection = null, Expression<Func<M, object>>? orderBy = null);
    Task<V> Find(Expression<Func<M, bool>> criteria, List<Expression<Func<M, object>>>? includes = null);
    Task<V> Create(V entityVM);
    Task<V> Update(K key, V entityVM);
    Task<IEnumerable<V>> Delete(K id);
    Task<IEnumerable<V>> Delete(Expression<Func<M, bool>> criteria, Expression<Func<SetPropertyCalls<M>, SetPropertyCalls<M>>> deleteCriteria);
}
