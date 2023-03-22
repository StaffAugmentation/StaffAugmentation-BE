using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface IPaymentTermService
    {
        Task<List<PaymentTermViewModel>?> GetPaymentTerm();
        Task<PaymentTermViewModel?> GetPaymentTerm(string Id);
        Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm);
        Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm);
        Task<List<PaymentTermViewModel>?> DeletePaymentTerm(string Id);
    }
}