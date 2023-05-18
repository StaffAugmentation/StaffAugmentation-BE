using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class UsersTypeOfContract
{
    public int Id { get; set; }

    public int IdTypeOfContract { get; set; }

    public int IdUser { get; set; }

    [ForeignKey("IdTypeOfContract")]
    public virtual TypeOfContract TypeOfContract { get; set; } = null!;

    [ForeignKey("IdUser")]
    public virtual User User { get; set; } = null!;
}