using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class EverisContractDetail
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public int IdConsultant { get; set; }
    public int IdTypeService { get; set; }

    [Column("Signature_date")]
    public DateTime? SignatureDate { get; set; }

    [Column("Maximum_end_date")]
    public DateTime MaximumEndDate { get; set; }

    [Column("Sent_date")]
    public DateTime SentDate { get; set; }

    [Column("Specific_Provision")]
    public string SpecificProvision { get; set; }

    [Column("EC_Comment")]
    public string ECComment { get; set; }
    public DateTime DateUpdate { get; set; }
    public string EVUserName { get; set; }
    public string idConsultantContractStatus { get; set; }
    public int? IdBRProfile { get; set; }

    public virtual ConsultantContractStatus ConsultantContractStatus { get; set; }
}