using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    [Table("BR_Consultant")]
    public partial class BRConsultant
    {
        public int Id { get; set; }

        public string? FrameworkContract { get; set; }

        [Column("RquestReference")]
        public string? RequestReference { get; set; }

        public string? Comment { get; set; }

        public int BRId { get; set; }

        public int ConsultantId { get; set; }

        public int? CandidateId { get; set; }

        public virtual BusinessRequest BusinessRequest { get; set; } = null!;

        public virtual Consultant Consultant { get; set; } = null!;
    }

}
