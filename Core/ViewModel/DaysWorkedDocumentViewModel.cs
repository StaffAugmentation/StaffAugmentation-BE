namespace Core.ViewModel;

public class DaysWorkedDocumentViewModel
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public string? SuppDocPath { get; set; }
    public DateTime? DateUploadFile { get; set; }
    public int? IdDaysWorked { get; set; }
    public bool IsDeleted { get; set; }
    public string? DWFileName { get; set; }
}