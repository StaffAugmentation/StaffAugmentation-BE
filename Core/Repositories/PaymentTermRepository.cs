using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories
{
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
            return await _db.PaymentTerm.Select(paymentTerm => _mapper.Map<PaymentTermViewModel>(paymentTerm)).ToListAsync();
        }
        
        public async Task<PaymentTermViewModel?> GetPaymentTerm(string Id)
        {
            var dbPaymentTerm = await _db.PaymentTerm.Where(paymentTerm => paymentTerm.Id == Id).Select(paymentTerm => _mapper.Map<PaymentTermViewModel>(paymentTerm)).FirstOrDefaultAsync();
            if (dbPaymentTerm == null)
                throw new Exception("PaymentTerm not found!");
            return dbPaymentTerm; 
        }

        public async Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm) 
        {
            var dbPaymentTerm = await _db.PaymentTerm.AddAsync(_mapper.Map<PaymentTerm>(paymentTerm));
            await _db.SaveChangesAsync();

            return _mapper.Map<PaymentTermViewModel>(dbPaymentTerm.Entity);
        }

        public async Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm)
        {
            var dbPaymentTerm = await _db.PaymentTerm.FindAsync(paymentTerm.Id);
            if (dbPaymentTerm == null)
                throw new Exception("PaymentTerm not found!");

            dbPaymentTerm.PaymentTermValue = paymentTerm.PaymentTermValue;
            
            await _db.SaveChangesAsync();
            return _mapper.Map<PaymentTermViewModel>(dbPaymentTerm);
        }

        public async Task<List<PaymentTermViewModel>?> DeletePaymentTerm(string Id)
        {
            var dbPaymentTerm = await _db.PaymentTerm.FindAsync(Id);
            if (dbPaymentTerm == null)
                throw new Exception("PaymentTerm not found!");

            _db.PaymentTerm.Remove(dbPaymentTerm);
            await _db.SaveChangesAsync();

            return await GetPaymentTerm();
        }

    }
}
