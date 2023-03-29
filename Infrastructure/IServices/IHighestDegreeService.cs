using Core.ViewModel;

namespace Business.IServices
{
    public interface IHighestDegreeService
    {
        Task<List<HighestDegreeViewModel>?> GetHighestDegree();
        Task<HighestDegreeViewModel?> GetHighestDegree(int Id);
        Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree);
        Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree);
        Task<List<HighestDegreeViewModel>?> DeleteHighestDegree(int Id);
    }
}
