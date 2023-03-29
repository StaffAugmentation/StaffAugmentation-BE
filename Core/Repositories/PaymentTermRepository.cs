using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PaymentTermRepository : IPaymentTermRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public PaymentTermRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<PaymentTermViewModel>?> GetPaymentTerm()
    {
        return await _db.PaymentTerm
                .Select(paymentTerm => _mapper.Map<PaymentTermViewModel>(paymentTerm))
                .ToListAsync();
    }
    
    public async Task<PaymentTermViewModel?> GetPaymentTerm(string Id)
    {
        PaymentTermViewModel PaymentTermVM = await _db.PaymentTerm
                    .Where(paymentTerm => paymentTerm.Id == Id)
                    .Select(paymentTerm => _mapper.Map<PaymentTermViewModel>(paymentTerm))
                    .FirstOrDefaultAsync() ?? throw new Exception("PaymentTerm not found!");
        return PaymentTermVM;
    }

    public async Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTermVM) 
    {
        PaymentTerm paymentTerm = _mapper.Map<PaymentTerm>(paymentTermVM);

        await _db.PaymentTerm.AddAsync(paymentTerm);
        await _db.SaveChangesAsync();

        return _mapper.Map<PaymentTermViewModel>(paymentTerm);
    }

    public async Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTermVM)
    {
        PaymentTerm paymentTerm = await _db.PaymentTerm.FindAsync(paymentTermVM.Id) ?? throw new Exception("PaymentTerm not found!");

        paymentTerm.Value = paymentTermVM.Value;

        await _db.SaveChangesAsync();

        return _mapper.Map<PaymentTermViewModel>(paymentTerm);
    }

    public async Task<List<PaymentTermViewModel>?> DeletePaymentTerm(string Id)
    {
        PaymentTerm paymentTerm = await _db.PaymentTerm.FindAsync(Id) ?? throw new Exception("PaymentTerm not found!");

        _db.PaymentTerm.Remove(paymentTerm);
        await _db.SaveChangesAsync();

        return await GetPaymentTerm();
    }

}
