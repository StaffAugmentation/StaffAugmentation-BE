using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Linq.Expressions;

namespace Core.Repositories;

public class SubContractorRepository : GenericRepository<SubContractorViewModel, SubContractor, int>, ISubContractorRepository
{
    public SubContractorRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public override async Task<IEnumerable<SubContractorViewModel>> GetAll(Expression<Func<SubContractor, bool>>? criteria = null, string? orderDirection = null, Expression<Func<SubContractor, object>>? order = null)
    {
        return await (from subContractor in _context.SubContractor
                      join approver in _context.Approver on subContractor.IdApprover equals approver.Id into approver from approvers in approver.DefaultIfEmpty()
                      join typeOfCost in _context.TypeOfCost on subContractor.IdTypeOfCost equals typeOfCost.Id into typeOfCost from typeOfCosts in typeOfCost.DefaultIfEmpty()
                      join paymentTerm in _context.PaymentTerm on subContractor.IdPaymentTerm equals paymentTerm.Id into paymentTerm from paymentTerms in paymentTerm.DefaultIfEmpty()
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
    
    public override async Task<SubContractorViewModel> Find(Expression<Func<SubContractor, bool>> criteria)
    {
        SubContractorViewModel subContractorVM = await _context.SubContractor
            .Where(criteria)
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
                Approver = _mapper.Map<ApproverViewModel>(_context.Approver.Where(entity => entity.Id == subContractor.IdApprover).FirstOrDefault()),
                PaymentTerm = _mapper.Map<PaymentTermViewModel>(_context.PaymentTerm.Where(entity => entity.Id == subContractor.IdPaymentTerm).FirstOrDefault()),
                TypeOfCost = _mapper.Map<TypeOfCostViewModel>(_context.TypeOfCost.Where(entity => entity.Id == subContractor.IdTypeOfCost).FirstOrDefault())
            })
            .FirstOrDefaultAsync() ?? throw new Exception("SubContractor not found!");
        return subContractorVM;
    }

    public override async Task<SubContractorViewModel> Create(SubContractorViewModel subContractorVM) 
    {
        SubContractor subContractor = _mapper.Map<SubContractor>(subContractorVM);
        subContractor.IdApprover = subContractorVM.Approver?.Id;
        subContractor.IdPaymentTerm = subContractorVM.PaymentTerm?.Id;
        subContractor.IdTypeOfCost = subContractorVM.TypeOfCost?.Id;

        await _context.SubContractor.AddAsync(subContractor);
        await _context.SaveChangesAsync();

        subContractorVM = _mapper.Map<SubContractorViewModel>(subContractor);
        subContractorVM.Approver = _mapper.Map<ApproverViewModel>(_context.Approver.Where(entity => entity.Id == subContractor.IdApprover).FirstOrDefaultAsync());
        subContractorVM.PaymentTerm = _mapper.Map<PaymentTermViewModel>(_context.PaymentTerm.Where(entity => entity.Id == subContractor.IdPaymentTerm).FirstOrDefaultAsync());
        subContractorVM.TypeOfCost = _mapper.Map<TypeOfCostViewModel>(_context.TypeOfCost.Where(entity => entity.Id == subContractor.IdTypeOfCost).FirstOrDefaultAsync());

        return subContractorVM;
    }

    public override async Task<SubContractorViewModel> Update(int key, SubContractorViewModel subContractorVM)
    {
        SubContractor subContractor = await _context.SubContractor.FindAsync(key) ?? throw new Exception("SubContractor not found!");

        if(subContractor != null)
        {
            subContractor = _mapper.Map<SubContractor>(subContractorVM);
            subContractor.IdApprover = subContractorVM.Approver?.Id;
            subContractor.IdPaymentTerm = subContractorVM.PaymentTerm?.Id;
            subContractor.IdTypeOfCost = subContractorVM.TypeOfCost?.Id;
        }

        await _context.SaveChangesAsync();

        return await Find(entity => entity.Id == key);
    }
}
