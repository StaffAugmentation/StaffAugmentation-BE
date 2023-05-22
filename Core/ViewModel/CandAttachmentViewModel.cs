namespace Core.ViewModel;
public class CandAttachmentViewModel
{
    public int IdDocument { get; set; }
    public string FileName { get; set; }
    public string TypeDoc { get; set; }
    public string pathDoc { get; set; }
    public int BRCandId { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public bool isPartner { get; set; }
    public string DocTypeId { get; set; }
    public string AppFileName { get; set; }
}
