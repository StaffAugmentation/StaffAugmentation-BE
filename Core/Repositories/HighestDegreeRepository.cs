using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

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
        HighestDegreeViewModel highestDegreeVM = await _db.HighestDegree
            .Where(HighestDegree => HighestDegree.Id == Id)
            .Select(HighestDegree => _mapper.Map<HighestDegreeViewModel>(HighestDegree))
            .FirstOrDefaultAsync() ?? throw new Exception("HighestDegree not found!");
        return highestDegreeVM;
    }

    public async Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel highestDegreeVM)
    {
        HighestDegree highestDegree = _mapper.Map<HighestDegree>(highestDegreeVM);

        highestDegree = (await _db.HighestDegree.AddAsync(highestDegree)).Entity;
        await _db.SaveChangesAsync();

        return _mapper.Map<HighestDegreeViewModel>(highestDegree);
    }

    public async Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel highestDegreeVM)
    {
        HighestDegree highestDegree = await _db.HighestDegree.FindAsync(highestDegreeVM.Id) ?? throw new Exception("HighestDegree not found!");

        highestDegree.Value = highestDegreeVM.Value;
        highestDegree.IsActive = highestDegreeVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<HighestDegreeViewModel>(highestDegree);
    }

    public async Task<List<HighestDegreeViewModel>?> DeleteHighestDegree(int Id)
    {
        HighestDegree highestDegree = await _db.HighestDegree.FindAsync(Id) ?? throw new Exception("HighestDegree not found!");

        _db.HighestDegree.Remove(highestDegree);
        await _db.SaveChangesAsync();

        return await GetHighestDegree();
    }
}
