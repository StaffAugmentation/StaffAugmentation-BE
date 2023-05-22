using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public partial class CandidateDocuments
{
    [Key]
    public int IdDocument { get; set; }
    public string FileName { get; set; }
    public string TypeDoc { get; set; }
    public string PathDoc { get; set; }
    public int BRCandId { get; set; }
    public string DocTypeId { get; set; }
    public string AppFileName { get; set; }
    public virtual BrCandidateList BrCandidateList { get; set; }
}