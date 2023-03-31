using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<DepartmentViewModel>?> GetDepartment()
        {
            return await _unitOfWork.Department.GetAll();
        }

        public async Task<DepartmentViewModel?> GetDepartment(int Id)
        {
            return await _unitOfWork.Department.Find(entity => entity.Id == Id);
        }

        public async Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department)
        {
            return await _unitOfWork.Department.Create(department);
        }

        public async Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department)
        {
            return await _unitOfWork.Department.Update(department.Id, department);
        }

        public async Task<IEnumerable<DepartmentViewModel>?> DeleteDepartment(int Id)
        {
            return await _unitOfWork.Department.Delete(Id);
        }

    }
}
