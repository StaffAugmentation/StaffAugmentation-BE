using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class PTMOwnerRepository : GenericRepository<PTMOwnerViewModel, PTMOwner, int>, IPTMOwnerRepository
{
    public PTMOwnerRepository(DataContext context, IMapper mapper) : base(context, mapper)
    { }

    public override async Task<IEnumerable<PTMOwnerViewModel>> GetAll(Expression<Func<PTMOwner, bool>>? criteria = null, string? orderDirection = null, Expression<Func<PTMOwner, object>>? order = null)
    {
        return await (from ptmOwner in _context.PTMOwner
                      join approver in _context.Approver on ptmOwner.IdApprover equals approver.Id into approver
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

    public override async Task<PTMOwnerViewModel> Find(Expression<Func<PTMOwner, bool>> criteria)
    {
        PTMOwnerViewModel PTMOwnerVM = await _context.PTMOwner
            .Where(criteria)
            .Select(PTMOwner => new PTMOwnerViewModel
            {
                Id = PTMOwner.Id,
                ValueId = PTMOwner.ValueId,
                BA = PTMOwner.BA,
                BICSW = PTMOwner.BICSW,
                VatRate = PTMOwner.VatRate,
                IsEveris = PTMOwner.IsEveris,
                VatNumber = PTMOwner.VatNumber,
                Approver = _context.Approver
                                            .Where(approver => approver.Id == PTMOwner.IdApprover)
                                            .Select(approver => _mapper.Map<ApproverViewModel>(approver))
                                            .FirstOrDefault()
            }).FirstOrDefaultAsync() ?? throw new Exception("PTMOwner not found!");
        return PTMOwnerVM;
    }

    public override async Task<PTMOwnerViewModel> Create(PTMOwnerViewModel PTMOwnerVM)
    {
        PTMOwner ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
        ptmOwner.IdApprover = PTMOwnerVM.Approver?.Id;

        await _context.PTMOwner.AddAsync(ptmOwner);
        await _context.SaveChangesAsync();

        return await Find(entity => entity.Id == ptmOwner.Id);
    }

    public override async Task<PTMOwnerViewModel> Update(int key, PTMOwnerViewModel PTMOwnerVM)
    {
        PTMOwner ptmOwner = await _context.PTMOwner.FindAsync(key) ?? throw new Exception("PTMOwner not found!");

        if (ptmOwner != null)
        {
            ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
            ptmOwner.IdApprover = PTMOwnerVM.Approver?.Id;
        }

        await _context.SaveChangesAsync();

        return await Find(entity => entity.Id == key);
    }
}
