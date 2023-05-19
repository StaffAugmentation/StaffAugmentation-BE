using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("InvoicesSC")]
public partial class InvoiceSC
{
    public int Id { get; set; }
    public string? OERPInvoiceCode { get; set; }
    public DateTime InvoiceDate { get; set; }
    public DateTime? InvoicingPeriodFrom { get; set; }
    public DateTime? InvoicingPeriodTo { get; set; }
    public double InvoiceAmount { get; set; }
    public string? InvoiceComment { get; set; }
    public DateTime DateCreation { get; set; }
    public string? LoginCreation { get; set; }
    public DateTime DateUpdate { get; set; }
    public string? LoginUpdate { get; set; }
    public string? IdDraft { get; set; }
    public string? TypeInvoice { get; set; }
    public string? Client { get; set; }
    public string? EverisEntity { get; set; }
    public string? ClientPONumber { get; set; }
    public double? MFValue { get; set; }
    public int? OriginInvoiceId { get; set; }
    public string? InvoiceNature { get; set; }
    public string? IdInvoicingStatus { get; set; }
    public int IdSC { get; set; }
    public bool? IsGlobalInvoice { get; set; }
    public string? OERPCustomerCode { get; set; }

    //public virtual ICollection<InvoicesDaysWorked> InvoicesDaysWorkeds { get; } = new List<InvoicesDaysWorked>();
    //public virtual ICollection<InvoicesScOerpcode> InvoicesScOerpcodes { get; } = new List<InvoicesScOerpcode>();
    //public virtual ICollection<ScfollowUpTmptmInvoiceDaysWorkedProvision> ScfollowUpTmptmInvoiceDaysWorkedProvisions { get; } = new List<ScfollowUpTmptmInvoiceDaysWorkedProvision>();
    //public virtual ICollection<ScfollowUpTmptmInvoiceGeneralProvision> ScfollowUpTmptmInvoiceGeneralProvisions { get; } = new List<ScfollowUpTmptmInvoiceGeneralProvision>();
}