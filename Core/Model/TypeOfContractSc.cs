using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
public partial class TypeOfContractSC
{
    public int Id { get; set; }

    public string ValueId { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsIntern { get; set; }

    //public virtual ICollection<BrProfileConsultant> BrProfileConsultants { get; } = new List<BrProfileConsultant>();

    //public virtual ICollection<ChangeCompany> ChangeCompanyIdCurrentTocNavigations { get; } = new List<ChangeCompany>();

    //public virtual ICollection<ChangeCompany> ChangeCompanyIdNewTocNavigations { get; } = new List<ChangeCompany>();
}