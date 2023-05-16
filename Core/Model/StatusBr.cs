using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class StatusBr
{
    public string Id { get; set; } = null!;

    public string ValueId { get; set; } = null!;

    public int? DispOrder { get; set; }

    //public virtual ICollection<BusinessRequest> BusinessRequests { get; } = new List<BusinessRequest>();
}