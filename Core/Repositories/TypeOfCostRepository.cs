using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class TypeOfCostRepository : ITypeOfCostRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public TypeOfCostRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<TypeOfCostViewModel>?> GetTypeOfCost()
    {
        return await _db.TypeOfCost.Select(typeOfCost => _mapper.Map<TypeOfCostViewModel>(typeOfCost)).ToListAsync();
    }
    
    public async Task<TypeOfCostViewModel?> GetTypeOfCost(string Id)
    {
        TypeOfCostViewModel dbTypeOfCost = await _db.TypeOfCost
                                            .Where(typeOfCost => typeOfCost.Id == Id)
                                            .Select(typeOfCost => _mapper.Map<TypeOfCostViewModel>(typeOfCost))
                                            .FirstOrDefaultAsync() ?? throw new Exception("TypeOfCost not found!");
        return dbTypeOfCost; 
    }

    public async Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCostVM) 
    {
        TypeOfCost typeOfCost = _mapper.Map<TypeOfCost>(typeOfCostVM);

        await _db.TypeOfCost.AddAsync(typeOfCost);
        await _db.SaveChangesAsync();

        return _mapper.Map<TypeOfCostViewModel>(typeOfCost);
    }

    public async Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCostVM)
    {
        TypeOfCost typeOfCost = await _db.TypeOfCost.FindAsync(typeOfCostVM.Id) ?? throw new Exception("TypeOfCost not found!");

        typeOfCost.Value = typeOfCostVM.Value;

        await _db.SaveChangesAsync();

        return _mapper.Map<TypeOfCostViewModel>(typeOfCost);
    }

    public async Task<List<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id)
    {
        TypeOfCost typeOfCost = await _db.TypeOfCost.FindAsync(Id) ?? throw new Exception("TypeOfCost not found!");
        
        _db.TypeOfCost.Remove(typeOfCost);
        await _db.SaveChangesAsync();

        return await GetTypeOfCost();
    }

}
