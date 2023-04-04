using Core.ViewModel;

namespace Business.IServices
{
    public interface IAppParameterService
    {
        Task<List<AppParameterViewModel>?> GetAppParameter();
        Task<AppParameterViewModel?> GetAppParameter(int Id);
        Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter);
        Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter);
        Task<List<AppParameterViewModel>?> DeleteAppParameter(int Id);
    }
}