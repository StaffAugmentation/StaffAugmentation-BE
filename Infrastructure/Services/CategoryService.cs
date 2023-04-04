using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services;

public class CategoryService : ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<CategoryViewModel>?> GetCategory()
    {
        return await _unitOfWork.Category.GetAll();
    }

    public async Task<CategoryViewModel?> GetCategory(int Id)
    {
        return await _unitOfWork.Category.Find(entity => entity.Id == Id);
    }

    public async Task<CategoryViewModel?> CreateCategory(CategoryViewModel Category)
    {
        return await _unitOfWork.Category.Create(Category);
    }

    public async Task<CategoryViewModel?> UpdateCategory(CategoryViewModel Category)
    {
        return await _unitOfWork.Category.Update(Category.Id, Category);
    }

    public async Task<IEnumerable<CategoryViewModel>?> DeleteCategory(int Id)
    {
        return await _unitOfWork.Category.Delete(Id);
    }

}
