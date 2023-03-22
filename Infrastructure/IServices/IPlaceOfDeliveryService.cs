using Core.ViewModel;

namespace Business.IServices
{
    public interface IPlaceOfDeliveryService
    {
        Task<List<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery();
        Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id);
        Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
        Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
        Task<List<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id);
    }
}
