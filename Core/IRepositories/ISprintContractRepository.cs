namespace Core.IRepositories
{
    public interface ISprintContractRepository
    {
        Task<List<object>> GetAll();
    }
}