using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PlaceOfDeliveryRepository : IPlaceOfDeliveryRepository
{
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    public PlaceOfDeliveryRepository(DataContext context, IMapper mapper)
    {
        _db = context;
        _mapper = mapper;
    }

    public async Task<List<PlaceOfDeliveryViewModel>?> GetPlaceOfDelivery()
    {
        return await _db.PlaceOfDelivery.Select(PlaceOfDelivery => _mapper.Map<PlaceOfDeliveryViewModel>(PlaceOfDelivery)).ToListAsync();
    }

    public async Task<PlaceOfDeliveryViewModel?> GetPlaceOfDelivery(int Id)
    {
        PlaceOfDeliveryViewModel placeOfDeliveryVM = await _db.PlaceOfDelivery
                                    .Where(PlaceOfDelivery => PlaceOfDelivery.Id == Id)
                                    .Select(PlaceOfDelivery => _mapper.Map<PlaceOfDeliveryViewModel>(PlaceOfDelivery))
                                    .FirstOrDefaultAsync() ?? throw new Exception("PlaceOfDelivery not found!");
        return placeOfDeliveryVM;
    }

    public async Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel placeOfDeliveryVM)
    {
        PlaceOfDelivery placeOfDelivery = _mapper.Map<PlaceOfDelivery>(placeOfDeliveryVM);

        await _db.PlaceOfDelivery.AddAsync(placeOfDelivery);
        await _db.SaveChangesAsync();

        return _mapper.Map<PlaceOfDeliveryViewModel>(placeOfDelivery);
    }

    public async Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDeliveryVM)
    {
        _ = await _db.PlaceOfDelivery.FindAsync(PlaceOfDeliveryVM.Id) ?? throw new Exception("PlaceOfDelivery not found!");

        PlaceOfDelivery placeOfDelivery = _mapper.Map<PlaceOfDelivery>(PlaceOfDeliveryVM);

        _db.PlaceOfDelivery.Update(placeOfDelivery);
        await _db.SaveChangesAsync();

        return _mapper.Map<PlaceOfDeliveryViewModel?>(placeOfDelivery);
    }

    public async Task<List<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id)
    {
        PlaceOfDelivery placeOfDelivery = await _db.PlaceOfDelivery.FindAsync(Id) ?? throw new Exception("PlaceOfDelivery not found!");

        _db.PlaceOfDelivery.Remove(placeOfDelivery);
        await _db.SaveChangesAsync();

        return await GetPlaceOfDelivery();
    }
}
