using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Column("cmp_VATLegalEntity")]
        public string? VatLegalEntity { get; set; }

        [Column("cmp_BICSW")]
        public string? BICSW { get; set; }

        [Column("cmp_VAT_Rate")]
        public double? VatRate { get; set; }

        [Column("idApproverCmp")]
        public int? IdApprover { get; set; }

        [Column("Cmp_Email")]
        public string? Email { get; set; }
    }
}
