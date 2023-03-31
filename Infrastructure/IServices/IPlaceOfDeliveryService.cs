using Core.ViewModel;

namespace Business.IServices;

public interface IPlaceOfDeliveryService
{
    Task<IEnumerable<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery();
    Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id);
    Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
    Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
    Task<IEnumerable<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id);
}
