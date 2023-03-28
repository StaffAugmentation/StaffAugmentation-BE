using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class BrSourceRepository : IBrSourceRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public BrSourceRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<BrSourceViewModel>?> GetBrSource()
    {
        return await _db.BrSource.Select(brSource => _mapper.Map<BrSourceViewModel>(brSource)).ToListAsync();

    }

    public async Task<BrSourceViewModel?> GetBrSource(string IdSource)
    {
        BrSourceViewModel dbBrSource = await _db.BrSource
                                        .Where(brSource => brSource.IdSource == IdSource)
                                        .Select(brSource => _mapper.Map<BrSourceViewModel>(brSource))
                                        .FirstOrDefaultAsync() ?? throw new Exception("BrSource not found!");
        return dbBrSource;
    }

    public async Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSourceVM)
    {
        BrSource? brSource = await _db.BrSource
            .Where(brSrc => brSrc.IdSource == brSourceVM.IdSource)
            .FirstOrDefaultAsync();
        if (brSource != null)
            throw new Exception("BrSource with this id already exists!");

        brSource = _mapper.Map<BrSource>(brSourceVM);
        await _db.BrSource.AddAsync(brSource);

        await _db.SaveChangesAsync();
        return _mapper.Map<BrSourceViewModel>(brSource);
    }

    public async Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSourceVM)
    {
        _ = await _db.BrSource.FindAsync(brSourceVM.IdSource) ?? throw new Exception("BrSource not found!");

        BrSource brSource = _mapper.Map<BrSource>(brSourceVM);
        _db.BrSource.Update(brSource);

        await _db.SaveChangesAsync();
        return _mapper.Map<BrSourceViewModel>(brSource);
    }

    public async Task<List<BrSourceViewModel>?> DeleteBrSource(string IdSource)
    {
        BrSource brSource = await _db.BrSource.FindAsync(IdSource) ?? throw new Exception("BrSource not found!");

        _db.BrSource.Remove(brSource);
        await _db.SaveChangesAsync();

        return await GetBrSource();
    }
}
