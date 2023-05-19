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

    public async Task<List<TypeOfContract>> GetOnlyTypeOfContractUser(int UserId)
    {
        var listTOC = await (from utoc in _context.UserTypeOfContract
                       join toc in _context.TypeOfContract on utoc.TypeOfContract.Id equals toc.Id
                       where utoc.User.UserId == UserId
                       select toc ).ToListAsync();
        return listTOC;
    }

    public async Task<IEnumerable<object>> GetTOCOfUser(int UserId)
    {
        return await (from utoc in _context.UserTypeOfContract
                      where utoc.User.UserId == UserId
                      select new
                      {
                          Id = utoc.Id,
                          TypeOfContract = utoc.TypeOfContract.ValueId,
                          TypeOfContractId = utoc.TypeOfContractId
                      }
                 ).ToListAsync();
    }

    public async Task<UserParameter?> GetUserConfig(int UserId)
    {
        try
        {
            return await _context.UserParameter
                .Where(ur => ur.UserId == UserId)
                .FirstOrDefaultAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<string> AddTOCUser(List<TypeOfContract> ListTOC, int UserId)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                var lisTOCOfUser = await (from utoc in _context.UserTypeOfContract where utoc.User.UserId == UserId select utoc).ToListAsync();
                if (lisTOCOfUser.Count != 0)
                {
                    foreach (var v in lisTOCOfUser)
                    {
                        _context.UserTypeOfContract.Remove(v);
                    }
                    _context.SaveChanges();
                }
                if (ListTOC != null)
                {
                    foreach (var value in ListTOC)
                    {
                        UserTypeOfContract userTOC = new UserTypeOfContract();
                        userTOC.TypeOfContractId = value.Id;
                        userTOC.Id = UserId;
                        _context.UserTypeOfContract.Add(userTOC);
                    }
                    _context.SaveChanges();
                }
                transaction.Commit();
                return "ConstantsMessage.MESSAGE_P_SUCCESS_ADD";
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }

    public async Task<string> UpdateUserConfig(UserParameter user)
    {
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                UserParameter? config = await GetUserConfig(user.UserId);
                if (config != null)
                {
                    _context.UserParameter.Remove(config);
                    _context.Entry(config).State = EntityState.Deleted;
                    _context.SaveChanges();
                }
                _context.UserParameter.Add(user);
                _context.SaveChanges();
                transaction.Commit();
                return "ConstantsMessage.MESSAGE_USER_CONFIG_SUCCESS_UPD";
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}
