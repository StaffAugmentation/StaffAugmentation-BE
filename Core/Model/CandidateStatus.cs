using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class CandidateStatus
{
    public int Id { get; set; }

    [Column("ValueId")]
    public string? Value { get; set; }
}
