using Business.IServices;
using Core.IRepositories;
using Core.Model;
using Core.ViewModel;
using System.Linq.Expressions;

namespace Business.Services
{
    public class PTMOwnerService : IPTMOwnerService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PTMOwnerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<PTMOwnerViewModel>?> GetPTMOwner()
        {
            return await _unitOfWork.PTMOwner.GetAll(new List<Expression<Func<PTMOwner, object>>> { entity => entity.Approver });
        }

        public async Task<PTMOwnerViewModel?> GetPTMOwner(int Id)
        {
            return await _unitOfWork.PTMOwner.Find(entity => entity.Id == Id, new List<Expression<Func<PTMOwner, object>>> { entity => entity.Approver });
        }

        public async Task<PTMOwnerViewModel?> CreatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            return await _unitOfWork.PTMOwner.Create(PTMOwner);
        }

        public async Task<PTMOwnerViewModel?> UpdatePTMOwner(PTMOwnerViewModel PTMOwner)
        {
            return await _unitOfWork.PTMOwner.Update(PTMOwner.Id, PTMOwner);
        }

        public async Task<IEnumerable<PTMOwnerViewModel>?> DeletePTMOwner(int Id)
        {
            return await _unitOfWork.PTMOwner.Delete(Id);
        }

    }
}
