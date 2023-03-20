using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class TypeService : ITypeService
    {
        private readonly ITypeRepository repo;
        public TypeService(ITypeRepository typerepository) 
        {
            repo = typerepository;
        }

        public new async Task<List<TypeViewModel>?> GetType()
        {
            return await repo.GetType();
        }

        public async Task<TypeViewModel?> GetType(int Id)
        {
            return await repo.GetType(Id);
        }

        public async Task<TypeViewModel?> CreateType(TypeViewModel type)
        {
            return await repo.CreateType(type);
        }

        public async Task<TypeViewModel?> UpdateType(TypeViewModel type)
        {
            return await repo.UpdateType(type);
        }
        public async Task<List<TypeViewModel>?> DeleteType(int Id)
        {
            return await repo.DeleteType(Id);
        }
    }
}
