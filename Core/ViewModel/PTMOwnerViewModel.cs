using Core.Model;

namespace Core.ViewModel;

public class PTMOwnerViewModel
{
    public int Id { get; set; }
    public string ValueId { get; set; } = null!;
    public string? BA { get; set; }
    public string? BICSW { get; set; }
    public double? VatRate { get; set; }
    public bool IsStaff { get; set; }
    public string? VatNumber { get; set; }
    public ApproverViewModel? Approver { get; set; }
}