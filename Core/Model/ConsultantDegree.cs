using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public partial class ConsultantDegree
    {
        public int Id { get; set; }

        public string ValueId { get; set; } = null!;

        public bool? IsActive { get; set; }

        public virtual ICollection<Consultant> Consultants { get; } = new List<Consultant>();
    }
}
