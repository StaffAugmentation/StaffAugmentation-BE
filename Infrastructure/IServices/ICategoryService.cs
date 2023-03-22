using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface ICategoryService
    {
        Task<List<CategoryViewModel>?> GetCategory();
        Task<CategoryViewModel?> GetCategory(int Id);
        Task<CategoryViewModel?> CreateCategory(CategoryViewModel category);
        Task<CategoryViewModel?> UpdateCategory(CategoryViewModel category);
        Task<List<CategoryViewModel>?> DeleteCategory(int Id);
    }
}