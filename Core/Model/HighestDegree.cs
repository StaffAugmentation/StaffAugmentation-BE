using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("ConsultantDegree")]
public class HighestDegree
{
    public int Id { get; set; }

    [Column("ValueId")]
    public string Value { get; set; } = null!;

    public bool IsActive { get; set; }
}
