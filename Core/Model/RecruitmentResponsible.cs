using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("Recruitment_Resp")]
public class RecruitmentResponsible
{
    public int Id { get; set; }

    [Column("ResponsibleName")]
    public string? Name { get; set; }

    [Column("ResponsibleEmail")]
    public string? Email { get; set; }

    public bool IsPartner { get; set; }

    public int? TypeOfContractId { get; set; }
}
