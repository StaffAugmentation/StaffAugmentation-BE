using Core.ViewModel;

namespace Business.IServices;

public interface IPaymentTermService
{
    Task<IEnumerable<PaymentTermViewModel>?> GetPaymentTerm();
    Task<PaymentTermViewModel?> GetPaymentTerm(string Id);
    Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm);
    Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm);
    Task<IEnumerable<PaymentTermViewModel>?> DeletePaymentTerm(string Id);
}