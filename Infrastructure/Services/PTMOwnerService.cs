using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class PTMOwnerService : IPTMOwnerService
    {
        private readonly IPTMOwnerRepository repo;
        public PTMOwnerService(IPTMOwnerRepository ptmOwnerRepository)
        {
            repo = ptmOwnerRepository;
        }

        public async Task<List<PTMOwnerViewModel>?> GetPTMOwner()
        {
            return await repo.GetPTMOwner();
        }

        public async Task<PTMOwnerViewModel?> GetPTMOwner(int Id)
        {
            return await repo.GetPTMOwner(Id);
        }

        public async Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            return await repo.CreatePTMOwner(PTMOwner);
        }

        public async Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            return await repo.UpdatePTMOwner(PTMOwner);
        }

        public async Task<List<PTMOwnerViewModel>?> DeletePTMOwner(int Id)
        {
            return await repo.DeletePTMOwner(Id);
        }

    }
}
