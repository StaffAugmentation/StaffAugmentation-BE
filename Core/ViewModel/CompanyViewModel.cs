namespace Core.ViewModel;
public class CompanyViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? BankAccount { get; set; }
    public bool IsEveris { get; set; }
    public string? VatLegalEntity { get; set; }
    public string? BICSW { get; set; }
    public double? VatRate { get; set; }
    public string? Email { get; set; }
    public ApproverViewModel? Approver { get; set; }
}