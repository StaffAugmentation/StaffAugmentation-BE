namespace Core.ViewModel
{
    public class RecruitmentResponsibleViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public bool IsPartner { get; set; }
        public int? TypeOfContractId { get; set; }
    }
}