using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SA_ActivityLog")]
public partial class SaActivityLog
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public DateTime DateTimeLog { get; set; }

    public string CommentLog { get; set; } = null!;

    public string AppModule { get; set; } = null!;
}