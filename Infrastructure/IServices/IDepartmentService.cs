using Core.ViewModel;

namespace Business.IServices
{
    public interface IDepartmentService
    {
        Task<List<DepartmentViewModel>?> GetDepartment();
        Task<DepartmentViewModel?> GetDepartment(int Id);
        Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department);
        Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department);
        Task<List<DepartmentViewModel>?> DeleteDepartment(int Id);
    }
}
