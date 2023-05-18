using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class EverisPM
{
    public int Id { get; set; }

    [Column("EverisPM_Name")]
    public string? Name { get; set; }

    [Column("EverisPM_Email")]
    public string? Email { get; set; }

    public virtual ICollection<SCFollowUPFP> SCFollowUPFP { get; } = new List<SCFollowUPFP>();

    public virtual ICollection<SCFollowUPQTM> SCFollowUPQTM { get; } = new List<SCFollowUPQTM>();
}