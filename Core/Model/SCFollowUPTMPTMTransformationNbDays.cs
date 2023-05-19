using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_TMPTM_TransformationNdays")]
public partial class SCFollowUPTMPTMTransformationNbDays
{
    public int Id { get; set; }
    [Column("idSC")]
    public int SprintContractId { get; set; }
    [Column("idConsultant")]
    public int ConsultantId { get; set; }
    [Column("NdaysTransformed")]
    public double NbDaysTransformed { get; set; }
    public double NbDaysProvision { get; set; }
    public double TotalBudget { get; set; }
    public double? SalesPrice { get; set; }
    public double? ConsultantCost { get; set; }
    public double CurrentSalesPrice { get; set; }
    public double CurrentConsultantCost { get; set; }
    public bool IsDeleted { get; set; }
    public string Username { get; set; } = null!;
    public DateTime DateUpdate { get; set; }
    [Column("idBRProfile")]
    public int? BRProfileId { get; set; }
    public virtual SprintContract SprintContract { get; set; } = null!;
}