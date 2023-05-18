using System.ComponentModel.DataAnnotations;

namespace Core.Model;

public partial class Role
{
    [Key]
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleType { get; set; }

    //public virtual ICollection<RoleModulePermission> RoleModulePermissions { get; } = new List<RoleModulePermission>();

    //public virtual ICollection<RoleModule> RoleModules { get; } = new List<RoleModule>();

    //public virtual RoleType? RoleTypeNavigation { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}