using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface ITypeOfCostService
    {
        Task<List<TypeOfCostViewModel>?> GetTypeOfCost();
        Task<TypeOfCostViewModel?> GetTypeOfCost(string Id);
        Task<TypeOfCostViewModel?> CreateTypeOfCost(TypeOfCostViewModel typeOfCost);
        Task<TypeOfCostViewModel?> UpdateTypeOfCost(TypeOfCostViewModel typeOfCost);
        Task<List<TypeOfCostViewModel>?> DeleteTypeOfCost(string Id);
    }
}