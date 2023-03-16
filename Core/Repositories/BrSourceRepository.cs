using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
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
            var dbBrSource = await _db.BrSource.Where(brSource => brSource.IdSource == IdSource).Select(brSource => _mapper.Map<BrSourceViewModel>(brSource)).FirstOrDefaultAsync();
            if (dbBrSource == null)
                throw new Exception("BrSource not found!");
            return dbBrSource;
        }

        public async Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource)
        {
            var dbBrSource = await _db.BrSource.AddAsync(_mapper.Map<BrSource>(brSource));
            await _db.SaveChangesAsync();

            return _mapper.Map<BrSourceViewModel>(dbBrSource.Entity);
        }

        public async Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource)
        {
            var dbBrSource = await _db.BrSource.FindAsync(brSource.IdSource);
            if (dbBrSource == null)
                throw new Exception("BrSource not found!");

            dbBrSource.IdSource = brSource.IdSource;
            dbBrSource.SourceName = brSource.SourceName;

            await _db.SaveChangesAsync();
            return _mapper.Map<BrSourceViewModel>(dbBrSource);
        }

        public async Task<List<BrSourceViewModel>?> DeleteBrSource(string IdSource)
        {
            var dbBrSource = await _db.BrSource.FindAsync(IdSource);
            if (dbBrSource == null)
                throw new Exception("BrSource not found!");

            _db.BrSource.Remove(dbBrSource);
            await _db.SaveChangesAsync();

            return await GetBrSource();
        }
    }
}
