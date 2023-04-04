using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
    public class AppParameterRepository : IAppParameterRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public AppParameterRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<AppParameterViewModel>?> GetAppParameter()
        {
            return await _db.AppParameter.Select(appParameter => _mapper.Map<AppParameterViewModel>(appParameter)).ToListAsync();
        }
        
        public async Task<AppParameterViewModel?> GetAppParameter(int Id)
        {
            var dbAppParameter = await _db.AppParameter.Where(appParameter => appParameter.Id == Id).Select(appParameter => _mapper.Map<AppParameterViewModel>(appParameter)).FirstOrDefaultAsync();
            if (dbAppParameter == null)
                throw new Exception("AppParameter not found!");
            return dbAppParameter; 
        }

        public async Task<AppParameterViewModel?> CreateAppParameter(AppParameterViewModel appParameter) 
        {
            var dbAppParameter = await _db.AppParameter.AddAsync(_mapper.Map<AppParameter>(appParameter));
            await _db.SaveChangesAsync();

            return _mapper.Map<AppParameterViewModel>(dbAppParameter.Entity);
        }

        public async Task<AppParameterViewModel?> UpdateAppParameter(AppParameterViewModel appParameter)
        {
            var dbAppParameter = await _db.AppParameter.FindAsync(appParameter.Id);
            if (dbAppParameter == null)
                throw new Exception("AppParameter not found!");

            dbAppParameter.QTMDailyPriceIsActive = appParameter.QTMDailyPriceIsActive;
            dbAppParameter.TMDailyPriceIsActive = appParameter.TMDailyPriceIsActive;
            dbAppParameter.DaysBeforeDeletingFile = appParameter.DaysBeforeDeletingFile;
            dbAppParameter.SAUrlAppProd = appParameter.SAUrlAppProd;
            dbAppParameter.SAEmail = appParameter.SAEmail;
            dbAppParameter.BrAdvancedSearchDate = appParameter.BrAdvancedSearchDate;
            dbAppParameter.SCAdvancedSearchPeriod = appParameter.SCAdvancedSearchPeriod;
            dbAppParameter.HREmailSubject = appParameter.HREmailSubject;
            dbAppParameter.HREmailText = appParameter.HREmailText;
            dbAppParameter.ConsultantEmailSubject = appParameter.ConsultantEmailSubject;
            dbAppParameter.ConsultantEmailText = appParameter.ConsultantEmailText;
            dbAppParameter.SAVersion = appParameter.SAVersion;
            dbAppParameter.UseLDAPService = appParameter.UseLDAPService;
            dbAppParameter.ContractApprover = appParameter.ContractApprover;
            dbAppParameter.ContractApproverEmail = appParameter.ContractApproverEmail;

        await _db.SaveChangesAsync();
            return _mapper.Map<AppParameterViewModel>(dbAppParameter);
        }

        public async Task<List<AppParameterViewModel>?> DeleteAppParameter(int Id)
        {
            var dbAppParameter = await _db.AppParameter.FindAsync(Id);
            if (dbAppParameter == null)
                throw new Exception("AppParameter not found!");

            _db.AppParameter.Remove(dbAppParameter);
            await _db.SaveChangesAsync();

            return await GetAppParameter();
        }

    }
}
