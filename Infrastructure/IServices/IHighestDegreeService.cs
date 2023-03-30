using Core.ViewModel;

namespace Business.IServices;

public interface IHighestDegreeService
{
    Task<IEnumerable<HighestDegreeViewModel>?> GetHighestDegree();
    Task<HighestDegreeViewModel?> GetHighestDegree(int Id);
    Task<HighestDegreeViewModel?> CreateHighestDegree(HighestDegreeViewModel HighestDegree);
    Task<HighestDegreeViewModel?> UpdateHighestDegree(HighestDegreeViewModel HighestDegree);
    Task<IEnumerable<HighestDegreeViewModel>?> DeleteHighestDegree(int Id);
}
