using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ITypeOfCostRepository
    {
        Task<List<TypeOfCostViewModel>?> GetTypeOfCost();
        Task<TypeOfCostViewModel?> GetTypeOfCost(string Id);
        Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost);
        Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost);
        Task<List<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id);
    }
}
