using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository repo;
        public DepartmentService(IDepartmentRepository departmentrepository)
        {
            repo = departmentrepository;
        }

        public async Task<List<DepartmentViewModel>?> GetDepartment()
        {
            return await repo.GetDepartment();
        }

        public async Task<DepartmentViewModel?> GetDepartment(int Id)
        {
            return await repo.GetDepartment(Id);
        }

        public async Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department)
        {
            return await repo.CreateDepartment(department);
        }

        public async Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department)
        {
            return await repo.UpdateDepartment(department);
        }

        public async Task<List<DepartmentViewModel>?> DeleteDepartment(int Id)
        {
            return await repo.DeleteDepartment(Id);
        }

    }
}
