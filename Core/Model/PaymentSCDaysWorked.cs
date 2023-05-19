using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("PaymentSC_DaysWorked")]
public partial class PaymentSCDaysWorked
{
    public int Id { get; set; }
    [Column("idDaysWorked")]
    public int DaysWorkedId { get; set; }
    [Column("idPayment")]
    public int PaymentId { get; set; }
    public double? NbDaysPaid { get; set; }
    public double ConsultantCost { get; set; }
    [Column("idConsultant")]
    public int ConsultantId { get; set; }
    public string? OERPProjectCode { get; set; }
    [Column("idBRProfile")]
    public int? BRProfileId { get; set; }

    [ForeignKey("PaymentId")]
    public virtual PaymentSC PaymentSC { get; set; } = null!;
    [ForeignKey("DaysWorkedId")]
    public virtual ScDaysWorkedByMonth ScDaysWorkedByMonth { get; set; } = null!;

}