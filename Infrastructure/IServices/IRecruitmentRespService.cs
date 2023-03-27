using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface IRecruitmentRespService
    {
        Task<List<RecruitmentRespViewModel>?> GetRecruitmentResp();
        Task<RecruitmentRespViewModel?> GetRecruitmentResp(int Id);
        Task<RecruitmentRespViewModel?> CreateRecruitmentResp(RecruitmentRespViewModel recruitmentResp);
        Task<RecruitmentRespViewModel?> UpdateRecruitmentResp(RecruitmentRespViewModel recruitmentResp);
        Task<List<RecruitmentRespViewModel>?> DeleteRecruitmentResp(int Id);
    }
}