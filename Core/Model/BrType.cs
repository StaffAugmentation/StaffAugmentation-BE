using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model
{
    //[Table("TypeBR")]
    public class BrType
    {
        public int Id { get; set; }
        public string ValueId { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
