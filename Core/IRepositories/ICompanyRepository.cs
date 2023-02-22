using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ICompanyRepository
    {
        Task<List<CompanyViewModel>?> GetCompany();
        Task<CompanyViewModel?> CreateCompany(CompanyViewModel company);
        Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company);
        Task<List<CompanyViewModel>?> DeleteCompany(int CompanyId);
    }
}
