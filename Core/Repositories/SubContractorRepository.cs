using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;
using SubContractor = Core.Model.SubContractor;
using Core.Migrations;

namespace Core.Repositories
{
    public class SubContractorRepository : ISubContractorRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public SubContractorRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<SubContractorViewModel>?> GetSubContractor()
        {
            return await (from subContractor in _db.SubContractor
                          join approver in _db.Approvers on subContractor.IdApproverSub equals approver.Id into approver
                          from approvers in approver.DefaultIfEmpty()
                          join typeOfCost in _db.TypeOfCost on subContractor.IdTypeOfCost equals typeOfCost.Id into typeOfCost
                          from typeOfCosts in typeOfCost.DefaultIfEmpty()
                          join paymentTerm in _db.PaymentTerm on subContractor.IdPaymentTerm equals paymentTerm.Id into paymentTerm
                          from paymentTerms in paymentTerm.DefaultIfEmpty()
                          select new SubContractorViewModel
                          {
                              Id = subContractor.Id,
                              ValueId = subContractor.ValueId,
                              SubContBa = subContractor.SubContBa,
                              SubContBicsw = subContractor.SubContBicsw,
                              SubContVatRate = subContractor.SubContVatRate,
                              IsOfficial = subContractor.IsOfficial,
                              IdApproverSub = subContractor.IdApproverSub,
                              LegalEntityName = subContractor.LegalEntityName,
                              LegalEntityAdress = subContractor.LegalEntityAdress,
                              VatNumber = subContractor.VatNumber,
                              IdNumber = subContractor.IdNumber,
                              IdPaymentTerm = subContractor.IdPaymentTerm,
                              IdTypeOfCost = subContractor.IdTypeOfCost,
                              TypeOfCostName = typeOfCosts != null ? typeOfCosts.TypeOfCostValue : "",
                              PaymentTermName = paymentTerms != null ? paymentTerms.PaymentTermValue : "",
                              ApproverName = approvers != null ? approvers.AppFirstName + " " + approvers.AppLastName : ""

                          }).ToListAsync();
        }
        
        public async Task<SubContractorViewModel?> GetSubContractor(int Id)
        {
            var dbSubContractor = await _db.SubContractor.Where(subContractor => subContractor.Id == Id).Select(subContractor => _mapper.Map<SubContractorViewModel>(subContractor)).FirstOrDefaultAsync();
            if (dbSubContractor == null)
                throw new Exception("SubContractor not found!");
            return dbSubContractor; 
        }

        public async Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor) 
        {
            var dbSubContractor = await _db.SubContractor.AddAsync(_mapper.Map<SubContractor>(subContractor));
            await _db.SaveChangesAsync();

            return _mapper.Map<SubContractorViewModel>(dbSubContractor.Entity);
        }

        public async Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor)
        {
            var dbSubContractor = await _db.SubContractor.FindAsync(subContractor.Id);
            if (dbSubContractor == null)
                throw new Exception("SubContractor not found!");

            dbSubContractor.ValueId = subContractor.ValueId;
            dbSubContractor.SubContBa = subContractor.SubContBa;
            dbSubContractor.SubContBicsw = subContractor.SubContBicsw;
            dbSubContractor.SubContVatRate = subContractor.SubContVatRate;
            dbSubContractor.IsOfficial = subContractor.IsOfficial;
            dbSubContractor.IdApproverSub = subContractor.IdApproverSub;
            dbSubContractor.LegalEntityName = subContractor.LegalEntityName;
            dbSubContractor.LegalEntityAdress = subContractor.LegalEntityAdress;
            dbSubContractor.VatNumber = subContractor.VatNumber;
            dbSubContractor.IdNumber = subContractor.IdNumber;
            dbSubContractor.IdPaymentTerm = subContractor.IdPaymentTerm;
            dbSubContractor.IdTypeOfCost = subContractor.IdTypeOfCost;

        await _db.SaveChangesAsync();
            return _mapper.Map<SubContractorViewModel>(dbSubContractor);
        }

        public async Task<List<SubContractorViewModel>?> DeleteSubContractor(int Id)
        {
            var dbSubContractor = await _db.SubContractor.FindAsync(Id);
            if (dbSubContractor == null)
                throw new Exception("SubContractor not found!");

            _db.SubContractor.Remove(dbSubContractor);
            await _db.SaveChangesAsync();

            return await GetSubContractor();
        }

    }
}
