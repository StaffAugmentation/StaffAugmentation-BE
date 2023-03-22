using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class TypeOfCostService : ITypeOfCostService
    {
        private readonly ITypeOfCostRepository repo;
        public TypeOfCostService(ITypeOfCostRepository TypeOfCostRepository)
        {
            repo = TypeOfCostRepository;
        }

        public async Task<List<TypeOfCostViewModel>?> GetTypeOfCost()
        {
            return await repo.GetTypeOfCost();
        }

        public async Task<TypeOfCostViewModel?> GetTypeOfCost(string Id)
        {
            return await repo.GetTypeOfCost(Id);
        }

        public async Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost)
        {
            return await repo.CreateTypeOfCost(typeOfCost);
        }

        public async Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost)
        {
            return await repo.UpdateTypeOfCost(typeOfCost);
        }

        public async Task<List<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id)
        {
            return await repo.DeleteTypeOfCost(Id);
        }

    }
}
