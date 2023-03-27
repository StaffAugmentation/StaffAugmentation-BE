namespace Core.Model
{
    public class RecruitmentResp
    {
        public int Id { get; set; }
        public string? ResponsibleName { get; set; }
        public string? ResponsibleEmail { get; set; }
        public bool IsPartner { get; set; }
        public int? TypeOfContractId { get; set; }

    }
}
