using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public partial class ServiceLevelCategory
    {
        [Key]
        public int Id { get; set; }

        public string? ValueId { get; set; }
    }
}
