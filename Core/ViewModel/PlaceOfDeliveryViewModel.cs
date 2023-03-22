namespace Core.ViewModel
{
    public partial class PlaceOfDeliveryViewModel
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public bool? IsActive { get; set; }
        //public virtual ICollection<BusinessRequest> BusinessRequests { get; } = new List<BusinessRequest>();
    }
}
