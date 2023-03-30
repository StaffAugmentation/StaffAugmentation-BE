using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;


[Table("SA_OERPCodes")]
public partial class OERPCode
{
    public int Id { get; set; }

    [Column("OERPcodeValue")]
    public string Value { get; set; } = null!;

    public bool IsActive { get; set; }
}
