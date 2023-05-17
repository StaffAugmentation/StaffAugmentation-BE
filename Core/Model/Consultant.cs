using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public partial class Consultant
    {
        public int IdConsultant { get; set; }

        [Column("Cons_Fname")]
        public string Firstname { get; set; } = null!;

        [Column("Cons_Lname")]
        public string Lastname { get; set; } = null!;

        [Column("Cons_Role")]
        public string? Role { get; set; }

        [Column("Cons_Email")]
        public string? Email { get; set; }

        [Column("Cons_Phone")]
        public string? Phone { get; set; }

        [Column("Cons_Nationality")]
        public string? Nationality { get; set; }

        [Column("Risk_Departure")]
        public bool? RiskDeparture { get; set; }

        [Column("Risk_Departure_Comment")]
        public string? RiskDepartureComment { get; set; }

        [Column("Dt_Planned_Leave")]
        public DateTime? DtPlannedLeave { get; set; }

        public string? LegalEntityName { get; set; }

        [Column("LegalEntityAdress")]
        public string? LegalEntityAddress { get; set; }

        [Column("VAT_Number")]
        public string? VatNumber { get; set; }

        [Column("ID_Number")]
        public string? IdNumber { get; set; }

        public bool? IsPartner { get; set; }

        public string? IdPaymentTerm { get; set; }

        public string? IdTypeOfCost { get; set; }

        public string? ProjectCode { get; set; }

        [Column("Cons_BA")]
        public string? BA { get; set; }

        [Column("BICSW")]
        public string? Cons_BICSW { get; set; }

        public string? ClientProjectManager { get; set; }

        public string? ClientProjectManagerContact { get; set; }

        public DateTime? EarliestStartDate { get; set; }

        public string? CompanyRegistrationNumber { get; set; }

        [Column("Cons_Birthdate")]
        public DateTime? Birthdate { get; set; }

        [Column("VAT_Rate")]
        public double? VatRate { get; set; }

        public double? Cost { get; set; }

        public int? IdTypeOfContract { get; set; }

        [Column("cons_third_party_rate")]
        public double? ThirdPartyRate { get; set; }

        [Column("cons_Comment")]
        public string? Comment { get; set; }

        public int? IdConsultantDegree { get; set; }

        [Column("idApprover_Cons")]
        public int? IdApprover { get; set; }

        public int? IdCountry { get; set; }

        [Column("IT_career_started")]
        public DateTime? ItCareerStarted { get; set; }

        public bool AcceleratePayment { get; set; }

        [Column("Nbr_AcceleratePayment")]
        public int? NbrAcceleratePayment { get; set; }

        [Column("Nbr_RemainingAcceleratePayment")]
        public int? NbrRemainingAcceleratePayment { get; set; }

        public int IdCandidate { get; set; }

        [Column("ConsCost_idCurrency")]
        public int? CostIdCurrency { get; set; }

        [Column("TPRate_idCurrency")]
        public int? TPRateIdCurrency { get; set; }

        [Column("SAP_vendor")]
        public string? SAPVendor { get; set; }

        public string? OERPEmployeeNumber { get; set; }

        public virtual ConsultantDegree? ConsultantDegree { get; set; }

        public virtual Country? Country { get; set; }

        public virtual PaymentTerm? PaymentTerms { get; set; }

        public virtual TypeOfCost? TypeOfCost { get; set; }

        public virtual ICollection<BRConsultant> BrConsultants { get; } = new List<BrConsultant>();

        //public virtual ICollection<ChangeCompany> ChangeCompanies { get; } = new List<ChangeCompany>();

        //public virtual ICollection<ChangeConsultantCostProvision> ChangeConsultantCostProvisions { get; } = new List<ChangeConsultantCostProvision>();

        //public virtual ICollection<ChangeConsultantCost> ChangeConsultantCosts { get; } = new List<ChangeConsultantCost>();

        //public virtual ICollection<ChangePtmrate> ChangePtmrates { get; } = new List<ChangePtmrate>();

        //public virtual ICollection<ChangeThirdPartyRateProvision> ChangeThirdPartyRateProvisions { get; } = new List<ChangeThirdPartyRateProvision>();

        //public virtual ICollection<ChangeThirdPartyRate> ChangeThirdPartyRates { get; } = new List<ChangeThirdPartyRate>();

        //public virtual ICollection<ScfpExpense> ScfpExpenses { get; } = new List<ScfpExpense>();

        //public virtual ICollection<ScposExpense> ScposExpenses { get; } = new List<ScposExpense>();

        //public virtual ICollection<ScqtmExpense> ScqtmExpenses { get; } = new List<ScqtmExpense>();

        //public virtual ICollection<SctmptmExpense> SctmptmExpenses { get; } = new List<SctmptmExpense>();
    }
}
