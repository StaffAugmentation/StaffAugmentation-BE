using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class OERPCodeService : IOERPCodeService
    {
        private readonly IOERPCodeRepository repo;
        public OERPCodeService(IOERPCodeRepository OERPCodeRepository)
        {
            repo = OERPCodeRepository;
        }

        public async Task<List<OERPCodeViewModel>?> GetOERPCode()
        {
            return await repo.GetOERPCode();
        }

        public async Task<OERPCodeViewModel?> GetOERPCode(int Id)
        {
            return await repo.GetOERPCode(Id);
        }

        public async Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCode)
        {
            return await repo.CreateOERPCode(OERPCode);
        }

        public async Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCode)
        {
            return await repo.UpdateOERPCode(OERPCode);
        }

        public async Task<List<OERPCodeViewModel>?> DeleteOERPCode(int Id)
        {
            return await repo.DeleteOERPCode(Id);
        }

    }
}
