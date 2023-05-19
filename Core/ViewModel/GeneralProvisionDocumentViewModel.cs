namespace Core.ViewModel;

public class GeneralProvisionDocumentViewModel
{
    public int Id { get; set; }
    public int ProvisionId { get; set; }
    public string? SuppDocPath { get; set; }
    public string? DWFileName { get; set; }
    public bool IsDeleted { get; set; }
}