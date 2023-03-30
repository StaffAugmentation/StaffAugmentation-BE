using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IOERPCodeRepository
    {
        Task<List<OERPCodeViewModel>?> GetOERPCode();
        Task<OERPCodeViewModel?> GetOERPCode(int Id);
        Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCode);
        Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCode);
        Task<List<OERPCodeViewModel>?> DeleteOERPCode(int Id);
    }
}
