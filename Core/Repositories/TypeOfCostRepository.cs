using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using System.Data.Common;

namespace Core.Repositories
{
    public class TypeOfCostRepository : ITypeOfCostRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public TypeOfCostRepository(DataContext context, IMapper mapper)
        {
            _db = context;
            _mapper = mapper;
        }

        public async Task<List<TypeOfCostViewModel>?> GetTypeOfCost()
        {
            return await _db.TypeOfCost.Select(typeOfCost => _mapper.Map<TypeOfCostViewModel>(typeOfCost)).ToListAsync();
        }
        
        public async Task<TypeOfCostViewModel?> GetTypeOfCost(string Id)
        {
            var dbTypeOfCost = await _db.TypeOfCost.Where(typeOfCost => typeOfCost.Id == Id).Select(typeOfCost => _mapper.Map<TypeOfCostViewModel>(typeOfCost)).FirstOrDefaultAsync();
            if (dbTypeOfCost == null)
                throw new Exception("TypeOfCost not found!");
            return dbTypeOfCost; 
        }

        public async Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost) 
        {
            var dbTypeOfCost = await _db.TypeOfCost.AddAsync(_mapper.Map<TypeOfCost>(typeOfCost));
            await _db.SaveChangesAsync();

            return _mapper.Map<TypeOfCostViewModel>(dbTypeOfCost.Entity);
        }

        public async Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost)
        {
            var dbTypeOfCost = await _db.TypeOfCost.FindAsync(typeOfCost.Id);
            if (dbTypeOfCost == null)
                throw new Exception("TypeOfCost not found!");

            dbTypeOfCost.TypeOfCostValue = typeOfCost.TypeOfCostValue;
            
            await _db.SaveChangesAsync();
            return _mapper.Map<TypeOfCostViewModel>(dbTypeOfCost);
        }

        public async Task<List<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id)
        {
            var dbTypeOfCost = await _db.TypeOfCost.FindAsync(Id);
            if (dbTypeOfCost == null)
                throw new Exception("TypeOfCost not found!");

            _db.TypeOfCost.Remove(dbTypeOfCost);
            await _db.SaveChangesAsync();

            return await GetTypeOfCost();
        }

    }
}
