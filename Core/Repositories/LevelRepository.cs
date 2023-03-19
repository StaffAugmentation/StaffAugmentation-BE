using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
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
            var dbLevel = await _db.Level.Where(level => level.Id == Id).Select(level => _mapper.Map<LevelViewModel>(level)).FirstOrDefaultAsync();
            if (dbLevel == null)
                throw new Exception("Level not found!");
            return dbLevel;
        }

        public async Task<LevelViewModel?> CreateLevel(LevelViewModel level)
        {
            var dbLevel = await _db.Level.AddAsync(_mapper.Map<Level>(level));
            await _db.SaveChangesAsync();

            return _mapper.Map<LevelViewModel>(dbLevel.Entity);
        }

        public async Task<LevelViewModel?> UpdateLevel(LevelViewModel level)
        {
            var dbLevel = await _db.Level.FindAsync(level.Id);
            if (dbLevel == null)
                throw new Exception("Level not found!");

            dbLevel.ValueId = level.ValueId;
            dbLevel.IsActive = level.IsActive;
            
            await _db.SaveChangesAsync();
            return _mapper.Map<LevelViewModel>(dbLevel);
        }

        public async Task<List<LevelViewModel>?> DeleteLevel(int Id)
        {
            var dbLevel = await _db.Level.FindAsync(Id);
            if (dbLevel == null)
                throw new Exception("Level not found!");

            _db.Level.Remove(dbLevel);
            await _db.SaveChangesAsync();

            return await GetLevel();
        }

    }
}
