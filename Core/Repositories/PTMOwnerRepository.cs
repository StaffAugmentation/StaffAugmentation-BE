using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
    public class PTMOwnerRepository : IPTMOwnerRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public PTMOwnerRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<PTMOwnerViewModel>?> GetPTMOwner()
        {
            return await (from ptmOwner in _db.PTMOwner
                          join approver in _db.Approvers on ptmOwner.IdApprover equals approver.Id into approver
                          from approvers in approver.DefaultIfEmpty()
                          select new PTMOwnerViewModel
                          {
                              Id = ptmOwner.Id,
                              ValueId = ptmOwner.ValueId,
                              PTMOwnerBA = ptmOwner.PTMOwnerBA,
                              PTMOwnerBICSW = ptmOwner.PTMOwnerBICSW,
                              PTMOwnerVatRate = ptmOwner.PTMOwnerVatRate,
                              IsEveris = ptmOwner.IsEveris,
                              IdApprover = ptmOwner.IdApprover,
                              PTMOwnerVatNumber = ptmOwner.PTMOwnerVatNumber,
                              ApproverName = approvers != null ? approvers.AppFirstName + " " + approvers.AppLastName : ""
                          }).ToListAsync();
        }

        public async Task<PTMOwnerViewModel?> GetPTMOwner(int Id)
        {
            var dbPTMOwner = await _db.PTMOwner.Where(PTMOwner => PTMOwner.Id == Id).Select(PTMOwner => _mapper.Map<PTMOwnerViewModel>(PTMOwner)).FirstOrDefaultAsync();
            if (dbPTMOwner == null)
                throw new Exception("PTMOwner not found!");
            return dbPTMOwner;
        }

        public async Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            var dbPTMOwner = await _db.PTMOwner.AddAsync(_mapper.Map<PTMOwner>(PTMOwner));
            await _db.SaveChangesAsync();

            return _mapper.Map<PTMOwnerViewModel>(dbPTMOwner.Entity);
        }

        public async Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            var dbPTMOwner = await _db.PTMOwner.FindAsync(PTMOwner.Id);
            if (dbPTMOwner == null)
                throw new Exception("PTMOwner not found!");

            dbPTMOwner.ValueId = PTMOwner.ValueId;
            dbPTMOwner.PTMOwnerBA = PTMOwner.PTMOwnerBA;
            dbPTMOwner.PTMOwnerBICSW = PTMOwner.PTMOwnerBICSW;
            dbPTMOwner.PTMOwnerVatRate = PTMOwner.PTMOwnerVatRate;
            dbPTMOwner.IsEveris = PTMOwner.IsEveris;
            dbPTMOwner.IdApprover = PTMOwner.IdApprover;
            dbPTMOwner.PTMOwnerVatNumber = PTMOwner.PTMOwnerVatNumber;


            await _db.SaveChangesAsync();
            return _mapper.Map<PTMOwnerViewModel>(dbPTMOwner);
        }

        public async Task<List<PTMOwnerViewModel>?> DeletePTMOwner(int Id)
        {
            var dbPTMOwner = await _db.PTMOwner.FindAsync(Id);
            if (dbPTMOwner == null)
                throw new Exception("PTMOwner not found!");

            _db.PTMOwner.Remove(dbPTMOwner);
            await _db.SaveChangesAsync();

            return await GetPTMOwner();
        }

    }
}
