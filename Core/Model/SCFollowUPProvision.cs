using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class SCFollowUPProvision
{
    public int Id { get; set; }

    [Column("RequestNumberId")]
    public int BusinessRequestId { get; set; }

    public double RemainingDays { get; set; }

    public double ManagementFee { get; set; }

    public bool IsManagementFeeInvoiced { get; set; }

    public int IdStatus { get; set; }

    public string LoginCreation { get; set; } = null!;

    public DateTime DateCreation { get; set; }

    public string LoginUpdate { get; set; } = null!;

    public DateTime DateUpdate { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStaffAugmentation { get; set; }

    public string? PurchaseOrderReferencePay { get; set; }

    public double MaximumCost { get; set; }

    public string? PTMPurchaseOrderReferencePay { get; set; }

    public string? ThirdPartyPurchaseOrderReferencePay { get; set; }

    public string? MFPurchaseOrderReferencePay { get; set; }

    public string? ProvisionPurchaseOrderReferencePay { get; set; }

    public string? PerformanceComment { get; set; }

    public string? MissionPurchaseOrderReferencePay { get; set; }

    [ForeignKey("IdStatus")]
    public virtual ContractStatus? ContractStatus { get; set; }

    [ForeignKey("BusinessRequestId")]
    public virtual BusinessRequest? BusinessRequest { get; set; }

    //public virtual ICollection<ChangeConsultantCostProvision> ChangeConsultantCostProvisions { get; } = new List<ChangeConsultantCostProvision>();

    //public virtual ICollection<ChangeThirdPartyRateProvision> ChangeThirdPartyRateProvisions { get; } = new List<ChangeThirdPartyRateProvision>();

    //public virtual ICollection<ScfollowUpProvisionDaysWorked> ScfollowUpProvisionDaysWorkeds { get; } = new List<ScfollowUpProvisionDaysWorked>();

    //public virtual ICollection<ScfollowUpProvisionGeneralProvision> ScfollowUpProvisionGeneralProvisions { get; } = new List<ScfollowUpProvisionGeneralProvision>();

    //public virtual ICollection<ScfollowUpProvisionOerpcode> ScfollowUpProvisionOerpcodes { get; } = new List<ScfollowUpProvisionOerpcode>();

    //public virtual ICollection<ScposExpense> ScposExpenses { get; } = new List<ScposExpense>();
}