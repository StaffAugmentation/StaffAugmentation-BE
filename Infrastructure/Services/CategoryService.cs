using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository repo;
        public CategoryService(ICategoryRepository CategoryRepository)
        {
            repo = CategoryRepository;
        }

        public async Task<List<CategoryViewModel>?> GetCategory()
        {
            return await repo.GetCategory();
        }

        public async Task<CategoryViewModel?> GetCategory(int Id)
        {
            return await repo.GetCategory(Id);
        }

        public async Task<CategoryViewModel?> CreateCategory(CategoryViewModel Category)
        {
            return await repo.CreateCategory(Category);
        }

        public async Task<CategoryViewModel?> UpdateCategory(CategoryViewModel Category)
        {
            return await repo.UpdateCategory(Category);
        }

        public async Task<List<CategoryViewModel>?> DeleteCategory(int Id)
        {
            return await repo.DeleteCategory(Id);
        }

    }
}
