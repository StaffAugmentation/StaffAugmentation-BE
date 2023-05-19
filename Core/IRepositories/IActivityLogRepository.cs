namespace Core.IRepositories;

public interface IActivityLogRepository
{
    void SaveActivityLog(string UserName, string CommentLog, string AppModule);
    Task<IEnumerable<Object>> GetActivityLogs(DateTime SearchDateFrom, DateTime SearchDateTo, string UserName);
}
