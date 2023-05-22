using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class ResourceType
{
    public int Id { get; set; }
    public string ValueId { get; set; }
    public virtual ICollection<Candidate> Candidates { get; set; }
    public virtual ICollection<BrCandidateList> BrCandidateList { get; set; }
}