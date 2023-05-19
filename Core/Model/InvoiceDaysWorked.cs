using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("InvoicesDaysWorked")]
public partial class InvoiceDaysWorked
{
    public int Id { get; set; }

    public int IdDaysWorked { get; set; }

    public int IdInvoice { get; set; }

    public double? NbDaysInvoiced { get; set; }

    public int IdConsultant { get; set; }

    public double SalesPrice { get; set; }

    public string? OERPProjectCode { get; set; }

    public int? idBRProfile { get; set; }

    [ForeignKey("IdDaysWorked")]
    public virtual ScDaysWorkedByMonth ScDaysWorkedByMonth { get; set; } = null!;

    [ForeignKey("IdInvoice")]
    public virtual InvoiceSC InvoiceSC { get; set; } = null!;
}