using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class BrSourceService : IBrSourceService
    {
        private readonly IBrSourceRepository repo;
        public BrSourceService(IBrSourceRepository brSourcerepository)
        {
            repo = brSourcerepository;
        }

        public async Task<List<BrSourceViewModel>?> GetBrSource()
        {
            return await repo.GetBrSource();
        }

        public async Task<BrSourceViewModel?> GetBrSource(string IdSource)
        {
            return await repo.GetBrSource(IdSource);
        }

        public async Task<BrSourceViewModel?> CreateBrSource(BrSourceViewModel brSource)
        {
            return await repo.CreateBrSource(brSource);
        }

        public async Task<BrSourceViewModel?> UpdateBrSource(BrSourceViewModel brSource)
        {
            return await repo.UpdateBrSource(brSource);
        }

        public async Task<List<BrSourceViewModel>?> DeleteBrSource(string IdSource)
        {
            return await repo.DeleteBrSource(IdSource);
        }
    }
}
