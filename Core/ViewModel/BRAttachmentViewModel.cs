namespace Core.ViewModel;

public class BRAttachmentViewModel
{
    public int IdAttachment { get; set; }
    public int IdBR { get; set; }
    public string? Type { get; set; }
    public string? Path { get; set; }
    public string? FileName { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public string? VersionDoc { get; set; }
    public string? DocType { get; set; }
    public string? OriginFileName { get; set; }
    public string? AppFileName { get; set; }
    public DateTime DateUpload { get; set; }
    public string? DocFormat { get; set; }
    public string? PathDoc { get; set; }
    public string? DocTypeId { get; set; }
}