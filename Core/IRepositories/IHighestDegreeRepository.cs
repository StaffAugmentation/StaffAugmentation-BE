using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IHighestDegreeRepository
    {
        Task<List<HighestDegreeViewModel>?> GetHighestDegree();
        Task<HighestDegreeViewModel?> GetHighestDegree(int Id);
        Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree);
        Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree);
        Task<List<HighestDegreeViewModel>?> DeleteHighestDegree(int Id);
    }
}
