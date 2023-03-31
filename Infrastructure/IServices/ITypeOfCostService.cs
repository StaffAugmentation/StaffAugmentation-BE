using Core.ViewModel;

namespace Business.IServices;

public interface ITypeOfCostService
{
    Task<IEnumerable<TypeOfCostViewModel>?> GetTypeOfCost();
    Task<TypeOfCostViewModel?> GetTypeOfCost(string Id);
    Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost);
    Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost);
    Task<IEnumerable<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id);
}