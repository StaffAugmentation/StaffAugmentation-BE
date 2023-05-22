using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("BR_Documents")]
public partial class BrDocuments
{
    [Key]
    public int IdDocument { get; set; }
    public int IdBR { get; set; }
    public string DocTypeId { get; set; }
    public string OrigineFileName { get; set; }
    public string AppFileName { get; set; }
    public string DocFormat { get; set; }
    public string VersionDoc { get; set; }
    public string PathDoc { get; set; }
    public DateTime DateUpload { get; set; }
    public string LoginUpload { get; set; }

    public virtual TypeDocument TypeDocument { get; set; }
    public virtual BusinessRequest BusinessRequest { get; set; }
}