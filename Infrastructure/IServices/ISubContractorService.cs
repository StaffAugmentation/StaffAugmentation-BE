using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model;
using Core.ViewModel;

namespace Business.IServices
{
    public interface ISubContractorService
    {
        Task<List<SubContractorViewModel>?> GetSubContractor();
        Task<SubContractorViewModel?> GetSubContractor(int Id);
        Task<SubContractorViewModel?> CreateSubContractor(SubContractorViewModel subContractor);
        Task<SubContractorViewModel?> UpdateSubContractor(SubContractorViewModel subContractor);
        Task<List<SubContractorViewModel>?> DeleteSubContractor(int Id);
    }
}