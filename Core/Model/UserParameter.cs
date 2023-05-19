using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class UserParameter
{
    public int Id { get; set; }

    [Column("IdUser")]
    public int UserId { get; set; }

    public string? ExcelSeparator { get; set; }

    public virtual User User { get; set; } = null!;
}