using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PTMOwnerRepository : IPTMOwnerRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public PTMOwnerRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<PTMOwnerViewModel>?> GetPTMOwner()
    {
        return await (from ptmOwner in _db.PTMOwner
                      join approver in _db.Approver on ptmOwner.IdApprover equals approver.Id into approver
                      from approvers in approver.DefaultIfEmpty()
                      select new PTMOwnerViewModel
                      {
                          Id = ptmOwner.Id,
                          ValueId = ptmOwner.ValueId,
                          BA = ptmOwner.BA,
                          BICSW = ptmOwner.BICSW,
                          VatRate = ptmOwner.VatRate,
                          IsEveris = ptmOwner.IsEveris,
                          VatNumber = ptmOwner.VatNumber,
                          Approver = _mapper.Map<ApproverViewModel>(approvers),
                      }).ToListAsync();
    }

    public async Task<PTMOwnerViewModel?> GetPTMOwner(int Id)
    {
        PTMOwnerViewModel PTMOwnerVM = await _db.PTMOwner
            .Where(PTMOwner => PTMOwner.Id == Id)
            .Select(PTMOwner => new PTMOwnerViewModel
                            {
                                Id = PTMOwner.Id, 
                                ValueId = PTMOwner.ValueId, 
                                BA = PTMOwner.BA,
                                BICSW = PTMOwner.BICSW,
                                VatRate = PTMOwner.VatRate,
                                IsEveris = PTMOwner.IsEveris,
                                VatNumber = PTMOwner.VatNumber,
                                Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(approver => approver.Id == PTMOwner.IdApprover).FirstOrDefault())
                            }
            ).FirstOrDefaultAsync() ?? throw new Exception("PTMOwner not found!");
        return PTMOwnerVM;
    }

    public async Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwnerVM)
    {
        PTMOwner ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
        ptmOwner.IdApprover = PTMOwnerVM.Approver?.Id;

        await _db.PTMOwner.AddAsync(ptmOwner);
        await _db.SaveChangesAsync();

        PTMOwnerVM = _mapper.Map<PTMOwnerViewModel>(ptmOwner);
        PTMOwnerVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(app => app.Id == ptmOwner.IdApprover).FirstOrDefaultAsync());

        return PTMOwnerVM;
    }

    public async Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwnerVM)
    {
        _ = await _db.PTMOwner.FindAsync(PTMOwnerVM.Id) ?? throw new Exception("PTMOwner not found!");

        PTMOwner ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
        ptmOwner.IdApprover = PTMOwnerVM.Approver?.Id;

        _db.PTMOwner.Update(ptmOwner);
        await _db.SaveChangesAsync();

        PTMOwnerVM = _mapper.Map<PTMOwnerViewModel>(ptmOwner);
        PTMOwnerVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(app => app.Id == ptmOwner.IdApprover).FirstOrDefaultAsync());

        return PTMOwnerVM;
    }

    public async Task<List<PTMOwnerViewModel>?> DeletePTMOwner(int Id)
    {
        PTMOwner ptmOwner = await _db.PTMOwner.FindAsync(Id) ?? throw new Exception("PTMOwner not found!");
        _db.PTMOwner.Remove(ptmOwner);
        await _db.SaveChangesAsync();

        return await GetPTMOwner();
    }

}
