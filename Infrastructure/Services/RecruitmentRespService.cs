using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class RecruitmentRespService : IRecruitmentRespService
    {
        private readonly IRecruitmentRespRepository repo;
        public RecruitmentRespService(IRecruitmentRespRepository RecruitmentRespRepository)
        {
            repo = RecruitmentRespRepository;
        }

        public async Task<List<RecruitmentRespViewModel>?> GetRecruitmentResp()
        {
            return await repo.GetRecruitmentResp();
        }

        public async Task<RecruitmentRespViewModel?> GetRecruitmentResp(int Id)
        {
            return await repo.GetRecruitmentResp(Id);
        }

        public async Task<RecruitmentRespViewModel?> CreateRecruitmentResp(RecruitmentRespViewModel recruitmentResp)
        {
            return await repo.CreateRecruitmentResp(recruitmentResp);
        }

        public async Task<RecruitmentRespViewModel?> UpdateRecruitmentResp(RecruitmentRespViewModel recruitmentResp)
        {
            return await repo.UpdateRecruitmentResp(recruitmentResp);
        }

        public async Task<List<RecruitmentRespViewModel>?> DeleteRecruitmentResp(int Id)
        {
            return await repo.DeleteRecruitmentResp(Id);
        }

    }
}
