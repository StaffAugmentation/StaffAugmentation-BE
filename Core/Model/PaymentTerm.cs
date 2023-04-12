using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("PaymentTerms")]
public class PaymentTerm
{
    public string Id { get; set; } = null!;

    [Column("PaymentTermValue")]
    public string Value { get; set; } = null!;

}