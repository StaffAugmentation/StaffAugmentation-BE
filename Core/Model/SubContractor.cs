using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public partial class SubContractor
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

    public string? LegalEntityName { get; set; }

    [Column("LegalEntityAdress")]
    public string? LegalEntityAddress { get; set; }

    [Column("VAT_Number")]
    public string? VatNumber { get; set; }

    [Column("ID_Number")]
    public string? IdNumber { get; set; }

    [Column("idApproverSub")]
    public int? ApproverId { get; set; }

    public virtual Approver? Approver { get; set; }

    [Column("IdPaymentTerm")]
    public string? PaymentTermId { get; set; }

    public virtual PaymentTerm? PaymentTerm { get; set; }

    [Column("IdTypeOfCost")]
    public string? TypeOfCostId { get; set; }

    public virtual TypeOfCost? TypeOfCost { get; set; }

}