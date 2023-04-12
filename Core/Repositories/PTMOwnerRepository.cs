using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class PTMOwnerRepository : GenericRepository<PTMOwnerViewModel, PTMOwner, int>, IPTMOwnerRepository
{
    public PTMOwnerRepository(DataContext context, IMapper mapper) : base(context, mapper)
    { }

    public override async Task<PTMOwnerViewModel> Create(PTMOwnerViewModel PTMOwnerVM)
    {
        PTMOwner ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
        ptmOwner.ApproverId = PTMOwnerVM.Approver?.Id;

        await _context.PTMOwner.AddAsync(ptmOwner);
        await _context.SaveChangesAsync();

        return await Find(entity => entity.Id == ptmOwner.Id);
    }

    public override async Task<PTMOwnerViewModel> Update(int key, PTMOwnerViewModel PTMOwnerVM)
    {
        try
        {
            PTMOwner ptmOwner = _mapper.Map<PTMOwner>(PTMOwnerVM);
            ptmOwner.ApproverId = PTMOwnerVM.Approver?.Id;
            _context.PTMOwner.Update(ptmOwner);
            await _context.SaveChangesAsync();
            return _mapper.Map<PTMOwnerViewModel>(ptmOwner);
        }
        catch (Exception)
        {
            throw new Exception("PTMOwner not found !");
        }
    }
}
