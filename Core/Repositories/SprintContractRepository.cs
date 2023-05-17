using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class SprintContractRepository : ISprintContractRepository
    {
        protected DataContext _context;
        protected IMapper _mapper;
        public SprintContractRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<object>> GetAll()
        {
            //return base.GetAll(includes, criteria, orderDirection, order);
            var offset = Math.Abs(TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Hours);
            //LocalUTC = (LocalUTC / 60) + offset;
            var LocalUTC = 0;
            //using (StaffAugmentationConnection db = new StaffAugmentationConnection())
            //{
            //_context.Database.SetCommandTimeout = 300;
            // }
            //Consultant consultant = new Consultant();
            //Candidates cand = new Candidates();
            //var listid = listToc_User.Select(s => s.id).ToList();
            var ptx = (from br in _context.BusinessRequest
                       //where listid.Contains(br.TypeOfContract.id) && br.isDeleted == false
                       select new
                       {
                           Id = br.Id,
                           //Status = br.StatusBR.ValueId,
                           //StatusId = br.StatusBR.id,
                           dt_Deadline = br.DtDeadline != null ? br.DtDeadline.Value.AddHours(LocalUTC) : br.DtDeadline,
                           RequestNumber = br.RequestNumber,
                           //Profile = (from profile in _context.BR_Profile where profile.BusinessRequest.id == br.id && profile.Profile.valueId!="FPControl" select profile.Profile.valueId).ToList(),
                           //Level = (from level in _context.BR_Profile where level.BusinessRequest.id == br.id && level.Level.valueId != "FPControl"  select level.Level.valueId).ToList(),
                           Type = br.Type != null ? br.Type.ValueId : null,
                           TypeBR = br.BrType != null ? br.BrType.ValueId : null,
                           TypeOfContract = br.TypeOfContract.ValueId,
                           //Level = br.Level.valueId,
                           PlaceOfDelivery = br.PlaceOfDelivery.ValueId,
                           //Category = (from category in _context.BR_Profile where category.BusinessRequest.id == br.id && category.Profile.valueId != "FPControl"  select category.Category.valueId).ToList(),
                           Max_End_Date = br.MaxEndDate != null ? br.MaxEndDate.Value.AddHours(LocalUTC) : br.MaxEndDate,
                           Number_Of_Days = br.NumberOfDays,
                           //Other_Expertise_Required = (from other in _context.BR_Profile where other.BusinessRequest.id == br.id select other.Other_Expertise_Required).ToList(),
                           Project_Start_Date = br.ProjectStartDate != null ? br.ProjectStartDate.Value.AddHours(LocalUTC) : br.ProjectStartDate,
                           Proximity = br.Proximity,
                           SourceBR = br.BrSource != null ? br.BrSource.Name : null,
                           //Revenue = br.Revenue,
                           Specific_Contract_Number = br.SpecificContractNumber,
                           TOTAL_man_days = br.TotalManDays,
                           Total_Price = br.TotalPrice,
                           //Validity_Date = br.Validity_Date != null ? System.Data.Entity.DbFunctions.AddHours(br.Validity_Date, LocalUTC) : br.Validity_Date,
                           //Bank_Account = br.Bank_Account,
                           //Company = br.idCompany,
                           //CompanyName = br.Company.CompanyName,//Here
                           Contact_Name = br.ContactName,
                           //Daily_Price = (from profile in _context.BR_Profile where profile.BusinessRequest.id == br.id && profile.Profile.valueId != "FPControl" select profile.DailyPrice).ToList(),
                           Department = br.Department != null ? br.Department.ValueId : null,
                           DG_Email = br.DgEmail,
                           dt_Acknowledgement = br.DtAcknowledgement != null ? br.DtAcknowledgement.Value.AddHours(LocalUTC) : br.DtAcknowledgement,
                           // dt_FO_Is_Submitted_To_Customer = br.dt_FO_Is_Submitted_To_Customer,
                           dt_ProposalDeadline = br.DtProposalDeadline != null ?  br.DtProposalDeadline.Value.AddHours(LocalUTC) : br.DtProposalDeadline,
                           //dt_Proposal_Is_Submitted_To_Customer = br.dt_Proposal_Is_Submitted_To_Customer,
                           dt_RFReceived = br.DtRfReceived != null ? br.DtRfReceived.Value.AddHours(LocalUTC) : br.DtRfReceived,
                           dt_SC_Is_Received = br.DtScIsReceived != null ? br.DtScIsReceived.Value.AddHours(LocalUTC) : br.DtScIsReceived,
                           dt_SC_Is_signed = br.DtScIsSigned != null ? br.DtScIsSigned.Value.AddHours(LocalUTC) : br.DtScIsSigned,
                           //  dt_SentToCustomer = br.dt_SentToCustomer,
                           Expected_Project_Start_Date = br.ExpectedProjectStartDate != null ? br.ExpectedProjectStartDate.Value.AddHours(LocalUTC) : br.ExpectedProjectStartDate,
                           DateCreation = br.DateCreation != null ? br.DateCreation.Value.AddHours(LocalUTC) : br.DateCreation,
                           //dt_ChangeOffer = br.dt_ChangeOffer,
                           //dt_ChangeOffer_Is_Submitted_To_Customer = br.dt_ChangeOffer_Is_Submitted_To_Customer,
                           //Final_Candidate_FN = br.Final_Candidate_FN,
                           //Final_Candidate_LN = br.Final_Candidate_LN,
                           //Final_Candidate = br.Final_Candidate_FN + " " + br.Final_Candidate_LN,
                           //Final_Candidate_Email = br.Final_Candidate_Email,
                           // RequestFormStatus = br.RequestFormStatus.ValueId,
                           Ext_Max_End_Date = br.ExtMaxEndDate != null ? br.ExtMaxEndDate.Value.AddHours(LocalUTC) : br.ExtMaxEndDate,
                           TechnicalContact = br.TechnicalContact,
                           OpenIntendedComment = br.OpenIntendedComment,
                           NextActionDate = br.NextActionDate != null ? br.NextActionDate.Value.AddHours(LocalUTC) : br.NextActionDate,
                           //  dt_FO_Deadline = br.dt_FO_Deadline,
                           SpecificClientCode = br.SpecificClientCode,
                           //Penalty = br.Penalty,
                           //PenaltyComment = br.PenaltyComment,
                           isSCCreated = br.IsScCreated,
                           AdditionalBudget = br.AdditionalBudget,
                           Consultant = (from BRConsultant in _context.BRConsultant
                                         join Const in _context.Consultant
                                         on BRConsultant.ConsultantId equals Const.IdConsultant
                                         where BRConsultant.BRId == br.Id
                                         select Const.Firstname + " " + Const.Lastname).ToList(),
                           DataProfile = (from Brprofile in _context.BRProfile
                                          where Brprofile.BusinessRequest.Id == br.Id
                                          select new
                                          {
                                              Profile = Brprofile.Profile.ValueId,
                                              Level = Brprofile.Level.ValueId,
                                              Category = Brprofile.Category != null ? Brprofile.Category.ValueId : string.Empty,
                                              Other_Expertise_Required = Brprofile.OtherExpertiseRequired,
                                              Daily_Price = Brprofile.DailyPrice,
                                              dt_FO_Is_Submitted_To_Customer = Brprofile.DtFoIsSubmittedToCustomer != null ? Brprofile.DtFoIsSubmittedToCustomer.Value.AddHours(LocalUTC) : Brprofile.DtFoIsSubmittedToCustomer,
                                              dt_Proposal_Is_Submitted_To_Customer = Brprofile.DtProposalIsSubmittedToCustomer != null ? Brprofile.DtProposalIsSubmittedToCustomer.Value.AddHours(LocalUTC) : Brprofile.DtProposalIsSubmittedToCustomer,
                                              dt_SentToCustomer = Brprofile.DtSentToCustomer != null ? Brprofile.DtSentToCustomer.Value.AddHours(LocalUTC) : Brprofile.DtSentToCustomer,
                                              RequestFormStatus = Brprofile.IdRequestFromStatus != null ? (from req in _context.RequestFormStatus where req.Id == Brprofile.IdRequestFromStatus select req.Value).FirstOrDefault() : string.Empty,
                                              CurrencySalesPrice = (from Currency in _context.CurrencyRateParam
                                                                    where Currency.Id == Brprofile.IdCurrency
                                                                    select Currency.CurrencySymbol).FirstOrDefault(),
                                              Service_Level_Category = Brprofile.IdServiceLevelCategory != null ? (from serv in _context.ServiceLevelCategory where serv.Id == Brprofile.IdServiceLevelCategory select serv.ValueId).FirstOrDefault() : "",
                                              CompanyName = Brprofile.IdCompany != null ? (from cmp in _context.Company where cmp.Id == Brprofile.IdCompany select cmp.Name).FirstOrDefault() : "",
                                              Validity_Date = Brprofile.ValidityDate != null ? Brprofile.ValidityDate.Value.AddHours(LocalUTC) : Brprofile.ValidityDate,
                                              Bank_Account = Brprofile.BankAccount,
                                          }).ToList(),
                           Normal_Performance = br.TypeOfContract.NormalPerformance,
                           dt_AcknowledgementDeadline = br.DtAcknowledgementDeadline != null ? br.DtAcknowledgementDeadline.Value.AddHours(LocalUTC) : br.DtAcknowledgementDeadline,
                           GeneralComment = br.GeneralComment
                       })
                       .OrderByDescending(sc => sc.NextActionDate.HasValue)
                       .ThenBy(sc => sc.NextActionDate)
                       .ThenByDescending(sc => sc.Id).AsQueryable()
                       .Select(sc => (object)sc);
            //if (Search != null)
            //{
            //    if (Search.RequestNumber != null)
            //    {

            //        ptx = ptx.Where(p => p.Request_number.ToUpper().Contains(Search.RequestNumber.ToUpper()));

            //    }
            //    if (Search.AdvancedSearchList != null)
            //    {
            //        ptx = ptx.Where(p => Search.AdvancedSearchList.Contains(p.StatusId));
            //    }
            //    if (Search.AdvancedSearchDate != null)
            //    {

            //        ptx = ptx.Where(b => b.dt_RFReceived != null && System.Data.Entity.DbFunctions.TruncateTime(b.dt_RFReceived) >= System.Data.Entity.DbFunctions.TruncateTime(Search.AdvancedSearchDate));
            //    }
            //    if (Search.AdvancedSearchListFWC != null)
            //    {
            //        ptx = ptx.Where(p => Search.AdvancedSearchListFWC.Contains(p.TypeOfContract));
            //    }
            //}

            var result = ptx.ToListAsync();
            return result;
        }
    }
}