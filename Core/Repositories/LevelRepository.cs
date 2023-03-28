using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class LevelRepository : ILevelRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public LevelRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<LevelViewModel>?> GetLevel()
    {
        return await _db.Level.Select(level => _mapper.Map<LevelViewModel>(level)).ToListAsync();
    }

    public async Task<LevelViewModel?> GetLevel(int Id)
    {
        LevelViewModel levelVM = await _db.Level
                                    .Where(level => level.Id == Id)
                                    .Select(level => _mapper.Map<LevelViewModel>(level))
                                    .FirstOrDefaultAsync()?? throw new Exception("Level not found!");
        return levelVM;
    }

    public async Task<LevelViewModel?> CreateLevel(LevelViewModel levelVM)
    {
        Level level = _mapper.Map<Level>(levelVM);

        await _db.Level.AddAsync(level);
        await _db.SaveChangesAsync();

        return _mapper.Map<LevelViewModel>(level);
    }

    public async Task<LevelViewModel?> UpdateLevel(LevelViewModel levelVM)
    {
        Level level = await _db.Level.FindAsync(levelVM.Id) ?? throw new Exception("Level not found!");

        level.ValueId = levelVM.ValueId;
        level.IsActive = levelVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<LevelViewModel>(level);
    }

    public async Task<List<LevelViewModel>?> DeleteLevel(int Id)
    {
        Level level = await _db.Level.FindAsync(Id) ?? throw new Exception("Level not found!");

        _db.Level.Remove(level);
        await _db.SaveChangesAsync();

        return await GetLevel();
    }

}
