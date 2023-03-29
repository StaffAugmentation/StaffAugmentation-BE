namespace Core.ViewModel
{
    public class SubContractorViewModel
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public string? BA { get; set; }
        public string? BICSW { get; set; }
        public double? VatRate { get; set; }
        public bool IsOfficial { get; set; }
        public string? LegalEntityName { get; set; }
        public string? LegalEntityAddress { get; set; }
        public string? VatNumber { get; set; }
        public string? IdNumber { get; set; }
        public ApproverViewModel? Approver { get; set; }
        public PaymentTermViewModel? PaymentTerm { get; set; }
        public TypeOfCostViewModel? TypeOfCost { get; set; }
    }
}