using Core.Model;

namespace Core.ViewModel;
public class CandidateDataViewModel
{
    public Company Company { get; set; }
    public int IdBR { get; set; }
    public string InterviewDetail { get; set; }
    public virtual RecruitmentResponsible RecruitmentResponsible { get; set; }
    public int CandidateId { get; set; }
    public bool IsPartner { get; set; }
    public int? IdResourceType { get; set; }
    public List<CandAttachmentViewModel> ListDocs { get; set; }
    public DateTime? AvailabilityDate { get; set; }
    public bool IsSubContractor { get; set; }
    public int IdStatus { get; set; }
    public int IdSubcontractor { get; set; }

    public string Comment { get; set; }
    public int? IdBRProfile { get; set; }
    public int IdProfileTemp { get; set; }

    public int Id { get; set; }
    public int? IdTypeUser { get; set; }
    public string UserType { get; set; }
    public bool? FOApproval { get; set; }
    public bool? ProposalCompleted { get; set; }

    public List<ProfileCandidateViewModel> Profile { get; set; }
    public Nullable<bool> DraftApproval { get; set; }
    public string DraftUserName { get; set; }
    public DateTime DraftDateApproval { get; set; }
}
