using AutoMapper;
using Core.Data;
using Core.IRepositories;
using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class ConfigurationRepository : IConfigurationRepository
{
    protected DataContext _context;
    protected IMapper _mapper;

    public ConfigurationRepository(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<string> AddTOCUser(List<TypeOfContract> ListTOC, int UserId)
    {
        throw new NotImplementedException();
    }

    public async Task<List<TypeOfContract>> GetOnlyTypeOfContractUser(int UserId)
    {
        var listTOC = (from utoc in _context.UsersTypeOfContract
                       join toc in _context.TypeOfContract on utoc.TypeOfContract.Id equals toc.Id
                       where utoc.User.UserId == UserId
                       select toc ).ToList();
        return listTOC;
    }

    public async Task<IEnumerable<object>> GetTOCOfUser(int UserId)
    {
        throw new NotImplementedException();
    }

    public async Task<UserParameter> GetUserConfig(int UserId)
    {
        throw new NotImplementedException();
    }

    public async Task<string> UpdateUserConfig(UserParameter user)
    {
        throw new NotImplementedException();
    }
}
