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
        Task<IEnumerable<OERPCodeViewModel>?> GetOERPCode();
        Task<OERPCodeViewModel?> GetOERPCode(int Id);
        Task<OERPCodeViewModel?> CreateOERPCode(OERPCodeViewModel OERPCode);
        Task<OERPCodeViewModel?> UpdateOERPCode(OERPCodeViewModel OERPCode);
        Task<IEnumerable<OERPCodeViewModel>?> DeleteOERPCode(int Id);
    }
}