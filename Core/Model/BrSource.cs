using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public class BrSource
{
    [Key]
    [Column("IdSource")]
    public string Id { get; set; } = null!;

    [Column("SourceName")]
    public string Name { get; set; } = null!;
}