using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;

namespace Business.Services
{
    public class ApproverService : IApproverService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApproverService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<ApproverViewModel>?> GetApprover()
        {
            return await _unitOfWork.Approver.GetAll();
        }

        public async Task<ApproverViewModel?> GetApprover(int approverId)
        {
            return await _unitOfWork.Approver.Find(entity => entity.Id == approverId) ;
        }

        public async Task<ApproverViewModel?> CreateApprover(ApproverViewModel approver)
        {
            return await _unitOfWork.Approver.Create(approver);
        }

        public async Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approver)
        {
            return await _unitOfWork.Approver.Update(approver.Id, approver);
        }

        public async Task<IEnumerable<ApproverViewModel>?> DeleteApprover(int ApproverId)
        {
            return await _unitOfWork.Approver.Delete(ApproverId);
        }

    }
}
