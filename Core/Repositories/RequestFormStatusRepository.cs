using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

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
        RequestFormStatusViewModel requestFormStatusVM  = await _db.RequestFormStatus
            .Where(RequestFormStatus => RequestFormStatus.Id == Id)
            .Select(RequestFormStatus => _mapper.Map<RequestFormStatusViewModel>(RequestFormStatus))
            .FirstOrDefaultAsync()  ?? throw new Exception("RequestFormStatus not found!");
        return requestFormStatusVM;
    }

    public async Task<RequestFormStatusViewModel?> CreateRequestFormStatus(RequestFormStatusViewModel RequestFormStatusVM)
    {
        RequestFormStatus requestFormStatus = _mapper.Map<RequestFormStatus>(RequestFormStatusVM);
        
        await _db.RequestFormStatus.AddAsync(requestFormStatus);
        await _db.SaveChangesAsync();

        return _mapper.Map<RequestFormStatusViewModel>(requestFormStatus);
    }

    public async Task<RequestFormStatusViewModel?> UpdateRequestFormStatus(RequestFormStatusViewModel RequestFormStatusVM)
    {
        _ = await _db.RequestFormStatus.FindAsync(RequestFormStatusVM.Id) ?? throw new Exception("Request From Status not found!");

        RequestFormStatus requestFormStatus = _mapper.Map<RequestFormStatus>(RequestFormStatusVM);

        _db.RequestFormStatus.Update(requestFormStatus);
        await _db.SaveChangesAsync();

        return _mapper.Map<RequestFormStatusViewModel>(requestFormStatus);
    }

    public async Task<List<RequestFormStatusViewModel>?> DeleteRequestFormStatus(int Id)
    {
        RequestFormStatus requestFormStatus = await _db.RequestFormStatus.FindAsync(Id) ?? throw new Exception("Request From Status not found!");

        _db.RequestFormStatus.Remove(requestFormStatus);
        await _db.SaveChangesAsync();

        return await GetRequestFormStatus();
    }

}
