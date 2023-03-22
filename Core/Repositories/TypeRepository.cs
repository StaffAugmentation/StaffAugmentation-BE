using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;
using Type = Core.Model.Type;

namespace Core.Repositories
{
    public class TypeRepository : ITypeRepository
    {
        private readonly DataContext _db;
        private readonly IMapper _mapper;

        public TypeRepository(DataContext context, IMapper mapper) 
        {
            _db = context;
            _mapper = mapper;
        }

        public new async Task<List<TypeViewModel>?> GetType()
        {
            return await _db.Type.Select(type => _mapper.Map<TypeViewModel>(type)).ToListAsync();
        }

        public async Task<TypeViewModel?> GetType(int Id)
        {
            var dbType = await _db.Type.Where(type => type.Id == Id).Select(type => _mapper.Map<TypeViewModel>(type)).FirstOrDefaultAsync();
            if (dbType == null)
                throw new Exception("Type not found!");
            return dbType;
        }

        public async Task<TypeViewModel?> CreateType(TypeViewModel type)
        {
            var dbType = await _db.Type.AddAsync(_mapper.Map<Type>(type));
            await _db.SaveChangesAsync();

            return _mapper.Map<TypeViewModel>(dbType.Entity);
        }

        public async Task<TypeViewModel?> UpdateType(TypeViewModel type)
        {
            var dbType = await _db.Type.FindAsync(type.Id);
            if (dbType == null)
                throw new Exception("Type not found!");

            dbType.ValueId = type.ValueId;
            dbType.IsActive = type.IsActive;

            await _db.SaveChangesAsync();
            return _mapper.Map<TypeViewModel?>(dbType);
        }

        public async Task<List<TypeViewModel>?> DeleteType(int Id)
        {
            var dbType = await _db.Type.FindAsync(Id);
            if (dbType == null)
                throw new Exception("Type not found!");

            _db.Type.Remove(dbType);
            await _db.SaveChangesAsync();

            return await GetType();
        }
    }
}
