using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository repo;
        public CompanyService(ICompanyRepository companyRepository) 
        {
            repo = companyRepository;
        }

        public async Task<List<CompanyViewModel>?> GetCompany()
        {
            return await repo.GetCompany();
        }

        public async Task<CompanyViewModel?> CreateCompany(CompanyViewModel company)
        {
            return await repo.CreateCompany(company);
        }

        public async Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company)
        {
            return await repo.UpdateCompany(company);
        }

        public async Task<List<CompanyViewModel>?> DeleteCompany(int CompanyId)
        {
            return await repo.DeleteCompany(CompanyId);
        }
    }
}
