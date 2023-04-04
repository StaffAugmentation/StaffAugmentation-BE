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

    public override async Task<SubContractorViewModel> Create(SubContractorViewModel subContractorVM) 
    {
        SubContractor subContractor = _mapper.Map<SubContractor>(subContractorVM);
        subContractor.ApproverId = subContractorVM.Approver?.Id;
        subContractor.PaymentTermId = subContractorVM.PaymentTerm?.Id;
        subContractor.TypeOfCostId = subContractorVM.TypeOfCost?.Id;

        subContractor.Approver = null;
        subContractor.PaymentTerm = null;
        subContractor.TypeOfCost = null;

        await _context.SubContractor.AddAsync(subContractor);
        await _context.SaveChangesAsync();

        return await Find(entity => entity.Id == subContractor.Id, new List<Expression<Func<SubContractor, object>>> { entity => entity.Approver, entity => entity.PaymentTerm, entity => entity.TypeOfCost });
    }

    public override async Task<SubContractorViewModel> Update(int key, SubContractorViewModel subContractorVM)
    {
        try
        {
            SubContractor subContractor = _mapper.Map<SubContractor>(subContractorVM);
            subContractor.ApproverId = subContractorVM.Approver?.Id;
            subContractor.PaymentTermId = subContractorVM.PaymentTerm?.Id;
            subContractor.TypeOfCostId = subContractorVM.TypeOfCost?.Id;

            _context.Update(subContractor);
            await _context.SaveChangesAsync();
            return await Find(entity => entity.Id == subContractor.Id, new List<Expression<Func<SubContractor, object>>> { entity => entity.Approver, entity => entity.PaymentTerm, entity => entity.TypeOfCost });
        }
        catch (Exception)
        {
            throw new Exception("SubContractor not found!");
        }
    }
}
