using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class DepartmentRepository : GenericRepository<DepartmentViewModel, Level, int>, IDepartmentRepository
{
    public DepartmentRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
