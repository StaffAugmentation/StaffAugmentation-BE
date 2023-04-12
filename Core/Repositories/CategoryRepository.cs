using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class CategoryRepository : GenericRepository<CategoryViewModel, Category, int>, ICategoryRepository
{
    public CategoryRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
