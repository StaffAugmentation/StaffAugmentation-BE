using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Type = Core.Model.Type;

namespace Core.Repositories;

public class TypeRepository : ITypeRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public TypeRepository(DataContext context, IMapper mapper) 
    {
        _db = context;
        _mapper = mapper;
    }

    public new async Task<List<TypeViewModel>?> GetType()
    {
        return await _db.Type.Select(type => _mapper.Map<TypeViewModel>(type)).ToListAsync();
    }

    public async Task<TypeViewModel?> GetType(int Id)
    {
        TypeViewModel typeVM = await _db.Type
            .Where(type => type.Id == Id)
            .Select(type => _mapper.Map<TypeViewModel>(type))
            .FirstOrDefaultAsync() ?? throw new Exception("Type not found!");
        return typeVM;
    }

    public async Task<TypeViewModel?> CreateType(TypeViewModel typeVM)
    {
        Type type = _mapper.Map<Type>(typeVM);

        await _db.Type.AddAsync(type);
        await _db.SaveChangesAsync();

        return _mapper.Map<TypeViewModel>(type);
    }

    public async Task<TypeViewModel?> UpdateType(TypeViewModel typeVM)
    {
        _ = await _db.Type.FindAsync(typeVM.Id) ?? throw new Exception("Type not found!");

        Type type = _mapper.Map<Type>(typeVM);

        _db.Type.Update(type);
        await _db.SaveChangesAsync();

        return _mapper.Map<TypeViewModel?>(type);
    }

    public async Task<List<TypeViewModel>?> DeleteType(int Id)
    {
        Type type = await _db.Type.FindAsync(Id) ?? throw new Exception("Type not found!");

        _db.Type.Remove(type);
        await _db.SaveChangesAsync();

        return await GetType();
    }
}
