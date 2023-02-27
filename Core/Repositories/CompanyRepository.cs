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
            return await _db.Company.Where(company => !company.IsDeleted).Select(company => _mapper.Map<CompanyViewModel>(company)).ToListAsync();
        }
        
        public async Task<CompanyViewModel?> GetCompany(int companyId)
        {
            var dbCompany = await _db.Company.Where(company => company.IdCompany == companyId && !company.IsDeleted).Select(company => _mapper.Map<CompanyViewModel>(company)).FirstOrDefaultAsync();
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
