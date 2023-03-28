using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

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
                      join approver in _db.Approver on subContractor.IdApprover equals approver.Id into approver
                      from approvers in approver.DefaultIfEmpty()
                      join typeOfCost in _db.TypeOfCost on subContractor.IdTypeOfCost equals typeOfCost.Id into typeOfCost
                      from typeOfCosts in typeOfCost.DefaultIfEmpty()
                      join paymentTerm in _db.PaymentTerm on subContractor.IdPaymentTerm equals paymentTerm.Id into paymentTerm
                      from paymentTerms in paymentTerm.DefaultIfEmpty()
                      select new SubContractorViewModel
                      {
                          Id = subContractor.Id,
                          ValueId = subContractor.ValueId,
                          BA = subContractor.BA,
                          BICSW = subContractor.BICSW,
                          VatRate = subContractor.VatRate,
                          IsOfficial = subContractor.IsOfficial,
                          LegalEntityName = subContractor.LegalEntityName,
                          LegalEntityAddress = subContractor.LegalEntityAddress,
                          VatNumber = subContractor.VatNumber,
                          IdNumber = subContractor.IdNumber,
                          Approver = _mapper.Map<ApproverViewModel>(approvers),
                          PaymentTerm = _mapper.Map<PaymentTermViewModel>(paymentTerms),
                          TypeOfCost = _mapper.Map<TypeOfCostViewModel>(typeOfCosts)
                      }).ToListAsync();
    }
    
    public async Task<SubContractorViewModel?> GetSubContractor(int Id)
    {
        SubContractorViewModel subContractorVM = await _db.SubContractor
            .Where(subContractor => subContractor.Id == Id)
            .Select(subContractor => new SubContractorViewModel
            {
                Id = subContractor.Id,
                ValueId = subContractor.ValueId,
                BA = subContractor.BA,
                BICSW = subContractor.BICSW,
                VatRate = subContractor.VatRate,
                IsOfficial = subContractor.IsOfficial,
                LegalEntityName = subContractor.LegalEntityName,
                LegalEntityAddress = subContractor.LegalEntityAddress,
                VatNumber = subContractor.VatNumber,
                IdNumber = subContractor.IdNumber,
                Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(entity => entity.Id == subContractor.IdApprover)),
                PaymentTerm = _mapper.Map<PaymentTermViewModel>(_db.PaymentTerm.Where(entity => entity.Id == subContractor.IdPaymentTerm)),
                TypeOfCost = _mapper.Map<TypeOfCostViewModel>(_db.TypeOfCost.Where(entity => entity.Id == subContractor.IdTypeOfCost))
            })
            .FirstOrDefaultAsync() ?? throw new Exception("SubContractor not found!");
        return subContractorVM;
    }

    public async Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractorVM) 
    {
        SubContractor subContractor = _mapper.Map<SubContractor>(subContractorVM);
        subContractor.IdApprover = subContractorVM.Approver?.Id;
        subContractor.IdPaymentTerm = subContractorVM.PaymentTerm?.Id;
        subContractor.IdTypeOfCost = subContractorVM.TypeOfCost?.Id;

        await _db.SubContractor.AddAsync(subContractor);
        await _db.SaveChangesAsync();

        subContractorVM = _mapper.Map<SubContractorViewModel>(subContractor);
        subContractorVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(entity => entity.Id == subContractor.IdApprover).FirstOrDefaultAsync());
        subContractorVM.PaymentTerm = _mapper.Map<PaymentTermViewModel>(_db.PaymentTerm.Where(entity => entity.Id == subContractor.IdPaymentTerm).FirstOrDefaultAsync());
        subContractorVM.TypeOfCost = _mapper.Map<TypeOfCostViewModel>(_db.TypeOfCost.Where(entity => entity.Id == subContractor.IdTypeOfCost).FirstOrDefaultAsync());

        return subContractorVM;
    }

    public async Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractorVM)
    {
        SubContractor subContractor = await _db.SubContractor.FindAsync(subContractorVM.Id) ?? throw new Exception("SubContractor not found!");

        subContractor.ValueId = subContractorVM.ValueId;
        subContractor.BA = subContractorVM.BA;
        subContractor.BICSW = subContractorVM.BICSW;
        subContractor.VatRate = subContractorVM.VatRate;
        subContractor.VatNumber = subContractorVM.VatNumber;
        subContractor.IsOfficial = subContractorVM.IsOfficial;
        subContractor.LegalEntityName = subContractorVM.LegalEntityName;
        subContractor.LegalEntityAddress = subContractorVM.LegalEntityAddress;
        subContractor.IdApprover = subContractorVM.Approver?.Id;
        subContractor.IdPaymentTerm = subContractorVM.PaymentTerm?.Id;
        subContractor.IdTypeOfCost = subContractorVM.TypeOfCost?.Id;

        await _db.SaveChangesAsync();

        subContractorVM = _mapper.Map<SubContractorViewModel>(subContractor);
        subContractorVM.Approver = _mapper.Map<ApproverViewModel>(_db.Approver.Where(entity => entity.Id == subContractor.IdApprover).FirstOrDefaultAsync());
        subContractorVM.PaymentTerm = _mapper.Map<PaymentTermViewModel>(_db.PaymentTerm.Where(entity => entity.Id == subContractor.IdPaymentTerm).FirstOrDefaultAsync());
        subContractorVM.TypeOfCost = _mapper.Map<TypeOfCostViewModel>(_db.TypeOfCost.Where(entity => entity.Id == subContractor.IdTypeOfCost).FirstOrDefaultAsync());

        return subContractorVM;
    }

    public async Task<List<SubContractorViewModel>?> DeleteSubContractor(int Id)
    {
        SubContractor subContractor = await _db.SubContractor.FindAsync(Id) ?? throw new Exception("SubContractor not found!");
        
        _db.SubContractor.Remove(subContractor);
        await _db.SaveChangesAsync();

        return await GetSubContractor();
    }
}
