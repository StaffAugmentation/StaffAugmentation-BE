using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;

namespace Core.Repositories;

public class TypeRepository : GenericRepository<TypeViewModel, Core.Model.Type, int>, ITypeRepository
{
    public TypeRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
