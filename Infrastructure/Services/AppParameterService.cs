using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class AppParameterService : IAppParameterService
    {
        private readonly IAppParameterRepository repo;
        public AppParameterService(IAppParameterRepository AppParameterRepository)
        {
            repo = AppParameterRepository;
        }

        public async Task<List<AppParameterViewModel>?> GetAppParameter()
        {
            return await repo.GetAppParameter();
        }

        public async Task<AppParameterViewModel?> GetAppParameter(int Id)
        {
            return await repo.GetAppParameter(Id);
        }

        public async Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter)
        {
            return await repo.CreateAppParameter(appParameter);
        }

        public async Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter)
        {
            return await repo.UpdateAppParameter(appParameter);
        }

        public async Task<List<AppParameterViewModel>?> DeleteAppParameter(int Id)
        {
            return await repo.DeleteAppParameter(Id);
        }

    }
}
