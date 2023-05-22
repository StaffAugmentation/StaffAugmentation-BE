using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("FWC_BusinessRequestRequiredFields")]
public partial class FwcBusinessRequestRequiredFields
{
    public int Id { get; set; }
    public int IdFWC { get; set; }
    public string IdStatus { get; set; }
    public string IdSource { get; set; }
    public int IdServiceType { get; set; }
    public string FieldId { get; set; }
    public bool IsRequired { get; set; }
    public virtual FwcBusinessRequestFields FWC_BusinessRequestFields { get; set; }
    public virtual TypeOfContract? TypeOfContract { get; set; }
}