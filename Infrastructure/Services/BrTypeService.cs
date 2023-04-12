using Business.IServices;
using Core.IRepositories;
using Core.ViewModel;

namespace Business.Services;

public class BrTypeService : IBrTypeService
{
    private readonly IUnitOfWork _unitOfWork;

    public BrTypeService (IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<BrTypeViewModel>?> GetBrType()
    {
        return await _unitOfWork.BrType.GetAll();
    }

    public async Task<BrTypeViewModel?> GetBrType(int Id)
    {
        return await _unitOfWork.BrType.Find(entity => entity.Id == Id);
    }

    public async Task<BrTypeViewModel?> CreateBrType(BrTypeViewModel brType)
    {
        return await _unitOfWork.BrType.Create(brType);
    }

    public async Task<BrTypeViewModel?> UpdateBrType(BrTypeViewModel brType)
    {
        return await _unitOfWork.BrType.Update(brType.Id, brType);
    }

    public async Task<IEnumerable<BrTypeViewModel>?> DeleteBrType(int Id)
    {
        return await _unitOfWork.BrType.Delete(Id);
    }

}
