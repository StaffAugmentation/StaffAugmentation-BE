using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Core.IRepositories;
using Core.Data;
using Core.ViewModel;
using Core.Model;

namespace Core.Repositories;

public class OERPCodeRepository : GenericRepository<OERPCodeViewModel, OERPCode, int>, IOERPCodeRepository
{
    public OERPCodeRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
