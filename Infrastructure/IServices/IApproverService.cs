using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface IApproverService
    {
        Task<List<ApproverViewModel>?> GetApprover();
        Task<ApproverViewModel?> GetApprover(int approverId);
        Task<ApproverViewModel?> CreateApprover(ApproverViewModel approver);
        Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approver);
        Task<List<ApproverViewModel>?> DeleteApprover(int ApproverId);
    }
}