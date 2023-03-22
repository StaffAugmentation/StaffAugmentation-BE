using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IPlaceOfDeliveryRepository
    {
        Task<List<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery();
        Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id);
        Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
        Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery);
        Task<List<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id);


    }
}
