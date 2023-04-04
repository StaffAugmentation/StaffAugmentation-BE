using Core.ViewModel;

namespace Core.IRepositories
{
    public interface IAppParameterRepository
    {
        Task<List<AppParameterViewModel>?> GetAppParameter();
        Task<AppParameterViewModel?> GetAppParameter(int Id);
        Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter);
        Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter);
        Task<List<AppParameterViewModel>?> DeleteAppParameter(int Id);
    }
}
