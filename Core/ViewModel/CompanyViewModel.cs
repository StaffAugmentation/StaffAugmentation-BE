namespace Core.ViewModel
{
    public class CompanyViewModel
    {
        public int IdCompany { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? BankAccount { get; set; }
        public bool IsEveris { get; set; }
        public string? CmpVatlegalEntity { get; set; }
        public string? CmpBicsw { get; set; }
        public double? CmpVatRate { get; set; }
        public int? IdApproverCmp { get; set; }
        public string? ApproverName { get; set; }
        public string? CmpEmail { get; set; }
    }
}