using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PaymentTermRepository : GenericRepository<PaymentTermViewModel, PaymentTerm, string>, IPaymentTermRepository
{
    public PaymentTermRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
