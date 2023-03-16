using System.ComponentModel.DataAnnotations;

namespace Core.Model
{
    public class BrSource
    {
        [Key]
        public string IdSource { get; set; } = null!;
        public string SourceName { get; set; } = null!;
    }
}
