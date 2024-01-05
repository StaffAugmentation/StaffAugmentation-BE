using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class Company
{
    [Key]
    [Column("IdCompany")]
    public int Id { get; set; }

    [Column("CompanyName")]
    public string Name { get; set; } = null!;

    public string? BankAccount { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsStaff { get; set; }

    [Column("cmp_VATLegalEntity")]
    public string? VatLegalEntity { get; set; }

    [Column("cmp_BICSW")]
    public string? BICSW { get; set; }

    [Column("cmp_VAT_Rate")]
    public double? VatRate { get; set; }

    [Column("idApproverCmp")]
    public int? ApproverId { get; set; }

    public virtual Approver? Approver { get; set; }

    [Column("Cmp_Email")]
    public string? Email { get; set; }
}