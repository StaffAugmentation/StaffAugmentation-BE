using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;
using RecruitmentResp = Core.Model.RecruitmentResp;

namespace Core.Repositories
{
    public class RecruitmentRespRepository : IRecruitmentRespRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public RecruitmentRespRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<RecruitmentRespViewModel>?> GetRecruitmentResp()
        {
            return await _db.RecruitmentResp.Select(recruitmentResp => _mapper.Map<RecruitmentRespViewModel>(recruitmentResp)).ToListAsync();
        }
        
        public async Task<RecruitmentRespViewModel?> GetRecruitmentResp(int Id)
        {
            var dbRecruitmentResp = await _db.RecruitmentResp.Where(recruitmentResp => recruitmentResp.Id == Id).Select(recruitmentResp => _mapper.Map<RecruitmentRespViewModel>(recruitmentResp)).FirstOrDefaultAsync();
            if (dbRecruitmentResp == null)
                throw new Exception("RecruitmentResp not found!");
            return dbRecruitmentResp; 
        }

        public async Task<RecruitmentRespViewModel?> CreateRecruitmentResp(RecruitmentRespViewModel recruitmentResp) 
        {
            var dbRecruitmentResp = await _db.RecruitmentResp.AddAsync(_mapper.Map<RecruitmentResp>(recruitmentResp));
            await _db.SaveChangesAsync();

            return _mapper.Map<RecruitmentRespViewModel>(dbRecruitmentResp.Entity);
        }

        public async Task<RecruitmentRespViewModel?> UpdateRecruitmentResp(RecruitmentRespViewModel recruitmentResp)
        {
            var dbRecruitmentResp = await _db.RecruitmentResp.FindAsync(recruitmentResp.Id);
            if (dbRecruitmentResp == null)
                throw new Exception("RecruitmentResp not found!");

            dbRecruitmentResp.ResponsibleName = recruitmentResp.ResponsibleName;
            dbRecruitmentResp.ResponsibleEmail = recruitmentResp.ResponsibleEmail;
            dbRecruitmentResp.IsPartner = recruitmentResp.IsPartner;
            dbRecruitmentResp.TypeOfContractId = recruitmentResp.TypeOfContractId;

        await _db.SaveChangesAsync();
            return _mapper.Map<RecruitmentRespViewModel>(dbRecruitmentResp);
        }

        public async Task<List<RecruitmentRespViewModel>?> DeleteRecruitmentResp(int Id)
        {
            var dbRecruitmentResp = await _db.RecruitmentResp.FindAsync(Id);
            if (dbRecruitmentResp == null)
                throw new Exception("RecruitmentResp not found!");

            _db.RecruitmentResp.Remove(dbRecruitmentResp);
            await _db.SaveChangesAsync();

            return await GetRecruitmentResp();
        }

    }
}
