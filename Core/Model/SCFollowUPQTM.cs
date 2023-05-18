using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class SCFollowUPQTM
{
    public int Id { get; set; }

    [Column("RequestNumberId")]
    public int BusinessRequestId { get; set; }

    public double? RevenueConsumed { get; set; }

    public double? ManagementFee { get; set; }

    public string? ManagementFeeInvoiceNumber { get; set; }

    public bool SCWithEC { get; set; }

    public string? Report { get; set; }

    public double? TotalCost { get; set; }

    public double? TotalMargin { get; set; }

    public string? Comment { get; set; }

    public string? LoginCreation { get; set; }

    public DateTime DateCreation { get; set; }

    public string? LoginUpdate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStaffAugmentation { get; set; }

    public string? DarwinCode { get; set; }

    public int? PMEverisId { get; set; }

    [ForeignKey("PMEverisId")]
    public virtual EverisPM? EverisPM { get; set; }

    [ForeignKey("BusinessRequestId")]
    public virtual BusinessRequest BusinessRequest { get; set; } = null!;

    //public virtual ICollection<SccontrolOerpcode> SccontrolOerpcodes { get; } = new List<SccontrolOerpcode>();

    //public virtual ICollection<ScqtmExpense> ScqtmExpenses { get; } = new List<ScqtmExpense>();

    //public virtual ICollection<SubtaskScfollowUpQtm> SubtaskScfollowUpQtms { get; } = new List<SubtaskScfollowUpQtm>();
}