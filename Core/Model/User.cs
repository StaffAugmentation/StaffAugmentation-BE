using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public bool IsDeleted { get; set; }

    public byte[]? Image { get; set; }

    public int? RoleId { get; set; }

    public DateTime DateCreation { get; set; }

    public bool IsActive { get; set; }

    public bool IsVisible { get; set; }

    public string? UserPassword { get; set; }

    public bool UseConsortiumPortal { get; set; }

    public string TypeUser { get; set; } = null!;

    public int? IdTypeUser { get; set; }

    public bool IsFirstConnection { get; set; }

    [ForeignKey("RoleId")]
    public virtual Role? Role { get; set; }

    //public virtual ICollection<UserParameter> UserParameters { get; } = new List<UserParameter>();

    //public virtual ICollection<UsersTypeOfContract> UsersTypeOfContracts { get; } = new List<UsersTypeOfContract>();
}
