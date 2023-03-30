using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public class PTMOwner
{
    public int Id { get; set; }

    public string ValueId { get; set; } = null!;

    [Column("PTMOwner_BA")]
    public string? BA { get; set; }

    [Column("PTMOwner_BICSW")]
    public string? BICSW { get; set; }

    [Column("PTMOwner_VAT_Rate")]
    public double? VatRate { get; set; }

    public bool IsEveris { get; set; }

    [Column("IdApproverPTMOwner")]
    public int? IdApprover { get; set; }

    [Column("PTMOwner_VAT_Number")]
    public string? VatNumber { get; set; }
}