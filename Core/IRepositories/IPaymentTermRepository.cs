using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IPaymentTermRepository
    {
        Task<List<PaymentTermViewModel>?> GetPaymentTerm();
        Task<PaymentTermViewModel?> GetPaymentTerm(string Id);
        Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm);
        Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm);
        Task<List<PaymentTermViewModel>?> DeletePaymentTerm(string Id);
    }
}
