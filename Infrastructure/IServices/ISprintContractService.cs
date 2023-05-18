using Core.ViewModel;

namespace Business.IServices
{
    public interface ISprintContractService
    {
        Task<IEnumerable<object>?> GetSprintContracts(int UserId, string state, AdvancedSearchViewModel search);
        Task<SprintContractViewModel?> GetSprintContract(int Id);
        Task<SprintContractViewModel?> CreateSprintContract(SprintContractViewModel BR);
        Task<SprintContractViewModel?> UpdateSprintContract(SprintContractViewModel BR);
        Task<IEnumerable<SprintContractViewModel>?> DeleteSprintContract(int Id);
    }
}