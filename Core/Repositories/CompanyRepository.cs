using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories;

public class CompanyRepository : ICompanyRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public CompanyRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<CompanyViewModel>?> GetCompany()
    {
        return await (from company in _db.Company
                join approver in _db.Approver on company.IdApprover equals approver.Id into approver from approvers in approver.DefaultIfEmpty()
                where !company.IsDeleted
                select new CompanyViewModel
                {
                    IdCompany = company.IdCompany,
                    CompanyName = company.CompanyName,
                    Email = company.Email,
                    BankAccount = company.BankAccount,
                    BICSW = company.BICSW,
                    VatLegalEntity = company.VatLegalEntity,
                    VatRate = company.VatRate,
                    IsEveris = company.IsEveris,
                    Approver = _mapper.Map<ApproverViewModel>(approvers)
                 }).ToListAsync();
    }

    public async Task<CompanyViewModel?> GetCompany(int companyId)
    {
        CompanyViewModel Company = await 
            (from company in _db.Company
             where company.IdCompany == companyId && !company.IsDeleted
             select new CompanyViewModel
             {
                 IdCompany = company.IdCompany,
                 CompanyName = company.CompanyName,
                 BankAccount = company.BankAccount,
                 BICSW = company.BICSW,
                 Email = company.Email,
                 IsEveris = company.IsEveris,
                 VatLegalEntity = company.VatLegalEntity,
                 VatRate = company.VatRate,
                 Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(approver => approver.Id == company.IdApprover).FirstOrDefault())
            }).FirstOrDefaultAsync() ?? throw new Exception("Company not found!");
        return Company;
    }

    public async Task<CompanyViewModel?> CreateCompany(CompanyViewModel companyVM) 
    {
        Company company = _mapper.Map<Company>(companyVM);
        company.IdApprover = companyVM.Approver?.Id;

        await _db.Company.AddAsync(company);
        await _db.SaveChangesAsync();

        companyVM = _mapper.Map<CompanyViewModel>(company);
        companyVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(approver => approver.Id == company.IdApprover).FirstOrDefaultAsync());
        return companyVM;
    }

    public async Task<CompanyViewModel?> UpdateCompany(CompanyViewModel companyVM)
    {
        Company company = await _db.Company.FindAsync(companyVM.IdCompany) ?? throw new Exception("Company not found!");
        if (company.IsDeleted)
            throw new Exception("Company deleted!");

        company = _mapper.Map<Company>(companyVM);
        company.IdApprover = companyVM.Approver?.Id;

        await _db.SaveChangesAsync();

        companyVM = _mapper.Map<CompanyViewModel>(company);
        companyVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(approver => approver.Id == company.IdApprover).FirstOrDefaultAsync());
        return companyVM;
    }

    public async Task<List<CompanyViewModel>?> DeleteCompany(int CompanyId)
    {
        Company company = await _db.Company.FindAsync(CompanyId) ?? throw new Exception("Company not found!");
        
        company.IsDeleted = true;
        await _db.SaveChangesAsync();

        return await GetCompany();
    }
}
