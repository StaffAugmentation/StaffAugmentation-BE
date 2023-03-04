using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IDepartmentRepository
    {
        Task<List<DepartmentViewModel>?> GetDepartment();
        Task<DepartmentViewModel?> GetDepartment(int companyId);
        Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department);
        Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department);
        Task<List<DepartmentViewModel>?> DeleteDepartment(int Id);
    }
}
