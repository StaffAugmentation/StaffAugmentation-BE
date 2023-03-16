using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class BrType
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
