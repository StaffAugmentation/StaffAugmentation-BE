using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("SCTMPTM_Expenses")]
public partial class SCTMPTMExpense
{
    public int Id { get; set; }
    public int IdSC { get; set; }
    public int IdConsultant { get; set; }
    public string? ProjectName { get; set; }
    [Column("Goal_of_mission")]
    public string? GoalOfMission { get; set; }
    [Column("Authorized_by")]
    public string? AuthorizedBy { get; set; }
    [Column("Authorized_by_Function")]
    public string? AuthorizedByFunction { get; set; }
    public int IdCountry { get; set; }
    public string? CityName { get; set; }
    [Column("isExchange_rate_applied")]
    public bool IsExchangeRateApplied { get; set; }
    [Column("Exchange_rate_applied")]
    public double? ExchangeRateApplied { get; set; }
    [Column("Exchange_rate_applied_source")]
    public string? ExchangeRateAppliedSource { get; set; }
    [Column("dt_departure_outward_journey")]
    public DateTime DtDepartureOutwardJourney { get; set; }
    [Column("dt_arrival_outward_journey")]
    public DateTime? DtArrivalOutwardJourney { get; set; }
    [Column("dt_commencement_services_rendered")]
    public DateTime? DtCommencementServicesRendered { get; set; }
    [Column("dt_cessation_services_rendered")]
    public DateTime? DtCessationServicesRendered { get; set; }
    [Column("dt_departure_return_journey")]
    public DateTime? DtDepartureReturnJourney { get; set; }
    [Column("dt_arrival_return_journey")]
    public DateTime DtArrivalReturnJourney { get; set; }
    [Column("Waiting_duration")]
    public string? WaitingDuration { get; set; }
    [Column("Total_duration_mission")]
    public string TotalDurationMission { get; set; } = null!;
    [Column("Daily_allowance_days")]
    public double? DailyAllowanceDays { get; set; }
    [Column("Train_tickect_amount")]
    public double? TrainTicketAmount { get; set; }
    [Column("Plane_ticket_amount")]
    public double? PlaneTicketAmount { get; set; }
    [Column("Transport_outward_trip_intern_amount")]
    public double? TransportOutwardTripInternAmount { get; set; }
    [Column("Transport_outward_trip_extern_amount")]
    public double? TransportOutwardTripExternAmount { get; set; }
    [Column("Transport_return_journey_intern_amount")]
    public double? TransportReturnJourneyInternAmount { get; set; }
    [Column("Transport_return_journey_extern_amount")]
    public double? TransportReturnJourneyExternAmount { get; set; }
    [Column("Number_of_nights")]
    public double? NumberOfNights { get; set; }
    [Column("Daily_allowance_amount")]
    public double? DailyAllowanceAmount { get; set; }
    [Column("Hotel_cost_per_day")]
    public double? HotelCostPerDay { get; set; }
    [Column("Maximum_hotel_cost_per_day")]
    public double? MaximumHotelCostPerDay { get; set; }
    [Column("Real_total_hotel_cost")]
    public double? RealTotalHotelCost { get; set; }
    [Column("Total_breakfast_amount")]
    public double? TotalBreakfastAmount { get; set; }
    [Column("Total_lunch_amount")]
    public double? TotalLunchAmount { get; set; }
    [Column("Total_dinner_amount")]
    public double? TotalDinnerAmount { get; set; }
    [Column("Total_allowance_amount")]
    public double? TotalAllowanceAmount { get; set; }
    [Column("Total_amount_mission")]
    public double? TotalAmountMission { get; set; }
    [Column("Total_extraCost_mission")]
    public double? TotalExtraCostMission { get; set; }
    [Column("Grand_total_mission")]
    public double? GrandTotalMission { get; set; }
    public string IdPaymentMissionStatus { get; set; } = null!;
    public string IdInvoicingMissionStatus { get; set; } = null!;
    public string LoginCreation { get; set; } = null!;
    public string LoginUpdate { get; set; } = null!;
    public DateTime DateCreation { get; set; }
    public DateTime DateUpdate { get; set; }
    public string? CustomAttachmentId { get; set; }
    public int? IdBRProfile { get; set; }

    [ForeignKey("IdConsultant")]
    public virtual Consultant Consultant { get; set; } = null!;

    [ForeignKey("IdCountry")]
    public virtual Country Country { get; set; } = null!;

    [ForeignKey("IdSC")]
    public virtual SprintContract SprintContract { get; set; } = null!;

    //public virtual ICollection<ScDocumentsTravelExpense> ScDocumentsTravelExpenses { get; } = new List<ScDocumentsTravelExpense>();
    //public virtual ICollection<SctmptmExpensesExtraCost> SctmptmExpensesExtraCosts { get; } = new List<SctmptmExpensesExtraCost>();
    //public virtual ICollection<SctmptmExpensesInvoicesMission> SctmptmExpensesInvoicesMissions { get; } = new List<SctmptmExpensesInvoicesMission>();
    //public virtual ICollection<SctmptmExpensesPaymentMission> SctmptmExpensesPaymentMissions { get; } = new List<SctmptmExpensesPaymentMission>();
}
