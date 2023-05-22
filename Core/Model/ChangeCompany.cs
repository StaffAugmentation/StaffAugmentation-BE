using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Model;

public partial class ChangeCompany
{
    public int Id { get; set; }
    
    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }

    public int IdInitialCompany { get; set; }
    
    public int IdCompanyTo { get; set; }

    public int IdCurrentTOC { get; set; }
    
    public int IdNewTOC { get; set; }

    public int IdBR { get; set; }
    
    public int IdConsultant { get; set; }
    
    public bool IsChanged { get; set; }
    public DateTime DateUpdate { get; set; }
    public string EVUserName { get; set; }
    public string Comment { get; set; }
    public string OERPProjectCode { get; set; }
    public int? IdBRProfile { get; set; }

    [ForeignKey("IdConsultant")]
    public virtual Consultant Consultant { get; set; }

    [ForeignKey("IdNewTOC")]
    public virtual TypeOfContractSC TypeOfContractSC { get; set; }

    //[ForeignKey("IdNewTOC")]
    //public virtual TypeOfContractSC TypeOfContractSC1 { get; set; }

    [ForeignKey("IdCompanyTo")]
    public virtual Company Company { get; set; }

    //[ForeignKey("IdCompanyTo")]
    //public virtual Company Company1 { get; set; }

    [ForeignKey("IdBR")]
    public virtual BusinessRequest BusinessRequest { get; set; }
}