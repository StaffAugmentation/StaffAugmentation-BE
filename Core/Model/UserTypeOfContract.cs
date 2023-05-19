using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("UsersTypeOfContract")]
public partial class UserTypeOfContract
{
    public int Id { get; set; }

    [Column("IdTypeOfContract")]
    public int TypeOfContractId { get; set; }

    [Column("IdUser")]
    public int UserId { get; set; }

    public virtual TypeOfContract TypeOfContract { get; set; } = null!;
    public virtual User User { get; set; } = null!;
}