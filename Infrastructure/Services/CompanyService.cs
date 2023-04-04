using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;
using System.Linq.Expressions;

namespace Business.Services;

public class CompanyService : ICompanyService
{
    private readonly IUnitOfWork _unitOfWork;

    public CompanyService(IUnitOfWork unitOfWork) 
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<CompanyViewModel>?> GetCompany()
    {
        return await _unitOfWork.Company.GetAll(new List<Expression<Func<Company, object>>> { company => company.Approver }, company => !company.IsDeleted);
    }

    public async Task<CompanyViewModel?> GetCompany(int companyId)
    {
        return await _unitOfWork.Company.Find(company => company.Id == companyId && !company.IsDeleted, new List<Expression<Func<Company, object>>> { company => company.Approver } );
    }

    public async Task<CompanyViewModel?> CreateCompany(CompanyViewModel company)
    {
        return await _unitOfWork.Company.Create(company);
    }

    public async Task<CompanyViewModel?> UpdateCompany(CompanyViewModel company)
    {
        return await _unitOfWork.Company.Update(company.Id, company);
    }

    public async Task<IEnumerable<CompanyViewModel>?> DeleteCompany(int CompanyId)
    {
        return await _unitOfWork.Company.Delete(entity => entity.Id == CompanyId && !entity.IsDeleted, s => s.SetProperty(x => x.IsDeleted, true));
    }

}
