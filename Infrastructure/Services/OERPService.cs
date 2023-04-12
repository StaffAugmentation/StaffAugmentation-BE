using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services
{
    public class OERPCodeService : IOERPCodeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OERPCodeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<OERPCodeViewModel>?> GetOERPCode()
        {
            return await _unitOfWork.OERPCode.GetAll();
        }

        public async Task<OERPCodeViewModel?> GetOERPCode(int Id)
        {
            return await _unitOfWork.OERPCode.Find(entity => entity.Id == Id);
        }

        public async Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCode)
        {
            return await _unitOfWork.OERPCode.Create(OERPCode);
        }

        public async Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCode)
        {
            return await _unitOfWork.OERPCode.Update(OERPCode.Id, OERPCode);
        }

        public async Task<IEnumerable<OERPCodeViewModel>?> DeleteOERPCode(int Id)
        {
            return await _unitOfWork.OERPCode.Delete(Id);
        }

    }
}
