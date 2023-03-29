using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public class TypeOfCost
{
    public string Id { get; set; } = null!;

    [Column("TypeOfCostValue")]
    public string Value { get; set; } = null!;

}