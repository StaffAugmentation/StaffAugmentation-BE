namespace Core.Model;

public class ConsultantDataPaymentViewModel
{
    public string? ConsultantName { get; set; }
    public string? Subcontractor { get; set; }
    public double? NumberOfDays { get; set; }
    public double? MaximumAmount { get; set; }
    public double DailyRate { get; set; }
    public double? Subtotal { get; set; }
    public double ConsultantCost { get; set; }
    public double? AmountPaid { get; set; }
    public string? OERPProjectCode { get; set; }
    public string? ProfileLevel { get; set; }

    public List<double>? ListNumberOfDays { get; set; }
    public List<double>? DailyRates { get; set; }
    public List<string>? IdDraft { get; set; }
    public List<string>? OERPInvoiceCode { get; set; }
}