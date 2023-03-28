using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public class SubContractor
{
    public int Id { get; set; }

    public string ValueId { get; set; } = null!;

    [Column("SubCont_BA")]
    public string? BA { get; set; }

    [Column("SubCont_BICSW")]
    public string? BICSW { get; set; }

    [Column("SubCont_VAT_Rate")]
    public double? VatRate { get; set; }

    public bool IsOfficial { get; set; }

    [Column("idApproverSub")]
    public int? IdApprover { get; set; }

    public string? LegalEntityName { get; set; }

    [Column("LegalEntityAdress")]
    public string? LegalEntityAddress { get; set; }

    [Column("VAT_Number")]
    public string? VatNumber { get; set; }

    [Column("ID_Number")]
    public string? IdNumber { get; set; }

    public string? IdPaymentTerm { get; set; }

    public string? IdTypeOfCost { get; set; }

}