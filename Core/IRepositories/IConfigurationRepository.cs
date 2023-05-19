using Core.Model;

namespace Core.IRepositories;

public interface IConfigurationRepository
{
    Task<IEnumerable<Object>> GetTOCOfUser(int UserId);
    Task<List<TypeOfContract>> GetOnlyTypeOfContractUser(int UserId);
    Task<UserParameter?> GetUserConfig(int UserId);
    Task<string> AddTOCUser(List<TypeOfContract> ListTOC, int UserId);
    Task<string> UpdateUserConfig(UserParameter user);
}
