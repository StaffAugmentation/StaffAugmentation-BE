using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("AppParameters")]
public class AppParameter
{
    public int Id { get; set; }

    [Column("QTMDailyPrice_IsActive")]
    public bool? QTMDailyPriceIsActive { get; set; }

    [Column("TMDailyPrice_IsActive")]
    public bool? TMDailyPriceIsActive { get; set; }

    public int? DaysBeforeDeletingFile { get; set; }

    [Column("SAUrlApp_Prod")]
    public string? SAUrlAppProd { get; set; }

    public string? SAEmail { get; set; }

    [Column("Br_AdvancedSearch_Date")]
    public int? BrAdvancedSearchDate { get; set; }

    [Column("SC_AdvancedSearch_Period")]
    public int? SCAdvancedSearchPeriod { get; set; }

    public string? HREmailSubject { get; set; }

    public string? HREmailText { get; set; }

    public string? ConsultantEmailSubject { get; set; }

    public string? ConsultantEmailText { get; set; }

    [Column("SA_Version")]
    public string? SAVersion { get; set; }

    public bool? UseLDAPService { get; set; }

    public string? ContractApprover { get; set; }

    [Column("ContractApprover_Email")]
    public string? ContractApproverEmail { get; set; }

}
