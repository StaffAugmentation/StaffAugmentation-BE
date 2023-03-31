using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class PlaceOfDeliveryService : IPlaceOfDeliveryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PlaceOfDeliveryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery()
        {
            return await _unitOfWork.PlaceOfDelivery.GetAll();
        }

        public async Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id)
        {
            return await _unitOfWork.PlaceOfDelivery.Find(entity => entity.Id == Id);
        }

        public async Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            return await _unitOfWork.PlaceOfDelivery.Create(PlaceOfDelivery);
        }

        public async Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            return await _unitOfWork.PlaceOfDelivery.Update(PlaceOfDelivery.Id, PlaceOfDelivery);
        }
        public async Task<IEnumerable<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id)
        {
            return await _unitOfWork.PlaceOfDelivery.Delete(Id);
        }
    }
}
