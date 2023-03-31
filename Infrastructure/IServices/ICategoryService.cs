using Core.ViewModel;

namespace Business.IServices;

public interface ICategoryService
{
    Task<IEnumerable<CategoryViewModel>?> GetCategory();
    Task<CategoryViewModel?> GetCategory(int Id);
    Task<CategoryViewModel?> CreateCategory(CategoryViewModel category);
    Task<CategoryViewModel?> UpdateCategory(CategoryViewModel category);
    Task<IEnumerable<CategoryViewModel>?> DeleteCategory(int Id);
}