using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class TypeOfCostRepository : GenericRepository<TypeOfCostViewModel, TypeOfCost, string>, ITypeOfCostRepository
{
    public TypeOfCostRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
