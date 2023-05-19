using Core.Model;

namespace Core.ViewModel;

public class SCTMPTMExpensesViewModel
{
    public SCTMPTMExpense TravelExpenses { get; set; }
    //public List<SCTMPTM_Expenses_ExtraCosts> listExtraCost { get; set; }
    //public List<TravelExpensesAttachmentViewModel> listTEAttachment { get; set; }
    public bool IsDeleted { get; set; }
}