using AutoMapper;
using Core.Data;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Core.Repositories;

public class GenericRepository<V, M, K> : IGenericRepository<V, M, K>
    where V : class
    where M : class
{
    protected DataContext _context;
    protected IMapper _mapper;

    public GenericRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public virtual async Task<IEnumerable<V>> GetAll(Expression<Func<M, bool>>? criteria = null, string? orderDirection = null, Expression<Func<M, object>>? order = null)
    {
        IQueryable<M> query = _context.Set<M>();

        if (criteria != null)
            query = query.Where(criteria);

        if (orderDirection != null && order != null)
        {
            if (orderDirection == "ASC")
                query = query.OrderBy(order);
            else
                query = query.OrderByDescending(order);
        }

        return await query
            .Select(entity => _mapper.Map<V>(entity))
            .ToListAsync();
    }

    public virtual async Task<V> Find(Expression<Func<M, bool>> criteria)
    {
        return await _context.Set<M>()
            .Where(criteria)
            .Select(entity => _mapper.Map<V>(entity))
            .FirstOrDefaultAsync() ?? throw new Exception(typeof(M).Name + " not found!");
    }

    public virtual async Task<V> Create(V entityVM)
    {
        M entity = _mapper.Map<M>(entityVM);

        await _context.Set<M>().AddAsync(_mapper.Map<M>(entity));
        await _context.SaveChangesAsync();

        return _mapper.Map<V>(entity);
    }

    public virtual async Task<V> Update(K key, V entityVM)
    {
        M entity = await _context.Set<M>().FindAsync(key) ?? throw new Exception(typeof(M).Name + " not found!");

        if (entity != null)
        {
            entity = _mapper.Map<M>(entityVM);
            await _context.SaveChangesAsync();
        }

        return _mapper.Map<V>(entity);
    }

    public async Task<IEnumerable<V>> Delete(K id)
    {
        M entity = await _context.Set<M>().FindAsync(id) ?? throw new Exception(typeof(M).Name + " not found!");

        _context.Set<M>().Remove(entity);
        await _context.SaveChangesAsync();

        return await GetAll();
    }

    public async Task<IEnumerable<V>> Delete(Expression<Func<M, bool>> criteria, Expression<Func<SetPropertyCalls<M>, SetPropertyCalls<M>>> deleteCriteria)
    {
        _ = await _context.Set<M>().Where(criteria).FirstOrDefaultAsync() ?? throw new Exception(typeof(M).Name + " not found!");

        await _context.Set<M>().Where(criteria).ExecuteUpdateAsync(deleteCriteria);
        await _context.SaveChangesAsync();

        return await GetAll();
    }

}
