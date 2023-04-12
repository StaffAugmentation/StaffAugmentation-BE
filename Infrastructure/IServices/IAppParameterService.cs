using Core.ViewModel;

namespace Business.IServices;

public interface IAppParameterService
{
    Task<IEnumerable<AppParameterViewModel>?> GetAppParameter();
    Task<AppParameterViewModel?> GetAppParameter(int Id);
    Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter);
    Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter);
    Task<IEnumerable<AppParameterViewModel>?> DeleteAppParameter(int Id);
}