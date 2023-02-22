using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface ICompanyService
    {
        Task<List<CompanyViewModel>?> GetCompany();
        Task<CompanyViewModel?> CreateCompany(CompanyViewModel company);
        Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company);
        Task<List<CompanyViewModel>?> DeleteCompany(int CompanyId);
    }
}
