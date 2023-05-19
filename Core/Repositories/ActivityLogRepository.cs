using Core.Data;
using Core.IRepositories;
using Core.Model;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories;

public class ActivityLogRepository : IActivityLogRepository
{
    protected DataContext _context;

    public ActivityLogRepository(DataContext context)
    {
        _context = context;
    }

    public void SaveActivityLog(string UserName, string CommentLog, string AppModule)
    {
        try
        {
            if (UserName != null && UserName != "")
            {
                SaActivityLog Activity = new SaActivityLog();
                Activity.Username = UserName;
                Activity.CommentLog = CommentLog;
                Activity.AppModule = AppModule;
                Activity.DateTimeLog = DateTime.Now;
                _context.SaActivityLog.Add(Activity);
                _context.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    // Activity logs        
    public async Task<IEnumerable<Object>> GetActivityLogs(DateTime SearchDateFrom, DateTime SearchDateTo, string UserName)
    {
        try
        {
            SearchDateTo = SearchDateTo.AddDays(1);
            var query = (from Activitylog in _context.SaActivityLog
                         where Activitylog.DateTimeLog >= SearchDateFrom && Activitylog.DateTimeLog <= SearchDateTo
                         select new
                         {
                             Username = Activitylog.Username,
                             DateTimeLog = Activitylog.DateTimeLog,
                             CommentLog = Activitylog.CommentLog,
                             AppModule = Activitylog.AppModule,
                         });

            if (UserName != null && UserName != "")
            {
                query.Where(a => a.Username.ToUpper().Contains(UserName.ToUpper()));
            }
            
            return await query
                .OrderByDescending(x => x.DateTimeLog)
                .ToListAsync(); ;
        }
        catch (Exception)
        {
            throw;
        }
    }
}
