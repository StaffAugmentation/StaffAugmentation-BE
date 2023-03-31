using Core.ViewModel;

namespace Business.IServices;

public interface ICompanyService
{
    Task<IEnumerable<CompanyViewModel>?> GetCompany();
    Task<CompanyViewModel?> GetCompany(int companyId);
    Task<CompanyViewModel?> CreateCompany(CompanyViewModel company);
    Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company);
    Task<IEnumerable<CompanyViewModel>?> DeleteCompany(int CompanyId);
}
