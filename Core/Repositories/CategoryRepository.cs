using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public CategoryRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<CategoryViewModel>?> GetCategory()
    {
        return await _db.Category.Select(category => _mapper.Map<CategoryViewModel>(category)).ToListAsync();
    }
    
    public async Task<CategoryViewModel?> GetCategory(int Id)
    {
        CategoryViewModel category = await _db.Category
                                                .Where(category => category.Id == Id)
                                                .Select(category => _mapper.Map<CategoryViewModel>(category))
                                                .FirstOrDefaultAsync() ?? throw new Exception("Category not found!");
        return category; 
    }

    public async Task<CategoryViewModel?> CreateCategory(CategoryViewModel categoryVM) 
    {
        Category category = _mapper.Map<Category>(categoryVM);
        
        await _db.Category.AddAsync(category);
        await _db.SaveChangesAsync();

        return _mapper.Map<CategoryViewModel>(category);
    }

    public async Task<CategoryViewModel?> UpdateCategory(CategoryViewModel categoryVM)
    {
        Category category = await _db.Category.FindAsync(categoryVM.Id) ?? throw new Exception("Category not found!");

        category.ValueId = categoryVM.ValueId;
        category.IsActive = categoryVM.IsActive;

        await _db.SaveChangesAsync();

        return _mapper.Map<CategoryViewModel>(category);
    }

    public async Task<List<CategoryViewModel>?> DeleteCategory(int Id)
    {
        Category category = await _db.Category.FindAsync(Id) ?? throw new Exception("Category not found!");

        _db.Category.Remove(category);
        await _db.SaveChangesAsync();

        return await GetCategory();
    }

}
