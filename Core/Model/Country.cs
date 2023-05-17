using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    [Table("Countries")]
    public partial class Country
    {
        public int Id { get; set; }

        public string CountryName { get; set; } = null!;

        public bool IsVisible { get; set; }

        [Column("Hotel_Ceiling")]
        public double? HotelCeiling { get; set; }

        [Column("Daily_Allowance")]
        public double? DailyAllowance { get; set; }

        public virtual ICollection<Consultant> Consultants { get; } = new List<Consultant>();

        //public virtual ICollection<ScfpExpense> ScfpExpenses { get; } = new List<ScfpExpense>();

        //public virtual ICollection<ScposExpense> ScposExpenses { get; } = new List<ScposExpense>();

        //public virtual ICollection<ScqtmExpense> ScqtmExpenses { get; } = new List<ScqtmExpense>();

        //public virtual ICollection<SctmptmExpense> SctmptmExpenses { get; } = new List<SctmptmExpense>();
    }
}
