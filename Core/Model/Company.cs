using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class Company
    {
        [Key]
        public int IdCompany { get; set; }

        public string CompanyName { get; set; } = null!;

        public string? BankAccount { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsEveris { get; set; }

        public string? CmpVatlegalEntity { get; set; }

        public string? CmpBicsw { get; set; }

        public double? CmpVatRate { get; set; }

        public int? IdApproverCmp { get; set; }

        public string? CmpEmail { get; set; }

        //public virtual ICollection<BrProfile> BrProfiles { get; } = new List<BrProfile>();

        //public virtual ICollection<ChangeCompany> ChangeCompanyIdCompanyToNavigations { get; } = new List<ChangeCompany>();

        //public virtual ICollection<ChangeCompany> ChangeCompanyIdInitialCompanyNavigations { get; } = new List<ChangeCompany>();

        //public virtual ICollection<ScDaysWorkedByMonth> ScDaysWorkedByMonths { get; } = new List<ScDaysWorkedByMonth>();
    }
}
