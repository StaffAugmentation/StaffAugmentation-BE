using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Core.Repositories;

public class CompanyRepository : GenericRepository<CompanyViewModel, Company, int>, ICompanyRepository
{
    public CompanyRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {}

    public override async Task<IEnumerable<CompanyViewModel>> GetAll(Expression<Func<Company, bool>>? criteria = null, string? orderDirection = null, Expression<Func<Company, object>>? order = null)
    {
        return await (from company in _context.Company
                      join approver in _context.Approver on company.IdApprover equals approver.Id into approver
                      from approvers in approver.DefaultIfEmpty()
                      where !company.IsDeleted
                      select new CompanyViewModel
                      {
                          Id = company.Id,
                          Name = company.Name,
                          Email = company.Email,
                          BankAccount = company.BankAccount,
                          BICSW = company.BICSW,
                          VatLegalEntity = company.VatLegalEntity,
                          VatRate = company.VatRate,
                          IsEveris = company.IsEveris,
                          Approver = _mapper.Map<ApproverViewModel>(approvers)
                      }).ToListAsync();
    }

    public override async Task<CompanyViewModel> Find(Expression<Func<Company, bool>> criteria)
    {
        Company entity = await _context.Company.Where(criteria).FirstOrDefaultAsync() ?? throw new Exception();

        if (entity.IsDeleted)
            throw new Exception("Company deleted !");

        CompanyViewModel companyVM = _mapper.Map<CompanyViewModel>(entity);
        companyVM.Approver = _mapper.Map<ApproverViewModel>(
                                await _context.Approver
                                .Where(approver => approver.Id == entity.IdApprover)
                                .FirstOrDefaultAsync());
        return companyVM;
    }

    public override async Task<CompanyViewModel> Create(CompanyViewModel entityVM)
    {
        Company entity = _mapper.Map<Company>(entityVM);
        entity.IdApprover = entityVM.Approver?.Id;

        await _context.Company.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<CompanyViewModel>(entity);
    }

    public override async Task<CompanyViewModel> Update(int key, CompanyViewModel entityVM)
    {
        Company entity = await _context.Company.FindAsync(key) ?? throw new Exception();

        if (entity != null)
        {
            entity = _mapper.Map<Company>(entityVM);
            entity.IdApprover = entityVM.Approver?.Id;
            await _context.SaveChangesAsync();
        }

        return _mapper.Map<CompanyViewModel>(entity);
    }
}
