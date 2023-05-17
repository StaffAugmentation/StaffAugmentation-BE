using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    public partial class SprintContract
    {
        public int Id { get; set; }

        public int RequestNumberId { get; set; }

        public double? ConsultantCost { get; set; }

        public bool? EverisContract { get; set; }

        public double? RemainingDays { get; set; }

        public double? DailyMargin { get; set; }

        public double? ManagementFee { get; set; }

        public bool? ManagementFeeInvoiceNumber { get; set; }

        public int? IdContractStatus { get; set; }

        public string? LoginCreation { get; set; }

        public DateTime? DateCreation { get; set; }

        public string? LoginUpdate { get; set; }

        public DateTime? DateUpdate { get; set; }

        public bool IsDeleted { get; set; }

        [Column("SC_PTM")]
        public bool ScPTM { get; set; }

        public bool IsStaffAugmentation { get; set; }

        public string? PerformanceComment { get; set; }

        public string? PurchaseOrderReferencePay { get; set; }

        public string? PTMPurchaseOrderReferencePay { get; set; }

        public string? ThirdPartyPurchaseOrderReferencePay { get; set; }

        public string? MFPurchaseOrderReferencePay { get; set; }

        public string? MissionPurchaseOrderReferencePay { get; set; }

        [ForeignKey("IdContractStatus")]
        public virtual ContractStatus? ContractStatus { get; set; }

        [ForeignKey("RequestNumberId")]
        public virtual BusinessRequest BusinessRequest { get; set; } = null!;

        //public virtual ICollection<ChangeConsultantCost> ChangeConsultantCosts { get; } = new List<ChangeConsultantCost>();

        //public virtual ICollection<ChangePtmrate> ChangePtmrates { get; } = new List<ChangePtmrate>();

        //public virtual ICollection<ChangeThirdPartyRate> ChangeThirdPartyRates { get; } = new List<ChangeThirdPartyRate>();

        //public virtual ICollection<ScDaysWorkedByMonth> ScDaysWorkedByMonths { get; } = new List<ScDaysWorkedByMonth>();

        //public virtual ICollection<ScfollowUpTmptmDaysWorkedProvision> ScfollowUpTmptmDaysWorkedProvisions { get; } = new List<ScfollowUpTmptmDaysWorkedProvision>();

        //public virtual ICollection<ScfollowUpTmptmGeneralProvision> ScfollowUpTmptmGeneralProvisions { get; } = new List<ScfollowUpTmptmGeneralProvision>();

        //public virtual ICollection<ScfollowUpTmptmTransformationNday> ScfollowUpTmptmTransformationNdays { get; } = new List<ScfollowUpTmptmTransformationNday>();

        //public virtual ICollection<SctmptmExpense> SctmptmExpenses { get; } = new List<SctmptmExpense>();

        //public virtual ICollection<SprintContractOerpcode> SprintContractOerpcodes { get; } = new List<SprintContractOerpcode>();
    }
}
