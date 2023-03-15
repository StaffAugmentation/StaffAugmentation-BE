using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IApproverRepository 
        //: IGenericRepository<ApproversViewModel>
    {
        Task<List<ApproversViewModel>?> GetApprover();
        Task<ApproversViewModel?> GetApprover(int Id);
        Task<ApproversViewModel?> CreateApprover(ApproversViewModel approver);
        Task<ApproversViewModel?> UpdateApprover(ApproversViewModel approver);
        Task<List<ApproversViewModel>?> DeleteApprover(int Id);
    }
}
