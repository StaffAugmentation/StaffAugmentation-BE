namespace Shared.Utility;
public class ConstantsMessage
{
    // User management messages
    public const string MESSAGE_USER_SUCCESS_ADD = "MAU-0000";
    public const string MESSAGE_USER_SUCCESS_UPD = "MUU-0000";
    public const string MESSAGE_USER_SUCCESS_DEL = "MDU-0000";
    public const string MESSAGE_USER_SUCCESS_CON = "MCU-0000";
    // ROLE management messages
    public const string MESSAGE_ROLE_SUCCESS_ADD = "MAR-0000";
    public const string MESSAGE_ROLE_SUCCESS_UPD = "MUR-0000";
    public const string MESSAGE_ROLE_SUCCESS_DEL = "MDR-0000";
    public const string MESSAGE_ROLE_SUCCESS_CON = "MCR-0000";

    // Help management messages
    public const string MESSAGE_HELP_SUCCESS_ADD = "MAH-0000";
    public const string MESSAGE_HELP_SUCCESS_UPD = "MUH-0000";
    public const string MESSAGE_HELP_SUCCESS_DEL = "MDH-0000";

    // TM Daily Price management messages
    public const string MESSAGE_TMDAILYPRICE_SUCCESS_ADD = "MATMDP-0000";
    public const string MESSAGE_TMDAILYPRICE_SUCCESS_UPD = "MUTMDP-0000";
    public const string MESSAGE_TMDAILYPRICE_SUCCESS_DEL = "MDTMDP-0000";
    public const string MESSAGE_TMDAILYPRICE_SUCCESS_CON = "MCTMDP-0000";

    // Company management messages
    public const string MESSAGE_COMPANY_SUCCESS_ADD = "MAC-0000";
    public const string MESSAGE_COMPANY_SUCCESS_UPD = "MUC-0000";
    public const string MESSAGE_COMPANY_SUCCESS_DEL = "MDC-0000";
    public const string MESSAGE_COMPANY_SUCCESS_CON = "MCC-0000";

    // Country management messages
    public const string MESSAGE_COUNTRY_SUCCESS_ADD = "MACT-0000";
    public const string MESSAGE_COUNTRY_SUCCESS_UPD = "MUCT-0000";
    public const string MESSAGE_COUNTRY_SUCCESS_DEL = "MDCT-0000";
    public const string MESSAGE_COUNTRY_SUCCESS_CON = "MCCT-0000";

    // AppParams management messages
    public const string MESSAGE_APPPARAMS_SUCCESS_ADD = "MAAP-0000";
    public const string MESSAGE_APPPARAMS_SUCCESS_UPD = "MUAP-0000";
    public const string MESSAGE_APPPARAMS_SUCCESS_DEL = "MDAP-0000";
    public const string MESSAGE_APPPARAMS_SUCCESS_CON = "MCAP-0000";

    //ReportParams managment error
    public const string MESSAGE_REPORTPARAMS_SUCCESS_ADD = "RPPA-0000";
    public const string ERROR_INVALID_FORECAST = "EINF-0000";
    // BR management messages
    public const string MESSAGE_BR_SUCCESS_ADD = "MABR-0000";
    public const string MESSAGE_BR_SUCCESS_UPD = "MUBR-0000";
    public const string MESSAGE_BR_SUCCESS_DEL = "MDBR-0000";
    public const string MESSAGE_BR_SUCCESS_CON = "MCBR-0000";
    public const string MESSAGE_BR_SUCCESS_ADDHIS = "MAHBR-0000";
    public const string MESSAGE_BR_NOT_ASSIGNED_SC = "MBRNA-0000";
    public const string MESSAGE_BR_INCORRECT_DW = "MBRID-0000";
    public const string MESSAGE_USER_DELETE_CURRENTLY_LOGGED = "MUDCL-0000";
    public const string MESSAGE_BR_SUCCESS_COMMENT = "MBRSC-0000";
    public const string MESSAGE_BR_SUCCESS_UPDATE_RESOURCE_TYPE = "MBRSURT-0000";
    public const string MESSAGE_CANDIDATE_ASSIGNED_TO_BR = "MCATBR-0000";
    public const string MESSAGE_CANDIDATE_NOT_ASSIGNED_TO_BR = "MCNATBR-0000";
    public const string ERROR_BRPROFILE_ASIGN_TO_CONSULTANT = "MPATC-0000";
    public const string ERROR_BRPROFILE_ASIGN_TO_CONSULTANT_SC = "MPACSC-0000";
    // ROLE management errors
    public const string ERROR_ROLE_NAME_EXIST = "ERR-0001";
    public const string ERROR_ROLE_ASSIGNED_USER = "ERR-0002";
    public const string ERROR_ROLE_NOTFOUND = "ERR-0003";
    public const string ERROR_ROLE_ASSIGNED_MODULE = "ERR-0004";
    public const string ERROR_Delete_ROLE = "ERR-0005";
    // User management errors
    public const string ERROR_USER_CODE_EXIST = "ERU-0001";
    public const string ERROR_USER_EMAIL_EXIST = "ERU-0002";
    public const string ERROR_USER_NOTFOUND = "ERU-0003";
    public const string ERROR_USER_NOTVALID = "ERU-0004";
    public const string ERROR_USER_EMAIL_NOTVALID = "ERU-0005";
    public const string ERROR_USER_USERNAME_NOTVALID = "ERU-0006";
    public const string USER_EMAIL_VALID = "ERU-0007";
    public const string USER_DE_VALID = "ERU-0007";
    public const string ERROR_USER_EXIST = "ERUE-0000";

    // Help management errors

    public const string ERROR_HELP_EXIST = "ERH-0001";
    public const string ERROR_HELP_NOTFOUND = "ERH-0002";
    public const string ERROR_HELP_NOTVALID = "ERH-0003";

    // TM Daily Price management errors

    public const string ERROR_TMDAILYPRICE_EXIST = "ERTMDP-0001";
    public const string ERROR_TMDAILYPRICE_NOTFOUND = "ERTMDP-0002";
    public const string ERROR_TMDAILYPRICE_NOTVALID = "ERTMDP-0003";

    // Company management errors

    public const string ERROR_COMPANY_EXIST = "ERC-0001";
    public const string ERROR_COMPANY_NOTFOUND = "ERC-0002";
    public const string ERROR_COMPANY_NOTVALID = "ERC-0003";
    public const string ERROR_COMPANY_ASSIGNED_TO_BR = "ERC-0004";
    public const string ERROR_COMPANY_EMAIL_EXIST = "ERC-0005";

    // Country management errors

    public const string ERROR_COUNTRY_EXIST = "ERCT-0001";
    public const string ERROR_COUNTRY_NOTFOUND = "ERCT-0002";
    public const string ERROR_COUNTRY_NOTVALID = "ERCT-0003";
    public const string ERROR_COUNTRY_ASSIGNED_TO_CONST = "ERCT-0004";
    public const string MESSAGE_COUNTRY_ASSIGNED_TO_MISSION = "ERCAM-0004";

    // AppParams management errors

    public const string ERROR_APPPARAMS_EXIST = "ERAP-0001";
    public const string ERROR_APPPARAMS_NOTFOUND = "ERAP-0002";
    public const string ERROR_APPPARAMS_NOTVALID = "ERAP-0003";

    public const string ERROR_TEMPLATE_IDINVALID = "ERAP-0004";

    //Report managment errors
    public const string ERROR_REPORTPARAMS_NOTVALID = "ERPA-0000";


    // BR management errors
    public const string ERROR_BR_REQUEST_NBR_EXIST = "ERBR-0001";
    public const string ERROR_BR_NOTVALID = "ERBR-0002";
    public const string ERROR_BR_NOTFOUND = "ERBR-0003";
    public const string ERROR_BR_ASSIGNED_MODULE = "ERBR-0004";
    public const string ERROR_BR_LINKEDBR_REQUIRED = "ERBR-0005";
    public const string ERROR_BR_ASIGN_TO_SC = "ERBR-0006";
    public const string ERROR_BR_ASIGN_TO_SC_TM = "ERBR-0010";
    public const string ERROR_BR_ASIGN_TO_SC_PTM = "ERBR-0011";
    public const string ERROR_BR_ASIGN_TO_QTM = "ERBR-0007";
    public const string ERROR_BR_ASIGN_TO_FP = "ERBR-0008";
    public const string ERROR_BR_ASIGN_TO_SC_CHANGE_STATUS = "ERBR-0009";
    public const string ERROR_BR_SUCCESS_UPDATE_RESOURCE_TYPE = "ERBR-0013";
    public const string ERROR_BR_NDAYS_CONSULTANT_EXCEED = "ERBR-0014";
    public const string ERROR_BR_CONSULTANTS_NO_PROFILE = "ERBR-0015";
    public const string ERROR_BR_CONSULTANTS_PROFILE_AFFECTED = "ERBR-0016";
    public const string ERROR_SUBTOTAL_EXCEED_TOTAL_PRICE = "ERBR-0017";
    public const string ERROR_StatusBR_NOTVALID = "ESBR-0019";

    // External error
    public const string ERROR_USER_EXTERNAL_ERROR = "ERE-1111";
    public const string ERROR_ROLE_EXTERNAL_ERROR = "ERE-2222";
    public const string ERROR_BR_EXTERNAL_ERROR = "ERE-3333";
    public const string ERROR_HBR_EXTERNAL_ERROR = "ERE-1515";
    public const string ERROR_SC_EXTERNAL_ERROR = "ERE-4444";
    public const string ERROR_HSC_EXTERNAL_ERROR = "ERE-5555";
    public const string ERROR_FP_EXTERNAL_ERROR = "ERE-6666";
    public const string ERROR_HFP_EXTERNAL_ERROR = "ERE-7777";
    public const string ERROR_DAYSWORKED_EXTERNAL_ERROR = "ERE-8888";
    public const string ERROR_QTM_EXTERNAL_ERROR = "ERE-9999";
    public const string ERROR_HQTM_EXTERNAL_ERROR = "ERE-1010";
    public const string ERROR_SUBTASKS_EXTERNAL_ERROR = "ERE-1111";
    public const string ERROR_HELP_EXTERNAL_ERROR = "ERE-1212";
    public const string ERROR_COMPANY_EXTERNAL_ERROR = "ERE-2121";
    public const string ERROR_COUNTRY_EXTERNAL_ERROR = "ERE-1919";
    public const string ERROR_APPPARAMS_EXTERNAL_ERROR = "ERE-1313";
    public const string ERROR_CONSULTANTINFORMATION_EXTERNAL_ERROR = "ERE-1313";
    public const string ERROR_LIST_ATTACHMENTS_EXTERNAL_ERROR = "ER-1414";
    public const string ERROR_FR_EXTERNAL_ERROR = "ERE-3131";
    public const string ERROR_TMDAILYPRICE_EXTERNAL_ERROR = "ERE-4141";
    public const string ERROR_CONBR_EXTERNAL_ERROR = "ERE-1515";
    public const string ERROR_PROFILEBR_EXTERNAL_ERROR = "ERE-1616";
    public const string ERROR_INVOICES_EXTERNAL_ERROR = "ERE-1717";
    public const string ERROR_RS_EXTERNAL_ERROR = "ERE-0018";
    public const string ERROR_LEVELPRTOC_EXTERNAL_ERROR = "ERE-0019";
    public const string ERROR_DEPARTMENT_EXTERNAL_ERROR = "ERE-0020";
    public const string ERROR_RECRUITMENT_EXTERNAL_ERROR = "ERE-0021";
    public const string ERROR_CANASCONS_EXTERNAL_ERROR = "ERE-0022";
    public const string ERROR_CANDIDATE_EXTERNAL_ERROR = "ERE-0023";
    public const string ERROR_DOCS_CANDIDATE_EXTERNAL_ERROR = "ERE-0024";
    public const string ERROR_CON_EXTERNAL_ERROR = "ERE-8787";
    public const string ERROR_CAN_EXTERNAL_ERROR = "ERE-8788";
    public const string ERROR_LIST_DW_DELETE = "ERE-99990";
    public const string ERROR_SCINVOICE_EXTERNAL_ERROR = "ERE-0025";
    public const string ERROR_SCPAYMENT_EXTERNAL_ERROR = "ERE-0026";
    public const string ERROR_SESSION_EXTERNAL_ERROR = "ERE-2626";
    public const string ERROR_TYPE_DOCS_EXTERNAL_ERROR = "ERE-27227";
    public const string ERROR_CATEGORY_TOC_EXTERNAL_ERROR = "ERE-28228";
    public const string ERROR_COMPANY_TOC_EXTERNAL_ERROR = "ERE-29229";
    public const string ERROR_PLD_TOC_EXTERNAL_ERROR = "ERE-30230";
    public const string ERROR_INVOICE_SUBTASK_EXTERNAL_ERROR = "ERE-3030";
    public const string ERROR_QTMDAILYPRICE_EXTERNAL_ERROR = "ERE-3131";
    public const string ERROR_PAYMENTFP_EXTERNAL_ERROR = "ERE-3232";
    public const string ERROR_PAYMENTQTM_EXTERNAL_ERROR = "ERE-3233";
    public const string ERROR_SUBCONTRACTOR_EXTERNAL_ERROR = "ERE-3333";
    public const string ERROR_PAYMENTSCHEDULE_EXTERNAL_ERROR = "ERE-3434";
    public const string ERROR_Payment_EXTERNAL_ERROR = "ERE-0034";
    public const string ERROR_CONSULTANT_EXTERNAL_ERROR = "ERE-3535";
    public const string ERROR_STATUS_EXTERNAL_ERROR = "ERE-3636";
    public const string ERROR_BR_ASIGN_TO_PROVISION = "ERE-3737";
    //ModuleRole mangement messages
    public const string MESSAGE_ROLE_EXIST = "MRE-0001";
    //ModuleRole mangement Errors
    public const string ERROR_ROLE_NOT_EXIST = "ERR-0001";
    public const string ERROR_ROLE_NOTVALID = "ERR-002";
    // TypeOfContract management messages
    public const string MESSAGE_P_SUCCESS_ADD = "MAP-0000";
    public const string MESSAGE_P_SUCCESS_UPD = "MUP-0000";
    public const string MESSAGE_P_SUCCESS_DEL = "MDP-0000";
    // TypeOfContract management errors
    public const string ERROR_P_VALUE_EXIST = "ERP-0001";
    public const string ERROR_P_NOTFOUND = "ERP-0002";
    public const string ERROR_P_NOTVALID = "ERP-0003";
    // External error TypeOfContract
    public const string ERROR_P_EXTERNAL_ERROR = "ERE-3333";
    //Request errors
    public const string MESSAGE_BR_EXIST = "MBRE-0001";
    //params errors
    public const string MESSAGE_CONST_EXIST = "MCONSTE-0001";
    //profiletypeofcontract management
    public const string MESSAGE_TYPE_PROFILE_ADD = "MAPT-0000";
    public const string MESSAGE_PTOC_EXIST = "MPTOE-0001";
    public const string MESSAGE_CTOC_EXIST = "MCTOE-0001";
    public const string MESSAGE_PODTOC_EXIST = "MPODTOE-0001";
    public const string MESSAGE_COMPTOC_EXIST = "MCOMPTOE-0001";
    //profiletypeofcontract errors
    public const string ERROR_TYPE_PROFILE_NOTVALID = "EPTOC-0003";
    public const string ERROR_TYPE_PROFILE_NOTFOUND = "EPTOC-0004";

    // CONFIG management 
    public const string MESSAGE_USER_CONFIG_SUCCESS_UPD = "MCSU-0000";
    public const string ERROR_USER_CONFIG = "EUC-0001";
    //TM Control Succes Messages
    public const string MESSAGE_SC_SUCCESS_ADD = "MASC-0000";
    public const string MESSAGE_SC_SUCCESS_UPD = "MUSC-0000";
    public const string MESSAGE_SC_SUCCESS_DEL = "MDSC-0000";
    public const string MESSAGE_SC_SUCCESS_CON = "MCSC-0000";
    public const string MESSAGE_SCH_SUCCESS_ADDHIS = "MAHSC-0000";
    public const string MESSAGE_DAYSWORKED_PROVISION_SUCCESS_DELETE = "MDPSC-0000";
    public const string MESSAGE_UPDATE_FORECAST_SUCCESS = "MUFS-0001";
    public const string MESSAGE_MONTH_EXIST = "MME-0001";
    public const string ERROR_MONTH_NOT_FOUND = "EMNF-0001";
    public const string MESSAGE_MONTH_NOT_EXIST = "MMNE-0001";

    // TM Control management errors
    public const string ERROR_SC_REQUEST_NBR_EXIST = "ERSC-0001";
    public const string ERROR_SC_NOTVALID = "ERSC-0002";
    public const string ERROR_SC_NOTFOUND = "ERSC-0003";
    public const string ERROR_SC_ASSIGNED_MODULE = "ERSC-0004";
    public const string ERROR_SC_EXIST = "ERSC-0004";
    public const string ERROR_BR_ASSIGNED_SC = "ERSC-0005";

    public static string ERROR_DELETE_SC_TRANSFORMATION_EXIST = "EDSTE-0006";
    //days worked mangement worked
    public const string MESSAGE_HISTORYDAYSWORKED_SUCCESS_ADD = "MAHDSC-0000";
    public const string MESSAGE_DAYSWORKED_SUCCESS_UPD = "MUDSC-0000";
    public const string MESSAGE_DAYSWORKED_SUCCESS_INF = "MUDGI-0001";
    public const string MESSAGE_DAYSWORKED_SUCCESS_DELETE = "MDDWS-0001";
    public const string MESSAGE_VALID_DW_MONTH = "MDWV-0001";
    public const string MESSAGE_DAYSWORKED_MONTHDETAILS = "MDWMD-0000";

    // days worked management errors
    public const string ERROR_DAYSWORKED_SCNOTFOUND = "ERDW-0001";
    public const string ERROR_DAYSWORKED_BRNOTFOUND = "ERDW-0002";
    public const string ERROR_DAYSWORKED_NOTFOUND = "ERDW-0003";
    public const string ERROR_DAYSWORKED_DISABLELINK = "ERDW-0004";
    public const string ERROR_DAYSWORKED_LINKNOTFOUND = "ERDW-0005";
    public const string ERROR_EXCEED_DW_MONTH = "ERDW-0006";
    public const string ERROR_DAYSWORKED_MONTHDETAILS = "EDWMD-0000";
    public const string ERROR_EXCEED_DW_NOINVOICEABLEDAYS = "ERDW-0007";
    public const string ERROR_EXCEED_DW_NOPAYABLEDAYS = "ERDW-0008";
    public const string ERROR_EXCEED_DW_NOSUPPDOCPATH = "ERDW-0009";


    //FP Control Succes Messages
    public const string MESSAGE_FP_SUCCESS_ADD = "MAFP-0000";
    public const string MESSAGE_FP_SUCCESS_UPD = "MUFP-0000";
    public const string MESSAGE_FP_SUCCESS_DEL = "MDFP-0000";
    public const string MESSAGE_FP_SUCCESS_CON = "McFP-0000";
    public const string MESSAGE_FPH_SUCCESS_ADDHIS = "MAHFP-0000";
    // FP Control management errors
    public const string ERROR_FP_REQUEST_NBR_EXIST = "ERFP-0001";
    public const string ERROR_FP_NOTVALID = "ERFP-0002";
    public const string ERROR_FP_NOTFOUND = "ERFP-0003";
    public const string ERROR_FP_ASSIGNED_MODULE = "ERFP-0004";
    public const string ERROR_FP_EXIST = "ERFP-0004";
    //public const string ERROR_BR_ASSIGNED_FP = "ERFP-0005";
    //milesstones mangement worked
    public const string MESSAGE_HISTORYMSUCCESS_ADD = "MAHMFP-0000";
    public const string MESSAGE_MILESTONE_SUCCESS_UPD = "MUMFP-0000";
    public const string MESSAGE_MILESTONE_SUCCESS_ADD = "MAMFP-0000";
    //public const string MESSAGE_MILESTONE_SUCCESS_INF = "MUDGI-0001";
    // days worked management errors
    public const string ERROR_MILESTONE_NOTFOUND = "ERMFP-0003";
    //QTM Control Succes Messages
    public const string MESSAGE_QTM_SUCCESS_ADD = "MAQTM-0000";
    public const string MESSAGE_QTM_SUCCESS_UPD = "MUQTM-0000";
    public const string MESSAGE_QTM_SUCCESS_DEL = "MDQTM-0000";
    public const string MESSAGE_QTM_SUCCESS_CON = "McQTM-0000";
    public const string MESSAGE_QTMH_SUCCESS_ADDHIS = "MAHQTM-0000";
    // QTM Control management errors
    public const string ERROR_QTM_REQUEST_NBR_EXIST = "ERQTM-0001";
    public const string ERROR_QTM_NOTVALID = "ERQTM-0002";
    public const string ERROR_QTM_NOTFOUND = "ERQTM-0003";
    public const string ERROR_QTM_ASSIGNED_MODULE = "ERQTM-0004";
    public const string ERROR_QTM_EXIST = "ERQTM-0004";
    //public const string ERROR_BR_ASSIGNED_QTM = "ERQTM-0005";
    //subtasks mangement worked
    public const string MESSAGE_HISTORYSUBTASKSUCCESS_ADD = "MAHSBQTM-0000";
    public const string MESSAGE_SUBTASK_SUCCESS_UPD = "MUSBQTM-0000";
    public const string MESSAGE_SUBTASK_SUCCESS_ADD = "MASBQTM-0000";
    public const string MESSAGE_SUBTASK_SUCCESS_DELETED = "MDSBQTM-0000";
    public const string MESSAGE_SUBTASKDOCS_SUCCESS_DELETED = "MDSBDQTM-0000";
    //public const string MESSAGE_MILESTONE_SUCCESS_INF = "MUDGI-0001";
    // days worked management errors
    public const string ERROR_SUBTASK_NOTFOUND = "ERSBQTM-0003";
    public const string ERROR_SUBTASK_EXISTS = "ERSBQTM-0004";
    public const string ERROR_SUBTASK_NOTVALID = "ERSBQTM-0005";
    //list candidates of br
    public const string MESSAGE_LIST_CANDIDATES_SUCCESS_UPD = "MULC-0000";
    public const string MESSAGE_BR_CANDIDATE_EXIST = "MBRCAND-0001";
    public const string MESSAGE_BR_CANDIDATE_NOT_EXIST = "MBRCAND-0002";
    // Consultant information management 
    public const string MESSAGE_CONSULTATIONFORM_SUCCESS_INF = "MCFGI-0000";
    public const string MESSAGE_CONSULTATIONFORM_SUCCESS_ADD = "MACF-0000";
    public const string MESSAGE_CONSULTATIONFORM_SUCCESS_SENDMAIL = "MSMCF-0000";
    public const string MESSAGE_CONSULTANT_CANDIDATE_EXIST = "MCEXI-0001";
    public const string MESSAGE_CONSULTANT_CANDIDATE_NOT_EXIST = "MCNEXI-0002";
    //Error
    public const string ERROR_CONSULTATIONFORM_CONS_SENDMAIL = "ECCS-0000";
    public const string ERROR_SENDMAIL_MAIL_NOT_EXIST_IN_OUTLOOK = "ESMNE-0000";
    //attachments managment messages
    public const string MESSAGE_LIST_ATTACHMENTS_SUCCESS_UPD = "MSLA-0000";
    public const string MESSAGE_LIST_ATTACHMENT_SUCCESS_DELETE = "MDLA-000";
    /// list profiles managment messages ////
    public const string MESSAGE_LIST_PROFILES_SUCCESS_ADD = "MSLP-0000";
    //list attachments invoice//
    public const string MESSAGE_LIST_ATTACHMENTSINVOICES_SUCCESS_UPD = "MSLAI-0000";
    //
    public const string MESSAGE_LIST_DW_SUCCESS_DELETE = "MLDWSD-0000";




    //Profile on site Succes Messages
    public const string MESSAGE_POS_SUCCESS_ADD = "MAPOS-0000";
    public const string MESSAGE_POS_SUCCESS_UPD = "MUPOS-0000";
    public const string MESSAGE_POS_SUCCESS_DEL = "MDPOS-0000";
    // Profile on site errors
    public const string ERROR_POS_EXIST = "ERPOS-0001";
    public const string ERROR_POS_NOTFOUND = "ERPOS-0002";
    // request from status on site errors

    //Consultant Succes Messages
    public const string MESSAGE_Consultant_SUCCESS_ADD = "MAConsultant-0000";
    public const string MESSAGE_Consultant_SUCCESS_UPD = "MUConsultant-0000";
    public const string MESSAGE_Consultant_SUCCESS_DEL = "MDConsultant-0000";
    // Consultant errors
    public const string ERROR_Consultant_EXIST = "ERConsultant-0001";
    public const string ERROR_Consultant_NOTFOUND = "ERConsultant-0002";
    public const string ERROR_CONSULTANT_ASSIGNED = "ERCON-0003";
    public const string MESSAGE_Consultant_ERROR_DEL = "MDConsultant-0001";
    public const string ERROR_CONSULTANT_NOTVALID = "ERConsultant-0003";
    public const string MESSAGE_Consultant_ERROR_EMPLOYEENUMBER = "ERCONEN-0004";
    //Candidate Succes Messages
    public const string MESSAGE_CANDIDATE_SUCCESS_ADD = "MACAN-0000";
    public const string MESSAGE_CANDIDATE_SUCCESS_UPD = "MUCAN-0000";
    public const string MESSAGE_CANDIDATE_SUCCESS_DEL = "MDCAN-0000";
    // Candidate errors
    public const string ERROR_CANDIDATE_EXIST = "ERCAN-0001";
    public const string ERROR_CANDIDATE_INVALID = "ERCAN-0002";
    public const string ERROR_CANDIDATE_NOTFOUND = "ERCAN-0003";
    public const string ERROR_CANDIDATE_ASSIGNED = "ERCAN-0004";
    public const string ERROR_CANDIDATE_INTERVIEW = "ERCAN-0005";
    public const string ERROR_DEL_CANDIDATE_REFERRAL = "ERDELCAN-0008";
    public const string ERROR_CANDIDATE_ASSIGNED_INTERVIEW_PAY = "ERCANPINT-0000";
    public const string ERROR_DEL_CANDIDATE_REFERRAL_INTERVIEW = "ERDELREFINTCAN-0000";

    public const string ERROR_CANDIDATE_PAYMENT = "ERCAN-0006";
    public const string ERROR_CANDIDATE_CONSULTANT = "ERCAN-0007";

    // Company management messages
    public const string MESSAGE_RECRUITMENT_SUCCESS_ADD = "MAREC-0000";
    public const string MESSAGE_RECRUITMENT_SUCCESS_UPD = "MUREC-0000";
    public const string MESSAGE_RECRUITMENT_SUCCESS_DEL = "MDREC-0000";
    public const string MESSAGE_RECRUITMENT_SUCCESS_CON = "MCREC-0000";
    // Recruitment management errors

    public const string ERROR_RECRUITMENT_EXIST = "ERREC-0001";
    public const string ERROR_RECRUITMENT_NOTFOUND = "ERREC-0002";
    public const string ERROR_RECRUITMENT_NOTVALID = "ERREC-0003";
    public const string ERROR_RECRUITMENT_DEL = "ERREC-0004";
    //Candidate as Consultant Msg**/
    public const string MESSAGE_CANDIASCONST_SUCCESS_ADD = "MACONASCONS-000";
    /** send mail consultant Msg**/
    public const string MESSAGE_CONSULTANT_SUCCESS_SENDMAIL = "MCSMS-0000";
    //error send mail to consultant messages
    public const string ERROR_CONSULTANT_SENDMAIL = "ERRCSM-0001";
    //msg candidates documents//
    public const string MESSAGE_LIST_CANDDOCS_SUCCESS_UPD = "MSLCD-0000";
    public const string MESSAGE_BR_Update = "ERR-NotUBR001";
    //INVOICE SC
    public const string MESSAGE_INVOICESC_SUCCESS_ADD = "MISCSA-000";
    public const string MESSAGE_INVOICESC_SUCCESS_UPDATE = "MISCSU-000";
    public const string MESSAGE_INVOICESC_HISTORY_ADD = "MAISCHCS-000";
    public const string MESSAGE_INVOICE_SUCCESS_DELETE = "MISCSD-000";
    public const string MESSAGE_SUMMF_VALID = "MSMFV_000";

    // INVOICE SC errors

    public const string ERROR_DW_INVOICED = "ERDWI-0001";
    public const string ERROR_INVOICE_NOTFOUND = "ERISCI-0001";
    public const string ERROR_INVOICE_NOTVALID = "ERISCI-0002";
    public const string MESSAGE_DW_NOT_INVOICED = "MDWNI-0001";
    public const string ERROR_EXCEED_MFTOTAL = "EEMFT-001";


    // messages payment SC//
    public const string MESSAGE_PAYMENTSC_SUCCESS_ADD = "MAPSC-0000";
    public const string MESSAGE_PAYMENTSC_SUCCESS_UPDATE = "MUPSC-0000";
    public const string MESSAGE_DW_NOT_PAID = "MDWNP-0000";
    public const string MESSAGE_PAYMENT_SUCCESS_DELETE = "MPSCSD-000";
    public const string MESSAGE_LIST_PAYMENT_EMPTY = "MPE-000";


    //payment SC errors//
    public const string ERROR_DW_PAID = "ERDWP-0001";
    public const string ERROR_PAYMENT_NOT_FOUND = "ERPNF-0002";
    public const string ERROR_PAYMENT_NOTVALID = "ERPNF-0003";
    public const string ERROR_MFPAID_EXCEED_MFTOTAL = "EMFPEMT-0002";
    public const string ERROR_PAYMENT_INVOICE_EXIST = "EPIE-0002";
    // attachment delete
    public const string MESSAGE_ATTACHMENT_DELETE_ALLOW = "MADA-000";
    public const string MESSAGE_ATTACHMENT_DELETE_FORBIDDEN = "MADF-000";

    public const string MESSAGE_LIST_ATTACHMENT_EMPTY = "MATE-000";


    // attachment delete errors

    public const string ERROR_ATTACHMENT_DELETE = "ERAD-0001";
    public const string ERROR_ATTACHMENT_NOT_FOUND = "ERATNF-0002";



    // Everis PM :
    public const string MESSAGE_EverisPM_SUCCESS_ADD = "MAEverisPM-000";
    public const string ERROR_EverisPM_Exists = "EREverisPM-000";
    // create sc in br:
    public const string ERROR_SC_CostNULL = "ERRSC_Cost-00";
    //check timeout session
    public const string ERROR_SESSION_TIMEOUT = "ERST-0000";
    public const string MESSAGE_SESSION_SUCCESS = "MSS-0000";
    // check Permission 
    public const string ERROR_Has_Permission = "ERHP-0000";
    //Notifications 
    public const string ERROR_NOTIFICATIONS = "ERNTF-0001";
    public const string ERROR_TOP4NOTIFICATIONS = "ERNTF-0004";
    public const string UPDATE_STATE_NOTIFICATIONS = "UPNTF-0000";
    //Categorytypeofcontract management
    public const string MESSAGE_TYPE_Category_ADD = "MACT-0000";
    public const string MESSAGE_CategoryTOC_EXIST = "MCTOE-0001";
    public const string ERROR_CTOC_NOTFOUND = "ERTOC-0002";
    //affected place of delivery  to TOC
    public const string MESSAGE_TYPE_POD_ADD = "MAPODT-0000";
    // affected Company to TOC
    public const string MESSAGE_TYPE_Company_ADD = "MAComT-0000";
    // update FWC SERVICE TYPE
    public const string MESSAGE_FWC_ServiceType_UPD = "MUFWC_ServiceType_0000";
    // update department framework contract
    public const string MESSAGE_FC_Department_UPD = "MUFC_Department_0000";
    // update service type framework contract
    public const string MESSAGE_FC_TypeBR_UPD = "MUFC_TypeBR_0000";
    // update level framework contract
    public const string MESSAGE_FC_Level_UPD = "MUFC_Level_0000";
    // update daily price affected to the specified TOC
    public const string MESSAGE_FWC_Dailyprice_UPD = "MUFWC_Dailyprice_0000";
    // update params FWC : profile-level-category.......
    public const string MESSAGE_FWC_Params_UPD = "MUFWC_Params_0000";
    //OERP code
    public const string MESSAGE_OERP_SUCCESS_UPD = "MOERPS_0000";
    public const string MESSAGE_FWC_REQUIRED_SUCCESS_UPD = "MFWCRSU_0000";
    // err Milestone
    public const string ERROR_Milestone_EXIST = "ERMilExist-0000";
    public const string ERROR_Milestone_NF = "ERMilNF-0000";
    public const string ERROR_Milestone_Invoiced = "ERMilInv-0000";
    public const string MESSAGE_Milestone_SUCCESS_DEL = "MDFPM-0000";
    public const string ERROR_FWC_EXTERNAL_ERROR = "EFWCEE_0000";
    //valid leading copany 
    public const string MESSAGE_FWC_VALID_ID_LEADING_COMPANY = "MFVILC_0000";


    // err Milestone invoiced
    public const string ERROR_MilestoneInvoiced_EXIST = "ERMilInvExist-0000";
    public const string ERROR_MilestoneInvoiced_NF = "ERMilInvNF-0000";


    //Messages invoice QTM//
    public const string MESSAGE_INVOICE_QTM_SUCCESS_ADD = "MIQTMA-0001";
    public const string MESSAGE_INVOICE_QTM_SUCCESS_UPDATE = "MIQTMU-0002";
    public const string MESSAGE_INVOICE_QTM_HISTORY_ADD = "MIQHA-0003";
    public const string MESSAGE_INVOICE_QTM_SUCCESS_DELETE = "MIQHD-0004";
    public const string MESSAGE_SUBTASK_NOT_INVOICED = "MSQNI-0005";
    public const string MESSAGE_LIST_INVOICESUBTASK_EMPTY = "MISE-000";
    public const string ERROR_Payment_SUBTASK_Profile = "ERPSPE-3030";



    // errors invoice QTM//
    public const string ERROR_INVOICE_SUBTASK_NOT_FOUND = "ERIQNF-0001";
    public const string ERROR_SUBTASK_INVOICED = "ERTI-0002";
    public const string ERROR_INVOICESUBTASK_NOTVALID = "ERISNV-0003";
    // ERRORS CURRENCY
    public const string ERROR_Currency_AssociedFWC = "ERCD-0001";
    // SUCCESS CURRENCY
    public const string Currency_SUCCESS_ADD = "CPA-0001";
    public const string Currency_SUCCESS_DEL = "CPD-0001";
    // update recruitment affected to the specified TOC
    public const string MESSAGE_FWC_Recruitment_UPD = "MUFWC_Recruitment_0000";


    /******* PTM Owner ********/
    public const string MESSAGE_PTMOWNER_SUCCESS = "OWNER-000";
    public const string ERROR_PTMOWNER_NOT_VALID = "EROWNER-0001";
    public const string ERROR_PTMOWNER_EXIST = "EROWNER-0002";
    public const string ERROR_PTMOWNER_EXTERNAL = "EROWNER-500";
    public const string ERROR_PTMOwner_NOTVALID = "EROWNER-0003";
    //ConsultantCost
    public const string ERROR_CONSULTANTS_COST_EXTERNAL_ERROR = "ECCEE-500";
    public const string MESSAGE_ADD_CONSULTANT_COST_SUCCESS = "MACCS-0000";
    public const string MESSAGE_ADD_CONSULTANT_COST_HISTORY_SUCCESS = "MACCHS-0000";

    /** payment milestone**/
    public const string MESSAGE_PAYMENTMILESTONE_SUCCESS_ADD = "MAPMIL-0000";
    public const string MESSAGE_PAYMENTMILESTONE_SUCCESS_UPDATE = "MUPMIL-0000";
    public const string MESSAGE_MILESTONE_NOT_PAID = "MDMILNP-0000";
    public const string MESSAGE_PAYMENTMILESTONE_SUCCESS_DELETE = "MPMILSD-000";
    public const string MESSAGE_HISTORYPAYMENTMILESTONE_SUCCESS_Add = "MAHPMIL-0000";
    public const string MESSAGE_LIST_PAYMENTSUBTASK_EMPTY = "MPSE-000";
    //payment milestone errors//
    public const string ERROR_MILESTONE_PAID = "ERMILP-0001";
    public const string ERROR_PAYMENTMILESTONE_NOT_FOUND = "ERPMILNF-0002";
    public const string ERROR_PAYMENTILESTONE_NOTVALID = "ERPMN-0003";
    /** OERP code payment **/
    public const string MESSAGE_PAYMENTOERPMILESTONE_SUCCESS_ADD = "MAPOERP-0000";
    public const string MESSAGE_PAYMENTOERPMILESTONE_SUCCESS_UPDATE = "MUPOERP-0000";
    public const string MESSAGE_LIST_PAYMENTOERP_EMPTY = "MPOERP-000";

    // OERP code payment error**/
    public const string ERROR_OERPCODEPAYMENT_NOT_FOUND = "ERPOERPNF-0002";
    public const string ERROR_OERPCODEPAYMENT_NOT_VALID = "ERPOERPNV-0003";
    //PTM Owner
    public const string MESSAGE_PTMOwner_SUCCESS_ADD = "MAPTMOwner-0000";
    public const string MESSAGE_PTMOwner_SUCCESS_UPDATE = "MUPTMOwner-0000";
    public const string MESSAGE_PTMOwner_SUCCESS_DELETE = "MDPTMOwner-000";
    //Error PTM Owner
    public const string ERROR_PTMOwner_EXIST = "EREPTMOwner-0000";
    public const string ERROR_PTMOwner_NF = "ERNFPTMOwner-0000";
    public const string ERROR_PTMOwner_Affected_FWC = "ERAFPTMOwner-0000";
    public const string ERROR_PTMOwner_EXTERNAL_ERROR = "ERE-3333";
    // SubContractor
    public const string MESSAGE_SubContractor_SUCCESS_ADD = "MASubContractor-0000";
    public const string MESSAGE_SubContractor_SUCCESS_UPDATE = "MUSubContractor-0000";
    public const string MESSAGE_SubContractor_SUCCESS_DELETE = "MDSubContractor-000";
    //Error subcontractor
    public const string ERROR_SubContractor_EXIST = "ERESubContractor-0000";
    public const string ERROR_SubContractor_NF = "ERNFSubContractor-0000";
    public const string MESSAGE_SubContractor_NOTVALID = "ERSubContractor-0000";
    //Error confirm consultant delete//
    public const string ERROR_CONS_DELETE_TMPTM_PAYMENT = "ERCDTMP-0000";
    public const string ERROR_CONS_DELETE_TMPTM_INVOICE = "ERCDTMI-0000";
    public const string ERROR_CONS_DELETE_FP_PAYMENT = "ERCDFPP-0000";
    public const string ERROR_CONS_DELETE_QTM_PAYMENT = "ERCDQTMP-0000";
    public const string ERROR_CONS_DELETE_FP_COST = "ERCDFPC-0000";
    public const string ERROR_CONS_DELETE_QTM_SUBT = "ERCDQTMC-0000";
    public const string MESSAGE_CONS_DELETE_GRANTED = "MCDG-0000";
    // consultant affected to misssion
    public const string ERROR_CONS_DELETE_QTM_PAYMENT_TE = "ERCDQTMPTE-0000";
    public const string ERROR_CONS_DELETE_QTM_MISSION = "ERCDQTMTE-0000";
    public const string ERROR_CONS_DELETE_TMPTM_MISSION = "ERCDTMPTMTE-0000";
    public const string ERROR_CONS_DELETE_FP_PAYMENT_TE = "ERCDFPPTE-0000";
    public const string ERROR_CONS_DELETE_FP_MISSION = "ERCDFPTE-0000";
    public const string ERROR_CONS_DELETE_QTM_EC = "ERCDQTMEC-0000";
    public const string ERROR_CONS_DELETE_QTM_CHANGECOST = "ERCDQTMCCOST-0000";
    public const string ERROR_CONS_DELETE_QTM_CHANGECMP = "ERCDQTMCCMP-0000";

    //subco 

    public const string ERROR_SUBCONTRACTOR_Affected_FWC = "ERAFSubco-0000";
    // exceed days worked limit forecast number of days
    public const string ERROR_EXCEED_LIMIT_DW = "ERELDW-0000";
    public const string ERROR_EXCEED_LIMIT_DW_FORECAST = "ERELDWF-0000";

    public const string MESSAGE_UPDATE_SC_SUCCESS_FROM_BR = "MUSCSFBR-0000";
    // Error param affected to FWC
    public const string ERROR_Param_Affected_FWC = "ERAFParams-0000";

    /** payment Subtask**/
    public const string MESSAGE_PAYMENT_Subtask_SUCCESS_ADD = "MAPSub-0000";
    public const string MESSAGE_PAYMENT_Subtask_SUCCESS_DELETE = "MPDSub-000";
    public const string MESSAGE_HISTORY_PAYMENT_Subtask_SUCCESS_Add = "MAHPSUB-0000";
    public const string MESSAGE_Subtask_NOT_PAID = "MSUBNP-0000";
    //payment Subtask errors//
    public const string ERROR_Subtask_PAID = "ERSUBP-0001";
    public const string ERROR_PAYMENT_Subtask_NOT_FOUND = "ERPSUBNF-0002";
    public const string ERROR_PAYMENT_Subtask_NOTVALID = "ERPSubNV-0003";

    /** OERP code payment QTM  **/
    public const string MESSAGE_PAYMENT_OERP_Subtask_SUCCESS_ADD = "MAPOERPS-0000";
    /** OERP code INVOICE QTM  **/
    public const string MESSAGE_INVOICE_OERP_Subtask_SUCCESS_ADD = "MAINVOERPS-0000";
    // Error calcul case import FP
    public const string ERROR_CalculMF_FP = "ERFPIMF-0001";
    public const string ERROR_CalculRC_FP = "ERFPIRC-0001";


    // get module permissions by role
    public const string MESSAGE_PERMISSIONSMODULEROLE_SUCCESS_GET = "GETPMR-0000";
    public const string MESSAGE_PERMISSIONSMODULEROLE_SUCCESS_ADD = "SUCPMR-0000";

    public const string MESSAGE_DW_DELETE_ALLOW = "MDWDA-000";
    public const string ERROR_BRPROFILE_ASIGN_TO_SUBTASK = "ERUPROFILE-0000";
    public const string MESSAGE_BRPROFILE_DELETE_ALLOW = "MPRDA-000";

    /**Error exceed limit days worked QTM**/
    //public const string ERROR_EXCEED_LIMIT_DW = "ERELDW-0000";
    //public const string ERROR_EXCEED_LIMIT_DW_FORECAST = "ERELDWF-0000";
    public const string MESSAGE_CALCUL_REMAININGDAYS_SUCCESS_QTM = "MRDS-0000";
    //  public const string MESSAGE_UPDATE_SC_SUCCESS_FROM_BR = "MUSCSFBR-0000";


    // 422 ERRORS
    public const string UNEXCEPTED_FILE_EXTENTION = "UFE-000";

    // exceed Revenue consumed > total price
    public const string ERROR_EXCEED_LIMIT_RC = "ERELRC-0000";
    public const string ERROR_EXCEED_SUBTOTAL = "ERELSUBTOTAL-0000";
    //  Approvers 
    public const string MESSAGE_Approvers_SUCCESS_ADD = "MAPPAS-0000";
    public const string MESSAGE_Approvers_SUCCESS_UPDATE = "MAPPUS-0000";
    public const string MESSAGE_Approvers_SUCCESS_DELETE = "MAPPDS-0000";

    public const string ERROR_Approvers_EXISTS = "ERAPPE-0000";
    public const string ERROR_Approvers_NOTFOUND = "ERAPPNF-0000";
    public const string ERROR_Approvers_AFFECTED_COMPANY = "ERAPPAFC-0000";
    public const string ERROR_Approvers_AFFECTED_SUBCO = "ERAPPAFS-0000";
    public const string ERROR_Approvers_AFFECTED_PTMOWNER = "ERAPPAFP-0000";
    public const string ERROR_Approvers_AFFECTED_MILESTONE = "ERAPPAFM-0000";
    public const string ERROR_Approvers_AFFECTED_SUBTASK = "ERAPPAFSP-0000";
    public const string ERROR_OERPINVOICECODE_EXISTS = "EROERPINVOICECODEE-0000";
    public const string ERROR_Approvers_AFFECTED_SC = "ERAPPSC-0000";
    public const string MESSAGE_APPROVERS_NOTVALID = "ERNVAPPROVER-0000";

    public const string ERROR_EXCEED_REMAINIG_AMOUNT = "EERA-0000";
    public const string ERROR_EXCEED_REMAINIG_NDAYS = "EERNDAYS-0000";
    public const string ERROR_EXCEED_REMAINIG_COST = "EERNCOST-0000";


    //* Travel expenses **/

    public const string MESSAGE_TRAVEL_EXPENSES_SUCCESS_ADD = "MATE-0000";
    public const string MESSAGE_HISTRORY_TRAVEL_EXPENSES_SUCCESS_ADD = "MAHTE-0000";
    public const string MESSAGE_TRAVEL_EXPENSES_SUCCESS_UPDATE = "MUTE-0000";
    public const string MESSAGE_TRAVEL_EXPENSES_SUCCESS_DELETE = "MDTE-0000";
    public const string MESSAGE_ADDITIONAL_BUDGET_INCORRECT = "MABI-0000";
    public const string MESSAGE_PERIOD_MISSION_VALID = "MPMV-0000";
    public const string MESSAGE_ADDITIONAL_BUDGET_INVALID = "MABI-0001";
    public const string MESSAGE_MISSION_DATES_VALID = "MDMV-0001";
    public const string MESSAGE_MISSION_LIST_DATES_EMPTY = "MLDME-0001";
    public const string MESSAGE_AMOUNT_PAID_EXCEED_BUDGET = "MABI-0002";
    public const string MESSAGE_MISSION_CANCELED = "MICA-0000";
    public const string MESSAGE_PERIOD_MISSION_INCORRECT = "MPINC-0000";

    /*** Errors Travel expenses**/

    public const string ERROR_EXPENSES_NOTFOUND = "ERTR-0001";

    public const string ERROR_EXPENSES_NOTVALID = "ERTR-0002";

    public const string ERROR_DATES_MISSION_NOTVALID = "ERTR-0003";
    public const string ERROR_PERIOD_MISSION_EXIST = "ERPME-0001";

    public const string ERROR_DEPARTED_ARRIVAL_OUT_INVALID = "EDAO-0001";
    public const string ERROR_COMMENCEMENT_DEPARTED_OUT_INVALID = "ECDO-0001";
    public const string ERROR_COMMENCEMENT_ARRIVAL_OUT_INVALID = "ECAO-0001";
    public const string ERROR_CESSATION_ARRIVAL_OUT_INVALID = "ECEAO-0001";
    public const string ERROR_CESSATION_COMMENCEMENT_INVALID = "ECEC-0001";
    public const string ERROR_CESSATION__DEPARTED_OUT_INVALID = "ECEDO-0001";
    public const string ERROR_DEPARTED_CESSATION_RETURN_INVALID = "EDCER-0001";
    public const string ERROR_DEPARTED_COMMENCEMENT_RETURN_INVALID = "EDCR-0001";
    public const string ERROR_DEPARTED_ARRIVAL_RETURN_OUT_INVALID = "EDARO-0001";
    public const string ERROR_DEPARTED_RETURN_OUT_INVALID = "EDRO-0001";
    public const string ERROR_ARRIVAL_DEPARTED_RETURN_INVALID = "EADR-0001";
    public const string ERROR_ARRIVAL_CESSATION_RETURN_INVALID = "EACER-0001";
    public const string ERROR_ARRIVAL_COMMENNCEMENT_RETURN_INVALID = "EACR-0001";
    public const string ERROR_ARRIVAL_RETURN_OUT_INVALID = "EARO-0001";
    public const string ERROR_ARRIVAL_DEPARTED_RETURN_OUT_INVALID = "EADRO-0001";

    /*** Errors Travel expenses invoice**/
    public const string ERROR_INVOICE_MISSION_NOTFOUND = "ERIM-0001";
    public const string ERROR_MISSION_INVOICED = "ERIM-0003";
    public const string ERROR_INVOICE_MISSION_NOTVALID = "ERIM-0002";
    /*** message Travel expenses invoice**/
    public const string MESSAGE_INVOICE_MISSION_SUCCESS_ADD = "MAIM-0000";
    public const string MESSAGE_INVOICE_MISSION_SUCCESS_UPDATE = "MUIM-0000";
    public const string MESSAGE_INVOICE_MISSION_HISTORY_ADD = "MAIHM-0000";

    /*** message Travel expenses payment**/
    public const string MESSAGE_PAYMENT_MISSION_SUCCESS_ADD = "MAPM-0000";
    public const string MESSAGE_PAYMENT_MISSION_SUCCESS_UPDATE = "MUPM-0000";
    public const string MESSAGE_PAYMENT_MISSION_HISTORY_ADD = "MAHPM-0000";

    public const string ERROR_PAYMENT_MISSION_NOTVALID = "ERPM-0002";
    public const string ERROR_MISSION_PAID = "ERPM-0003";
    public const string ERROR_PAYMENT_MISSION_NOT_FOUND = "ERPM-0001";
    // transfer company
    public const string MESSAGE_TRANSFER_COMPANY_SUCCESS_ADD = "MTCSA-0000";
    public const string MESSAGE_TRANSFER_COMPANY_SUCCESS_ADD_PEROFRMANCE = "MTCSAP-0000";
    public const string MESSAGE_TRANSFER_COMPANY_SUCCESS_UPDATE = "MTCSU-0000";
    public const string MESSAGE_TRANSFER_COMPANY_HISTORY_ADD = "MTCHA-0000";
    public const string MESSAGE_TRANSFER_COMPANY_SUCCESS_DELETE = "MTCSD-0000";
    public const string MESSAGE_HISTORY_TRANSFER_COMPANY_SUCCESS_ADD = "MHTCSA-0000";

    public const string ERROR_TRANSFER_COMPANY_NOTVALID = "ERTCNV-0000";
    public const string ERROR_TRANSFER_COMPANY_CHANGED = "ERTCC-0000";


    //** save dashboard data 
    public const string MESSAGE_DASHBOARD_DATA_SUCCESS_ADD = "MADASH-0000";
    // **Accelarate Payment 
    public const string ERROR_PAYMENT_ACCELERATE = "ERPACC-0001";
    public const string ERROR_PAYMENT_NOT_ACCELERATE = "ERPNACC-0001";
    public const string MESSAGE_PAYMENT_ACCELERATE_SUCCESS = "MPACCS-0000";

    // Everis contract detail
    public const string MESSAGE_EC_DETAIL_SUCCESS_ADD = "MECDSA-0000";
    public const string ERROR_ECDETAIL_NOTVALID = "EECD-0000";
    public const string ERROR_ECDETAIL_MAXENDDATE_SIGNATUREDATE = "EECD-0001";
    public const string ERROR_ECDETAIL_SENTDATE = "EECD-0002";
    public const string ERROR_ECDETAIL_MAXENDDATE_MAXENDDATESC = "EECD-0003";
    //list Subcontractor of br
    public const string MESSAGE_LIST_SUBCONTRACTOR_SUCCESS_UPD = "MULC-0000";

    //**  Deatil subtask
    public const string MESSAGE_DETAIL_SUCCESS_DELETE = "MDSD-000";

    public const string ERROR_CONS_DELETE_FP_DETAIL = "ERCDFPD-0000";
    public const string MESSAGE_SUBCO_DELETE_GRANTED = "MSDG-0000";
    public const string ERROR_SUBCO_DELETE_QTM_SUBT = "ERSDQTMC-0000";
    public const string ERROR_SUBCO_DELETE_FP_DETAIL = "ERSDFPD-0000";
    public const string ERROR_DATE_PROJECT_START_DATE = "EDPSD-0000";
    public const string MESSAGE_DATE_SUCCESS = "MDS-0000";
    public const string ERROR_START_DATE = "ESD-0000";
    public const string ERROR_PROJECT_START_DATE = "EPSD-0000";

    public const string ERROR_DATE_SCSIGNED_DATE = "EDSSD-0000";

    public const string ERROR_Subtask_CHANGE_COST = "ERSUBCOST-0001";
    public const string ERROR_INVOLVEMENT_CHANGE_COST = "ERINVCOST-0001";
    public const string ERROR_Milestone_CHANGE_COST = "ERMileCOST-0001";
    //Involvment
    public const string MESSAGE_INVOLVEMENT_FP_SUCCESS_DELETE = "MIFPSA-0000";
    public const string MESSAGE_INVOLVEMENT_HISTORY_ADD = "MIHSA-0000";
    public const string MESSAGE_LIST_INVOLVEMENT_SUCCESS_UPD = "MLISA-0000";
    public const string ERROR_INVOLVEMENT_FP_NOTFOUND = "EIFP-0000";
    //** consultant referral
    public const string MESSAGE_REFERRAL_SUCCESS_DEL = "MRDU-0000";
    public const string MESSAGE_REFERRAL_SUCCESS_ADD = "MRAU-0000";

    public const string ERROR_REFERRAL_NOTFOUND = "ERNF-0000";

    public const string ERROR_CONSULTANT_ASSIGNED_REFERRAL = "ERCON-0004";
    public const string ERROR_CANDIDATE_ASSIGNED_REFERRAL_PAY = "ERCAN-0008";
    public const string ERROR_COMPANY_ASSIGNED_REFERRAL = "ERCOMP-0001";
    public const string ERROR_SUBCONTRACTOR_ASSIGNED = "ERSUBCO-0001";

    // consultant contract status
    public const string MESSAGE_UPDATE_CONSULTANT_CONTRACT_STATUS_SUCCESS = "MUCCSS-0001";


    public const string MESSAGE_REMAINING_SUCCESS_UPD = "MRSU-0000";
    public const string ERROR_REMAINING_NDAYS = "ERRND-0000";
    public const string ERROR_REMAINING_AMOUNT = "ERRAMOUNT-0000";
    public const string ERROR_TYPE_INVOLVEMENT = "ERTINV-0000";
    public const string ERROR_INVOLVEMENT_PAID = "ERINVP-0000";

    //change consultant cost//

    public const string ERROR_CONSULTANT_COST_INVALID = "ECOST-0000";
    public const string ERROR_CONSULTANT_TOTALCOST_INVALID = "ETOTALCOST-0000";
    public const string ERROR_CHANGE_COST_NOT_FOUND = "ECOST-0001";
    public const string MESSAGE_CHANGE_CONSULTANT_COST_SUCCESS = "MCCCS-0000";
    public const string MESSAGE_NO_PAYMENT_CONSULTANT = "MNPCONS-0000";
    public const string MESSAGE_NO_CHANGE_COST = "MNCONS-0000";
    public const string ERROR_CONSULTANT_COST_PAID_INVALID = "ECOSTP-0000";

    public const string ERROR_REFERENT_PAID = "ERREFP-0001";
    public const string ERROR_INTERVIEW_PAID = "ERINTP-0001";

    // interview
    public const string ERROR_INTERVIEW_NOTFOUND = "ERINTERVIEW-0001";
    public const string ERROR_INERVIEW_ASSINGED_TO_PAYMENT = "ERINTERVIEW-0002";
    // referral
    public const string ERROR_REFERRAL_ASSIGNED_TO_PAYMENT = "ERREFERRAL-0001";

    //Log access
    public const string MESSAGE_LOG_ACCESS_SUCCESS_ADD = "LOG-0000";
    // FWC error of invalid fields values
    public const string ERROR_FWC_ID_REQUIRED_UP = "ERFWC-0000";
    public const string ERROR_FWC_ID_TYPE = "ERFWC-0001";
    public const string ERROR_FWC_VALUEID_REQUIRED = "ERFWC-0002";
    public const string ERROR_FWC_IDLEADINGCOMPANY_REQUIRED_UP = "ERFWC-0003";
    public const string ERROR_FWC_IDLEADINGCOMPANY_TYPE = "ERFWC-0004";
    public const string ERROR_FWC_NORMAL_PERFORMANCE_REQUIRED = "ERFWC-0005";
    public const string ERROR_FWC_OUTSIDE_PERFORMANCE_REQUIRED = "ERFWC-0006";
    public const string ERROR_FWC_NORMAL_HOURSPERDAY_REQUIRED = "ERFWC-0007";
    public const string ERROR_FWC_NORMAL_HOURSPERDAY_TYPE = "ERFWC-0008";
    public const string ERROR_FWC_OUTSIDE_HOURSPERDAY_REQUIRED = "ERFWC-0009";
    public const string ERROR_FWC_OUTSIDE_HOURSPERDAY_TYPE = "ERFWC-0010";
    public const string ERROR_FWC_WITHCATEGORY_TYPE = "ERFWC-0011";
    public const string ERROR_FWC_EVERISLEADER_TYPE = "ERFWC-0012";
    public const string ERROR_FWC_ISPARTNER_TYPE = "ERFWC-0013";
    public const string ERROR_FWC_ISACTIVE_TYPE = "ERFWC-0014";
    public const string ERROR_FWC_NOTICEPERIOD_TYPE = "ERFWC-0015";
    public const string ERROR_FWC_DATE_FO_DEADLINE_DAYS_TYPE = "ERFWC-0016";
    public const string ERROR_FWC_NORMAL_WORKING_DAY_TYPE = "ERFWC-0017";
    public const string ERROR_FWC_VALIDITY_DAYS_TYPE = "ERFWC-0018";
    public const string ERROR_FWC_CURRENCY_ID_TYPE = "ERFWC-0019";
    public const string ERROR_FWC_DEFAULT_YN_DEADLINE_TYPE = "ERFWC-0020";
    public const string ERROR_FWC_DEFAULT_PROPOSAL_DEADLINE_TYPE = "ERFWC-0021";
    public const string ERROR_FWC_SIGNATURE_DATE_TYPE = "ERFWC-0022";
    public const string ERROR_FWC_DURATION_TYPE = "ERFWC-0023";
    public const string ERROR_FWC_AUTOMATIC_RENEWAL_TYPE = "ERFWC-0024";
    public const string ERROR_FWC_AUTOMATIC_RENEWAL_DATE_TYPE = "ERFWC-0025";
    public const string ERROR_FWC_END_DATE_TYPE = "ERFWC-0026";
    public const string ERROR_FWC_END_DATE_PERFORMANCE_TYPE = "ERFWC-0027";
    public const string ERROR_FWC_END_DATE_EXTENSION_TYPE = "ERFWC-0028";
    public const string ERROR_FWC_MF_CHARGEABILITY_TYPE = "ERFWC-0029";
    public const string ERROR_FWC_EVERIS_INVOICING_ALL_TYPE = "ERFWC-0030";
    public const string ERROR_FWC_INDEXATION_REQUEST_DEADLINE_DATE_TYPE = "ERFWC-0031";
    public const string ERROR_FWC_INDEXATION_APPLICABLE_FROM_TYPE = "ERFWC-0032";
    public const string ERROR_FWC_REPORTING_CLIENT_TYPE = "ERFWC-0033";
    public const string ERROR_FWC_PTM_SURCHARGE_TYPE = "ERFWC-0034";
    public const string ERROR_FWC_ISCASCADE_TYPE = "ERFWC-0035";
    public const string ERROR_FWC_PTM_SURCHARGE_RATE_TYPE = "ERFWC-0036";
    public const string ERROR_FWC_WITHCATEGORY_REQUIRED = "ERFWC-0037";
    public const string ERROR_FWC_EVERISLEADER_REQUIRED = "ERFWC-0038";
    public const string ERROR_FWC_ISACTIVE_REQUIRED = "ERFWC-0039";
    public const string ERROR_FWC_ISCASCADE_REQUIRED = "ERFWC-0040";
    public const string ERROR_FWC_PAYMENT_TERMS_ID_REQUIRED = "ERFWC-0041";
    public const string ERROR_FWC_CURRENCY_ID_REQUIRED = "ERFWC-0042";
    public const string ERROR_FWC_MFINVOICED_REQUIRED = "ERFWC-0043";

    // Consultant error of invalid fields values
    public const string ERROR_CONSULTANT_IDCONSULTANT_REQUIRED_UP = "ERCONS-0000";
    public const string ERROR_CONSULTANT_IDCONSULTANT_TYPE = "ERCONS-0001";
    public const string ERROR_CONSULTANT_CONS_FNAME_REQUIRED = "ERCONS-0002";
    public const string ERROR_CONSULTANT_CONS_LNAME_REQUIRED = "ERCONS-0003";
    public const string ERROR_CONSULTANT_ACCELERATEPAYMENT_REQUIRED = "ERCONS-0004";
    public const string ERROR_CONSULTANT_ACCELERATEPAYMENT_TYPE = "ERCONS-0005";
    public const string ERROR_CONSULTANT_IDCANDIDATE_REQUIRED_UP = "ERCONS-0006";
    public const string ERROR_CONSULTANT_IDCANDIDATE_TYPE = "ERCONS-0007";
    public const string ERROR_CONSULTANT_RISK_DEPARTURE_TYPE = "ERCONS-0008";
    public const string ERROR_CONSULTANT_DT_PLANNED_LEAVE_TYPE = "ERCONS-0009";
    public const string ERROR_CONSULTANT_ISPARTNER_TYPE = "ERCONS-0010";
    public const string ERROR_CONSULTANT_EARLIESTSTARTDATE_TYPE = "ERCONS-0011";
    public const string ERROR_CONSULTANT_CONS_BIRTHDATE_TYPE = "ERCONS-0012";
    public const string ERROR_CONSULTANT_VAT_RATE_TYPE = "ERCONS-0013";
    public const string ERROR_CONSULTANT_COST_TYPE = "ERCONS-0014";
    public const string ERROR_CONSULTANT_IDTYPEOFCONTRACT_TYPE = "ERCONS-0015";
    public const string ERROR_CONSULTANT_CONS_THIRD_PARTY_RATE_TYPE = "ERCONS-0016";
    public const string ERROR_CONSULTANT_IDCONSULTANTDEGREE_TYPE = "ERCONS-0017";
    public const string ERROR_CONSULTANT_IDAPPROVER_CONS_TYPE = "ERCONS-0018";
    public const string ERROR_CONSULTANT_IDCOUNTRY_TYPE = "ERCONS-0019";
    public const string ERROR_CONSULTANT_IT_CAREER_STARTED_TYPE = "ERCONS-0020";
    public const string ERROR_CONSULTANT_NBR_ACCELERATEPAYMENT_TYPE = "ERCONS-0021";
    public const string ERROR_CONSULTANT_NBR_REMAININGACCELERATEPAYMENT_TYPE = "ERCONS-0022";
    public const string ERROR_CONSULTANT_EARLIESTSTARTDATE_REQUIRED_UP = "ERCONS-0023";
    public const string ERROR_CONSULTANT_CONS_BIRTHDATE_REQUIRED_UP = "ERCONS-0024";
    public const string ERROR_CONSULTANT_IDTYPEOFCONTRACT_REQUIRED_UP = "ERCONS-0025";
    public const string ERROR_CONSULTANT_IDCONSULTANTDEGREE_REQUIRED_UP = "ERCONS-0026";
    public const string ERROR_CONSULTANT_IT_CAREER_STARTED_REQUIRED_UP = "ERCONS-0027";


    // Candidate error of invalid fields values
    public const string ERROR_CANDIDATE_IDCANDIDATE_REQUIRED_UP = "ERCAND-0000";
    public const string ERROR_CANDIDATE_IDCANDIDATE_TYPE = "ERCAND-0001";
    public const string ERROR_CANDIDATE_FIRSTNAME_REQUIRED = "ERCAND-0002";
    public const string ERROR_CANDIDATE_LASTNAME_REQUIRED = "ERCAND-0003";
    public const string ERROR_CANDIDATE_ISPARTNER_REQUIRED = "ERCAND-0004";
    public const string ERROR_CANDIDATE_ISPARTNER_TYPE = "ERCAND-0005";
    public const string ERROR_CANDIDATE_IDRESOURCETYPE_TYPE = "ERCAND-0006";
    public const string ERROR_CANDIDATE_VAT_RATE_TYPE = "ERCAND-0007";
    public const string ERROR_CANDIDATE_IDAPPROVER_CONS_TYPE = "ERCAND-0008";
    public const string ERROR_CANDIDATE_IDRESOURCETYPE_REQUIRED = "ERCAND-0009";

    // USER error of invalid fields values
    public const string ERROR_USER_USERID_REQUIRED_UP = "ERUSER-0000";
    public const string ERROR_USER_USERID_TYPE = "ERUSER-0001";
    public const string ERROR_USER_USERNAME_REQUIRED = "ERUSER-0002";
    public const string ERROR_USER_IMAGE_TYPE = "ERUSER-0003";
    public const string ERROR_USER_EMAIL_REQUIRED = "ERUSEREM-0000";
    // Role error of invalid fields values
    public const string ERROR_ROLE_ROLEID_REQUIRED_UP = "ERROLE-0000";
    public const string ERROR_ROLE_ROLEID_TYPE = "ERROLE-0001";
    public const string ERROR_ROLE_ROLENAME_REQUIRED = "ERROLE-0002";

    // TabParams (level-category-place of dilevery-type-profile-departement-highest degree) error of invalid fields values
    public const string ERROR_PARAM_ID_REQUIRED_UP = "ERPARAM-0000";
    public const string ERROR_PARAM_ID_TYPE = "ERPARAM-0001";
    public const string ERROR_PARAM_VALUEID_REQUIRED = "ERPARAM-0002";

    // Company error of invalid fields values
    public const string ERROR_COMPANY_IDCOMPANY_REQUIRED_UP = "ERCOMP-0000";
    public const string ERROR_COMPANY_IDCOMPANY_TYPE = "ERCOMP-0002";
    public const string ERROR_COMPANY_COMPANYNAME_REQUIRED = "ERCOMP-0003";
    public const string ERROR_COMPANY_CMP_VAT_RATE_TYPE = "ERCOMP-0004";
    public const string ERROR_COMPANY_IDAPPROVERCMP_TYPE = "ERCOMP-0005";

    // PTM owner error of invalid fields values
    public const string ERROR_PTMOWNER_ID_REQUIRED_UP = "ERPTMOwner-0000";
    public const string ERROR_PTMOWNER_ID_TYPE = "ERPTMOwner-0001";
    public const string ERROR_PTMOWNER_VALUEID_REQUIRED = "ERPTMOwner-0002";
    public const string ERROR_PTMOWNER_PTMOWNER_VAT_RATE_TYPE = "ERPTMOwner-0004";
    public const string ERROR_PTMOWNER_IDAPPROVERPTMOWNER_TYPE = "ERPTMOwner-0005";

    // Subcontractor error of invalid fields values
    public const string ERROR_SUBCONTRACTOR_ID_REQUIRED_UP = "ERSUBCON-0000";
    public const string ERROR_SUBCONTRACTOR_ID_TYPE = "ERSUBCON-0001";
    public const string ERROR_SUBCONTRACTOR_VALUEID_REQUIRED = "ERSUBCON-0002";
    public const string ERROR_SUBCONTRACTOR_SUBCONT_VAT_RATE_TYPE = "ERPTMOwner-0003";
    public const string ERROR_SUBCONTRACTOR_IDAPPROVERSUB_TYPE = "ERPTMOwner-0004";

    // Approvers error of invalid fields values
    public const string ERROR_APPROVERS_ID_REQUIRED_UP = "ERAPPROVER-0000";
    public const string ERROR_APPROVERS_ID_TYPE = "ERAPPROVER-0001";
    public const string ERROR_APPROVERS_APP_FIRSTNAME_REQUIRED = "ERAPPROVER-0002";
    public const string ERROR_APPROVERS_APP_LASTNAME_REQUIRED = "ERAPPROVER-0003";


    // Country error of invalid fields values
    public const string ERROR_COUNTRY_ID_REQUIRED_UP = "ERCOUNTRY-0000";
    public const string ERROR_COUNTRY_ID_TYPE = "ERCOUNTRY-0001";
    public const string ERROR_COUNTRY_COUNTRYNAME_REQUIRED = "ERCOUNTRY-0002";
    public const string ERROR_COUNTRY_HOTEL_CEILING_TYPE = "ERCOUNTRY-0003";


    // Activity log
    public const string ERROR_ACTIVITYLOG_DATE_RANGE_INVALID = "ERAL-0000";

    public const string ERROR_COUNTRY_DAILY_ALLOWANCE_TYPE = "ERCOUNTRY-0004";
    public const string ERROR_EXCEED_LIMIT_CONSULTANT_DW = "ERELCDW-0000";
    public const string ERROR_EXCEED_LIMIT_CONSULTANT_DW_FORECAST = "ERELCDWF-0000";
    public const string ERROR_CONS_DELETE_TMPTM_DW = "ERDELCONSDW-0000";
    public const string ERROR_CONS_DELETE_TMPTM_LINE = "ERDELCONSLINE-0000";

    public const string ERROR_EXCEED_LIMIT_DAYS_PROFILE = "ERELDPROFILE-0000";

    //Check outlook 
    public const string MESSAGE_CHECKOUTLOOK_SUCCESS = "MOUTLOOK-0000";
    public const string MESSAGE_CHECKOUTLOOK_NOTSUCCES = "MOUTLOOK-0001";


    /**********Provision messages ******************/
    public const string MESSAGE_PROVISION_SUCCESS_ADD = "MAPS-0000";
    public const string MESSAGE_OERP_PROVISION_SUCCESS_UPD = "MOPS-0000";
    public const string MESSAGE_PROVISION_SUCCESS_DEL = "MDPS-0000";

    public const string MESSAGE_PROVISION_SUCCESS_UPD = "MUPS-0000";

    public const string MESSAGE_PROVISION_SUCCESS_COMMENT = "MCPS-0000";

    public const string MESSAGE_PROVISION_HISTORY_SUCCESS_ADD = "MPHS-0000";

    public const string MESSAGE_DW_PROVISION_SUCCESS_UPD = "MADPS-0000";

    public const string MESSAGE_GENERAL_PROVISION_SUCCESS = "MGPS-0000";
    public const string MESSAGE_HISTORYDWPROVISION_SUCCESS_ADD = "MHDPA-0000";
    public const string MESSAGE_HISTORY_GENERAL_PROVISION_SUCCESS_ADD = "MHGPA-0000";
    public const string MESSAGE_GENERAL_PROVISION_SUCCESS_DEL = "MDPROVS-0001";
    public const string MESSAGE_INVOICE_PROVISION_SUCCESS_ADD = "MIPRSA-0001";
    public const string MESSAGE_INVOICE_PROVISION_SUCCESS_UPDATE = "MIPRSU-0001";
    public const string MESSAGE_INVOICE_OERP_PROVISION_SUCCESS_ADD = "MIPROA-0001";
    public const string MESSAGE_SUMMF_PROVISION_VALID = "MSPRV-0001";
    public const string MESSAGE_INVOICE_PROVISION_HISTORY_ADD = "MSPRHA-0001";
    public const string MESSAGE_CHANGE_CONSULTANT_COST_PROVISION_SUCCESS = "MCHCPS-0001";
    public const string MESSAGE_NO_CHANGE_COST_PROVISION = "MNCHCP-0001";
    public const string MESSAGE_PAYMENT_PROVISION_SUCCESS_ADD = "MPPSA-0001";
    public const string MESSAGE_PAYMENT_PROVISION_SUCCESS_UPDATE = "MPPSU-0001";
    public const string MESSAGE_PAYMENT_PROVISION_HISTORY_ADD = "MPPH-0001";
    public const string MESSAGE_PAYMENT_OERP_PROVISION_SUCCESS_ADD = "MPPROA-0001";
    public const string MESSAGE_BR_INCORRECT_DW_PROVISION = "MBRIDP-0001";
    /***********Provision errors*********************/
    public const string ERROR_PROVISION_NOTVALID = "ERPS0001";

    public const string ERROR_PROVISION_REQUEST_NBR_EXIST = "ERPS0002";

    public const string ERROR_PROVISION_NOTFOUND = "ERPS0003";

    public const string ERROR_PROVISION_EXTERNAL_ERROR = "ERPS0004";
    public const string ERROR_PROVISION_AMOUNT_EXCEED = "ERPE0005";

    public const string ERROR_PROVISION_INVOICED = "ERPINV-0001";
    public const string ERROR_EXCEED_LIMIT_DW_PROVISION = "ERLDP-0001";
    public const string ERROR_EXCEED_LIMIT_CONSULTANT_PROVISION_DW = "ERLDP-0002";
    public const string ERROR_CONS_DELETE_PROVISION_INVOICE = "ERCDPROVI-0000";

    public const string ERROR_CONS_DELETE_PROVISION_DW = "ERDELCONSDWPROV-0000";

    public const string ERROR_DW_PROVISION_INVOICED = "ERDPINV-0001";

    public const string ERROR_INVOICE_PROVISION_NOTVALID = "ERPINV-0002";

    public const string ERROR_INVOICE_PROVISION_NOTFOUND = "ERPINV-0003";

    public const string ERROR_GENERAL_PROVISION_INVOICED = "ERPINV-0004";

    public const string ERROR_PROVISION_EXCEED_MFTOTAL = "ERPINV-0005";
    public const string ERROR_CONSULTANT_COST_PROVISION_INVALID = "ERPCI-0006";
    public const string ERROR_DW_PROVISION_PAID = "ERDPPAY-0006";
    public const string ERROR_PAYMENT_PROVISION_ACCELERATE = "ERAPPAY-0007";
    public const string ERROR_GERNERAL_PROVISION_PAID = "ERGPPAY-0008";
    public const string ERROR_PAYMENT_PROVISION_NOT_ACCELERATE = "ERNAPPAY-0007";

    public const string ERROR_PROVISION_PAYMENT_NOTVALID = "ERPPV-0008";
    public const string ERROR_PAYMENT_PROVISION_NOT_FOUND = "ERPNF-0009";
    public const string ERROR_MFPAID_PROVSION_EXCEED_MFTOTAL = "ERPMF-0010";
    public const string ERROR_CONS_DELETE_PROVISION_PAYMENT = "ERCDPROVP-0011";
    public const string ERROR_CONS_DELETE_PROVISION_CHANGECOST = "ERCDPROVC-0012";
    public const string ERROR_CONS_DELETE_PROVISION_EC = "ERCDPROVEC-0013";
    public const string ERROR_DAYSWORKED_PROVISION_NOTFOUND = "EDPNF-0000";
    public const string MESSAGE_OERP_SC_SUCCESS_UPD = "MOSCS-0000";
    public const string MESSAGE_INVOICE_OERP_SC_SUCCESS_ADD = "MIOSCS-0000";
    public const string MESSAGE_PAYMENT_OERP_SC_SUCCESS_ADD = "MPOSCS-0000";
    public const string ERROR_CONS_DELETE_GENERAL_PROVISION = "ECDGP-0000";


    /***** errors provision TMPTM***/
    public const string ERROR_DW_PROVISION_TMPTM_INVOICED = "EDWPTMPTMI-0001";
    public const string ERROR_DAYSWORKED_PROVISION_TM_PTMNOTFOUND = "ERDWPNF-0002";
    public const string ERROR_GENERAL_PROVISION_TM_PTM_INVOICED = "ERGPNTMPTMI-0003";


    /**** messages provision TMPTM***/

    public const string MESSAGE_DAYSWORKED_PROVISION_TMPTM_SUCCESS_DELETE = "MDWPDS-0001";
    public const string MESSAGE_DW_PROVISION_TMPPTM_DELETE_ALLOW = "MDWPDA-0002";
    public static string MESSAGE_GENERAL_PROVISION_MTPTM_SUCCESS_DEL = "MGPDA-0003";

    /***** errors Payment provision TMPTM***/

    public const string ERROR_DW_PROVISION__TMPTM_PAID = "ERDWPPROV-0001";
    public const string ERROR_PROVISION__TMPTM_PAID = "ERPPROV-0001";


    /*** Currency ***/
    public const string ERROR_CURRENCY_EXTERNAL_ERROR = "ERC-0000";
    public const string ERROR_CURRENCY_NOTVALID = "ERCNV-0000";
    public const string MESSAGE_CURRENCY_SUCCESS_ADD = "MCSA-0000";
    public const string MESSAGE_CURRENCY_SUCCESS_UPD = "MCSU-0000";
    public const string ERROR_CURRENCY_EXIST = "ERCE-0000";
    public const string ERROR_CURRENCY_NOTFOUND = "ERCNF-0000";
    public const string MESSAGE_CURRENCY_ASSIGNED_TO_CONST = "MCAC-0000";
    public const string MESSAGE_CURRENCY_ASSIGNED_TO_PROFILE = "MCAP-0000";
    public const string MESSAGE_CURRENCY_ASSIGNED_TO_BR = "MCABR-0000";
    public const string MESSAGE_CURRENCY_SUCCESS_DEL = "MCSD-0000";
    public const string MESSAGE_CURRENCY_ASSIGNED_TO_FWC = "MCAFWC-0000";
    public const string ERROR_CURRENCY_ISDEFAULT = "ECDE-0000";
    public const string MESSAGE_LIST_RATES_SUCCESS_UPD = "MERSU-0000";

    /**** Transformation into extra services ******/

    public const string ERROR_NBDAYSTRANSFORMED_INVALID = "ERNDT-0001";
    public const string ERROR_NBDAYSPROVISION_INVALID = "ERNDP-0002";
    public const string MESSAGE_TRANSFOMRATION_ADD_SUCCESS = "MTAS-0001";
    public static string MESSAGE_TRANSFOMRATION_DELETE_SUCCESS = "MTDS-0002";
    public static string ERROR_TRANSFOMRATION_NOT_FOUND = "ERTNF-0003";
    public static string ERROR_TOTALBUDGET_INVALID = "ERTBI-0004";
    public static string ERROR_DELETE_NDAYS_INVALID = "ERDNI-0005";
    public static string ERROR_DELETE_AMOUNT_INVALID = "ERDAI-0006";
    public static string ERROR_DELETE_TRANSFORMATION_PROVISION_EXIST = "ERDTP-0007";
    public const string ERROR_PAYMENT_INVOICE_EXIST_PROVISION = "EPIEP-0008";
    public const string ERROR_BR_PROFILE_CURRENCY = "ERBRPCR-0000";
    public const string ERROR_EXCEED_LIMIT_CONSULTANT_DW_TRANSFORMED = "ERELCDWTRANS-0000";

    /** FWC params messages **/
    public const string ERROR_FWC_MISSING_PARAMS = "ERFWCMP-0000";
    public const string MESSAGE_FWC_PARAMS_VALID = "MFWCPV-0000";



    /******errors OERP in performance *******/
    public const string ERROR_OERPCODE_EMPTY_DW_PROVISION = "EOERPEDP-0001";
    public const string ERROR_OERPCODE_EMPTY_GENERAL_PROVISION = "EOERPEGP-0001";
    public const string ERROR_OERPCODE_EMPTY_NORMAL_DW = "EOERPEND-0001";

    //*********** OERP Setting *****************/
    public const string MESSAGE_OERP_SUCCESS_ADD = "OERPA-0000";
    public const string MESSAGE_OERPS_SUCCESS_UPD = "OERPU-0000";
    public const string MESSAGE_OERP_SUCCESS_DEL = "OERPD-0000";
    public const string MESSAGE_OERP_EXIST = "OERPE-0000";

    //*********** Communicate to partners *****************/
    public const string MESSAGE_PARTNER_SUCCESS_SENDMAIL = "MPSMS-0000";
    public const string ERROR_PARTNER_SENDMAIL = "ERRPSM-0001";

    // exceed  Max Quartly
    public const string ERROR_EXCEED_MaxQuartly = "EREMAXInv-0000";
    public const string ERROR_EXCEED_MinQuartly = "EREMINInv-0000";
    //public const string ERROR_EXCEED_MinQuartly2 = "EREMINQ2-0000";
    //public const string ERROR_EXCEED_MinQuartly3 = "EREMINQ3-0000";
    //public const string ERROR_EXCEED_MinQuartly4 = "EREMINQ4-0000";

    public const string MESSAGE_SEND_EMAIL_SUCCESS = "MSSE-0000";
    public const string ERROR_DRAFT_APPROVAL = "ERDRAFTAPPROVAL-0000";
    public const string ERROR_LINE_NOTFOUND = "ERLINENF-0001";
    public const string MESSAGE_PERFORMANCE_SUCCESS_UPD = "MPERSU-0000";
}