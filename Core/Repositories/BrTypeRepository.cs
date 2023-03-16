using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
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
            var dbBrType = await _db.BrType.Where(brType => brType.Id == Id).Select(brType => _mapper.Map<BrTypeViewModel>(brType)).FirstOrDefaultAsync();
            if (dbBrType == null)
                throw new Exception("BrType not found!");
            return dbBrType;
        }

        public async Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType)
        {
            var dbBrType = await _db.BrType.AddAsync(_mapper.Map<BrType>(brType));
            await _db.SaveChangesAsync();

            return _mapper.Map<BrTypeViewModel>(dbBrType.Entity);
        }

        public async Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType)
        {
            var dbBrType = await _db.BrType.FindAsync(brType.Id);
            if (dbBrType == null)
                throw new Exception("BrType not found!");

            dbBrType.ValueId = brType.ValueId;
            dbBrType.IsActive = brType.IsActive;

            await _db.SaveChangesAsync();
            return _mapper.Map<BrTypeViewModel>(dbBrType);
        }

        public async Task<List<BrTypeViewModel>?> DeleteBrType(int Id)
        {
            var dbBrType = await _db.BrType.FindAsync(Id);
            if (dbBrType == null)
                throw new Exception("BrType not found!");

            _db.BrType.Remove(dbBrType);
            await _db.SaveChangesAsync();

            return await GetBrType();
        }
    }
}
