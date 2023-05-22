using Microsoft.EntityFrameworkCore;
using Core.Model;

namespace Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Company> Company => Set<Company>();
        public DbSet<Department> Department => Set<Department>();
        public DbSet<Approver> Approver => Set<Approver>();
        public DbSet<Profile> Profile => Set<Profile>();
        public DbSet<BrSource> BrSource => Set<BrSource>();
        public DbSet<BrType> BrType => Set<BrType>();
        public DbSet<SubContractor> SubContractor => Set<SubContractor>();
        public DbSet<TypeOfCost> TypeOfCost => Set<TypeOfCost>();
        public DbSet<PaymentTerm> PaymentTerm => Set<PaymentTerm>();
        public DbSet<Level> Level => Set<Level>();
        public DbSet<PTMOwner> PTMOwner => Set<PTMOwner>();
        public DbSet<Core.Model.Type> Type => Set<Core.Model.Type>();
        public DbSet<Category> Category => Set<Category>();
        public DbSet<PlaceOfDelivery> PlaceOfDelivery => Set<PlaceOfDelivery>();
        public DbSet<RecruitmentResponsible> RecruitmentResponsible => Set<RecruitmentResponsible>();
        public DbSet<HighestDegree> HighestDegree => Set<HighestDegree>();
        public DbSet<RequestFormStatus> RequestFormStatus => Set<RequestFormStatus>();
        public DbSet<OERPCode> OERPCode => Set<OERPCode>();
        public DbSet<AppParameter> AppParameter => Set<AppParameter>();
        public DbSet<BusinessRequest> BusinessRequest => Set<BusinessRequest>();
        public DbSet<SprintContract> SprintContract => Set<SprintContract>();
        public DbSet<BRConsultant> BRConsultant => Set<BRConsultant>();
        public DbSet<Consultant> Consultant => Set<Consultant>();
        public DbSet<BRProfile> BRProfile => Set<BRProfile>();
        public DbSet<CurrencyRateParam> CurrencyRateParam => Set<CurrencyRateParam>();
        public DbSet<ServiceLevelCategory> ServiceLevelCategory => Set<ServiceLevelCategory>();
        public DbSet<UserTypeOfContract> UserTypeOfContract => Set<UserTypeOfContract>();
        public DbSet<UserParameter> UserParameter => Set<UserParameter>();
        public DbSet<TypeOfContract> TypeOfContract => Set<TypeOfContract>();
        public DbSet<TypeOfContractSC> TypeOfContractSC => Set<TypeOfContractSC>();
        public DbSet<SprintContractOERPCode> SprintContractOERPCode => Set<SprintContractOERPCode>();
        public DbSet<BRProfileConsultant> BRProfileConsultant => Set<BRProfileConsultant>();
        public DbSet<ConsultantContractStatus> ConsultantContractStatus => Set<ConsultantContractStatus>();
        public DbSet<ContractStatus> ContractStatus => Set<ContractStatus>();
        public DbSet<SaActivityLog> SaActivityLog => Set<SaActivityLog>();
        public DbSet<InvoiceSC> InvoiceSC => Set<InvoiceSC>();
        public DbSet<InvoiceDaysWorked> InvoiceDaysWorked => Set<InvoiceDaysWorked>();
        public DbSet<PaymentSC> PaymentSC => Set<PaymentSC>();
        public DbSet<PaymentSCDaysWorked> PaymentSCDaysWorked => Set<PaymentSCDaysWorked>();
        public DbSet<SCFollowUPTMPTMTransformationNbDays> SCFollowUPTMPTMTransformationNbDays => Set<SCFollowUPTMPTMTransformationNbDays>();
        public DbSet<SCFollowUPFP> SCFollowUPFP => Set<SCFollowUPFP>();
        public DbSet<StatusBr> StatusBr => Set<StatusBr>();
        public DbSet<SCFollowUPQTM> SCFollowUPQTM => Set<SCFollowUPQTM>();
        public DbSet<SCFollowUPProvision> SCFollowUPProvision => Set<SCFollowUPProvision>();
        public DbSet<ChangeCompany> ChangeCompany => Set<ChangeCompany>();
        public DbSet<FwcBusinessRequestRequiredFields> FwcBusinessRequestRequiredFields => Set<FwcBusinessRequestRequiredFields>();
        public DbSet<BrDocuments> BrDocuments => Set<BrDocuments>();
        public DbSet<TypeDocument> TypeDocument => Set<TypeDocument>();
        public DbSet<BrCandidateList> BrCandidateList => Set<BrCandidateList>();
        public DbSet<ResourceType> ResourceType => Set<ResourceType>();
        public DbSet<CandidateDocuments> CandidateDocuments => Set<CandidateDocuments>();
        public DbSet<BrProfileCandidate> BrProfileCandidate => Set<BrProfileCandidate>();
        public DbSet<Candidate> Candidate => Set<Candidate>();
        public DbSet<EverisContractDetail> EverisContractDetail => Set<EverisContractDetail>();
        public DbSet<SCTMPTMExpense> SCTMPTMExpense => Set<SCTMPTMExpense>();
        public DbSet<ScDaysWorkedByMonth> ScDaysWorkedByMonth => Set<ScDaysWorkedByMonth>();
        public DbSet<ChangeConsultantCost> ChangeConsultantCost => Set<ChangeConsultantCost>();
        public DbSet<SCFollowUPTMPTMDaysWorkedProvision> SCFollowUPTMPTMDaysWorkedProvision => Set<SCFollowUPTMPTMDaysWorkedProvision>();
        public DbSet<SCFollowUPTMPTMInvoiceDaysWorkedProvision> SCFollowUPTMPTMInvoiceDaysWorkedProvision => Set<SCFollowUPTMPTMInvoiceDaysWorkedProvision>();
        public DbSet<SCFollowUPTMPTMPaymentDaysWorkedProvision> SCFollowUPTMPTMPaymentDaysWorkedProvision => Set<SCFollowUPTMPTMPaymentDaysWorkedProvision>();
        public DbSet<SCFollowUPTMPTMGeneralProvision> SCFollowUPTMPTMGeneralProvision => Set<SCFollowUPTMPTMGeneralProvision>();
        public DbSet<SCFollowUPTMPTMInvoiceGeneralProvision> SCFollowUPTMPTMInvoiceGeneralProvision => Set<SCFollowUPTMPTMInvoiceGeneralProvision>();
        public DbSet<SCFollowUPTMPTMPaymentGeneralProvision> SCFollowUPTMPTMPaymentGeneralProvision => Set<SCFollowUPTMPTMPaymentGeneralProvision>();
        public DbSet<SCFollowUPProvisionDaysWorked> SCFollowUPProvisionDaysWorked => Set<SCFollowUPProvisionDaysWorked>();
        public DbSet<SCFollowUPProvisionInvoiceDaysWorkedDetail> SCFollowUPProvisionInvoiceDaysWorkedDetail => Set<SCFollowUPProvisionInvoiceDaysWorkedDetail>();
        public DbSet<SCFollowUPProvisionPaymentDaysWorkedDetail> SCFollowUPProvisionPaymentDaysWorkedDetail => Set<SCFollowUPProvisionPaymentDaysWorkedDetail>();
        public DbSet<ChangeConsultantCostProvision> ChangeConsultantCostProvision => Set<ChangeConsultantCostProvision>();
        public DbSet<SCFollowUPProvisionGeneralProvision> SCFollowUPProvisionGeneralProvision => Set<SCFollowUPProvisionGeneralProvision>();
        public DbSet<HistoryBusinessRequest> HistoryBusinessRequest => Set<HistoryBusinessRequest>();

    }
}
