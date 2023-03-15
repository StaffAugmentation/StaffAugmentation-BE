using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories
{
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
            //return await _db.Company
            //    .Where(company => !company.IsDeleted)
            //    .OrderByDescending(cmp => cmp.IdCompany)
            //    .Select(company => _mapper.Map<CompanyViewModel>(company))
            //    .Select(cmp => new CompanyViewModel
            //    {
            //        IdCompany = cmp.IdCompany,
            //        CompanyName = cmp.CompanyName,
            //        CmpEmail = cmp.CmpEmail,
            //        BankAccount = cmp.BankAccount,
            //        CmpBicsw = cmp.CmpBicsw,
            //        CmpVatlegalEntity = cmp.CmpVatlegalEntity,
            //        CmpVatRate = cmp.CmpVatRate,
            //        IdApproverCmp = cmp.IdApproverCmp,
            //        IsEveris = cmp.IsEveris,
            //        ApproverName = cmp.IdApproverCmp != null ? _db.Approvers.Where(appr => appr.Id == cmp.IdApproverCmp).Select(appr =>  appr.AppFirstName + " " + appr.AppLastName).FirstOrDefault() : ""
            //    })
            //    .ToListAsync();

            return await (from company in _db.Company
                    join approver in _db.Approvers on company.IdApproverCmp equals approver.Id into approver from approvers in approver.DefaultIfEmpty()
                    where !company.IsDeleted
                    select new CompanyViewModel
                    {
                        IdCompany = company.IdCompany,
                        CompanyName = company.CompanyName,
                        CmpEmail = company.CmpEmail,
                        BankAccount = company.BankAccount,
                        CmpBicsw = company.CmpBicsw,
                        CmpVatlegalEntity = company.CmpVatlegalEntity,
                        CmpVatRate = company.CmpVatRate,
                        IdApproverCmp = company.IdApproverCmp,
                        IsEveris = company.IsEveris,
                        ApproverName = approvers!=null ? approvers.AppFirstName + " " + approvers.AppLastName : ""
                     }).ToListAsync();
        }

        public async Task<CompanyViewModel?> GetCompany(int companyId)
        {
            var dbCompany = await _db.Company
                .Where(company => company.IdCompany == companyId && !company.IsDeleted)
                .Select(company => _mapper.Map<CompanyViewModel>(company))
                .FirstOrDefaultAsync();
            if (dbCompany == null)
                throw new Exception("Company not found!");
            return dbCompany; 
        }

        public async Task<CompanyViewModel?> CreateCompany(CompanyViewModel company) 
        {
            var dbCompany = await _db.Company.AddAsync(_mapper.Map<Company>(company));
            await _db.SaveChangesAsync();

            return _mapper.Map<CompanyViewModel>(dbCompany.Entity);
        }

        public async Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company)
        {
            var dbCompany = await _db.Company.FindAsync(company.IdCompany);
            if (dbCompany == null)
                throw new Exception("Company not found!");
            if (dbCompany.IsDeleted)
                throw new Exception("Company deleted!");

            dbCompany.CompanyName = company.CompanyName;
            dbCompany.BankAccount = company.BankAccount;
            dbCompany.IsEveris = company.IsEveris;
            dbCompany.CmpVatlegalEntity = company.CmpVatlegalEntity;
            dbCompany.CmpBicsw = company.CmpBicsw;
            dbCompany.CmpVatRate = company.CmpVatRate;
            dbCompany.IdApproverCmp = company.IdApproverCmp;
            dbCompany.CmpEmail = company.CmpEmail;

            await _db.SaveChangesAsync();
            return _mapper.Map<CompanyViewModel>(dbCompany);
        }

        public async Task<List<CompanyViewModel>?> DeleteCompany(int CompanyId)
        {
            var dbCompany = await _db.Company.FindAsync(CompanyId);
            if (dbCompany == null)
                throw new Exception("Company not found!");

            dbCompany.IsDeleted = true;
            await _db.SaveChangesAsync();

            return await GetCompany();
        }

    }
}
