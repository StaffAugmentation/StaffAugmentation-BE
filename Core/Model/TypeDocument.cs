using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class TypeDocument
{
    [Key]
    public string IdTypeDoc { get; set; }
    public string DocumentType { get; set; }
    public string Naming { get; set; }
    public string NumberOfDocs { get; set; }
    public string DocFormat { get; set; }
    public string LinkedTo { get; set; }
    public string ModuleName { get; set; }
    public bool DownloadFromExternal { get; set; }
    public virtual ICollection<BrDocuments> BrDocuments { get; set; }
}