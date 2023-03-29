using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;
using RecruitmentResponsible = Core.Model.RecruitmentResponsible;

namespace Core.Repositories
{
    public class RecruitmentResponsibleRepository : IRecruitmentResponsibleRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public RecruitmentResponsibleRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<RecruitmentResponsibleViewModel>?> GetRecruitmentResponsible()
        {
            return await _db.RecruitmentResponsible.Select(recruitmentResponsible => _mapper.Map<RecruitmentResponsibleViewModel>(recruitmentResponsible)).ToListAsync();
        }
        
        public async Task<RecruitmentResponsibleViewModel?> GetRecruitmentResponsible(int Id)
        {
            RecruitmentResponsibleViewModel recruitmentResponsibleVM = await _db.RecruitmentResponsible
                .Where(recruitmentResponsible => recruitmentResponsible.Id == Id)
                .Select(recruitmentResponsible => _mapper.Map<RecruitmentResponsibleViewModel>(recruitmentResponsible))
                .FirstOrDefaultAsync() ?? throw new Exception("RecruitmentResponsible not found!");
            return recruitmentResponsibleVM; 
        }

        public async Task<RecruitmentResponsibleViewModel?> CreateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsibleVM) 
        {
            RecruitmentResponsible recruitmentResponsible = _mapper.Map<RecruitmentResponsible>(recruitmentResponsibleVM);

            await _db.RecruitmentResponsible.AddAsync(recruitmentResponsible);
            await _db.SaveChangesAsync();

            return _mapper.Map<RecruitmentResponsibleViewModel>(recruitmentResponsible);
        }

        public async Task<RecruitmentResponsibleViewModel?> UpdateRecruitmentResponsible(RecruitmentResponsibleViewModel recruitmentResponsibleVM)
        {
            RecruitmentResponsible recruitmentResponsible = await _db.RecruitmentResponsible.FindAsync(recruitmentResponsibleVM.Id) ?? throw new Exception("RecruitmentResponsible not found!");

            recruitmentResponsible.Name = recruitmentResponsibleVM.Name;
            recruitmentResponsible.Email = recruitmentResponsibleVM.Email;
            recruitmentResponsible.IsPartner = recruitmentResponsibleVM.IsPartner;
            recruitmentResponsible.TypeOfContractId = recruitmentResponsibleVM.TypeOfContractId;

            await _db.SaveChangesAsync();

            return _mapper.Map<RecruitmentResponsibleViewModel>(recruitmentResponsible);
        }

        public async Task<List<RecruitmentResponsibleViewModel>?> DeleteRecruitmentResponsible(int Id)
        {
            RecruitmentResponsible recruitmentResponsible = await _db.RecruitmentResponsible.FindAsync(Id) ?? throw new Exception("RecruitmentResponsible not found!");

            _db.RecruitmentResponsible.Remove(recruitmentResponsible);
            await _db.SaveChangesAsync();

            return await GetRecruitmentResponsible();
        }

    }
}
