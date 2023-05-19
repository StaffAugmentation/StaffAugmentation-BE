using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class InvoicingStatus
{
    public string Id { get; set; } = null!;

    [Column("StatusValue")]
    public string Value { get; set; } = null!;
    //public virtual ICollection<ScDaysWorkedByMonth> ScDaysWorkedByMonths { get; } = new List<ScDaysWorkedByMonth>();
}