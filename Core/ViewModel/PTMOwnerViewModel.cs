namespace Core.ViewModel
{
    public class PTMOwnerViewModel
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public string? PTMOwnerBA { get; set; }
        public string? PTMOwnerBICSW { get; set; }
        public double? PTMOwnerVatRate { get; set; }
        public bool IsEveris { get; set; }
        public int? IdApprover { get; set; }
        public string? ApproverName { get; set; }

        public string? PTMOwnerVatNumber { get; set; }
    }
}
