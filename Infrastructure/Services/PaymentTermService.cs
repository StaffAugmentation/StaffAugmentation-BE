using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class PaymentTermService : IPaymentTermService
    {
        private readonly IPaymentTermRepository repo;
        public PaymentTermService(IPaymentTermRepository PaymentTermRepository)
        {
            repo = PaymentTermRepository;
        }

        public async Task<List<PaymentTermViewModel>?> GetPaymentTerm()
        {
            return await repo.GetPaymentTerm();
        }

        public async Task<PaymentTermViewModel?> GetPaymentTerm(string Id)
        {
            return await repo.GetPaymentTerm(Id);
        }

        public async Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm)
        {
            return await repo.CreatePaymentTerm(paymentTerm);
        }

        public async Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm)
        {
            return await repo.UpdatePaymentTerm(paymentTerm);
        }

        public async Task<List<PaymentTermViewModel>?> DeletePaymentTerm(string Id)
        {
            return await repo.DeletePaymentTerm(Id);
        }

    }
}
