using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("FWC_BusinessRequestFields")]
public partial class FwcBusinessRequestFields
{
    [Column("FieldId")]
    public string? Id { get; set; }
    public string? FieldName { get; set; }
    public int NumStep { get; set; }
    public bool IsBasicField { get; set; }
    public string? FieldIdParent { get; set; }

    //public virtual ICollection<FWC_BusinessRequestRequiredFields> FWC_BusinessRequestRequiredFields { get; set; }
}