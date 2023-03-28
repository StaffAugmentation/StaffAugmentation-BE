using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("Approvers")]
public class Approver
{
    public int Id { get; set; }

    [Column("app_FirstName")]
    public string AppFirstName { get; set; } = null!;
    [Column("app_LastName")]
    public string AppLastName { get; set; } = null!;
}