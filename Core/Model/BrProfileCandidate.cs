using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("BR_ProfileCandidate")]
public class BrProfileCandidate
{
    public int Id { get; set; }
    public int IdBrCandidate { get; set; }
    public int? IdBrProfile { get; set; }
    public int? IdStatus { get; set; }
}