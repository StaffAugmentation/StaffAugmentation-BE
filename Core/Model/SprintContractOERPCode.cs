using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SprintContract_OERPCode")]
public partial class SprintContractOERPCode
{
    public int Id { get; set; }

    public int IdSC { get; set; }

    public string OERPProjectCode { get; set; } = null!;

    [ForeignKey("IdSC")]
    public virtual SprintContract SprintContract { get; set; } = null!;
}