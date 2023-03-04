using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
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
