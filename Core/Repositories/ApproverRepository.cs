using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class ApproverRepository : IApproverRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public ApproverRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<ApproverViewModel>?> GetApprover()
    {
        return await _db.Approver.Select(approver => _mapper.Map<ApproverViewModel>(approver)).ToListAsync();
    }

    public async Task<ApproverViewModel?> GetApprover(int Id)
    {
        ApproverViewModel dbApprover = await _db.Approver
                                        .Where(approver => approver.Id == Id)
                                        .Select(approver => _mapper.Map<ApproverViewModel>(approver))
                                        .FirstOrDefaultAsync() ?? throw new Exception("Approver not found!");
        return dbApprover ;
    }

    public async Task<ApproverViewModel?> CreateApprover(ApproverViewModel approverVM)
    {
        Approver approver = _mapper.Map<Approver>(approverVM);

        approver = (await _db.Approver.AddAsync(approver)).Entity;
        await _db.SaveChangesAsync();

        return _mapper.Map<ApproverViewModel>(approver);
    }

    public async Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approverVM)
    {
        Approver approver = await _db.Approver.FindAsync(approverVM.Id) ?? throw new Exception("Approver not found!");

        approver.AppFirstName = approverVM.AppFirstName;
        approver.AppLastName = approverVM.AppLastName;

        await _db.SaveChangesAsync();

        return _mapper.Map<ApproverViewModel>(approver);
    }

    public async Task<List<ApproverViewModel>?> DeleteApprover(int Id)
    {
        Approver approver = await _db.Approver.FindAsync(Id) ?? throw new Exception("Approver not found!");
        
        _db.Approver.Remove(approver);
        await _db.SaveChangesAsync();

        return await GetApprover();
    }
}
