using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Core.Repositories;

public class BrTypeRepository : GenericRepository<BrTypeViewModel, BrType, int>, IBrTypeRepository
{
    public BrTypeRepository(DataContext context, IMapper mapper) : base(context, mapper)
    {
    }
}
