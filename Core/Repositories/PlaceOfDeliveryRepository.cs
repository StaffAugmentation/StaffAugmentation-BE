using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PlaceOfDeliveryRepository : GenericRepository<PlaceOfDeliveryViewModel, PlaceOfDelivery, int>, IPlaceOfDeliveryRepository
{
    public PlaceOfDeliveryRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
