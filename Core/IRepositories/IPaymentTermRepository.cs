using Core.Model;
using Core.ViewModel;

namespace Core.IRepositories;

public interface IPaymentTermRepository : IGenericRepository<PaymentTermViewModel, PaymentTerm, string>
{
}
