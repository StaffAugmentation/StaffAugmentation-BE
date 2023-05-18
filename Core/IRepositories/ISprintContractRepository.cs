using Core.ViewModel;

namespace Core.IRepositories
{
    public interface ISprintContractRepository
    {
        Task<List<object>> GetSprintContracts(int UserId, string state, AdvancedSearchViewModel search);
    }
}