using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class PaymentTermService : IPaymentTermService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PaymentTermService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PaymentTermViewModel>?> GetPaymentTerm()
        {
            return await _unitOfWork.PaymentTerm.GetAll();
        }

        public async Task<PaymentTermViewModel?> GetPaymentTerm(string Id)
        {
            return await _unitOfWork.PaymentTerm.Find(payment => payment.Id == Id);
        }

        public async Task<PaymentTermViewModel?> CreatePaymentTerm(PaymentTermViewModel paymentTerm)
        {
            return await _unitOfWork.PaymentTerm.Create(paymentTerm);
        }

        public async Task<PaymentTermViewModel?> UpdatePaymentTerm(PaymentTermViewModel paymentTerm)
        {
            return await _unitOfWork.PaymentTerm.Update(paymentTerm.Id, paymentTerm);
        }

        public async Task<IEnumerable<PaymentTermViewModel>?> DeletePaymentTerm(string Id)
        {
            return await _unitOfWork.PaymentTerm.Delete(Id);
        }

    }
}
