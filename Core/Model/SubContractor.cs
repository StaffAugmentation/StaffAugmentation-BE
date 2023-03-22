namespace Core.Model
{
    public class SubContractor
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public string? SubContBa { get; set; }
        public string? SubContBicsw { get; set; }
        public double? SubContVatRate { get; set; }
        public bool IsOfficial { get; set; }
        public int? IdApproverSub { get; set; }
        public string? LegalEntityName { get; set; }
        public string? LegalEntityAdress { get; set; }
        public string? VatNumber { get; set; }
        public string? IdNumber { get; set; }
        public string? IdPaymentTerm { get; set; }
        public string? IdTypeOfCost { get; set; }

    }
}
