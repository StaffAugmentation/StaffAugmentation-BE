using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public class RequestFormStatus
{
    public required string Id { get; set; }

    [Column("ValueId")]
    public string Value { get; set; } = null!;

}