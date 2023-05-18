using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class SprintContractRepository : ISprintContractRepository
    {
        protected DataContext _context;
        protected IMapper _mapper;
        protected IUnitOfWork _unitOfWork;
        public SprintContractRepository(DataContext context, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _context = context;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public Task<List<object>> GetSprintContracts(int UserId, string state, AdvancedSearchViewModel search)
        {
            try
            {
                List<TypeOfContract> listToc_User = _unitOfWork
                    .ConfigurationRepository
                    .GetOnlyTypeOfContractUser(UserId)
                    .Result;
                var listid = listToc_User.Select(s => s.Id).ToList();
                bool scPTM = state == "PTM";
                var listSprintContract = (from sc in _context.SprintContract
                                          join br in _context.BusinessRequest on sc.RequestNumberId equals br.Id
                                          //join consultant in _context.BR_Consultant on sc.BusinessRequest.id equals consultant.idBR
                                          // join BC in _context.BR_Consultant on br.id equals BC.BRId
                                          //into x
                                          // from BC in x.DefaultIfEmpty()
                                          // join c in _context.Consultant on BC.ConsultantId equals c.idConsultant
                                          //into y
                                          // from c in y.DefaultIfEmpty()
                                          where listid.Contains(sc.BusinessRequest.TypeOfContract.Id) && sc.IsDeleted == false && sc.ScPTM == scPTM && br.BrType.ValueId == state
                                          select new
                                          {
                                              id = sc.Id,
                                              RequestNumber = br.RequestNumber,
                                              idBR = br.Id,
                                              RexOrExt = br.IdSourceBr != null ? (from source in _context.BrSource where source.Id.Equals(br.IdSourceBr) select source.Name).FirstOrDefault() : "",
                                              // Ressource = sc.Ressource,
                                              Departement = br.Department.ValueId,
                                              ContractNumber = br.SpecificContractNumber,
                                              Consultant = (from BRConsultant in _context.BRConsultant
                                                            join BRProfileConsultant in _context.BRProfileConsultant on BRConsultant.Id equals BRProfileConsultant.IdBRConsultant
                                                            join Const in _context.Consultant on BRConsultant.ConsultantId equals Const.IdConsultant
                                                            where BRConsultant.BRId == br.Id
                                                            select new
                                                            {
                                                                ConsultantName = Const.Firstname + " " + Const.Lastname,
                                                                ConsultantCost = BRProfileConsultant.AgreedRate,
                                                                DailyMargin = BRProfileConsultant.ConsCostMargin,
                                                                CurrencyConsCostValue = (from Currency in _context.CurrencyRateParam where Currency.Id == BRProfileConsultant.ConsCostIdCurrency select Currency.CurrencySymbol).FirstOrDefault(),

                                                            }).ToList(),
                                              SalesPrice = (from brprofilr in _context.BRProfile
                                                            join Currency in _context.CurrencyRateParam on brprofilr.IdCurrency equals Currency.Id
                                                             into x
                                                            from Currency in x.DefaultIfEmpty()
                                                            where brprofilr.IdBr == br.Id
                                                            select brprofilr.DailyPrice + " " + Currency.CurrencySymbol).ToList(),
                                              //ConsultantCost = sc.ConsultantCost,
                                              //EverisContract = sc.EverisContract,
                                              RemainingDays = sc.RemainingDays,
                                              //DailyMargin = sc.DailyMargin,

                                              //ManagementFee = sc.ManagementFee,
                                              //MangementFeeInvoice = sc.ManagementFeeInvoiceNumber,
                                              //LoginCreation = sc.LoginCreation,
                                              //LoginUpdate = sc.LoginUpdate,
                                              //DateCreation = sc.DateCreation,
                                              //DateUpdate = sc.DateUpdate,
                                              Profile = (from brprofilr in _context.BRProfile where brprofilr.IdBr == br.Id select brprofilr.Profile.ValueId).ToList(),
                                              PlaceOfDelivery = br.PlaceOfDelivery.ValueId,
                                              TypeOfContract = br.TypeOfContract.ValueId,
                                              dt_RFReceived = br.DtRfReceived,
                                              NumberOfDays = br.NumberOfDays,
                                              PurchaseOrderReferencePay = sc.PurchaseOrderReferencePay,
                                              Level = (from brprofilr in _context.BRProfile where brprofilr.IdBr == br.Id select brprofilr.Level.ValueId).ToList(),
                                              Category = (from brprofilr in _context.BRProfile where brprofilr.IdBr == br.Id select brprofilr.Category.ValueId).ToList(),
                                              ContractStatus = sc.ContractStatus.ValueId,
                                              FWC = br.TypeOfContract.ValueId,
                                              //Company = br.Company.CompanyName,
                                              Company = (from brprofile in _context.BRProfile where brprofile.IdBr == br.Id select new { CompanyName = brprofile.Company.Name }).Distinct().ToList(),
                                              TypeOfContractSC = (from BRConsultant in _context.BRConsultant
                                                                  join BRProfileConsultant in _context.BRProfileConsultant on BRConsultant.Id equals BRProfileConsultant.IdBRConsultant
                                                                  join toc in _context.TypeOfContractSC
                                                                  on BRProfileConsultant.TypeOfContractId equals toc.Id
                                                                  where BRConsultant.BRId == br.Id
                                                                  select toc.ValueId).ToList(),
                                              Consultant_contract_status = (from brc in _context.BRConsultant
                                                                            join BRProfileConsultant in _context.BRProfileConsultant on brc.Id equals BRProfileConsultant.IdBRConsultant
                                                                            join status in _context.ConsultantContractStatus on BRProfileConsultant.IdConsultantContractStatus equals status.Id
                                                                            where brc.BRId == br.Id
                                                                            select status.ValueId).Distinct().ToList(),
                                              AdditionalBudget = br.AdditionalBudget,
                                              OERPProjectCode = _context.SprintContractOERPCode.Where(x => x.IdSC == sc.Id).Select(x => x.OERPProjectCode).ToList()
                                              //CurrencySalesPriceValue = (from Currency in _context.CurrencyRateParams join brprofilr in _context.BR_Profile on Currency.id equals brprofilr.idCurrency
                                              //                           select Currency.CurrencySymbol).FirstOrDefault(),

                                          }
                                ).OrderByDescending(sc => sc.id).AsQueryable();

                if (search != null)
                {
                    if (search.RequestNumber != null)
                    {
                        listSprintContract = listSprintContract.Where(SC => SC.RequestNumber.ToUpper().Contains(search.RequestNumber.ToUpper()));
                    }
                    if (search.AdvancedSearchList != null)
                    {
                        listSprintContract = listSprintContract.Where(SC => search.AdvancedSearchList.Contains(SC.TypeOfContract));
                    }
                    if (search.AdvancedSearchDate != null)
                    {
                        listSprintContract = listSprintContract.Where(SC => search.AdvancedSearchDate.Value.Date <= SC.dt_RFReceived.Value.Date );
                    }
                }
                var result = listSprintContract.Select(sc => (object)sc).ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}