using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
    public class RequestFormStatusRepository : IRequestFormStatusRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public RequestFormStatusRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<RequestFormStatusViewModel>?> GetRequestFormStatus()
        {
            return await _db.RequestFormStatus.Select(RequestFormStatus => _mapper.Map<RequestFormStatusViewModel>(RequestFormStatus)).ToListAsync();
        }

        public async Task<RequestFormStatusViewModel?> GetRequestFormStatus(int Id)
        {
            var dbRequestFormStatus = await _db.RequestFormStatus.Where(RequestFormStatus => RequestFormStatus.Id == Id).Select(RequestFormStatus => _mapper.Map<RequestFormStatusViewModel>(RequestFormStatus)).FirstOrDefaultAsync();
            if (dbRequestFormStatus == null)
                throw new Exception("RequestFormStatus not found!");
            return dbRequestFormStatus;
        }

        public async Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            var dbRequestFormStatus = await _db.RequestFormStatus.AddAsync(_mapper.Map<RequestFormStatus>(RequestFormStatus));
            await _db.SaveChangesAsync();

            return _mapper.Map<RequestFormStatusViewModel>(dbRequestFormStatus.Entity);
        }

        public async Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatus)
        {
            var dbRequestFormStatus = await _db.RequestFormStatus.FindAsync(RequestFormStatus.Id);
            if (dbRequestFormStatus == null)
                throw new Exception("Request From Status not found!");

            dbRequestFormStatus.ValueId = RequestFormStatus.ValueId;
            dbRequestFormStatus.IsActive = RequestFormStatus.IsActive;

            await _db.SaveChangesAsync();
            return _mapper.Map<RequestFormStatusViewModel>(dbRequestFormStatus);
        }

        public async Task<List<RequestFormStatusViewModel>?> DeleteRequestFormStatus(int Id)
        {
            var dbRequestFormStatus = await _db.RequestFormStatus.FindAsync(Id);
            if (dbRequestFormStatus == null)
                throw new Exception("Request From Status not found!");

            _db.RequestFormStatus.Remove(dbRequestFormStatus);
            await _db.SaveChangesAsync();

            return await GetRequestFormStatus();
        }

    }
}
