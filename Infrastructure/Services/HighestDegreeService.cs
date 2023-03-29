using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class HighestDegreeService : IHighestDegreeService
    {
        private readonly IHighestDegreeRepository repo;
        public HighestDegreeService(IHighestDegreeRepository HighestDegreerepository)
        {
            repo = HighestDegreerepository;
        }

        public async Task<List<HighestDegreeViewModel>?> GetHighestDegree()
        {
            return await repo.GetHighestDegree();
        }

        public async Task<HighestDegreeViewModel?> GetHighestDegree(int Id)
        {
            return await repo.GetHighestDegree(Id);
        }

        public async Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            return await repo.CreateHighestDegree(HighestDegree);
        }

        public async Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree)
        {
            return await repo.UpdateHighestDegree(HighestDegree);
        }

        public async Task<List<HighestDegreeViewModel>?> DeleteHighestDegree(int Id)
        {
            return await repo.DeleteHighestDegree(Id);
        }

    }
}
