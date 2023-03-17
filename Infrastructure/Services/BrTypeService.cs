using Business.IServices;
using Core.IRepositories;
using Core.Repositories;
using Core.ViewModel;

namespace Business.Services
{
    public class BrTypeService : IBrTypeService
    {
        private readonly IBrTypeRepository repo;
        public BrTypeService(IBrTypeRepository brTyperepository)
        {
            repo = brTyperepository;
        }

        public async Task<List<BrTypeViewModel>?> GetBrType()
        {
            return await repo.GetBrType();
        }

        public async Task<BrTypeViewModel?> GetBrType(int Id)
        {
            return await repo.GetBrType(Id);
        }

        public async Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType)
        {
            return await repo.CreateBrType(brType);
        }

        public async Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType)
        {
            return await repo.UpdateBrType(brType);
        }

        public async Task<List<BrTypeViewModel>?> DeleteBrType(int Id)
        {
            return await repo.DeleteBrType(Id);
        }

    }
}
