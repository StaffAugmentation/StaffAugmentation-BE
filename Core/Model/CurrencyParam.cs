using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

[Table("CurrencyParams")]
public partial class CurrencyParam
{
    public int Id { get; set; }

    public string CurrencyName { get; set; } = null!;

    public string CurrencySign { get; set; } = null!;

    public double ExchangeRate { get; set; }

    //public virtual ICollection<TypeOfContract> TypeOfContracts { get; } = new List<TypeOfContract>();
}