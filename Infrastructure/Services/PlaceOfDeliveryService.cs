using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class PlaceOfDeliveryService : IPlaceOfDeliveryService
    {
        private readonly IPlaceOfDeliveryRepository repo;
        public PlaceOfDeliveryService(IPlaceOfDeliveryRepository PlaceOfDeliveryrepository)
        {
            repo = PlaceOfDeliveryrepository;
        }

        public async Task<List<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery()
        {
            return await repo.GetPlaceOfDelivery();
        }

        public async Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id)
        {
            return await repo.GetPlaceOfDelivery(Id);
        }

        public async Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            return await repo.CreatePlaceOfDelivery(PlaceOfDelivery);
        }

        public async Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            return await repo.UpdatePlaceOfDelivery(PlaceOfDelivery);
        }
        public async Task<List<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id)
        {
            return await repo.DeletePlaceOfDelivery(Id);
        }
    }
}
