using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IApproverRepository 
        //: IGenericRepository<ApproverViewModel>
    {
        Task<List<ApproverViewModel>?> GetApprover();
        Task<ApproverViewModel?> GetApprover(int Id);
        Task<ApproverViewModel?> CreateApprover(ApproverViewModel approver);
        Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approver);
        Task<List<ApproverViewModel>?> DeleteApprover(int Id);
    }
}
