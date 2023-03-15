using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class ApproverService : IApproverService
    {
        private readonly IApproverRepository repo;
        public ApproverService(IApproverRepository approverRepository)
        {
            repo = approverRepository;
        }

        public async Task<List<ApproversViewModel>?> GetApprover()
        {
            return await repo.GetApprover();
        }

        public async Task<ApproversViewModel?> GetApprover(int approverId)
        {
            return await repo.GetApprover(approverId);
        }

        public async Task<ApproversViewModel?> CreateApprover(ApproversViewModel approver)
        {
            return await repo.CreateApprover(approver);
        }

        public async Task<ApproversViewModel?> UpdateApprover(ApproversViewModel approver)
        {
            return await repo.UpdateApprover(approver);
        }

        public async Task<List<ApproversViewModel>?> DeleteApprover(int ApproverId)
        {
            return await repo.DeleteApprover(ApproverId);
        }

    }
}
