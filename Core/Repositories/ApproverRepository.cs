using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories
{
    public class ApproverRepository : IApproverRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public ApproverRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<ApproversViewModel>?> GetApprover()
        {
            return await _db.Approvers.Select(approver => _mapper.Map<ApproversViewModel>(approver)).ToListAsync();
        }

        public async Task<ApproversViewModel?> GetApprover(int Id)
        {
            var dbApprover = await _db.Approvers.Where(approver => approver.Id == Id).Select(approver => _mapper.Map<ApproversViewModel>(approver)).FirstOrDefaultAsync();
            if (dbApprover == null)
                throw new Exception("Approvers not found!");
            return dbApprover;
        }

        public async Task<ApproversViewModel?> CreateApprover(ApproversViewModel approver)
        {
            var dbApprover = await _db.Approvers.AddAsync(_mapper.Map<Approvers>(approver));
            await _db.SaveChangesAsync();

            return _mapper.Map<ApproversViewModel>(dbApprover.Entity);
        }

        public async Task<ApproversViewModel?> UpdateApprover(ApproversViewModel approver)
        {
            var dbApprover = await _db.Approvers.FindAsync(approver.Id);
            if (dbApprover == null)
                throw new Exception("Approvers not found!");

            dbApprover.AppFirstName = approver.AppFirstName;
            dbApprover.AppLastName = approver.AppLastName;

            await _db.SaveChangesAsync();
            return _mapper.Map<ApproversViewModel>(dbApprover);
        }

        public async Task<List<ApproversViewModel>?> DeleteApprover(int Id)
        {
            var dbApprover = await _db.Approvers.FindAsync(Id);
            if (dbApprover == null)
                throw new Exception("Approvers not found!");

            _db.Approvers.Remove(dbApprover);
            await _db.SaveChangesAsync();

            return await GetApprover();
        }

    }
}
