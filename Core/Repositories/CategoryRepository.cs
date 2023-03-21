using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
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
            var dbCategory = await _db.Category.Where(category => category.Id == Id).Select(category => _mapper.Map<CategoryViewModel>(category)).FirstOrDefaultAsync();
            if (dbCategory == null)
                throw new Exception("Category not found!");
            return dbCategory; 
        }

        public async Task<CategoryViewModel?> CreateCategory(CategoryViewModel category) 
        {
            var dbCategory = await _db.Category.AddAsync(_mapper.Map<Category>(category));
            await _db.SaveChangesAsync();

            return _mapper.Map<CategoryViewModel>(dbCategory.Entity);
        }

        public async Task<CategoryViewModel?> UpdateCategory(CategoryViewModel category)
        {
            var dbCategory = await _db.Category.FindAsync(category.Id);
            if (dbCategory == null)
                throw new Exception("Category not found!");

            dbCategory.ValueId = category.ValueId;
            dbCategory.IsActive = category.IsActive;
            
            await _db.SaveChangesAsync();
            return _mapper.Map<CategoryViewModel>(dbCategory);
        }

        public async Task<List<CategoryViewModel>?> DeleteCategory(int Id)
        {
            var dbCategory = await _db.Category.FindAsync(Id);
            if (dbCategory == null)
                throw new Exception("Category not found!");

            _db.Category.Remove(dbCategory);
            await _db.SaveChangesAsync();

            return await GetCategory();
        }

    }
}
