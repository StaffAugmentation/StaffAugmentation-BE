using Core.ViewModel;

namespace Business.IServices;

public interface IApproverService
{
    Task<IEnumerable<ApproverViewModel>?> GetApprover();
    Task<ApproverViewModel?> GetApprover(int approverId);
    Task<ApproverViewModel?> CreateApprover(ApproverViewModel approver);
    Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approver);
    Task<IEnumerable<ApproverViewModel>?> DeleteApprover(int ApproverId);
}