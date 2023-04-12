using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("Approvers")]
public class Approver
{
    public int Id { get; set; }

    [Column("app_FirstName")]
    public string FirstName { get; set; } = null!;
    [Column("app_LastName")]
    public string LastName { get; set; } = null!;
}