using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class TypeOfCostService : ITypeOfCostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypeOfCostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TypeOfCostViewModel>?> GetTypeOfCost()
        {
            return await _unitOfWork.TypeOfCost.GetAll();
        }

        public async Task<TypeOfCostViewModel?> GetTypeOfCost(string Id)
        {
            return await _unitOfWork.TypeOfCost.Find(entity => entity.Id == Id);
        }

        public async Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost)
        {
            return await _unitOfWork.TypeOfCost.Create(typeOfCost);
        }

        public async Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost)
        {
            return await _unitOfWork.TypeOfCost.Update(typeOfCost.Id, typeOfCost);
        }

        public async Task<IEnumerable<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id)
        {
            return await _unitOfWork.TypeOfCost.Delete(Id);
        }

    }
}
