using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;
[Table("CurrencyRateParams")]
public partial class CurrencyRateParam
{
    public int Id { get; set; }



    public string CurrencyName { get; set; } = null!;



    public string CurrencyCode { get; set; } = null!;



    public string CurrencySymbol { get; set; } = null!;



    public double ExchangeRate { get; set; }



    public bool IsDefault { get; set; }



    //public virtual ICollection<BrProfile> BrProfiles { get; } = new List<BrProfile>();



    //public virtual ICollection<CurrencyExchangeRate> CurrencyExchangeRates { get; } = new List<CurrencyExchangeRate>();
}
