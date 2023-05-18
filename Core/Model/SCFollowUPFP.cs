using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCFollowUP_FP")]
public partial class SCFollowUPFP
{
    public int Id { get; set; }

    [Column("RequestNumberId")]
    public int BusinessRequestId { get; set; }

    public string Status { get; set; } = null!;

    public double? RevenueConsumed { get; set; }

    public double? ManagementFee { get; set; }

    public bool? ManagementFeeInvoiceNumber { get; set; }

    public double? TotalCost { get; set; }

    public double? TotalMargin { get; set; }

    public string LoginCreation { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public string? LoginUpdate { get; set; }

    public DateTime? DateUpdate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStaffAugmentation { get; set; }

    public int? PMEverisId { get; set; }

    [ForeignKey("PMEverisId")]
    public virtual EverisPM? EverisPM { get; set; }

    [ForeignKey("BusinessRequestId")]
    public virtual BusinessRequest BusinessRequest { get; set; } = null!;

    //public virtual ICollection<MilestoneScfollowUpFp> MilestoneScfollowUpFps { get; } = new List<MilestoneScfollowUpFp>();

    //public virtual ICollection<ScfollowUpFpOerpcode> ScfollowUpFpOerpcodes { get; } = new List<ScfollowUpFpOerpcode>();

    //public virtual ICollection<ScfpExpense> ScfpExpenses { get; } = new List<ScfpExpense>();
}
