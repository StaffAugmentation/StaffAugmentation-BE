using Core.ViewModel;

namespace Business.IServices;

public interface IPTMOwnerService
{
    Task<IEnumerable<PTMOwnerViewModel>?> GetPTMOwner();
    Task<PTMOwnerViewModel?> GetPTMOwner(int Id);
    Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwner);
    Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwner);
    Task<IEnumerable<PTMOwnerViewModel>?> DeletePTMOwner(int Id);
}