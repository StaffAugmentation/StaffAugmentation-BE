using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ICategoryRepository
    {
        Task<List<CategoryViewModel>?> GetCategory();
        Task<CategoryViewModel?> GetCategory(int Id);
        Task<CategoryViewModel?> CreateCategory(CategoryViewModel category);
        Task<CategoryViewModel?> UpdateCategory(CategoryViewModel category);
        Task<List<CategoryViewModel>?> DeleteCategory(int Id);
    }
}
