using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface ILevelService
    {
        Task<List<LevelViewModel>?> GetLevel();
        Task<LevelViewModel?> GetLevel(int Id);
        Task<LevelViewModel?> CreateLevel(LevelViewModel level);
        Task<LevelViewModel?> UpdateLevel(LevelViewModel level);
        Task<List<LevelViewModel>?> DeleteLevel(int Id);
    }
}