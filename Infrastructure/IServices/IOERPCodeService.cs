using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface IOERPCodeService
    {
        Task<List<OERPCodeViewModel>?> GetOERPCode();
        Task<OERPCodeViewModel?> GetOERPCode(int Id);
        Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCode);
        Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCode);
        Task<List<OERPCodeViewModel>?> DeleteOERPCode(int Id);
    }
}