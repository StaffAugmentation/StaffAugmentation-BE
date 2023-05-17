namespace Core.Model
{
    public partial class ContractStatus
    {
        public int Id { get; set; }

        public string ValueId { get; set; } = null!;

        public bool IsActive { get; set; }

        //public virtual ICollection<ScfollowUpProvision> ScfollowUpProvisions { get; } = new List<ScfollowUpProvision>();

        //public virtual ICollection<SprintContract> SprintContracts { get; } = new List<SprintContract>();
    }
}
