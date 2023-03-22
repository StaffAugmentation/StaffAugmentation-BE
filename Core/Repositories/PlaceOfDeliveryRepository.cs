using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories
{
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
            var dbPlaceOfDelivery = await _db.PlaceOfDelivery.Where(PlaceOfDelivery => PlaceOfDelivery.Id == Id).Select(PlaceOfDelivery => _mapper.Map<PlaceOfDeliveryViewModel>(PlaceOfDelivery)).FirstOrDefaultAsync();
            if (dbPlaceOfDelivery == null)
                throw new Exception("PlaceOfDelivery not found!");
            return dbPlaceOfDelivery;
        }

        public async Task<PlaceOfDeliveryViewModel?> CreatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            var dbPlaceOfDelivery = await _db.PlaceOfDelivery.AddAsync(_mapper.Map<PlaceOfDelivery>(PlaceOfDelivery));
            await _db.SaveChangesAsync();

            return _mapper.Map<PlaceOfDeliveryViewModel>(dbPlaceOfDelivery.Entity);
        }

        public async Task<PlaceOfDeliveryViewModel?> UpdatePlaceOfDelivery(PlaceOfDeliveryViewModel PlaceOfDelivery)
        {
            var dbPlaceOfDelivery = await _db.PlaceOfDelivery.FindAsync(PlaceOfDelivery.Id);
            if (dbPlaceOfDelivery == null)
                throw new Exception("PlaceOfDelivery not found!");

            dbPlaceOfDelivery.ValueId = PlaceOfDelivery.ValueId;
            dbPlaceOfDelivery.IsActive = PlaceOfDelivery.IsActive;

            await _db.SaveChangesAsync();
            return _mapper.Map<PlaceOfDeliveryViewModel?>(dbPlaceOfDelivery);
        }

        public async Task<List<PlaceOfDeliveryViewModel>?> DeletePlaceOfDelivery(int Id)
        {
            var dbPlaceOfDelivery = await _db.PlaceOfDelivery.FindAsync(Id);
            if (dbPlaceOfDelivery == null)
                throw new Exception("PlaceOfDelivery not found!");

            _db.PlaceOfDelivery.Remove(dbPlaceOfDelivery);
            await _db.SaveChangesAsync();

            return await GetPlaceOfDelivery();
        }
    }
}
