using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class OERPCodeRepository : IOERPCodeRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public OERPCodeRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<OERPCodeViewModel>?> GetOERPCode()
    {
        return await _db.OERPCode.Select(OERPCode => _mapper.Map<OERPCodeViewModel>(OERPCode)).ToListAsync();
    }

    public async Task<OERPCodeViewModel?> GetOERPCode(int Id)
    {
        OERPCodeViewModel OERPCodeVM = await _db.OERPCode
                                    .Where(OERPCode => OERPCode.Id == Id)
                                    .Select(OERPCode => _mapper.Map<OERPCodeViewModel>(OERPCode))
                                    .FirstOrDefaultAsync() ?? throw new Exception("OERPCode not found!");
        return OERPCodeVM;
    }

    public async Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCodeVM)
    {
        OERPCode OERPCode = _mapper.Map<OERPCode>(OERPCodeVM);

        await _db.OERPCode.AddAsync(OERPCode);
        await _db.SaveChangesAsync();

        return _mapper.Map<OERPCodeViewModel>(OERPCode);
    }

    public async Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCodeVM)
    {
        OERPCode OERPCode = await _db.OERPCode.FindAsync(OERPCodeVM.Id) ?? throw new Exception("OERPCode not found!");

        OERPCode.Value = OERPCodeVM.Value;
        OERPCode.IsActive = OERPCodeVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<OERPCodeViewModel>(OERPCode);
    }

    public async Task<List<OERPCodeViewModel>?> DeleteOERPCode(int Id)
    {
        OERPCode OERPCode = await _db.OERPCode.FindAsync(Id) ?? throw new Exception("OERPCode not found!");

        _db.OERPCode.Remove(OERPCode);
        await _db.SaveChangesAsync();

        return await GetOERPCode();
    }

}
