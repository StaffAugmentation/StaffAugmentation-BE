using Core.ViewModel;

namespace Business.IServices
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentViewModel>?> GetDepartment();
        Task<DepartmentViewModel?> GetDepartment(int Id);
        Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department);
        Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department);
        Task<IEnumerable<DepartmentViewModel>?> DeleteDepartment(int Id);
    }
}
