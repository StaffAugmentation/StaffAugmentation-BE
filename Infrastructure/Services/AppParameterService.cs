using Business.IServices;
using Core.IRepositories;
using Core.Repositories;
using Core.ViewModel;

namespace Business.Services;

public class AppParameterService : IAppParameterService
{
    private readonly IUnitOfWork _unitOfWork;

    public AppParameterService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<AppParameterViewModel>?> GetAppParameter()
    {
        return await _unitOfWork.AppParameter.GetAll();
    }

    public async Task<AppParameterViewModel?> GetAppParameter(int Id)
    {
        return await _unitOfWork.AppParameter.Find(entity => entity.Id == Id);
    }

    public async Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter)
    {
        return await _unitOfWork.AppParameter.Create(appParameter);
    }

    public async Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter)
    {
        return await _unitOfWork.AppParameter.Update(appParameter.Id, appParameter);
    }

    public async Task<IEnumerable<AppParameterViewModel>?> DeleteAppParameter(int Id)
    {
        return await _unitOfWork.AppParameter.Delete(Id);
    }

}
