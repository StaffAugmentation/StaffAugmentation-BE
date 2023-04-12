using AutoMapper;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class CompanyRepository : GenericRepository<CompanyViewModel, Company, int>, ICompanyRepository
{
    public CompanyRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {}

    public override async Task<CompanyViewModel> Create(CompanyViewModel entityVM)
    {
        Company entity = _mapper.Map<Company>(entityVM);
        entity.ApproverId = entityVM.Approver?.Id;

        await _context.Company.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<CompanyViewModel>(entity);
    }

    public override async Task<CompanyViewModel> Update(int key, CompanyViewModel entityVM)
    {
        try
        {
            Company entity = _mapper.Map<Company>(entityVM);
            entity.ApproverId = entityVM.Approver?.Id;
            _context.Company.Update(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<CompanyViewModel>(entity);
        }
        catch (Exception )
        {
            throw new Exception("Company not found !");
        }
    }
}
