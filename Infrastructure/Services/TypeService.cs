using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class TypeService : ITypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypeService(IUnitOfWork unitOfWork) 
        {
            _unitOfWork = unitOfWork;
        }

        public new async Task<IEnumerable<TypeViewModel>?> GetType()
        {
            return await _unitOfWork.Type.GetAll();
        }

        public async Task<TypeViewModel?> GetType(int Id)
        {
            return await _unitOfWork.Type.Find(entity  => entity.Id == Id);
        }

        public async Task<TypeViewModel?> CreateType(TypeViewModel type)
        {
            return await _unitOfWork.Type.Create(type);
        }

        public async Task<TypeViewModel?> UpdateType(TypeViewModel type)
        {
            return await _unitOfWork.Type.Update(type.Id, type);
        }
        public async Task<IEnumerable<TypeViewModel>?> DeleteType(int Id)
        {
            return await _unitOfWork.Type.Delete(Id);
        }
    }
}
