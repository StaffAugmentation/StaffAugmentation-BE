using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class UserParameter
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public string? ExcelSeparator { get; set; }

    [ForeignKey("IdUser")]
    public virtual User User { get; set; } = null!;
}