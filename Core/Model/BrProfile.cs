using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    [Table("BR_Profile")]
    public partial class BRProfile
    {
        [Key]
        public int Id { get; set; }

        public int IdProfile { get; set; }

        public int? IdLevel { get; set; }

        public int IdBr { get; set; }

        public double? NumberOfDays { get; set; }

        public string? OnSite { get; set; }

        public double? DailyPrice { get; set; }

        public int? IdCategory { get; set; }

        public string? IdRequestFromStatus { get; set; }

        [Column("dt_SentToCustomer")]
        public DateTime? DtSentToCustomer { get; set; }

        [Column("dt_Acceptance")]
        public DateTime? DtAcceptance { get; set; }

        [Column("dt_Refusal")]
        public DateTime? DtRefusal { get; set; }

        [Column("Other_Expertise_Required")]
        public string? OtherExpertiseRequired { get; set; }

        [Column("Penalty_Amount")]
        public double? PenaltyAmount { get; set; }

        [Column("Penalty_Days")]
        public int? PenaltyDays { get; set; }

        public string? PenaltyComment { get; set; }

        [Column("dt_Proposal_Is_Submitted_To_Customer")]
        public DateTime? DtProposalIsSubmittedToCustomer { get; set; }

        [Column("dt_FO_Deadline")]
        public DateTime? DtFoDeadline { get; set; }

        [Column("dt_FO_Is_Submitted_To_Customer")]
        public DateTime? DtFoIsSubmittedToCustomer { get; set; }

        [Column("dt_ChangeOffer")]
        public DateTime? DtChangeOffer { get; set; }

        [Column("dt_ChangeOffer_Is_Submitted_To_Customer")]
        public DateTime? DtChangeOfferIsSubmittedToCustomer { get; set; }

        public int? IdCurrency { get; set; }

        [Column("Penalty_idCurrency")]
        public int? PenaltyIdCurrency { get; set; }

        [Column("id_Service_Level_Category")]
        public int? IdServiceLevelCategory { get; set; }

        public bool? ApplyItEquipment { get; set; }

        public int? IdCompany { get; set; }

        [Column("Bank_Account")]
        public string? BankAccount { get; set; }

        [Column("Validity_Date")]
        public DateTime? ValidityDate { get; set; }

        public bool? ApplyContractorPremises { get; set; }

        [Column("Place_Of_Execution")]
        public string? PlaceOfExecution { get; set; }

        [ForeignKey("IdBr")]
        public virtual BusinessRequest BusinessRequest { get; set; } = null!;

        [ForeignKey("IdCategory")]
        public virtual Category? Category { get; set; }

        [ForeignKey("IdCompany")]
        public virtual Company? Company { get; set; }

        [ForeignKey("IdCurrency")]
        public virtual CurrencyRateParam? CurrencyRateParam { get; set; }

        [ForeignKey("IdLevel")]
        public virtual Level? Level { get; set; }

        [ForeignKey("IdProfile")]
        public virtual Profile Profile { get; set; } = null!;
    }
}
