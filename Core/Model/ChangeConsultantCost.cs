using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public class ChangeConsultantCost
{
    public int Id { get; set; }
    public DateTime dateFrom { get; set; }
    public double NewConsultantCostValue { get; set; }
    public int IdSC { get; set; }
    public int IdConsultant { get; set; }
    public bool IsChanged { get; set; }
    public DateTime DateUpdate { get; set; }
    public string EVUserName { get; set; }
    public bool IsChangedFromScript { get; set; }
    public bool? isNormalPerformance { get; set; }
    public int? idBRProfile { get; set; }

    public virtual Consultant Consultant { get; set; }
    public virtual SprintContract SprintContract { get; set; }
}