using AutoMapper;
using Core.Data;
using Core.Model;
using Core.ViewModel;
using Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Security.AccessControl;
using Shared.Utility;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Core.Repositories;

public class BusinessRequestRepository : IBusinessRequestRepository
{
    protected DateTime CurrentDate = DateTime.Now;
    protected DataContext _context;
    protected IMapper _mapper;
    protected IUnitOfWork _unitOfWork;
    string SADocs = "";
    public List<char> characters = new List<char>(new char[] { '/', '*', '>', '<', '|', ':', '"', '\'' });
    public BusinessRequestRepository(DataContext context, IMapper mapper, IUnitOfWork unitOfWork)
    {
        _context = context;
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }
    public async Task<List<object>?> GetBusinessRequests(int UserId, AdvancedSearchViewModel Search, int LocalUTC)
    {
        try
        {
            List<TypeOfContract> listToc_User = _unitOfWork
                    .ConfigurationRepository
                    .GetOnlyTypeOfContractUser(UserId)
                    .Result;
            var offset = Math.Abs(TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Hours);
            LocalUTC = (LocalUTC / 60) + offset;
            Consultant consultant = new Consultant();
            var listTOCId = listToc_User.Select(s => s.Id).ToList();
            var ptx = (from br in _context.BusinessRequest
                       where listTOCId.Contains(br.TypeOfContract.Id) && br.IsDeleted == false
                       select new
                       {
                           Id = br.Id,
                           Status = br.StatusBr.ValueId,
                           StatusId = br.StatusBr.Id,
                           dt_Deadline = br.DtDeadline != null ? br.DtDeadline.Value.AddHours(LocalUTC) : br.DtDeadline,
                           RequestNumber = br.RequestNumber,
                           Type = br.Type != null ? br.Type.ValueId : null,
                           TypeBR = br.BrType != null ? br.BrType.ValueId : null,
                           TypeOfContract = br.TypeOfContract.ValueId,
                           PlaceOfDelivery = br.PlaceOfDelivery.ValueId,
                           Max_End_Date = br.MaxEndDate != null ? br.MaxEndDate.Value.AddHours(LocalUTC) : br.MaxEndDate,
                           Number_Of_Days = br.NumberOfDays,
                           Project_Start_Date = br.ProjectStartDate != null ? br.ProjectStartDate.Value.AddHours(LocalUTC) : br.ProjectStartDate,
                           Proximity = br.Proximity,
                           SourceBR = br.BrSource != null ? br.BrSource.Name : null,
                           Specific_Contract_Number = br.SpecificContractNumber,
                           TOTAL_man_days = br.TotalManDays,
                           Total_Price = br.TotalPrice,
                           Contact_Name = br.ContactName,
                           Department = br.Department != null ? br.Department.ValueId : null,
                           DG_Email = br.DgEmail,
                           dt_Acknowledgement = br.DtAcknowledgement != null ? br.DtAcknowledgement.Value.AddHours(LocalUTC) : br.DtAcknowledgement,
                           dt_ProposalDeadline = br.DtProposalDeadline != null ? br.DtProposalDeadline.Value.AddHours(LocalUTC) : br.DtProposalDeadline,
                           dt_RFReceived = br.DtRfReceived != null ? br.DtRfReceived.Value.AddHours(LocalUTC) : br.DtRfReceived,
                           dt_SC_Is_Received = br.DtScIsReceived != null ? br.DtScIsReceived.Value.AddHours(LocalUTC) : br.DtScIsReceived,
                           dt_SC_Is_signed = br.DtScIsSigned != null ? br.DtScIsSigned.Value.AddHours(LocalUTC) : br.DtScIsSigned,
                           Expected_Project_Start_Date = br.ExpectedProjectStartDate != null ? br.ExpectedProjectStartDate.Value.AddHours(LocalUTC) : br.ExpectedProjectStartDate,
                           DateCreation = br.DateCreation != null ? br.DateCreation.Value.AddHours(LocalUTC) : br.DateCreation,
                           Ext_Max_End_Date = br.ExtMaxEndDate != null ? br.ExtMaxEndDate.Value.AddHours(LocalUTC) : br.ExtMaxEndDate,
                           TechnicalContact = br.TechnicalContact,
                           OpenIntendedComment = br.OpenIntendedComment,
                           NextActionDate = br.NextActionDate != null ? br.NextActionDate.Value.AddHours(LocalUTC) : br.NextActionDate,
                           SpecificClientCode = br.SpecificClientCode,
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
                                              RequestFormStatus = Brprofile.RequestFromStatusId != null ? (from req in _context.RequestFormStatus where req.Id == Brprofile.RequestFromStatusId select req.Value).FirstOrDefault() : string.Empty,
                                              CurrencySalesPrice = (from Currency in _context.CurrencyRateParam
                                                                    where Currency.Id == Brprofile.CurrencyId
                                                                    select Currency.CurrencySymbol).FirstOrDefault(),
                                              Service_Level_Category = Brprofile.IdServiceLevelCategory != null ? (from serv in _context.ServiceLevelCategory where serv.Id == Brprofile.IdServiceLevelCategory select serv.ValueId).FirstOrDefault() : "",
                                              CompanyName = Brprofile.CompanyId != null ? (from cmp in _context.Company where cmp.Id == Brprofile.CompanyId select cmp.Name).FirstOrDefault() : "",
                                              Validity_Date = Brprofile.ValidityDate != null ? Brprofile.ValidityDate.Value.AddHours(LocalUTC) : Brprofile.ValidityDate,
                                              Bank_Account = Brprofile.BankAccount,
                                          }).ToList(),
                           Normal_Performance = br.TypeOfContract.NormalPerformance,
                           dt_AcknowledgementDeadline = br.DtAcknowledgementDeadline != null ? br.DtAcknowledgementDeadline.Value.AddHours(LocalUTC) : br.DtAcknowledgementDeadline,
                           GeneralComment = br.GeneralComment
                       })
                       .OrderByDescending(sc => sc.NextActionDate.HasValue)
                       .ThenBy(sc => sc.NextActionDate)
                       .ThenByDescending(sc => sc.Id)
                       .AsQueryable();
            if (Search != null)
            {
                if (Search.RequestNumber != null)
                {

                    ptx = ptx.Where(p => p.RequestNumber.ToUpper().Contains(Search.RequestNumber.ToUpper()));

                }
                if (Search.AdvancedSearchList != null)
                {
                    ptx = ptx.Where(p => Search.AdvancedSearchList.Contains(p.StatusId));
                }
                if (Search.AdvancedSearchDate != null)
                {

                    ptx = ptx.Where(b => b.dt_RFReceived != null && b.dt_RFReceived.Value.Date >= Search.AdvancedSearchDate.Value.Date);
                }
                if (Search.AdvancedSearchListFWC != null)
                {
                    ptx = ptx.Where(p => Search.AdvancedSearchListFWC.Contains(p.TypeOfContract));
                }
            }

            var result = await ptx.Select(sc => (object)sc).AsSplitQuery().ToListAsync();
            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<BusinessRequestViewModel?> GetBusinessRequest(int Id, int LocalUTC)
    {
        try
        {
            var offset = Math.Abs(TimeZoneInfo.Local.GetUtcOffset(DateTime.UtcNow).Hours);
            LocalUTC = (LocalUTC / 60) + offset;
            object? SCExist = null;
            double? PTMRate = 0;
            int idSC = 0;
            BusinessRequestViewModel? BRData = await (from br in _context.BusinessRequest
                                  where br.Id == Id && br.IsDeleted == false
                                  select new BusinessRequestViewModel
                                  {
                                      MaxEndDate = br.MaxEndDate != null ? br.MaxEndDate.Value.AddHours(LocalUTC) : br.MaxEndDate,
                                      ExtMaxEndDate = br.ExtMaxEndDate != null ? br.ExtMaxEndDate.Value.AddHours(LocalUTC) : br.ExtMaxEndDate,
                                      NumberOfDays = br.NumberOfDays,
                                      ProjectStartDate = br.ProjectStartDate != null ? br.ProjectStartDate.Value.AddHours(LocalUTC) : br.ProjectStartDate,
                                      Proximity = br.Proximity,
                                      BRSource = br.BrSource,
                                      Requestnumber = br.RequestNumber,
                                      SpecificContractNumber = br.SpecificContractNumber,
                                      TOTALManDays = br.TotalManDays,
                                      TotalPrice = br.TotalPrice,
                                      ContactName = br.ContactName,
                                      DailyPrice = br.DailyPrice,
                                      DateCreation = br.DateCreation,
                                      DateUpdate = br.DateUpdate,
                                      Department = br.Department,
                                      DGEmail = br.DgEmail,
                                      DtAcknowledgement = br.DtAcknowledgement != null ? br.DtAcknowledgement.Value.AddHours(LocalUTC) : br.DtAcknowledgement,
                                      DtDeadline = br.DtDeadline != null ? br.DtDeadline.Value.AddHours(LocalUTC) : br.DtDeadline,
                                      DtProposalDeadline = br.DtProposalDeadline != null? br.DtProposalDeadline.Value.AddHours(LocalUTC) : br.DtProposalDeadline,
                                      DtRFReceived = br.DtRfReceived != null ? br.DtRfReceived.Value.AddHours(LocalUTC) : br.DtRfReceived,
                                      DtSCIsReceived = br.DtScIsReceived != null ? br.DtScIsReceived.Value.AddHours(LocalUTC) : br.DtScIsReceived,
                                      DtSCIsSigned = br.DtScIsSigned != null ? br.DtScIsSigned.Value.AddHours(LocalUTC) : br.DtScIsSigned,
                                      ExpectedProjectStartDate = br.ExpectedProjectStartDate != null ? br.ExpectedProjectStartDate.Value.AddHours(LocalUTC) : br.ExpectedProjectStartDate,
                                      TechnicalContact = br.TechnicalContact,
                                      IdSourceBR = br.IdSourceBr,
                                      LinkedBR = br.LinkedBr,
                                      Id = br.Id,
                                      Type = br.Type,
                                      TypeBR = br.BrType,
                                      StatusBR = br.StatusBr,
                                      TypeOfContract = br.TypeOfContract,
                                      OpenIntendedComment = br.OpenIntendedComment,
                                      PlaceOfDelivery = br.PlaceOfDelivery,
                                      AdditionalBudget = br.AdditionalBudget,
                                      SpecificClientCode = br.SpecificClientCode,
                                      IsCascade = br.IsCascade,
                                      HasTransfer = (from b in _context.ChangeCompany where b.IdBR == Id select b).Any(),
                                      DtAcknowledgementDeadline = br.DtAcknowledgementDeadline != null ? br.DtAcknowledgementDeadline.Value.AddHours(LocalUTC) : br.DtAcknowledgementDeadline,
                                      GeneralComment = br.GeneralComment,
                                      AdditionalBudgetIdCurrency = br.AdditionalBudgetIdCurrency,
                                      SubtotalPrice = br.SubtotalPrice,
                                      GeneralBudget = br.GeneralBudget,
                                      DtReceptionDraft = br.DtReceptionDraft != null ? br.DtReceptionDraft.Value.AddHours(LocalUTC) : br.DtReceptionDraft,
                                      DtDraftApproval = br.DtDraftApproval != null ? br.DtDraftApproval.Value.AddHours(LocalUTC) : br.DtDraftApproval,
                                      DraftApproval = br.DraftApproval,
                                      DraftContractApprover = br.DraftContractApprover,
                                  }).FirstOrDefaultAsync();
            if (BRData != null)
            {
                if (BRData.TypeBR != null)
                {
                    var TypeBR = BRData.TypeBR.ValueId;
                    switch (TypeBR)
                    {
                        case "TM":
                        case "PTM":
                            SCExist = await _context.SprintContract.Where(x => x.BusinessRequestId == BRData.Id && x.IsDeleted == false).FirstOrDefaultAsync();
                            if (SCExist != null)
                            {
                                SprintContract objSC = (SprintContract)(SCExist);
                                idSC = objSC.Id;
                            }
                            break;
                        case "FP":
                            SCExist = await _context.SCFollowUPFP.Where(x => x.BusinessRequestId == BRData.Id && x.IsDeleted == false).FirstOrDefaultAsync();
                            break;
                        case "QTM":
                            SCExist =await _context.SCFollowUPQTM.Where(x => x.BusinessRequestId == BRData.Id && x.IsDeleted == false).FirstOrDefaultAsync();
                            break;
                        case "Provision of services":
                            SCExist = await _context.SCFollowUPProvision.Where(x => x.BusinessRequestId == BRData.Id && x.IsDeleted == false).FirstOrDefaultAsync();
                            break;
                    }
                    if (SCExist != null)
                    {
                        BRData.SCExist = true;
                    }
                    else
                    {
                        BRData.SCExist = false;
                    }

                    BRData.PTMOwnerRate = PTMRate;
                    BRData.IdSC = idSC;
                }
            }
            return BRData;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<AddResultViewModel?> AddBusinessRequest(BusinessRequest Br, string Login, List<ProfileLevelViewModel> Listprofiles, List<BrConsultantViewModel> ListConsultants, List<CandidateDataViewModel> ListCandidates, List<BRAttachmentViewModel> ListAttachments, List<BrSubcontractorViewModel> ListBRSubcontractor)
    {
        using (var transaction = await _context.Database.BeginTransactionAsync())
        {
            try
            {
                AddResultViewModel result = new AddResultViewModel();
                if (Br != null)
                {
                    List<FwcBusinessRequestRequiredFields> listRequired = _context.FwcBusinessRequestRequiredFields.Where(r => r.IdFWC == Br.TypeOfContract.Id && r.IdStatus == Br.StatusBr.Id && r.IdSource == Br.BrSource.Id).ToList();
                    BusinessRequest? BReq = await GetBusinessRequestByRequestNumber(Br.RequestNumber.TrimEnd().TrimStart());
                    if (BReq == null)
                    {
                        var a = Br.TechnicalContact;

                        if (Br.PlaceOfDelivery != null)
                        {
                            Br.PlaceOfDelivery = _context.PlaceOfDelivery.Where(r => r.Id == Br.PlaceOfDelivery.Id).FirstOrDefault();
                        }
                        if (Br.StatusBr != null)
                        {
                            Br.StatusBr = _context.StatusBr.Where(r => r.Id == Br.StatusBr.Id).FirstOrDefault();
                        }
                        if (Br.Type != null)
                        {
                            Br.Type = _context.Type.Where(r => r.Id == Br.Type.Id).FirstOrDefault();
                        }
                        if (Br.TypeOfContract != null)
                        {
                            Br.TypeOfContract = _context.TypeOfContract.Where(r => r.Id == Br.TypeOfContract.Id).FirstOrDefault();
                        }
                        if (Br.BrType != null)
                        {
                            Br.BrType = _context.BrType.Where(r => r.Id == Br.BrType.Id).FirstOrDefault();
                            Br.Proximity = false;
                            if (Br.BrType.ValueId == "PTM")
                            {
                                Br.Proximity = true;

                            }
                        }
                        if (Br.BrSource != null)
                        {
                            Br.BrSource = _context.BrSource.Where(r => r.Id == Br.BrSource.Id).FirstOrDefault();
                        }
                        if (Br.Department != null)
                        {
                            Br.Department = _context.Department.Where(dep => dep.ValueId == Br.Department.ValueId).FirstOrDefault();
                        }
                        if (Br.IdSourceBr != null)
                        {
                            Br.BrSource = _context.BrSource.Where(r => r.Id == Br.IdSourceBr).FirstOrDefault();
                            string idSource = Br.BrSource.Id;
                            string idStatus = Br.StatusBr.ValueId;
                            int idFWC = Br.TypeOfContract.Id;
                            bool linkedBRRequierd = listRequired.Where(r => r.FieldId == "idf_LinkedBR" && r.IdSource == idSource && r.IdStatus == idStatus && r.IdFWC == idFWC).Select(r => r.IsRequired).FirstOrDefault();
                            if (Br.LinkedBr == null && linkedBRRequierd)
                            {
                                result.CodeMessage = ConstantsMessage.ERROR_BR_LINKEDBR_REQUIRED;
                                return result;
                            }
                            else
                            {
                                Br.LinkedBr = Br.LinkedBr;
                            }

                        }
                        Br.DateCreation = CurrentDate;
                        Br.DateUpdate = CurrentDate;
                        Br.LoginCreation = Login;
                        Br.LoginUpdate = Login;
                        Br.IsCascade = Br.IsCascade;
                        Br.IsDeleted = false;
                        Br.IsScCreated = false;
                        Br.NextActionDate = GetNextActionDate(Br, Listprofiles);
                        _context.BusinessRequest.Add(Br);
                        await _context.SaveChangesAsync();
                        AddHistoryRep(Br, "Creation", "Added", Listprofiles);
                        var resultProfile = AddListProfilesBR(Br.Id, Listprofiles, ListConsultants);
                        if (resultProfile.msgResult == ConstantsMessage.ERROR_BR_NDAYS_CONSULTANT_EXCEED && (Br.BrType.ValueId == "TM" || Br.BrType.ValueId == "PTM"))
                        {
                            result.CodeMessage = resultProfile.msgResult;
                            result.ValueProfile = resultProfile.valueProfile;
                            return result;
                        }
                        AddListCandidates(ListCandidates, Br.Id, Br.BrType.ValueId, resultProfile.ListProfiles);
                        AddAttachments(ListAttachments, Br.Id, Login);
                        if (Br.BrType.ValueId.IndexOf("Provision") != -1)
                        {
                            if (Listprofiles != null)
                            {
                                var exceed = checkSubTotalExceedTotalPrice(Listprofiles, Br.TotalPrice);
                                if (exceed)
                                {
                                    result.CodeMessage = ConstantsMessage.ERROR_SUBTOTAL_EXCEED_TOTAL_PRICE;
                                    return result;
                                }
                            }

                        }
                        var resulData = AddListConsultant(ListConsultants, Br, resultProfile.ListProfiles, Br.BrType.ValueId, null);
                        if (resulData == ConstantsMessage.ERROR_BR_CONSULTANTS_NO_PROFILE)
                        {
                            result.CodeMessage = resulData;
                            return result;
                        }
                        AddDocumentCandidates(ListCandidates, Br.Id);
                        AddListSubcontractor(ListBRSubcontractor, Br.Id);
                        await transaction.CommitAsync();
                        result.CodeMessage = ConstantsMessage.MESSAGE_BR_SUCCESS_ADD;
                        result.Id = Br.Id;
                        _unitOfWork.ActivityLogRepository.SaveActivityLog(Login, "Add new business request [" + Br.RequestNumber + "]", "Business Request");
                        if (ListAttachments != null && ListAttachments.Count > 0)
                        {
                            string AllFileName = String.Join("; ", ListAttachments.Select(x => x.AppFileName));
                            _unitOfWork.ActivityLogRepository.SaveActivityLog(Login, "Add business request document(s) [ " + Br.RequestNumber + " ]  [" + AllFileName + "]", "Business Request");
                        }
                        return result;
                    }
                    else
                    {
                        result.CodeMessage = ConstantsMessage.ERROR_BR_REQUEST_NBR_EXIST; // BR exists;
                        result.Id = BReq.Id;
                        return result;

                    }
                }
                else
                {
                    result.CodeMessage = ConstantsMessage.ERROR_BR_NOTVALID; // BR invalid
                    return result;
                }                
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
        }
    }

    public async Task<BusinessRequest?> GetBusinessRequestByRequestNumber(string? ReqNbr)
    {
        try
        {
            return await (from b in _context.BusinessRequest where b.RequestNumber == ReqNbr && b.IsDeleted == false select b).FirstOrDefaultAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public string AddAttachments(List<BRAttachmentViewModel> Attachment, int IdBR, string Login)
    {
        //SADocs = WebConfigurationManager.AppSettings["SADocs"];
        try
        {
            if (IdBR == 0)
            {
                return ConstantsMessage.ERROR_BR_NOTVALID;
            }
            var requestNumber = "";
            var Br = (from br in _context.BusinessRequest where br.Id == IdBR select br).FirstOrDefault();
            if (Br != null)
            {
                requestNumber = Br.RequestNumber;
            }
            requestNumber = ContainSpecficCharacters(requestNumber);
            if (Attachment != null)
            {
                foreach (var value in Attachment)
                {
                    if (!value.IsDeleted && value.IsChange)
                    {
                        BRAttachmentViewModel file = new BRAttachmentViewModel();
                        BrDocuments FileAttach = new BrDocuments();
                        if (value.IdAttachment != 0)
                        {
                            FileAttach = _context.BrDocuments.Where(x => x.IdDocument == value.IdAttachment).FirstOrDefault();
                        }
                        FileAttach.IdBR = IdBR;
                        FileAttach.AppFileName = value.AppFileName;
                        FileAttach.PathDoc = SADocs + "\\StaffDocs\\BR\\" + requestNumber + "_" + IdBR + "\\" + value.AppFileName;
                        FileAttach.OrigineFileName = value.OriginFileName;
                        FileAttach.DocFormat = value.DocFormat;

                        FileAttach.VersionDoc = value.VersionDoc;
                        FileAttach.DateUpload = value.DateUpload;
                        FileAttach.LoginUpload = Login;
                        if (value.DocType != null)
                        {
                            FileAttach.TypeDocument = _context.TypeDocument.Where(t => t.DocumentType == value.DocType).FirstOrDefault();
                        }
                        if (value.IdAttachment == 0)
                        {
                            _context.BrDocuments.Add(FileAttach);
                        }

                        _context.SaveChanges();
                    }
                }
            }
            return ConstantsMessage.MESSAGE_LIST_ATTACHMENTS_SUCCESS_UPD;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public string ContainSpecficCharacters(string requestNumber)
    {
        try
        {
            bool conatins = characters.Any(requestNumber.Contains);
            if (conatins)
            {
                for (int i = 0; i < characters.Count; i++)
                {
                    var pos = requestNumber.IndexOf(characters[i]);
                    if (pos > -1)
                    {
                        char ValuePos = requestNumber[pos];
                        requestNumber = requestNumber.Replace(ValuePos.ToString(), "");
                    }
                }
            }
            return requestNumber;
        }
        catch
        {
            throw;
        }
    }
    public string AddListCandidates(List<CandidateDataViewModel> Listcandidates, int IdBR, string TypeBR, List<ProfileLevelViewModel> ListProfiles)
    {
        try
        {
            var ListCandidatesByBR = (from brcandidates in _context.BrCandidateList where brcandidates.BusinessRequest.Id == IdBR && brcandidates.BusinessRequest.IsDeleted == false select brcandidates).ToList();

            if (ListCandidatesByBR.Count != 0)
            {
                foreach (var v in ListCandidatesByBR)
                {
                    var listCandidatesDocsByBR = (from docs in _context.CandidateDocuments where docs.BRCandId == v.Id select docs).ToList();
                    if (listCandidatesDocsByBR.Count != 0)
                    {
                        foreach (var doc in listCandidatesDocsByBR)
                        {
                            _context.CandidateDocuments.Remove(doc);
                        }
                        _context.SaveChangesAsync();
                    }
                    if (TypeBR == "TM" || TypeBR == "PTM")
                    {
                        var ListProfileCandidate = (from profCand in _context.BrProfileCandidate where profCand.IdBrCandidate == v.Id select profCand).ToList();
                        if (ListProfileCandidate.Count != 0)
                        {
                            foreach (var prof in ListProfileCandidate)
                            {
                                _context.BrProfileCandidate.Remove(prof);
                            }
                            _context.SaveChangesAsync();
                        }
                    }

                    _context.BrCandidateList.Remove(v);
                }
                _context.SaveChangesAsync();
            }
            if (Listcandidates != null)
            {
                foreach (var value in Listcandidates)
                {
                    var result = CheckCandidateExists(value.CandidateId, IdBR);
                    if (result == "MBRCAND-0002")
                    {
                        BrCandidateList candidateList = new BrCandidateList();
                        candidateList.IdBR = IdBR;
                        candidateList.Company = value.Company != null ? value.Company.Name : null;
                        candidateList.CandidateId = value.CandidateId;
                        candidateList.IdResourceType = value.IdResourceType;
                        if (value.RecruitmentResponsible != null)
                        {
                            candidateList.RecruitmentResponsible = _context.RecruitmentResponsible.Where(v => v.Id == value.RecruitmentResponsible.Id).FirstOrDefault();
                        }
                        candidateList.InterviewDetail = value.InterviewDetail;
                        candidateList.IdTypeUser = value.IdTypeUser;
                        candidateList.UserType = value.UserType;
                        candidateList.Comment = value.Comment;
                        candidateList.IdSubcontractor = value.IdSubcontractor;
                        candidateList.IsSubcontractor = value.IsSubContractor;
                        candidateList.AvailabilityDate = GetDateUTC(value.AvailabilityDate);
                        candidateList.FOApproval = value.FOApproval;
                        candidateList.ProposalCompleted = value.ProposalCompleted;
                        candidateList.DraftApproval = value.DraftApproval;
                        candidateList.DraftDateApproval = value.DraftDateApproval;
                        candidateList.DraftUserName = value.DraftUserName;
                        if (value.DraftApproval == false)
                        {
                            candidateList.DraftDateApproval = null;
                            candidateList.DraftUserName = null;
                        }
                        _context.BrCandidateList.Add(candidateList);
                        _context.SaveChanges();
                        if (TypeBR == "TM" || TypeBR == "PTM")
                        {
                            if (value.Profile != null)
                            {
                                foreach (var item in value.Profile)
                                {
                                    if (item.Id != 0 && item.Id != null)
                                    {
                                        BrProfileCandidate profileCandidate = new BrProfileCandidate() { IdBrCandidate = candidateList.Id, IdBrProfile = item.Id, IdStatus = item.IdStatus };
                                        _context.BrProfileCandidate.Add(profileCandidate);
                                        _context.SaveChangesAsync();
                                    }
                                    else
                                    {
                                        var idBRProfile = ListProfiles.Where(s => s.idProfileTemp == item.IdTemp).Select(s => s.Id).FirstOrDefault();
                                        BrProfileCandidate profileCandidate = new BrProfileCandidate() { IdBrCandidate = candidateList.Id, IdBrProfile = idBRProfile, IdStatus = item.IdStatus };
                                        _context.BrProfileCandidate.Add(profileCandidate);
                                        _context.SaveChangesAsync();
                                    }


                                }
                            }
                        }
                        if (value.IdResourceType != null)
                        {
                            var c = _context.Candidate.SingleOrDefault(x => x.idCandidate == value.CandidateId);
                            if (result != null)
                            {
                                c.IdResourceType = value.IdResourceType;
                                _context.SaveChangesAsync();
                            }
                        }

                    }

                }
            }
            return ConstantsMessage.MESSAGE_LIST_CANDIDATES_SUCCESS_UPD;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public DateTime? GetDateUTC(DateTime? date)
    {
        if (date != null)
        {
            DateTime dt = Convert.ToDateTime(date);
            DateTime newDate = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
            return newDate;
        }
        return date;
    }
    public string CheckCandidateExists(int IdCandidate, int IdBr)
    {
        try
        {
            var objCandidateBr = (from Candbr in _context.BrCandidateList where Candbr.IdBR == IdBr && Candbr.CandidateId == IdCandidate select Candbr).FirstOrDefault();
            if (objCandidateBr != null)
            {
                return ConstantsMessage.MESSAGE_BR_CANDIDATE_EXIST;
            }
            else
            {
                return ConstantsMessage.MESSAGE_BR_CANDIDATE_NOT_EXIST;
            }
        }
        catch
        {
            throw;
        }
    }
    public string addListConsultant(List<BrConsultantViewModel> listconsultant, BusinessRequest BR, List<ProfileLevelViewModel> listProfiles, string typeBR, List<BrConsultantViewModel> listconsultantDeleted)
    {
        try
        {
            if (listconsultant != null)
            {
                if (typeBR == "TM" || typeBR == "PTM" || typeBR.IndexOf("Provision") != -1)
                {
                    if (listProfiles != null)
                    {
                        var chekRequiredConsultant = (from req in _context.FwcBusinessRequestRequiredFields
                                                      where req.IdFWC == BR.IdTypeOfContract && req.IdServiceType == BR.IdTypeBr && req.IdSource == BR.IdSourceBr
                                                         && req.IdStatus == BR.IdStatus && req.FieldId == "idf_Consultant"
                                                      select req.IsRequired
                                                    ).FirstOrDefault();
                        if (chekRequiredConsultant && listProfiles.Count() > 0)
                        {
                            var noProfile = listconsultant.Where(x => x.BRProfile.Any(y => y.IdBRProfile == 0)).Any();
                            if (noProfile)
                            {
                                return ConstantsMessage.ERROR_BR_CONSULTANTS_NO_PROFILE;
                            }
                        }
                    }
                }
                foreach (var value in listconsultant)
                {
                    BRConsultant consultant = new BRConsultant();
                    if (value.Id != 0)
                    {
                        consultant = _context.BRConsultant.Where(x => x.Id == value.Id).FirstOrDefault();

                    }
                    if (value.IsChanged)
                    {
                        var objConsultant = _context.Consultant.Where(c => c.IdConsultant == value.ConsultantId).FirstOrDefault();
                        consultant.CandidateId = value.CandidateId;
                        if (value.Id == 0)
                        {
                            consultant.BRId = BR.Id;
                            consultant.ConsultantId = value.ConsultantId;
                            _context.BRConsultant.Add(consultant);
                            _context.SaveChangesAsync();
                        }
                        if (value.BRProfile != null)
                        {
                            foreach (var item in value.BRProfile)
                            {
                                BRProfileConsultant BRProfileCons = new BRProfileConsultant();
                                if (item.Id != 0)
                                {
                                    BRProfileCons = _context.BRProfileConsultant.Where(x => x.Id == item.Id).FirstOrDefault();
                                }
                                if (item.IsDeleted == false)
                                {
                                    BRProfileCons.AgreedRate = item.AgreedRate;
                                    BRProfileCons.ThirdPartyRate = item.ThirdPartyrate;
                                    BRProfileCons.ConsCostMargin = item.ConsCostMargin;
                                    BRProfileCons.ConsCostIdCurrency = item.ConsCostIdCurrency;
                                    BRProfileCons.TPRateIdCurrency = item.TPRateIdCurrency;
                                    BRProfileCons.ExpectedStartDate = GetDateUTC(item.ExpectedStartDate);
                                    BRProfileCons.PTMOwnerRate = item.PTMOwnerRate;
                                    BRProfileCons.PTMOwnerAddress = item.PTMOwnerAdress;
                                    BRProfileCons.IdPTMOwner = item.IdPTMOwner;
                                    BRProfileCons.PTMOwnerRateIdCurrency = item.PTMOwnerRateidCurrency;
                                    BRProfileCons.IdTypeInvolvement = item.IdTypeInvolvement;
                                    BRProfileCons.NbrDays = item.NbrDays;
                                    BRProfileCons.TotalCostIdCurrency = item.TotalCostidCurrency;
                                    BRProfileCons.TotalPriceMargin = item.TotalPriceMargin;
                                    BRProfileCons.TotalCost = item.TotalCost;
                                    BRProfileCons.DaysOfTraining = item.DaysOfTraining;
                                    if (item.SubContractor != null)
                                    {
                                        BRProfileCons.SubContractorId = item.SubContractor.Id;
                                        BRProfileCons.SubcontractorName = item.SubContractor.ValueId;
                                    }
                                    if (item.TypeOfContractSC != null)
                                    {
                                        BRProfileCons.TypeOfContractId = item.TypeOfContractSC.Id;
                                    }
                                    if (typeBR == "TM" || typeBR == "PTM" || typeBR.IndexOf("Provision") != -1)
                                    {
                                        if (item.IdBRProfile == null)
                                        {
                                            if (listProfiles != null)
                                            {
                                                BRProfileCons.IdBRProfile = listProfiles.Where(s => s.idProfileTemp == item.IdProfileTemp).Select(s => s.Id).FirstOrDefault();
                                            }
                                        }
                                        else
                                        {
                                            BRProfileCons.IdBRProfile = item.IdBRProfile;
                                        }
                                    }
                                    else
                                    {
                                        BRProfileCons.IdBRProfile = null;
                                    }
                                    item.IdBRProfile = BRProfileCons.IdBRProfile;
                                    if (objConsultant.IdTypeOfContract != BRProfileCons.TypeOfContractId)
                                    {
                                        objConsultant.IdTypeOfContract = BRProfileCons.TypeOfContractId;
                                    }
                                    bool isEveris = false;
                                    bool CompanyEmpty = true;
                                    if (typeBR == "TM" || typeBR == "PTM" || typeBR.IndexOf("Provision") != -1)
                                    {
                                        if (BRProfileCons.IdBRProfile != null)
                                        {
                                            if (listProfiles != null)
                                            {
                                                var Company = listProfiles.Where(s => s.idProfileTemp == item.IdProfileTemp).Select(s => s.Company).FirstOrDefault();
                                                if (Company != null)
                                                {
                                                    isEveris = Company.IsEveris;
                                                    CompanyEmpty = false;
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (listProfiles != null)
                                        {
                                            CompanyEmpty = listProfiles.All(s => s.Company == null);
                                            isEveris = listProfiles.Where(s => s.Company != null).Any(x => x.Company.IsEveris == true);
                                        }

                                    }
                                    if (!CompanyEmpty)
                                    {
                                        if (!isEveris)
                                        {
                                            BRProfileCons.IdConsultantContractStatus = "NA";
                                        }
                                        else if (item.TypeOfContractSC != null)
                                        {
                                            if (isEveris && item.TypeOfContractSC.ValueId.ToUpper() == "EMPLOYEE")
                                            {
                                                BRProfileCons.IdConsultantContractStatus = "employee";
                                            }
                                            else
                                            {
                                                int? serviceType = _context.BrType.Where(s => s.ValueId == typeBR).Select(x => x.Id).FirstOrDefault();
                                                if (serviceType != null)
                                                {
                                                    var generrateContract = _context.EverisContractDetail.Where(s => s.IdConsultant == value.ConsultantId && s.IdTypeService == (int)serviceType).OrderByDescending(x => x.Id).FirstOrDefault();
                                                    if (generrateContract == null)
                                                    {
                                                        BRProfileCons.IdConsultantContractStatus = "pending_init";
                                                    }
                                                    else
                                                    {
                                                        BRProfileCons.IdConsultantContractStatus = generrateContract.idConsultantContractStatus;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            BRProfileCons.IdConsultantContractStatus = "pending_init";
                                        }
                                    }
                                    else
                                    {
                                        BRProfileCons.IdConsultantContractStatus = "NA";
                                    }
                                    if (item.Id == 0)
                                    {
                                        BRProfileCons.IdBRConsultant = consultant.Id;
                                        _context.BRProfileConsultant.Add(BRProfileCons);
                                        _context.SaveChangesAsync();
                                        item.Id = BRProfileCons.Id;
                                    }
                                }
                                else
                                {
                                    if (item.Id != 0 && BRProfileCons != null)
                                    {
                                        int idBRProfile = (int)item.IdBRProfile;
                                        string confirmdelete = ConfirmDeleteProfile(typeBR, BR.Id, value.ConsultantId, idBRProfile);
                                        if (confirmdelete == ConstantsMessage.MESSAGE_CONS_DELETE_GRANTED)
                                        {
                                            if (typeBR == "TM" || typeBR == "PTM")
                                            {
                                                SprintContract? SC = (from sp in _context.SprintContract where sp.BusinessRequestId == BR.Id && sp.IsDeleted == false select sp).FirstOrDefault();
                                                if (SC != null)
                                                {

                                                    List<ScDaysWorkedByMonth> DW = (from dw in _context.ScDaysWorkedByMonth where dw.SprintContractId == SC.Id && dw.ConsultantId == value.ConsultantId && dw.BRProfileId == idBRProfile select dw).ToList();
                                                    if (DW != null)
                                                    {
                                                        _context.ScDaysWorkedByMonth.RemoveRange(DW);
                                                        _context.SaveChangesAsync();
                                                    }
                                                }
                                            }
                                            else if (typeBR.IndexOf("Provision") != -1)
                                            {
                                                SCFollowUPProvision? SCPOS = (from sp in _context.SCFollowUPProvision where sp.BusinessRequestId == BR.Id && sp.IsDeleted == false select sp).FirstOrDefault();
                                                if (SCPOS != null)
                                                {

                                                    List<SCFollowUPProvisionDaysWorked> DW = (from dw in _context.SCFollowUPProvisionDaysWorked where dw.IdSC == SCPOS.Id && dw.ConsultantId == value.ConsultantId && dw.IdBRProfile == idBRProfile select dw).ToList();
                                                    if (DW != null)
                                                    {
                                                        _context.SCFollowUPProvisionDaysWorked.RemoveRange(DW);
                                                        _context.SaveChangesAsync();
                                                    }
                                                }
                                            }
                                            _context.BRProfileConsultant.Remove(BRProfileCons);
                                            _context.SaveChangesAsync();
                                        }
                                    }
                                }
                                _context.SaveChangesAsync();
                            }
                        }
                        if (objConsultant.OERPEmployeeNumber != value.OERPEmployeeNumber && !string.IsNullOrEmpty(value.OERPEmployeeNumber))
                        {
                            objConsultant.OERPEmployeeNumber = value.OERPEmployeeNumber;
                        }
                    }
                    _context.SaveChanges();
                }
            }
            return ConstantsMessage.MESSAGE_LIST_CANDIDATES_SUCCESS_UPD;
        }
        catch (DbUpdateException e)
        {
            foreach (var entry in e.Entries)
            {
                Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                    entry.Entity.GetType().Name, entry.State);

                if (entry.State == EntityState.Added || entry.State == EntityState.Modified)
                {
                    var entity = entry.Entity as IValidatableObject;
                    if (entity != null)
                    {
                        var validationResults = entity.Validate(new ValidationContext(entity));

                        foreach (var validationResult in validationResults)
                        {
                            foreach (var memberName in validationResult.MemberNames)
                            {
                                var PropertyName = memberName;
                                var ErrorMessage = validationResult.ErrorMessage;

                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", PropertyName, ErrorMessage);
                            }
                        }
                    }
                }
            }
            throw;
        }
    }
    public string ConfirmDeleteProfile(string serviceType, int idBR, int ConsultantId, int idBRProfile)
    {
        try
        {
            string result = ConstantsMessage.MESSAGE_CONS_DELETE_GRANTED;
            var idCons = ConsultantId;
            object firstCheck = null, TMPTMPaymentCheck = null, TMPTMInvoiceCheck = null, MissionCheck = null, CheckPaymentMission = null, EvContractCheck = null, ChangeCostCheck = null, ChangeCmpCheck = null;
            object secondeCheck = null;
            if (serviceType != null)
            {
                switch (serviceType)
                {
                    case "PTM":
                    case "TM":
                        SprintContract SC = (from sc in _context.SprintContract where sc.BusinessRequestId == idBR && sc.IsDeleted == false select sc).FirstOrDefault();
                        if (SC != null)
                        {
                            List<ScDaysWorkedByMonth> DW = (from dw in _context.ScDaysWorkedByMonth where dw.SprintContractId == SC.Id && dw.ConsultantId == idCons && dw.BRProfileId == idBRProfile select dw).ToList();
                            if (DW != null)
                            {
                                List<int> listid = DW.Select(s => s.Id).ToList();
                                TMPTMPaymentCheck = (from paymentDW in _context.PaymentSCDaysWorked where listid.Contains(paymentDW.DaysWorkedId) select paymentDW).FirstOrDefault();
                                if (TMPTMPaymentCheck == null)
                                {
                                    TMPTMInvoiceCheck = (from invoice in _context.InvoiceDaysWorked where listid.Contains(invoice.IdDaysWorked) select invoice).FirstOrDefault();
                                    if (TMPTMInvoiceCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_INVOICE;
                                        return result;
                                    }
                                    else
                                    {
                                        if (DW.Any(x => x.NumberOfDaysWorked > 0))
                                        {
                                            result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_DW;
                                            return result;
                                        }
                                    }
                                }
                                else
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_PAYMENT;
                                    return result;
                                }
                            }
                            MissionCheck = (from exp in _context.SCTMPTMExpense
                                            where exp.IdConsultant == idCons && exp.IdSC == SC.Id && exp.IdBRProfile == idBRProfile
                                            select exp).FirstOrDefault();
                            if (MissionCheck != null)
                            {
                                result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_MISSION;
                                return result;

                            }
                            else
                            {
                                ChangeCostCheck = (from changecost in _context.ChangeConsultantCost where changecost.IdConsultant == idCons && changecost.idBRProfile == idBRProfile && changecost.IdSC == SC.Id select changecost).FirstOrDefault();
                                if (ChangeCostCheck != null)
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_QTM_CHANGECOST;
                                    return result;
                                }
                                else
                                {
                                    ChangeCmpCheck = (from changecmp in _context.ChangeCompany where changecmp.IdConsultant == idCons && changecmp.IdBRProfile == idBRProfile && changecmp.IdBR == idBR select changecmp).FirstOrDefault();
                                    if (ChangeCmpCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_QTM_CHANGECMP;
                                        return result;

                                    }
                                    EvContractCheck = (from detail in _context.EverisContractDetail where detail.IdConsultant == idCons && detail.IdBRProfile == idBRProfile && detail.IdSC == SC.Id select detail).FirstOrDefault();
                                    if (EvContractCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_QTM_EC;
                                        return result;
                                    }
                                }
                            }
                            List<SCFollowUPTMPTMDaysWorkedProvision> DW_Prov = (from dw in _context.SCFollowUPTMPTMDaysWorkedProvision where dw.IdSC == SC.Id && dw.ConsultantId == idCons && dw.idBRProfile == idBRProfile select dw).ToList();
                            if (DW_Prov != null)
                            {
                                var listid = DW_Prov.Select(s => s.Id).ToList();
                                TMPTMPaymentCheck = (from paymentDW in _context.SCFollowUPTMPTMPaymentDaysWorkedProvision where listid.Contains(paymentDW.IdDWProvision) select paymentDW).FirstOrDefault();
                                if (TMPTMPaymentCheck == null)
                                {
                                    TMPTMInvoiceCheck = (from invoice in _context.SCFollowUPTMPTMInvoiceDaysWorkedProvision where listid.Contains(invoice.IdDWProvision) select invoice).FirstOrDefault();
                                    if (TMPTMInvoiceCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_INVOICE;
                                        return result;
                                    }
                                    else
                                    {
                                        if (DW_Prov.Any(x => x.NumberOfDaysWorked > 0))
                                        {
                                            result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_DW;
                                            return result;
                                        }
                                    }
                                }
                                else
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_PAYMENT;
                                    return result;
                                }
                            }
                            List<SCFollowUPTMPTMGeneralProvision> Line = (from prov in _context.SCFollowUPTMPTMGeneralProvision where prov.IdSC == SC.Id && prov.ConsultantId == idCons && prov.IdBRProfile == idBRProfile select prov).ToList();
                            if (Line != null)
                            {
                                var listid = Line.Select(s => s.Id).ToList();
                                TMPTMPaymentCheck = (from payment in _context.SCFollowUPTMPTMPaymentGeneralProvision where listid.Contains(payment.idProvision) select payment).FirstOrDefault();
                                if (TMPTMPaymentCheck == null)
                                {
                                    TMPTMInvoiceCheck = (from invoice in _context.SCFollowUPTMPTMInvoiceGeneralProvision where listid.Contains(invoice.IdProvision) select invoice).FirstOrDefault();
                                    if (TMPTMInvoiceCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_INVOICE;
                                        return result;
                                    }
                                    else
                                    {
                                        if (Line.Any(x => x.ProvisionAmount > 0))
                                        {
                                            result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_LINE;
                                            return result;
                                        }
                                    }
                                }
                                else
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_TMPTM_PAYMENT;
                                    return result;
                                }
                            }
                        }
                        break;
                    case "Provision of services":
                        SCFollowUPProvision Provision = (from sc in _context.SCFollowUPProvision where sc.BusinessRequestId == idBR && sc.IsDeleted == false select sc).FirstOrDefault();
                        if (Provision != null)
                        {
                            List<SCFollowUPProvisionDaysWorked> DW_Provision = (from dw in _context.SCFollowUPProvisionDaysWorked where dw.IdSC == Provision.Id && dw.ConsultantId == idCons && dw.IdBRProfile == idBRProfile select dw).ToList();
                            if (DW_Provision != null)
                            {
                                var listid = DW_Provision.Select(s => s.Id).ToList();
                                TMPTMInvoiceCheck = (from invoice in _context.SCFollowUPProvisionInvoiceDaysWorkedDetail where listid.Contains(invoice.IdDaysWorked) select invoice).FirstOrDefault();
                                if (TMPTMInvoiceCheck != null)
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_PROVISION_INVOICE;
                                    return result;
                                }
                                else
                                {
                                    TMPTMPaymentCheck = (from paymentDW in _context.SCFollowUPProvisionPaymentDaysWorkedDetail where listid.Contains(paymentDW.IdDaysWorked) select paymentDW).FirstOrDefault();

                                    if (TMPTMPaymentCheck != null)
                                    {
                                        result = ConstantsMessage.ERROR_CONS_DELETE_PROVISION_PAYMENT;
                                        return result;
                                    }
                                    else
                                    {
                                        ChangeCostCheck = (from changecost in _context.ChangeConsultantCostProvision where changecost.IdConsultant == idCons && changecost.IdSC == Provision.Id && changecost.idBRProfile == idBRProfile select changecost).FirstOrDefault();
                                        if (ChangeCostCheck != null)
                                        {
                                            result = ConstantsMessage.ERROR_CONS_DELETE_PROVISION_CHANGECOST;
                                            return result;
                                        }
                                        if (DW_Provision.Any(x => x.NumberOfDaysWorked > 0))
                                        {
                                            result = ConstantsMessage.ERROR_CONS_DELETE_PROVISION_DW;
                                            return result;
                                        }
                                    }
                                }
                            }
                            EvContractCheck = (from detail in _context.EverisContractDetail where detail.IdConsultant == idCons && detail.IdSC == Provision.Id && detail.IdBRProfile == idBRProfile select detail).FirstOrDefault();
                            if (EvContractCheck != null)
                            {
                                result = ConstantsMessage.ERROR_CONS_DELETE_PROVISION_EC;
                                return result;
                            }
                            List<SCFollowUPProvisionGeneralProvision> Line = (from prov in _context.SCFollowUPProvisionGeneralProvision where prov.IdSC == Provision.Id && prov.ConsultantId == idCons && prov.idBRProfile == idBRProfile select prov).ToList();
                            if (Line != null)
                            {
                                if (Line.Any(x => x.ProvisionAmount > 0))
                                {
                                    result = ConstantsMessage.ERROR_CONS_DELETE_GENERAL_PROVISION;
                                    return result;
                                }
                            }
                        }
                        break;
                }
            }
            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    private DateTime? GetNextActionDate(BusinessRequest BR, List<ProfileLevelViewModel> listprofiles)
    {
        try
        {
            DateTime? DtNextAction = null;
            if (BR != null)
            {
                if (BR.StatusBr != null)
                {
                    if ((BR.StatusBr.Id == "PIP" || BR.StatusBr.Id == "PSA" || BR.StatusBr.Id == "OIP") && listprofiles != null)
                    {
                        var ObjRFS = listprofiles.Count() > 0 ? listprofiles.Where(x => x.RequestFormStatus != null && (x.RequestFormStatus.Id == "AR" || x.RequestFormStatus.Id == "CA" || x.RequestFormStatus.Id == "CP" || x.RequestFormStatus.Id == "OTHER" || x.RequestFormStatus.Id == "WMP")).ToList() : null;
                        if (ObjRFS != null)
                        {
                            if (ObjRFS.Count() > 0)
                            {

                                var PRDeadline = ObjRFS.Where(x => x.dt_SentToCustomer == null && BR.DtDeadline != null).FirstOrDefault();
                                if (PRDeadline != null)
                                {
                                    DtNextAction = BR.DtDeadline;
                                }
                                else
                                {
                                    var PRProposalDeadline = ObjRFS.Where(x => x.dt_Proposal_Is_Submitted_To_Customer == null && BR.DtProposalDeadline != null).FirstOrDefault();
                                    if (PRProposalDeadline != null)
                                    {
                                        DtNextAction = BR.DtProposalDeadline;
                                    }
                                    else
                                    {
                                        var PRFODeadline = ObjRFS.Where(x => x.dt_FO_Is_Submitted_To_Customer == null && x.dt_FO_Deadline != null).OrderByDescending(x => x.dt_FO_Deadline).FirstOrDefault();
                                        if (PRFODeadline != null)
                                        {
                                            DtNextAction = PRFODeadline.dt_FO_Deadline;
                                        }
                                        else
                                        {
                                            var FOIsSubmittedToCustomer = ObjRFS.Where(x => x.dt_FO_Is_Submitted_To_Customer != null).FirstOrDefault();
                                            if (FOIsSubmittedToCustomer == null) { DtNextAction = null; }

                                        }

                                    }
                                }

                            }
                        }
                    }
                }
            }
            return DtNextAction;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public string AddHistoryRep(BusinessRequest Br, string comment, string action, List<ProfileLevelViewModel> listprofiles)
    {
        try
        {
            HistoryBusinessRequest h = new HistoryBusinessRequest();
            List<string> arrayOfCompany = new List<string>();
            List<string> arrayofBankAccount = new List<string>();
            List<string> arrayofValidityDate = new List<string>();
            if (listprofiles != null)
            {
                for (int i = listprofiles.Count - 1; i >= 0; i--)
                {
                    var profileBr = listprofiles[i].Profile != null ? listprofiles[i].Profile.ValueId : null;
                    var levelBr = listprofiles[i].level != null ? listprofiles[i].level.ValueId : null;
                    var categoryBr = listprofiles[i].category != null ? listprofiles[i].category.ValueId : null;
                    var ServiceLevelCategory = listprofiles[i].ServiceLevelCategory != null ? listprofiles[i].ServiceLevelCategory.ValueId : null;
                    if (listprofiles[i].Company != null && listprofiles[i].isDeleted == false)
                    {
                        if (arrayOfCompany.IndexOf(listprofiles[i].Company.Name) == -1)
                        {
                            arrayOfCompany.Add(listprofiles[i].Company.Name);
                        }
                    }
                    if (listprofiles[i].BankAccount != null)
                    {
                        if (arrayofBankAccount.IndexOf(listprofiles[i].BankAccount) == -1)
                        {
                            arrayofBankAccount.Add(listprofiles[i].BankAccount);
                        }
                    }
                    if (listprofiles[i].Validity_Date != null)
                    {
                        if (arrayofValidityDate.IndexOf(listprofiles[i].Validity_Date.ToString()) == -1)
                        {
                            arrayofValidityDate.Add(listprofiles[i].Validity_Date.ToString());
                        }
                    }
                    if (i == 0)
                    {
                        h.Profiles += profileBr;
                        h.Levels += levelBr;
                        h.Category += categoryBr;
                        h.ServiceLevelCategoryValue += ServiceLevelCategory;
                    }
                    else
                    {
                        if (listprofiles.Count == 1)
                        {
                            h.Profiles = profileBr;
                            h.Levels = levelBr;
                            h.Category += categoryBr;
                            h.ServiceLevelCategoryValue += ServiceLevelCategory;
                        }
                        else
                        {
                            h.Profiles += profileBr + ";";
                            h.Levels += levelBr + ";";
                            h.Category += categoryBr + ";";
                            h.ServiceLevelCategoryValue += (ServiceLevelCategory != null ? ServiceLevelCategory + ";" : "");
                        }
                    }
                }
            }
            h.IdBR = Br.Id;
            h.MaxEndDate = Br.MaxEndDate;
            h.NumberOfDays = Br.NumberOfDays;
            h.ProjectStartDate = Br.ProjectStartDate;
            h.Proximity = Br.Proximity;
            h.LinkedBR = Br.LinkedBr;
            h.RequestNumber = Br.RequestNumber;
            h.SpecificContractNumber = Br.SpecificContractNumber;
            h.TotalManDays = Br.TotalManDays;
            h.TotalPrice = Br.TotalPrice;
            h.ValidityDate = arrayofValidityDate.Count > 0 ? String.Join(";", arrayofValidityDate) : "";
            h.BankAccount = arrayofBankAccount.Count > 0 ? String.Join(";", arrayofBankAccount) : "";
            h.ContactName = Br.ContactName;
            h.DailyPrice = Br.DailyPrice;
            h.DgDepartmentId = Br.Department != null ? Br.Department.ValueId : null;
            h.DgEmail = Br.DgEmail;
            h.DtAcknowledgement = Br.DtAcknowledgement;
            h.DtDeadline = Br.DtDeadline;
            h.TechnicalContact = Br.TechnicalContact;
            h.DtProposalDeadline = Br.DtProposalDeadline;
            h.DtRfReceived = Br.DtRfReceived;
            h.DtScIsReceived = Br.DtScIsReceived;
            h.DtScIsSigned = Br.DtScIsSigned;
            h.ExpectedProjectStartDate = Br.ExpectedProjectStartDate;
            h.IdSourceBr = Br.BrSource != null ? Br.BrSource.Name : null;
            h.IdType = Br.Type != null ? Br.Type.ValueId : null;
            h.TypeBRValue = Br.BrType != null ? Br.BrType.ValueId : null;
            h.IdTypeOfContract = Br.TypeOfContract != null ? Br.TypeOfContract.ValueId : null;
            h.IdStatus = Br.StatusBr != null ? Br.StatusBr.ValueId : null;
            h.IdPlaceOfDelivery = Br.PlaceOfDelivery != null ? Br.PlaceOfDelivery.ValueId : null;
            h.ExtMaxEndDate = Br.ExtMaxEndDate;
            h.IdCompany = arrayOfCompany.Count > 0 ? String.Join(";", arrayOfCompany) : "";
            h.LoginCreation = Br.LoginCreation;
            h.LoginUpdate = Br.LoginUpdate;
            h.NumberOfDays = Br.NumberOfDays;
            h.DateUpdate = Br.DateUpdate;
            h.DateCreation = Br.DateCreation;
            h.CommentUpdate = comment;
            h.OpenIntendedComment = Br.OpenIntendedComment;
            h.AdditionalBudget = Br.AdditionalBudget;
            h.AdditionalBudgetCurrency = (from currency in _context.CurrencyRateParam where currency.Id == Br.AdditionalBudgetIdCurrency select currency.CurrencySymbol).FirstOrDefault();
            h.SpecificClientCode = Br.SpecificClientCode;
            h.UserAction = action;
            h.IsCascade = Br.IsCascade;
            h.DtAcknowledgementDeadline = Br.DtAcknowledgementDeadline;
            h.GeneralComment = Br.GeneralComment;
            h.SubtotalPrice = Br.SubtotalPrice;
            h.GeneralBudget = Br.GeneralBudget;
            h.DtReceptionDraft = Br.DtReceptionDraft;
            _context.HistoryBusinessRequest.Add(h);
            _context.SaveChangesAsync();
            return "1"; // success
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    public BRProfileResultViewModel AddListProfilesBR(int idBr, List<ProfileLevelViewModel> listproflevel, List<BR_ConsultantViewModel> listConsultants)
    {
        try
        {
            //double? nbrdays = 0;
            //double? dailyprice = 0;
            List<ProfileLevelViewModel> listData = new List<ProfileLevelViewModel>();
            BRProfileResultViewModel result = new BRProfileResultViewModel();
            var objBr = (from br in _context.BusinessRequest where br.id == idBr select br).FirstOrDefault();
            //if (objBr != null)
            //{
            //    nbrdays = objBr.Number_Of_Days;
            //    dailyprice = objBr.Daily_Price;
            //}
            //var listProfilestByBR = (from brprofile in _context.BR_Profile where brprofile.BusinessRequest.id == idBr select brprofile).ToList();
            //if (listProfilestByBR.Count != 0)
            //{
            //    foreach (var v in listProfilestByBR)
            //    {
            //        _context.BR_Profile.Remove(v);
            //    }
            //    _context.SaveChanges();
            //}
            if (listproflevel != null)
            {
                foreach (var value in listproflevel)
                {
                    var siteValue = "on site";
                    double? nbrdays = 0;
                    double? dailyprice = 0;

                    if (value.NumberOfDays != null)
                    {
                        nbrdays = value.NumberOfDays;

                    }
                    if (value.DailyPrice != null)
                    {
                        dailyprice = value.DailyPrice;

                    }
                    BR_Profile BRprofile = new BR_Profile();
                    if (value.id != 0)
                    {
                        BRprofile = _context.BR_Profile.Where(x => x.id == value.id && x.idBR == idBr).FirstOrDefault();
                    }
                    if (!value.isDeleted)
                    {

                        //if (listConsultants != null)
                        //{
                        //    var ListProfile = listConsultants.Where(s => s.idProfileTemp == value.idProfileTemp).ToList();
                        //    if (ListProfile != null)
                        //    {
                        //        if (ListProfile.Count() > 0)
                        //        {
                        //            nbrDays = listConsultants.Where(s => s.idProfileTemp == value.idProfileTemp).Sum(s => s.Nbr_Days_Cons);
                        //            var nbrDaysProfile = value.NumberOfDays!=null? value.NumberOfDays: 0;

                        //            if (nbrDays != nbrDaysProfile)
                        //            {
                        //                result.msgResult = ConstantsMessage.ERROR_BR_NDAYS_CONSULTANT_EXCEED;
                        //                var valueResult = "profile :" + value.Profile.valueId + " /level :" + value.level.valueId;
                        //                if (value.category != null)
                        //                {
                        //                    valueResult += " /category :" + value.category.valueId;
                        //                }
                        //                if (value.OnSite == false)
                        //                {
                        //                    siteValue = "off site";

                        //                }
                        //                valueResult += " on/off site " + siteValue;
                        //                result.valueProfile = valueResult;
                        //                return result;
                        //            }
                        //        }

                        //    }

                        //}

                        BRprofile.idBR = idBr;
                        if (value.Profile != null)
                        {
                            BRprofile.Profile = _context.Profile.Where(p => p.valueId == value.Profile.valueId).FirstOrDefault();
                        }

                        if (value.category != null)
                        {
                            BRprofile.Category = _context.Category.Where(p => p.valueId == value.category.valueId).FirstOrDefault();
                        }

                        if (value.level != null)
                        {
                            BRprofile.Level = _context.Level.Where(l => l.valueId == value.level.valueId).FirstOrDefault();
                        }
                        if (value.Company != null)
                        {
                            //BRprofile.Company = _context.Company.Where(c => c.idCompany == value.Company.idCompany).FirstOrDefault();
                            BRprofile.idCompany = value.Company.idCompany;
                        }
                        BRprofile.id_Service_Level_Category = value.ServiceLevelCategory != null ? value.ServiceLevelCategory.id : 0;

                        BRprofile.OnSite = value.OnSite;
                        BRprofile.DailyPrice = dailyprice;
                        BRprofile.NumberOfDays = nbrdays;
                        if (value.RequestFormStatus != null)
                        {
                            BRprofile.idRequestFromStatus = value.RequestFormStatus.id;
                        }
                        BRprofile.dt_Acceptance = GetDateUTC(value.dt_Acceptance);
                        BRprofile.dt_ChangeOffer = GetDateUTC(value.dt_ChangeOffer);
                        BRprofile.dt_ChangeOffer_Is_Submitted_To_Customer = GetDateUTC(value.dt_ChangeOffer_Is_Submitted_To_Customer);
                        BRprofile.dt_FO_Deadline = GetDateUTC(value.dt_FO_Deadline);
                        BRprofile.dt_FO_Is_Submitted_To_Customer = GetDateUTC(value.dt_FO_Is_Submitted_To_Customer);
                        BRprofile.dt_Proposal_Is_Submitted_To_Customer = GetDateUTC(value.dt_Proposal_Is_Submitted_To_Customer);
                        BRprofile.dt_Refusal = GetDateUTC(value.dt_Refusal);
                        BRprofile.dt_SentToCustomer = GetDateUTC(value.dt_SentToCustomer);
                        BRprofile.Other_Expertise_Required = value.Other_Expertise_Required;
                        BRprofile.Penalty_Amount = value.Penalty_Amount;
                        BRprofile.Penalty_Days = value.Penalty_Days;
                        BRprofile.PenaltyComment = value.PenaltyComment;
                        BRprofile.idCurrency = value.BRProfile_idCurrency;
                        BRprofile.Penalty_idCurrency = value.Penalty_idCurrency;
                        BRprofile.ApplyItEquipment = value.ApplyItEquipment;
                        BRprofile.ApplyContractorPremises = value.ApplyContractorPremises;
                        BRprofile.Validity_Date = GetDateUTC(value.Validity_Date);
                        BRprofile.Bank_Account = value.Bank_Account;
                        BRprofile.Place_Of_Execution = value.PlaceOfExecution;
                        //if (value.id == 0&& !value.UpdateImport)
                        if (value.id == 0)
                        {
                            //if(value.Profile!=null && value.level != null)
                            //{
                            //if (!_context.BR_Profile.Any(x => x.idProfile == value.Profile.id && x.idLevel == value.level.id && x.OnSite == value.OnSite && x.idBR == idBr))
                            //{
                            // case Add 
                            _context.BR_Profile.Add(BRprofile);
                            _context.SaveChanges();
                            value.id = BRprofile.id;
                            listData.Add(value);
                            // }
                            //}
                        }
                        else
                        {
                            // case update
                            if (BRprofile != null)
                            {
                                _context.SaveChanges();
                                listData.Add(value);
                            }

                        }
                        result.listProfiles = listData;
                    }
                    else
                    {    // case remove 
                        if (BRprofile != null && value.id != 0)
                        {
                            _context.BR_Profile.Remove(BRprofile);
                            _context.SaveChanges();
                        }
                    }


                }
            }

            result.msgResult = ConstantsMessage.MESSAGE_LIST_PROFILES_SUCCESS_ADD;
            return result;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
