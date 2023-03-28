using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class BrTypeRepository : IBrTypeRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public BrTypeRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<BrTypeViewModel>?> GetBrType()
    {
        return await _db.BrType.Select(brType => _mapper.Map<BrTypeViewModel>(brType)).ToListAsync();

    }

    public async Task<BrTypeViewModel?> GetBrType(int Id)
    {
        BrTypeViewModel brTypeVM = await _db.BrType
                                            .Where(brType => brType.Id == Id)
                                            .Select(brType => _mapper.Map<BrTypeViewModel>(brType))
                                            .FirstOrDefaultAsync() ?? throw new Exception("BrType not found!");
        return brTypeVM;
    }

    public async Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brTypeVM)
    {
        BrType brType = _mapper.Map<BrType>(brTypeVM);

        await _db.BrType.AddAsync(brType);
        await _db.SaveChangesAsync();

        return _mapper.Map<BrTypeViewModel>(brType);
    }

    public async Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brTypeVM)
    {
        _ = await _db.BrType.FindAsync(brTypeVM.Id) ?? throw new Exception("BrType not found!");
        
        BrType brType = _mapper.Map<BrType>(brTypeVM);

        _db.BrType.Update(brType);
        await _db.SaveChangesAsync();

        return _mapper.Map<BrTypeViewModel>(brType);
    }

    public async Task<List<BrTypeViewModel>?> DeleteBrType(int Id)
    {
        BrType brType = await _db.BrType.FindAsync(Id) ?? throw new Exception("BrType not found!");
        
        _db.BrType.Remove(brType);
        await _db.SaveChangesAsync();

        return await GetBrType();
    }
}
