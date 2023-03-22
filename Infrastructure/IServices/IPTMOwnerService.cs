using Core.ViewModel;

namespace Business.IServices
{
    public interface IPTMOwnerService
    {
        Task<List<PTMOwnerViewModel>?> GetPTMOwner();
        Task<PTMOwnerViewModel?> GetPTMOwner(int Id);
        Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwner);
        Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwner);
        Task<List<PTMOwnerViewModel>?> DeletePTMOwner(int Id);
    }
}