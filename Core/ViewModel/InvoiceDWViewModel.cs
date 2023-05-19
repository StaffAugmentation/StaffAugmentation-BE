using Core.Model;

namespace Core.ViewModel;

public class InvoiceDWViewModel
{
    public InvoiceSC? Invoice { get; set; }
    public bool IsChange { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsCanceled { get; set; }

    //public List<InvoiceSCDWViewModel> listDaysWorked { get; set; }
    //public List<InvoicesSC_OERPCode> listOERP { get; set; }
    //public List<InvoiceDWProvisionTMPTMViewModel> listDaysWorkedProvision { get; set; }
    //public List<InvoiceGeneralProvisionTMPTMViewModel> listGeneralProvision { get; set; }
}
