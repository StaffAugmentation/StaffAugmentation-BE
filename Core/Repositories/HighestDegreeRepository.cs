using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
    public class HighestDegreeRepository : IHighestDegreeRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public HighestDegreeRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<HighestDegreeViewModel>?> GetHighestDegree()
        {
            return await _db.HighestDegree.Select(HighestDegree => _mapper.Map<HighestDegreeViewModel>(HighestDegree)).ToListAsync();
        }

        public async Task<HighestDegreeViewModel?> GetHighestDegree(int Id)
        {
            var dbHighestDegree = await _db.HighestDegree.Where(HighestDegree => HighestDegree.Id == Id).Select(HighestDegree => _mapper.Map<HighestDegreeViewModel>(HighestDegree)).FirstOrDefaultAsync();
            if (dbHighestDegree == null)
                throw new Exception("HighestDegree not found!");
            return dbHighestDegree;
        }

        public async Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            var dbHighestDegree = await _db.HighestDegree.AddAsync(_mapper.Map<HighestDegree>(HighestDegree));
            await _db.SaveChangesAsync();

            return _mapper.Map<HighestDegreeViewModel>(dbHighestDegree.Entity);
        }

        public async Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            var dbHighestDegree = await _db.HighestDegree.FindAsync(HighestDegree.Id);
            if (dbHighestDegree == null)
                throw new Exception("HighestDegree not found!");

            dbHighestDegree.Value = HighestDegree.Value;

            await _db.SaveChangesAsync();
            return _mapper.Map<HighestDegreeViewModel>(dbHighestDegree);
        }

        public async Task<List<HighestDegreeViewModel>?> DeleteHighestDegree(int Id)
        {
            var dbHighestDegree = await _db.HighestDegree.FindAsync(Id);
            if (dbHighestDegree == null)
                throw new Exception("HighestDegree not found!");

            _db.HighestDegree.Remove(dbHighestDegree);
            await _db.SaveChangesAsync();

            return await GetHighestDegree();
        }

    }
}
