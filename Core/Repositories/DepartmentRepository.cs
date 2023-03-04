using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public DepartmentRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<DepartmentViewModel>?> GetDepartment()
        {
            return await _db.Department.Select(department => _mapper.Map<DepartmentViewModel>(department)).ToListAsync();
        }

        public async Task<DepartmentViewModel?> GetDepartment(int Id)
        {
            var dbDepartment = await _db.Department.Where(department => department.Id == Id).Select(department => _mapper.Map<DepartmentViewModel>(department)).FirstOrDefaultAsync();
            if (dbDepartment == null)
                throw new Exception("Department not found!");
            return dbDepartment;
        }

        public async Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel department)
        {
            var dbDepartment = await _db.Department.AddAsync(_mapper.Map<Department>(department));
            await _db.SaveChangesAsync();

            return _mapper.Map<DepartmentViewModel>(dbDepartment.Entity);
        }

        public async Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel department)
        {
            var dbDepartment = await _db.Department.FindAsync(department.Id);
            if (dbDepartment == null)
                throw new Exception("Department not found!");

            dbDepartment.ValueId = department.ValueId;
            dbDepartment.IsActive = department.IsActive;

            await _db.SaveChangesAsync();
            return _mapper.Map<DepartmentViewModel>(dbDepartment);
        }

        public async Task<List<DepartmentViewModel>?> DeleteDepartment(int Id)
        {
            var dbDepartment = await _db.Department.FindAsync(Id);
            if (dbDepartment == null)
                throw new Exception("Department not found!");

            await _db.SaveChangesAsync();

            return await GetDepartment();
        }

    }
}
