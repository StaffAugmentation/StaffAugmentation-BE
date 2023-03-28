using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

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
        DepartmentViewModel DepartmentVM = await _db.Department
                            .Where(department => department.Id == Id)
                            .Select(department => _mapper.Map<DepartmentViewModel>(department))
                            .FirstOrDefaultAsync() ?? throw new Exception("Department not found!");
        return DepartmentVM;
    }

    public async Task<DepartmentViewModel?> CreateDepartment(DepartmentViewModel departmentVM)
    {
        Department department = _mapper.Map<Department>(departmentVM);

        await _db.Department.AddAsync(department);
        await _db.SaveChangesAsync();

        return _mapper.Map<DepartmentViewModel>(department);
    }

    public async Task<DepartmentViewModel?> UpdateDepartment(DepartmentViewModel departmentVM)
    {
        Department department = await _db.Department.FindAsync(departmentVM.Id) ?? throw new Exception("Department not found!");

        department.ValueId = departmentVM.ValueId;
        department.IsActive = departmentVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<DepartmentViewModel>(department);
    }

    public async Task<List<DepartmentViewModel>?> DeleteDepartment(int Id)
    {
        Department department = await _db.Department.FindAsync(Id) ?? throw new Exception("Department not found!");

        _db.Department.Remove(department);
        await _db.SaveChangesAsync();

        return await GetDepartment();
    }

}
