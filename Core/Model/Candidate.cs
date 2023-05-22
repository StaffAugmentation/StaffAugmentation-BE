using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    [Table("Candidates")]
    public partial class Candidate
    {
        [Key]
        public int idCandidate { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; } 

        public bool IsPartner { get; set; }

        public int? IdResourceType { get; set; }

        public string? LegalEntityName { get; set; }

        public string? LegalEntityAdress { get; set; }

        [Column("VAT_Number")]
        public string? VatNumber { get; set; }

        [Column("ID_Number")]
        public string? IdNumber { get; set; }

        public string? IdPaymentTerm { get; set; }

        public string? IdTypeOfCost { get; set; }

        [Column("Cons_BA")]
        public string? ConsBa { get; set; }

        [Column("Cons_BICSW")]
        public string? ConsBicsw { get; set; }

        [Column("VAT_Rate")]
        public double? VatRate { get; set; }

        [Column("idApprover_Cons")]
        public int? IdApproverCons { get; set; }

        //public virtual ICollection<BrCandidateList> BrCandidateLists { get; } = new List<BrCandidateList>();

        //public virtual ICollection<CandidateInterviewFee> CandidateInterviewFees { get; } = new List<CandidateInterviewFee>();

        //public virtual ICollection<CandidateReferralFee> CandidateReferralFees { get; } = new List<CandidateReferralFee>();

        //public virtual ResourceType? IdResourceTypeNavigation { get; set; }
    }
}
