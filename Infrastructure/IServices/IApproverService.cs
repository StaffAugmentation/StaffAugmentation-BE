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
        Task<List<ApproversViewModel>?> GetApprover();
        Task<ApproversViewModel?> GetApprover(int approverId);
        Task<ApproversViewModel?> CreateApprover(ApproversViewModel approver);
        Task<ApproversViewModel?> UpdateApprover(ApproversViewModel approver);
        Task<List<ApproversViewModel>?> DeleteApprover(int ApproverId);
    }
}