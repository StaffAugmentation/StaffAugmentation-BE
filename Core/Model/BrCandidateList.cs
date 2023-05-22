using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("BR_CandidateList")]
public partial class BrCandidateList
{
    public int Id { get; set; }
    public string Company { get; set; }
    public int IdBR { get; set; }
    public string InterviewDetail { get; set; }

    [Column("RecruitmentRespId")]
    public int? RecruitmentResponsibleId { get; set; }
    public int CandidateId { get; set; }
    public int? IdResourceType { get; set; }

    [Column("Availability_Date")]
    public DateTime? AvailabilityDate { get; set; }
    public bool? IsSubcontractor { get; set; }
    public int? IdStatus { get; set; }
    public int? IdSubcontractor { get; set; }
    public int? IdTypeUser { get; set; }
    public string UserType { get; set; }
    public string Comment { get; set; }
    public string SubcontractorName { get; set; }

    [Column("FO_Approval")]
    public bool? FOApproval { get; set; }

    [Column("FO_UserName")]
    public string FOUserName { get; set; }

    [Column("FO_DateApproval")]
    public DateTime? FODateApproval { get; set; }
    public bool? ProposalCompleted { get; set; }

    [Column("Draft_Approval")]
    public bool? DraftApproval { get; set; }

    [Column("Draft_UserName")]
    public string DraftUserName { get; set; }

    [Column("Draft_DateApproval")]
    public DateTime? DraftDateApproval { get; set; }

    public virtual ResourceType ResourceType { get; set; }
    public virtual Candidate Candidates { get; set; }
    public virtual RecruitmentResponsible RecruitmentResponsible { get; set; }

    //public virtual ICollection<CandidateDocuments> CandidateDocuments { get; set; }
    public virtual BusinessRequest BusinessRequest { get; set; }
}