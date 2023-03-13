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

        public async Task<List<ApproverViewModel>?> GetApprover()
        {
            return await _db.Approver.Select(approver => _mapper.Map<ApproverViewModel>(approver)).ToListAsync();
        }

        public async Task<ApproverViewModel?> GetApprover(int Id)
        {
            var dbApprover = await _db.Approver.Where(approver => approver.Id == Id).Select(approver => _mapper.Map<ApproverViewModel>(approver)).FirstOrDefaultAsync();
            if (dbApprover == null)
                throw new Exception("Approver not found!");
            return dbApprover;
        }

        public async Task<ApproverViewModel?> CreateApprover(ApproverViewModel approver)
        {
            var dbApprover = await _db.Approver.AddAsync(_mapper.Map<Approver>(approver));
            await _db.SaveChangesAsync();

            return _mapper.Map<ApproverViewModel>(dbApprover.Entity);
        }

        public async Task<ApproverViewModel?> UpdateApprover(ApproverViewModel approver)
        {
            var dbApprover = await _db.Approver.FindAsync(approver.Id);
            if (dbApprover == null)
                throw new Exception("Approver not found!");

            dbApprover.AppFirstName = approver.AppFirstName;
            dbApprover.AppLastName = approver.AppLastName;

            await _db.SaveChangesAsync();
            return _mapper.Map<ApproverViewModel>(dbApprover);
        }

        public async Task<List<ApproverViewModel>?> DeleteApprover(int Id)
        {
            var dbApprover = await _db.Approver.FindAsync(Id);
            if (dbApprover == null)
                throw new Exception("Approver not found!");

            _db.Approver.Remove(dbApprover);
            await _db.SaveChangesAsync();

            return await GetApprover();
        }

    }
}
