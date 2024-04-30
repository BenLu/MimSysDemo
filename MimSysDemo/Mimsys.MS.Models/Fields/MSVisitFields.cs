// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

#endregion

namespace Mimsys.MS.Models
{
    /// <summary>
    /// Contains list of MSVisit Constants
    /// </summary>
    public partial class MSVisit
    {
        /// <summary>
        /// Entity Name
        /// </summary>
        public const string EntityName = "MS0510";


        #region Fields Properties

        /// <summary>
        /// Contains list of MSVisit Field Constants
        /// </summary>
        public class Fields
        {
            /// <summary>
            /// Property for VisitCode
            /// </summary>
            public const string VisitCode = "VISITID";

            /// <summary>
            /// Property for VisitDate
            /// </summary>
            public const string VisitDate = "VISTDATE";

            /// <summary>
            /// Property for VisitTime
            /// </summary>
            public const string VisitTime = "VISTTIME";

            /// <summary>
            /// Property for VisitType
            /// </summary>
            public const string VisitType = "VISTTYPE";

            /// <summary>
            /// Property for PatientCode
            /// </summary>
            public const string PatientCode = "PATCODE";

            /// <summary>
            /// Property for ProviderCode
            /// </summary>
            public const string ProviderCode = "PROVIDER";

            /// <summary>
            /// Property for DepartmentCode
            /// </summary>
            public const string DepartmentCode = "DEPTID";

            /// <summary>
            /// Property for VisitClosed
            /// </summary>
            public const string VisitClosed = "CLOSEYN";

            /// <summary>
            /// Property for ReferenceType
            /// </summary>
            public const string ReferenceType = "REFTYPE";

            /// <summary>
            /// Property for ReferralProviderCode
            /// </summary>
            public const string ReferralProviderCode = "REFPROV";

            /// <summary>
            /// Property for Facility
            /// </summary>
            public const string Facility = "REFFACL";

            /// <summary>
            /// Property for OtherReferrals
            /// </summary>
            public const string OtherReferrals = "REFOTH";

            /// <summary>
            /// Property for ReferenceCode
            /// </summary>
            public const string ReferenceCode = "REFCODE";

            /// <summary>
            /// Property for ReferenceDetail
            /// </summary>
            public const string ReferenceDetail = "REFDETAL";

            /// <summary>
            /// Property for Billed
            /// </summary>
            public const string Billed = "BILLYN";

            /// <summary>
            /// Property for QueueNumber2
            /// </summary>
            public const string QueueNumber2 = "NATEXP";

            /// <summary>
            /// Property for CheckTime
            /// </summary>
            public const string CheckTime = "CHKTIME";

            /// <summary>
            /// Property for CheckOut
            /// </summary>
            public const string CheckOut = "CHKOUTYN";

            /// <summary>
            /// Property for CheckOutTime
            /// </summary>
            public const string CheckOutTime = "CHKOTIME";

            /// <summary>
            /// Property for VisitLevelCopay
            /// </summary>
            public const string VisitLevelCopay = "VSTCOPAY";

            /// <summary>
            /// Property for Inactive
            /// </summary>
            public const string Inactive = "INACTIVE";

            /// <summary>
            /// Property for InsuranceCompanyCode
            /// </summary>
            public const string InsuranceCompanyCode = "INSCOMP";

            /// <summary>
            /// Property for PlanCode
            /// </summary>
            public const string PlanCode = "INSPOLCY";

            /// <summary>
            /// Property for PolicyNumber
            /// </summary>
            public const string PolicyNumber = "POLCYNO";

            /// <summary>
            /// Property for DeductibleBalance
            /// </summary>
            public const string DeductibleBalance = "DEDCTBAL";

            /// <summary>
            /// Property for CustomerType
            /// </summary>
            public const string CustomerType = "CREDITTY";

            /// <summary>
            /// Property for Customer
            /// </summary>
            public const string Customer = "CREPAT";

            /// <summary>
            /// Property for BillNumber
            /// </summary>
            public const string BillNumber = "BILLNUM";

            /// <summary>
            /// Property for BillingCode
            /// </summary>
            public const string BillingCode = "BILLCODE";

            /// <summary>
            /// Property for ConsultationType
            /// </summary>
            public const string ConsultationType = "CONSULTTP";

            /// <summary>
            /// Property for Others
            /// </summary>
            public const string Others = "OTHERS";

            /// <summary>
            /// Property for EpisodeCode
            /// </summary>
            public const string EpisodeCode = "EPISDCOD";

            /// <summary>
            /// Property for PreviousVisitDate
            /// </summary>
            public const string PreviousVisitDate = "PRVVSTDATE";

            /// <summary>
            /// Property for PreviousVisitProviderCode
            /// </summary>
            public const string PreviousVisitProviderCode = "PRVVSTPRO";

            /// <summary>
            /// Property for CaseTransfer
            /// </summary>
            public const string CaseTransfer = "CASETRF";

            /// <summary>
            /// Property for TransferDate
            /// </summary>
            public const string TransferDate = "TRFDATE";

            /// <summary>
            /// Property for RequisitionNo
            /// </summary>
            public const string RequisitionNo = "REQNO";

            /// <summary>
            /// Property for CaseSelect
            /// </summary>
            public const string CaseSelect = "CASESELECT";

            /// <summary>
            /// Property for SponsoredBy
            /// </summary>
            public const string SponsoredBy = "SUBSCRIBBY";

            /// <summary>
            /// Property for SponsorCode
            /// </summary>
            public const string SponsorCode = "EMPLYRCODE";

            /// <summary>
            /// Property for IsEmergency
            /// </summary>
            public const string IsEmergency = "ISEMRGNCY";

            /// <summary>
            /// Property for VisitPurpose
            /// </summary>
            public const string VisitPurpose = "VSTPURPOSE";

            /// <summary>
            /// Property for ClinicCode
            /// </summary>
            public const string ClinicCode = "CLINICCODE";

            /// <summary>
            /// Property for IsPackagePatient
            /// </summary>
            public const string IsPackagePatient = "PACKPATYN";

            /// <summary>
            /// Property for FreeVisit
            /// </summary>
            public const string FreeVisit = "FREVISITYN";

            /// <summary>
            /// Property for PackageCode
            /// </summary>
            public const string PackageCode = "PACKCODE";

            /// <summary>
            /// Property for ConsultationTypeCode
            /// </summary>
            public const string ConsultationTypeCode = "CONSULTTYP";

            /// <summary>
            /// Property for IsReferring
            /// </summary>
            public const string IsReferring = "ISREFERIN";

            /// <summary>
            /// Property for InitialVisit
            /// </summary>
            public const string InitialVisit = "INITVISIT";

            /// <summary>
            /// Property for IsDeductibleCollected
            /// </summary>
            public const string IsDeductibleCollected = "DEDCOLLYN";

            /// <summary>
            /// Property for DeductibleAmount
            /// </summary>
            public const string DeductibleAmount = "DEDUCTAMT";

            /// <summary>
            /// Property for GenCount
            /// </summary>
            public const string GenCount = "GENCOUNT";

            /// <summary>
            /// Property for SpecialCount
            /// </summary>
            public const string SpecialCount = "SPECOUNT";

            /// <summary>
            /// Property for ConsultationCount
            /// </summary>
            public const string ConsultationCount = "CONCOUNT";

            /// <summary>
            /// Property for IsMLC
            /// </summary>
            public const string IsMLC = "MLCYN";

            /// <summary>
            /// Property for MLCCode
            /// </summary>
            public const string MLCCode = "MLCCODE";

            /// <summary>
            /// Property for SOAPNumber
            /// </summary>
            public const string SOAPNumber = "SOAPNO";

            /// <summary>
            /// Property for PolicyGroupCode
            /// </summary>
            public const string PolicyGroupCode = "POLGRPCODE";

            /// <summary>
            /// Property for PolicyGroupDescription
            /// </summary>
            public const string PolicyGroupDescription = "POLGRPDES";

            /// <summary>
            /// Property for PlanName
            /// </summary>
            public const string PlanName = "POLICYNAME";

            /// <summary>
            /// Property for InsuranceName
            /// </summary>
            public const string InsuranceName = "INSNAME";

            /// <summary>
            /// Property for CreatedBy
            /// </summary>
            public const string CreatedBy = "CREATBY";

            /// <summary>
            /// Property for CreatedDate
            /// </summary>
            public const string CreatedDate = "CREATDT";

            /// <summary>
            /// Property for ModifiedBy
            /// </summary>
            public const string ModifiedBy = "MODBY";

            /// <summary>
            /// Property for ModifiedDate
            /// </summary>
            public const string ModifiedDate = "MODDT";

            /// <summary>
            /// Property for NumberOfBills
            /// </summary>
            public const string NumberOfBills = "NOOFBILLS";

            /// <summary>
            /// Property for ConsultBills
            /// </summary>
            public const string ConsultBills = "CONSBILLED";

            /// <summary>
            /// Property for RegisterBills
            /// </summary>
            public const string RegisterBills = "REGBILLED";

            /// <summary>
            /// Property for TransferBy
            /// </summary>
            public const string TransferBy = "TRFBY";

            /// <summary>
            /// Property for TransferTime
            /// </summary>
            public const string TransferTime = "TRFTIME";

            /// <summary>
            /// Property for TransferredAdmissionCode
            /// </summary>
            public const string TransferredAdmissionCode = "TRFIPCODE";

            /// <summary>
            /// Property for TransferReason
            /// </summary>
            public const string TransferReason = "TRANSFERRE";

            /// <summary>
            /// Property for IsChronic
            /// </summary>
            public const string IsChronic = "CHRONIC";

            /// <summary>
            /// Property for UnitCode
            /// </summary>
            public const string UnitCode = "UNITCODE";

            /// <summary>
            /// Property for UnitDescription
            /// </summary>
            public const string UnitDescription = "DESC";

            /// <summary>
            /// Property for DiscountCategoryCode
            /// </summary>
            public const string DiscountCategoryCode = "DISCCATCOD";

            /// <summary>
            /// Property for DiscountCategoryDescription
            /// </summary>
            public const string DiscountCategoryDescription = "DISCCATDES";

            /// <summary>
            /// Property for AccidentRegCode
            /// </summary>
            public const string AccidentRegCode = "ACCREGCODE";

            /// <summary>
            /// Property for AccidentPlace
            /// </summary>
            public const string AccidentPlace = "ACCDPLACE";

            /// <summary>
            /// Property for PoliceStationName
            /// </summary>
            public const string PoliceStationName = "POLSTANAME";

            /// <summary>
            /// Property for IsIntimated
            /// </summary>
            public const string IsIntimated = "ISINTIMATE";

            /// <summary>
            /// Property for WoundCertifiedDate
            /// </summary>
            public const string WoundCertifiedDate = "WOUNCERDAT";

            /// <summary>
            /// Property for ExternalProviderCode
            /// </summary>
            public const string ExternalProviderCode = "EXTPROVCOD";

            /// <summary>
            /// Property for ExternalProviderName
            /// </summary>
            public const string ExternalProviderName = "EXTPROVDES";

            /// <summary>
            /// Property for PatientType
            /// </summary>
            public const string PatientType = "SPONSCODE";

            /// <summary>
            /// Property for VisitExpiryDate
            /// </summary>
            public const string VisitExpiryDate = "VSTEXPDATE";

            /// <summary>
            /// Property for SpecialityCode
            /// </summary>
            public const string SpecialityCode = "SPECCODE";

            /// <summary>
            /// Property for LimitUtilized
            /// </summary>
            public const string LimitUtilized = "INLIMITUTL";

            /// <summary>
            /// Property for LimitBalance
            /// </summary>
            public const string LimitBalance = "INLIMITBAL";

            /// <summary>
            /// Property for OPLimitUtilized
            /// </summary>
            public const string OPLimitUtilized = "OPLIMITUTL";

            /// <summary>
            /// Property for OPLimitBalance
            /// </summary>
            public const string OPLimitBalance = "OPLIMITBAL";

            /// <summary>
            /// Property for QueueNumber
            /// </summary>
            public const string QueueNumber = "QUEUENO";

            /// <summary>
            /// Property for SpecialityDepartment
            /// </summary>
            public const string SpecialityDepartment = "SPECDEPTYN";

            /// <summary>
            /// Property for PackageType
            /// </summary>
            public const string PackageType = "PACKAGETYP";

            /// <summary>
            /// Property for CheckedIn
            /// </summary>
            public const string CheckedIn = "CHKINYN";

            /// <summary>
            /// Property for ReferralEmployeeCode
            /// </summary>
            public const string ReferralEmployeeCode = "REFEMPCODE";

            /// <summary>
            /// Property for EpisodeNo
            /// </summary>
            public const string EpisodeNo = "EPISODTOT";

            /// <summary>
            /// Property for VisitFromAppointment
            /// </summary>
            public const string VisitFromAppointment = "APPOINTYN";

            /// <summary>
            /// Property for InjuryCode
            /// </summary>
            public const string InjuryCode = "INJCODE";

            /// <summary>
            /// Property for MultiVisitPackageOrderCode
            /// </summary>
            public const string MultiVisitPackageOrderCode = "MLTPKGCOD";

            /// <summary>
            /// Property for PatientName
            /// </summary>
            public const string PatientName = "PATNAME";

            /// <summary>
            /// Property for ProviderName
            /// </summary>
            public const string ProviderName = "PRONAME";

            /// <summary>
            /// Property for DepartmentName
            /// </summary>
            public const string DepartmentName = "DEPTNAME";

            /// <summary>
            /// Property for ConsultName
            /// </summary>
            public const string ConsultName = "CONSNAME";

            /// <summary>
            /// Property for ReferredName
            /// </summary>
            public const string ReferredName = "REFNAME";

            /// <summary>
            /// Property for EmployeeName
            /// </summary>
            public const string EmployeeName = "EMPLYRNAME";

            /// <summary>
            /// Property for ClinicDescription
            /// </summary>
            public const string ClinicDescription = "CLINICDESC";

            /// <summary>
            /// Property for PackageDescription
            /// </summary>
            public const string PackageDescription = "PACKDESC";

            /// <summary>
            /// Property for ReferralName
            /// </summary>
            public const string ReferralName = "REFDNAME";

            /// <summary>
            /// Property for SpecialityDescription
            /// </summary>
            public const string SpecialityDescription = "SPECDESC";

            /// <summary>
            /// Property for ConsultationDescription
            /// </summary>
            public const string ConsultationDescription = "CONSULTDSC";

            /// <summary>
            /// Property for MLCDescription
            /// </summary>
            public const string MLCDescription = "MLCDESC";

            /// <summary>
            /// Property for TypeOfVisit
            /// </summary>
            public const string TypeOfVisit = "TYPOFVST";

            /// <summary>
            /// Property for RegistrationDate
            /// </summary>
            public const string RegistrationDate = "REGDATE";

            /// <summary>
            /// Property for IsFreeVisit
            /// </summary>
            public const string IsFreeVisit = "ISFREEVST";

            /// <summary>
            /// Property for AgeYears
            /// </summary>
            public const string AgeYears = "AGEYEARS";

            /// <summary>
            /// Property for AgeMonths
            /// </summary>
            public const string AgeMonths = "AGEMONTHS";

            /// <summary>
            /// Property for AgeDays
            /// </summary>
            public const string AgeDays = "AGEDAYS";

            /// <summary>
            /// Property for Authorized
            /// </summary>
            public const string Authorized = "AUTH";

            /// <summary>
            /// Property for ProvisionalICDCompleted
            /// </summary>
            public const string ProvisionalICDCompleted = "PRVICD";

            /// <summary>
            /// Property for FinalICDCompleted
            /// </summary>
            public const string FinalICDCompleted = "FINICD";

            /// <summary>
            /// Property for AuthorizationBy
            /// </summary>
            public const string AuthorizationBy = "AUTHBY";

            /// <summary>
            /// Property for AuthorizationDate
            /// </summary>
            public const string AuthorizationDate = "AUTHDT";

            /// <summary>
            /// Property for ConsultationSetup
            /// </summary>
            public const string ConsultationSetup = "PROVDEPSET";

            /// <summary>
            /// Property for EpisodeNumber
            /// </summary>
            public const string EpisodeNumber = "EPICODE";

            /// <summary>
            /// Property for InsApplicationNumber
            /// </summary>
            public const string InsApplicationNumber = "APPLNUM";

            /// <summary>
            /// Property for PrescriptionType
            /// </summary>
            public const string PrescriptionType = "PRESCTYPE";

            /// <summary>
            /// Property for AppointmentNumber
            /// </summary>
            public const string AppointmentNumber = "APPTNO";

            /// <summary>
            /// Property for EncounterUniqueCode
            /// </summary>
            public const string EncounterUniqueCode = "ENCOUUNIQ";

            /// <summary>
            /// Property for NursingAssessmentStatus
            /// </summary>
            public const string NursingAssessmentStatus = "NURASMST";

            /// <summary>
            /// Property for MultiVisitPackageType
            /// </summary>
            public const string MultiVisitPackageType = "MULTPKGTYP";

            /// <summary>
            /// Property for ApplicationDate
            /// </summary>
            public const string ApplicationDate = "APPLDATE";

            /// <summary>
            /// Property for EligibleAmount
            /// </summary>
            public const string EligibleAmount = "ELIGAMOUNT";

            /// <summary>
            /// Property for EligibleType
            /// </summary>
            public const string EligibleType = "ELIGIBTYPE";

            /// <summary>
            /// Property for IsFallRisk
            /// </summary>
            public const string IsFallRisk = "FALLRISKYN";

            /// <summary>
            /// Property for IsSecondaryPlan
            /// </summary>
            public const string IsSecondaryPlan = "SECPLANYN";

            /// <summary>
            /// Property for SecondaryCustomerType
            /// </summary>
            public const string SecondaryCustomerType = "SCUSTTYPE";

            /// <summary>
            /// Property for SecondaryCustomerCode
            /// </summary>
            public const string SecondaryCustomerCode = "SCUSTCODE";

            /// <summary>
            /// Property for SecondaryPolicyGroupCode
            /// </summary>
            public const string SecondaryPolicyGroupCode = "SPOLGRPCOD";

            /// <summary>
            /// Property for SecondaryPlanCode
            /// </summary>
            public const string SecondaryPlanCode = "SPLANCODE";

            /// <summary>
            /// Property for SecondaryPolicyNumber
            /// </summary>
            public const string SecondaryPolicyNumber = "SPOLCYNO";

            /// <summary>
            /// Property for HospitalName
            /// </summary>
            public const string HospitalName = "HOSPNAME";

            /// <summary>
            /// Property for Network
            /// </summary>
            public const string Network = "NETWCODE";

            /// <summary>
            /// Property for PolicyStartDate
            /// </summary>
            public const string PolicyStartDate = "POLSTDT";

            /// <summary>
            /// Property for PolicyExpiryDate
            /// </summary>
            public const string PolicyExpiryDate = "POLEXPDT";

            /// <summary>
            /// Property for SecondaryPolicyStartDate
            /// </summary>
            public const string SecondaryPolicyStartDate = "SPOLSTDT";

            /// <summary>
            /// Property for SecondaryPolicyExpiryDate
            /// </summary>
            public const string SecondaryPolicyExpiryDate = "SPOLEXPDT";

            /// <summary>
            /// Property for SecondarySponsorCode
            /// </summary>
            public const string SecondarySponsorCode = "SECSPONCOD";

            /// <summary>
            /// Property for EHRAlertMessage
            /// </summary>
            public const string EHRAlertMessage = "EHRALRTMSG";

            /// <summary>
            /// Property for ModifiedPrimaryPolicyNo
            /// </summary>
            public const string ModifiedPrimaryPolicyNo = "MODPRPOLNO";

            /// <summary>
            /// Property for ModifiedSecPolicyNumber
            /// </summary>
            public const string ModifiedSecPolicyNumber = "MODSEPOLNO";

            /// <summary>
            /// Property for VisitExistEnd
            /// </summary>
            public const string VisitExistEnd = "VSTEXTEND";

            /// <summary>
            /// Property for VisitExistEndTime
            /// </summary>
            public const string VisitExistEndTime = "EXTENDTIME";

            /// <summary>
            /// Property for IsConsent
            /// </summary>
            public const string IsConsent = "CONSENT";

            /// <summary>
            /// Property for IsDisclosure
            /// </summary>
            public const string IsDisclosure = "DISCLOSURE";

            /// <summary>
            /// Property for HL7Message
            /// </summary>
            public const string HL7Message = "HL7MESSAGE";

            /// <summary>
            /// Property for MaternityPatient
            /// </summary>
            public const string MaternityPatient = "MAITYPTENT";

            /// <summary>
            /// Property for PreAuthorizationRequired
            /// </summary>
            public const string PreAuthorizationRequired = "PREAUTHREQ";

            /// <summary>
            /// Property for Authorize
            /// </summary>
            public const string Authorize = "AUTHORIZE";

            /// <summary>
            /// Property for AuthorizationStart
            /// </summary>
            public const string AuthorizationStart = "AUTHSTDT";

            /// <summary>
            /// Property for AuthorizationEnd
            /// </summary>
            public const string AuthorizationEnd = "AUTHENDDT";

            /// <summary>
            /// Property for PatientEmployerCode
            /// </summary>
            public const string PatientEmployerCode = "COMPANY";

            /// <summary>
            /// Property for IPEMCode
            /// </summary>
            public const string IPEMCode = "IPEMCODE";

            /// <summary>
            /// Property for AuthorizationNumber
            /// </summary>
            public const string AuthorizationNumber = "AUTHNUM";

            /// <summary>
            /// Property for ExternalMedication
            /// </summary>
            public const string ExternalMedication = "EXTMEDCN";

            /// <summary>
            /// Property for PharmacyVisit
            /// </summary>
            public const string PharmacyVisit = "PHARVISIT";

            /// <summary>
            /// Property for DeliveryOrder
            /// </summary>
            public const string DeliveryOrder = "DELVORD";

            /// <summary>
            /// Property for IntermediateVisit
            /// </summary>
            public const string IntermediateVisit = "INTERMVIST";

            /// <summary>
            /// Property for Source
            /// </summary>
            public const string Source = "SOURCE";

            /// <summary>
            /// Property for AvailFirst
            /// </summary>
            public const string AvailFirst = "AVAILFRST";

            /// <summary>
            /// Property for IsVideoConsultation
            /// </summary>
            public const string IsVideoConsultation = "VDIOCONSYN";

            /// <summary>
            /// Property for DefaultEMCode
            /// </summary>
            public const string DefaultEMCode = "DEFEMCODE";

            /// <summary>
            /// Property for DiscountAmount
            /// </summary>
            public const string DiscountAmount = "DISCAMT";

            /// <summary>
            /// Property for DiscountPercentage
            /// </summary>
            public const string DiscountPercentage = "DISCPER";

            /// <summary>
            /// Property for IsRIAYATIConsent
            /// </summary>
            public const string IsRIAYATIConsent = "RIYTCONSYN";

            /// <summary>
            /// Property for InjuryValidationRequired
            /// </summary>
            public const string InjuryValidationRequired = "INJREQ";

            /// <summary>
            /// Property for InjuryIsOpen
            /// </summary>
            public const string InjuryIsOpen = "INJOPEN";

            /// <summary>
            /// Property for VisitModified
            /// </summary>
            public const string VisitModified = "VSTMODIFY";

            /// <summary>
            /// Property for Command
            /// </summary>
            public const string Command = "COMMAND";

            /// <summary>
            /// Property for IsExtendEpisode
            /// </summary>
            public const string IsExtendEpisode = "EXTEPIYN";

            /// <summary>
            /// Property for ConsultationCheck
            /// </summary>
            public const string ConsultationCheck = "CONSULCHK";

            /// <summary>
            /// Property for VisitDepartmentNumber
            /// </summary>
            public const string VisitDepartmentNumber = "VSTDEPTNM";

            /// <summary>
            /// Property for AllergyFlag
            /// </summary>
            public const string AllergyFlag = "ALRGYFLG";

            /// <summary>
            /// Property for InitialAssessmentFlag
            /// </summary>
            public const string InitialAssessmentFlag = "INASSFLG";

            /// <summary>
            /// Property for AlertFlag
            /// </summary>
            public const string AlertFlag = "ALRTFLG";

            /// <summary>
            /// Property for PatientComplainFlag
            /// </summary>
            public const string PatientComplainFlag = "PATCOMFLG";

            /// <summary>
            /// Property for MessageCenterFlag
            /// </summary>
            public const string MessageCenterFlag = "MSGCENFLG";

            /// <summary>
            /// Property for DoctorNotifyFlag
            /// </summary>
            public const string DoctorNotifyFlag = "DOCNOTYFLG";

            /// <summary>
            /// Property for OrdersFlag
            /// </summary>
            public const string OrdersFlag = "ORDERFLG";

            /// <summary>
            /// Property for FallRiskFlag
            /// </summary>
            public const string FallRiskFlag = "FALRSKFLG";

            /// <summary>
            /// Property for ResultsFlag
            /// </summary>
            public const string ResultsFlag = "RESULTFLG";

            /// <summary>
            /// Property for CheckBilled
            /// </summary>
            public const string CheckBilled = "CHKBILLED";

            /// <summary>
            /// Property for CheckSpeciality
            /// </summary>
            public const string CheckSpeciality = "CHKSPECTY";

            /// <summary>
            /// Property for MobileApp
            /// </summary>
            public const string MobileApp = "MOBILEAPP";

            /// <summary>
            /// Property for IsPreviousInitialVisit
            /// </summary>
            public const string IsPreviousInitialVisit = "INTIVISIT";

            /// <summary>
            /// Property for IsOrdered
            /// </summary>
            public const string IsOrdered = "ISORDERD";

            /// <summary>
            /// Property for IsPreOrdered
            /// </summary>
            public const string IsPreOrdered = "ISPHRORD";

            /// <summary>
            /// Property for LabAutomation
            /// </summary>
            public const string LabAutomation = "LABAUTOMAT";

            /// <summary>
            /// Property for AdvanceAlert
            /// </summary>
            public const string AdvanceAlert = "ADVANCALRT";

            /// <summary>
            /// Property for AdvanceUtilize
            /// </summary>
            public const string AdvanceUtilize = "ADVANCUTIL";

            /// <summary>
            /// Property for ReferralVisitCheck
            /// </summary>
            public const string ReferralVisitCheck = "CHKREFVST";

            /// <summary>
            /// Property for ApplyVisitLimit
            /// </summary>
            public const string ApplyVisitLimit = "VISITLIMIT";

            /// <summary>
            /// Property for ApplyCoPayLimit
            /// </summary>
            public const string ApplyCoPayLimit = "COPAYLMTON";

            /// <summary>
            /// Property for IPAddress
            /// </summary>
            public const string IPAddress = "IPADDRESS";

            /// <summary>
            /// Property for IsConsultation
            /// </summary>
            public const string IsConsultation = "CONSLATYPE";

        }

        #endregion

        #region Index Properties

        /// <summary>
        /// Contains list of MSVisit Index Constants
        /// </summary>
        public class Index
        {
            /// <summary>
            /// Property Indexer for VisitCode
            /// </summary>
            public const int VisitCode = 1;

            /// <summary>
            /// Property Indexer for VisitDate
            /// </summary>
            public const int VisitDate = 2;

            /// <summary>
            /// Property Indexer for VisitTime
            /// </summary>
            public const int VisitTime = 3;

            /// <summary>
            /// Property Indexer for VisitType
            /// </summary>
            public const int VisitType = 4;

            /// <summary>
            /// Property Indexer for PatientCode
            /// </summary>
            public const int PatientCode = 5;

            /// <summary>
            /// Property Indexer for ProviderCode
            /// </summary>
            public const int ProviderCode = 6;

            /// <summary>
            /// Property Indexer for DepartmentCode
            /// </summary>
            public const int DepartmentCode = 7;

            /// <summary>
            /// Property Indexer for VisitClosed
            /// </summary>
            public const int VisitClosed = 8;

            /// <summary>
            /// Property Indexer for ReferenceType
            /// </summary>
            public const int ReferenceType = 9;

            /// <summary>
            /// Property Indexer for ReferralProviderCode
            /// </summary>
            public const int ReferralProviderCode = 10;

            /// <summary>
            /// Property Indexer for Facility
            /// </summary>
            public const int Facility = 11;

            /// <summary>
            /// Property Indexer for OtherReferrals
            /// </summary>
            public const int OtherReferrals = 12;

            /// <summary>
            /// Property Indexer for ReferenceCode
            /// </summary>
            public const int ReferenceCode = 13;

            /// <summary>
            /// Property Indexer for ReferenceDetail
            /// </summary>
            public const int ReferenceDetail = 14;

            /// <summary>
            /// Property Indexer for Billed
            /// </summary>
            public const int Billed = 15;

            /// <summary>
            /// Property Indexer for QueueNumber2
            /// </summary>
            public const int QueueNumber2 = 16;

            /// <summary>
            /// Property Indexer for CheckTime
            /// </summary>
            public const int CheckTime = 17;

            /// <summary>
            /// Property Indexer for CheckOut
            /// </summary>
            public const int CheckOut = 18;

            /// <summary>
            /// Property Indexer for CheckOutTime
            /// </summary>
            public const int CheckOutTime = 19;

            /// <summary>
            /// Property Indexer for VisitLevelCopay
            /// </summary>
            public const int VisitLevelCopay = 20;

            /// <summary>
            /// Property Indexer for Inactive
            /// </summary>
            public const int Inactive = 21;

            /// <summary>
            /// Property Indexer for InsuranceCompanyCode
            /// </summary>
            public const int InsuranceCompanyCode = 22;

            /// <summary>
            /// Property Indexer for PlanCode
            /// </summary>
            public const int PlanCode = 23;

            /// <summary>
            /// Property Indexer for PolicyNumber
            /// </summary>
            public const int PolicyNumber = 24;

            /// <summary>
            /// Property Indexer for DeductibleBalance
            /// </summary>
            public const int DeductibleBalance = 25;

            /// <summary>
            /// Property Indexer for CustomerType
            /// </summary>
            public const int CustomerType = 26;

            /// <summary>
            /// Property Indexer for Customer
            /// </summary>
            public const int Customer = 27;

            /// <summary>
            /// Property Indexer for BillNumber
            /// </summary>
            public const int BillNumber = 28;

            /// <summary>
            /// Property Indexer for BillingCode
            /// </summary>
            public const int BillingCode = 29;

            /// <summary>
            /// Property Indexer for ConsultationType
            /// </summary>
            public const int ConsultationType = 30;

            /// <summary>
            /// Property Indexer for Others
            /// </summary>
            public const int Others = 31;

            /// <summary>
            /// Property Indexer for EpisodeCode
            /// </summary>
            public const int EpisodeCode = 32;

            /// <summary>
            /// Property Indexer for PreviousVisitDate
            /// </summary>
            public const int PreviousVisitDate = 33;

            /// <summary>
            /// Property Indexer for PreviousVisitProviderCode
            /// </summary>
            public const int PreviousVisitProviderCode = 34;

            /// <summary>
            /// Property Indexer for CaseTransfer
            /// </summary>
            public const int CaseTransfer = 35;

            /// <summary>
            /// Property Indexer for TransferDate
            /// </summary>
            public const int TransferDate = 36;

            /// <summary>
            /// Property Indexer for RequisitionNo
            /// </summary>
            public const int RequisitionNo = 37;

            /// <summary>
            /// Property Indexer for CaseSelect
            /// </summary>
            public const int CaseSelect = 38;

            /// <summary>
            /// Property Indexer for SponsoredBy
            /// </summary>
            public const int SponsoredBy = 39;

            /// <summary>
            /// Property Indexer for SponsorCode
            /// </summary>
            public const int SponsorCode = 40;

            /// <summary>
            /// Property Indexer for IsEmergency
            /// </summary>
            public const int IsEmergency = 41;

            /// <summary>
            /// Property Indexer for VisitPurpose
            /// </summary>
            public const int VisitPurpose = 42;

            /// <summary>
            /// Property Indexer for ClinicCode
            /// </summary>
            public const int ClinicCode = 43;

            /// <summary>
            /// Property Indexer for IsPackagePatient
            /// </summary>
            public const int IsPackagePatient = 44;

            /// <summary>
            /// Property Indexer for FreeVisit
            /// </summary>
            public const int FreeVisit = 45;

            /// <summary>
            /// Property Indexer for PackageCode
            /// </summary>
            public const int PackageCode = 46;

            /// <summary>
            /// Property Indexer for ConsultationTypeCode
            /// </summary>
            public const int ConsultationTypeCode = 47;

            /// <summary>
            /// Property Indexer for IsReferring
            /// </summary>
            public const int IsReferring = 48;

            /// <summary>
            /// Property Indexer for InitialVisit
            /// </summary>
            public const int InitialVisit = 49;

            /// <summary>
            /// Property Indexer for IsDeductibleCollected
            /// </summary>
            public const int IsDeductibleCollected = 50;

            /// <summary>
            /// Property Indexer for DeductibleAmount
            /// </summary>
            public const int DeductibleAmount = 51;

            /// <summary>
            /// Property Indexer for GenCount
            /// </summary>
            public const int GenCount = 52;

            /// <summary>
            /// Property Indexer for SpecialCount
            /// </summary>
            public const int SpecialCount = 53;

            /// <summary>
            /// Property Indexer for ConsultationCount
            /// </summary>
            public const int ConsultationCount = 54;

            /// <summary>
            /// Property Indexer for IsMLC
            /// </summary>
            public const int IsMLC = 55;

            /// <summary>
            /// Property Indexer for MLCCode
            /// </summary>
            public const int MLCCode = 56;

            /// <summary>
            /// Property Indexer for SOAPNumber
            /// </summary>
            public const int SOAPNumber = 57;

            /// <summary>
            /// Property Indexer for PolicyGroupCode
            /// </summary>
            public const int PolicyGroupCode = 58;

            /// <summary>
            /// Property Indexer for PolicyGroupDescription
            /// </summary>
            public const int PolicyGroupDescription = 59;

            /// <summary>
            /// Property Indexer for PlanName
            /// </summary>
            public const int PlanName = 60;

            /// <summary>
            /// Property Indexer for InsuranceName
            /// </summary>
            public const int InsuranceName = 61;

            /// <summary>
            /// Property Indexer for CreatedBy
            /// </summary>
            public const int CreatedBy = 62;

            /// <summary>
            /// Property Indexer for CreatedDate
            /// </summary>
            public const int CreatedDate = 63;

            /// <summary>
            /// Property Indexer for ModifiedBy
            /// </summary>
            public const int ModifiedBy = 64;

            /// <summary>
            /// Property Indexer for ModifiedDate
            /// </summary>
            public const int ModifiedDate = 65;

            /// <summary>
            /// Property Indexer for NumberOfBills
            /// </summary>
            public const int NumberOfBills = 66;

            /// <summary>
            /// Property Indexer for ConsultBills
            /// </summary>
            public const int ConsultBills = 67;

            /// <summary>
            /// Property Indexer for RegisterBills
            /// </summary>
            public const int RegisterBills = 68;

            /// <summary>
            /// Property Indexer for TransferBy
            /// </summary>
            public const int TransferBy = 69;

            /// <summary>
            /// Property Indexer for TransferTime
            /// </summary>
            public const int TransferTime = 70;

            /// <summary>
            /// Property Indexer for TransferredAdmissionCode
            /// </summary>
            public const int TransferredAdmissionCode = 71;

            /// <summary>
            /// Property Indexer for TransferReason
            /// </summary>
            public const int TransferReason = 72;

            /// <summary>
            /// Property Indexer for IsChronic
            /// </summary>
            public const int IsChronic = 73;

            /// <summary>
            /// Property Indexer for UnitCode
            /// </summary>
            public const int UnitCode = 74;

            /// <summary>
            /// Property Indexer for UnitDescription
            /// </summary>
            public const int UnitDescription = 75;

            /// <summary>
            /// Property Indexer for DiscountCategoryCode
            /// </summary>
            public const int DiscountCategoryCode = 76;

            /// <summary>
            /// Property Indexer for DiscountCategoryDescription
            /// </summary>
            public const int DiscountCategoryDescription = 77;

            /// <summary>
            /// Property Indexer for AccidentRegCode
            /// </summary>
            public const int AccidentRegCode = 78;

            /// <summary>
            /// Property Indexer for AccidentPlace
            /// </summary>
            public const int AccidentPlace = 79;

            /// <summary>
            /// Property Indexer for PoliceStationName
            /// </summary>
            public const int PoliceStationName = 80;

            /// <summary>
            /// Property Indexer for IsIntimated
            /// </summary>
            public const int IsIntimated = 81;

            /// <summary>
            /// Property Indexer for WoundCertifiedDate
            /// </summary>
            public const int WoundCertifiedDate = 82;

            /// <summary>
            /// Property Indexer for ExternalProviderCode
            /// </summary>
            public const int ExternalProviderCode = 83;

            /// <summary>
            /// Property Indexer for ExternalProviderName
            /// </summary>
            public const int ExternalProviderName = 84;

            /// <summary>
            /// Property Indexer for PatientType
            /// </summary>
            public const int PatientType = 85;

            /// <summary>
            /// Property Indexer for VisitExpiryDate
            /// </summary>
            public const int VisitExpiryDate = 86;

            /// <summary>
            /// Property Indexer for SpecialityCode
            /// </summary>
            public const int SpecialityCode = 87;

            /// <summary>
            /// Property Indexer for LimitUtilized
            /// </summary>
            public const int LimitUtilized = 88;

            /// <summary>
            /// Property Indexer for LimitBalance
            /// </summary>
            public const int LimitBalance = 89;

            /// <summary>
            /// Property Indexer for OPLimitUtilized
            /// </summary>
            public const int OPLimitUtilized = 90;

            /// <summary>
            /// Property Indexer for OPLimitBalance
            /// </summary>
            public const int OPLimitBalance = 91;

            /// <summary>
            /// Property Indexer for QueueNumber
            /// </summary>
            public const int QueueNumber = 92;

            /// <summary>
            /// Property Indexer for SpecialityDepartment
            /// </summary>
            public const int SpecialityDepartment = 93;

            /// <summary>
            /// Property Indexer for PackageType
            /// </summary>
            public const int PackageType = 94;

            /// <summary>
            /// Property Indexer for CheckedIn
            /// </summary>
            public const int CheckedIn = 95;

            /// <summary>
            /// Property Indexer for ReferralEmployeeCode
            /// </summary>
            public const int ReferralEmployeeCode = 96;

            /// <summary>
            /// Property Indexer for EpisodeNo
            /// </summary>
            public const int EpisodeNo = 97;

            /// <summary>
            /// Property Indexer for VisitFromAppointment
            /// </summary>
            public const int VisitFromAppointment = 98;

            /// <summary>
            /// Property Indexer for InjuryCode
            /// </summary>
            public const int InjuryCode = 99;

            /// <summary>
            /// Property Indexer for MultiVisitPackageOrderCode
            /// </summary>
            public const int MultiVisitPackageOrderCode = 100;

            /// <summary>
            /// Property Indexer for PatientName
            /// </summary>
            public const int PatientName = 101;

            /// <summary>
            /// Property Indexer for ProviderName
            /// </summary>
            public const int ProviderName = 102;

            /// <summary>
            /// Property Indexer for DepartmentName
            /// </summary>
            public const int DepartmentName = 103;

            /// <summary>
            /// Property Indexer for ConsultName
            /// </summary>
            public const int ConsultName = 104;

            /// <summary>
            /// Property Indexer for ReferredName
            /// </summary>
            public const int ReferredName = 105;

            /// <summary>
            /// Property Indexer for EmployeeName
            /// </summary>
            public const int EmployeeName = 106;

            /// <summary>
            /// Property Indexer for ClinicDescription
            /// </summary>
            public const int ClinicDescription = 107;

            /// <summary>
            /// Property Indexer for PackageDescription
            /// </summary>
            public const int PackageDescription = 108;

            /// <summary>
            /// Property Indexer for ReferralName
            /// </summary>
            public const int ReferralName = 109;

            /// <summary>
            /// Property Indexer for SpecialityDescription
            /// </summary>
            public const int SpecialityDescription = 110;

            /// <summary>
            /// Property Indexer for ConsultationDescription
            /// </summary>
            public const int ConsultationDescription = 111;

            /// <summary>
            /// Property Indexer for MLCDescription
            /// </summary>
            public const int MLCDescription = 112;

            /// <summary>
            /// Property Indexer for TypeOfVisit
            /// </summary>
            public const int TypeOfVisit = 113;

            /// <summary>
            /// Property Indexer for RegistrationDate
            /// </summary>
            public const int RegistrationDate = 114;

            /// <summary>
            /// Property Indexer for IsFreeVisit
            /// </summary>
            public const int IsFreeVisit = 115;

            /// <summary>
            /// Property Indexer for AgeYears
            /// </summary>
            public const int AgeYears = 116;

            /// <summary>
            /// Property Indexer for AgeMonths
            /// </summary>
            public const int AgeMonths = 117;

            /// <summary>
            /// Property Indexer for AgeDays
            /// </summary>
            public const int AgeDays = 118;

            /// <summary>
            /// Property Indexer for Authorized
            /// </summary>
            public const int Authorized = 119;

            /// <summary>
            /// Property Indexer for ProvisionalICDCompleted
            /// </summary>
            public const int ProvisionalICDCompleted = 120;

            /// <summary>
            /// Property Indexer for FinalICDCompleted
            /// </summary>
            public const int FinalICDCompleted = 121;

            /// <summary>
            /// Property Indexer for AuthorizationBy
            /// </summary>
            public const int AuthorizationBy = 122;

            /// <summary>
            /// Property Indexer for AuthorizationDate
            /// </summary>
            public const int AuthorizationDate = 123;

            /// <summary>
            /// Property Indexer for ConsultationSetup
            /// </summary>
            public const int ConsultationSetup = 124;

            /// <summary>
            /// Property Indexer for EpisodeNumber
            /// </summary>
            public const int EpisodeNumber = 125;

            /// <summary>
            /// Property Indexer for InsApplicationNumber
            /// </summary>
            public const int InsApplicationNumber = 126;

            /// <summary>
            /// Property Indexer for PrescriptionType
            /// </summary>
            public const int PrescriptionType = 127;

            /// <summary>
            /// Property Indexer for AppointmentNumber
            /// </summary>
            public const int AppointmentNumber = 128;

            /// <summary>
            /// Property Indexer for EncounterUniqueCode
            /// </summary>
            public const int EncounterUniqueCode = 129;

            /// <summary>
            /// Property Indexer for NursingAssessmentStatus
            /// </summary>
            public const int NursingAssessmentStatus = 130;

            /// <summary>
            /// Property Indexer for MultiVisitPackageType
            /// </summary>
            public const int MultiVisitPackageType = 131;

            /// <summary>
            /// Property Indexer for ApplicationDate
            /// </summary>
            public const int ApplicationDate = 132;

            /// <summary>
            /// Property Indexer for EligibleAmount
            /// </summary>
            public const int EligibleAmount = 133;

            /// <summary>
            /// Property Indexer for EligibleType
            /// </summary>
            public const int EligibleType = 134;

            /// <summary>
            /// Property Indexer for IsFallRisk
            /// </summary>
            public const int IsFallRisk = 135;

            /// <summary>
            /// Property Indexer for IsSecondaryPlan
            /// </summary>
            public const int IsSecondaryPlan = 136;

            /// <summary>
            /// Property Indexer for SecondaryCustomerType
            /// </summary>
            public const int SecondaryCustomerType = 137;

            /// <summary>
            /// Property Indexer for SecondaryCustomerCode
            /// </summary>
            public const int SecondaryCustomerCode = 138;

            /// <summary>
            /// Property Indexer for SecondaryPolicyGroupCode
            /// </summary>
            public const int SecondaryPolicyGroupCode = 139;

            /// <summary>
            /// Property Indexer for SecondaryPlanCode
            /// </summary>
            public const int SecondaryPlanCode = 140;

            /// <summary>
            /// Property Indexer for SecondaryPolicyNumber
            /// </summary>
            public const int SecondaryPolicyNumber = 141;

            /// <summary>
            /// Property Indexer for HospitalName
            /// </summary>
            public const int HospitalName = 142;

            /// <summary>
            /// Property Indexer for Network
            /// </summary>
            public const int Network = 143;

            /// <summary>
            /// Property Indexer for PolicyStartDate
            /// </summary>
            public const int PolicyStartDate = 144;

            /// <summary>
            /// Property Indexer for PolicyExpiryDate
            /// </summary>
            public const int PolicyExpiryDate = 145;

            /// <summary>
            /// Property Indexer for SecondaryPolicyStartDate
            /// </summary>
            public const int SecondaryPolicyStartDate = 146;

            /// <summary>
            /// Property Indexer for SecondaryPolicyExpiryDate
            /// </summary>
            public const int SecondaryPolicyExpiryDate = 147;

            /// <summary>
            /// Property Indexer for SecondarySponsorCode
            /// </summary>
            public const int SecondarySponsorCode = 148;

            /// <summary>
            /// Property Indexer for EHRAlertMessage
            /// </summary>
            public const int EHRAlertMessage = 149;

            /// <summary>
            /// Property Indexer for ModifiedPrimaryPolicyNo
            /// </summary>
            public const int ModifiedPrimaryPolicyNo = 150;

            /// <summary>
            /// Property Indexer for ModifiedSecPolicyNumber
            /// </summary>
            public const int ModifiedSecPolicyNumber = 151;

            /// <summary>
            /// Property Indexer for VisitExistEnd
            /// </summary>
            public const int VisitExistEnd = 152;

            /// <summary>
            /// Property Indexer for VisitExistEndTime
            /// </summary>
            public const int VisitExistEndTime = 153;

            /// <summary>
            /// Property Indexer for IsConsent
            /// </summary>
            public const int IsConsent = 154;

            /// <summary>
            /// Property Indexer for IsDisclosure
            /// </summary>
            public const int IsDisclosure = 155;

            /// <summary>
            /// Property Indexer for HL7Message
            /// </summary>
            public const int HL7Message = 156;

            /// <summary>
            /// Property Indexer for MaternityPatient
            /// </summary>
            public const int MaternityPatient = 157;

            /// <summary>
            /// Property Indexer for PreAuthorizationRequired
            /// </summary>
            public const int PreAuthorizationRequired = 158;

            /// <summary>
            /// Property Indexer for Authorize
            /// </summary>
            public const int Authorize = 159;

            /// <summary>
            /// Property Indexer for AuthorizationStart
            /// </summary>
            public const int AuthorizationStart = 160;

            /// <summary>
            /// Property Indexer for AuthorizationEnd
            /// </summary>
            public const int AuthorizationEnd = 161;

            /// <summary>
            /// Property Indexer for PatientEmployerCode
            /// </summary>
            public const int PatientEmployerCode = 162;

            /// <summary>
            /// Property Indexer for IPEMCode
            /// </summary>
            public const int IPEMCode = 163;

            /// <summary>
            /// Property Indexer for AuthorizationNumber
            /// </summary>
            public const int AuthorizationNumber = 164;

            /// <summary>
            /// Property Indexer for ExternalMedication
            /// </summary>
            public const int ExternalMedication = 165;

            /// <summary>
            /// Property Indexer for PharmacyVisit
            /// </summary>
            public const int PharmacyVisit = 166;

            /// <summary>
            /// Property Indexer for DeliveryOrder
            /// </summary>
            public const int DeliveryOrder = 167;

            /// <summary>
            /// Property Indexer for IntermediateVisit
            /// </summary>
            public const int IntermediateVisit = 168;

            /// <summary>
            /// Property Indexer for Source
            /// </summary>
            public const int Source = 169;

            /// <summary>
            /// Property Indexer for AvailFirst
            /// </summary>
            public const int AvailFirst = 170;

            /// <summary>
            /// Property Indexer for IsVideoConsultation
            /// </summary>
            public const int IsVideoConsultation = 171;

            /// <summary>
            /// Property Indexer for DefaultEMCode
            /// </summary>
            public const int DefaultEMCode = 172;

            /// <summary>
            /// Property Indexer for DiscountAmount
            /// </summary>
            public const int DiscountAmount = 173;

            /// <summary>
            /// Property Indexer for DiscountPercentage
            /// </summary>
            public const int DiscountPercentage = 174;

            /// <summary>
            /// Property Indexer for IsRIAYATIConsent
            /// </summary>
            public const int IsRIAYATIConsent = 175;

            /// <summary>
            /// Property Indexer for InjuryValidationRequired
            /// </summary>
            public const int InjuryValidationRequired = 200;

            /// <summary>
            /// Property Indexer for InjuryIsOpen
            /// </summary>
            public const int InjuryIsOpen = 201;

            /// <summary>
            /// Property Indexer for VisitModified
            /// </summary>
            public const int VisitModified = 202;

            /// <summary>
            /// Property Indexer for Command
            /// </summary>
            public const int Command = 203;

            /// <summary>
            /// Property Indexer for IsExtendEpisode
            /// </summary>
            public const int IsExtendEpisode = 204;

            /// <summary>
            /// Property Indexer for ConsultationCheck
            /// </summary>
            public const int ConsultationCheck = 205;

            /// <summary>
            /// Property Indexer for VisitDepartmentNumber
            /// </summary>
            public const int VisitDepartmentNumber = 206;

            /// <summary>
            /// Property Indexer for AllergyFlag
            /// </summary>
            public const int AllergyFlag = 207;

            /// <summary>
            /// Property Indexer for InitialAssessmentFlag
            /// </summary>
            public const int InitialAssessmentFlag = 208;

            /// <summary>
            /// Property Indexer for AlertFlag
            /// </summary>
            public const int AlertFlag = 209;

            /// <summary>
            /// Property Indexer for PatientComplainFlag
            /// </summary>
            public const int PatientComplainFlag = 210;

            /// <summary>
            /// Property Indexer for MessageCenterFlag
            /// </summary>
            public const int MessageCenterFlag = 211;

            /// <summary>
            /// Property Indexer for DoctorNotifyFlag
            /// </summary>
            public const int DoctorNotifyFlag = 212;

            /// <summary>
            /// Property Indexer for OrdersFlag
            /// </summary>
            public const int OrdersFlag = 213;

            /// <summary>
            /// Property Indexer for FallRiskFlag
            /// </summary>
            public const int FallRiskFlag = 214;

            /// <summary>
            /// Property Indexer for ResultsFlag
            /// </summary>
            public const int ResultsFlag = 215;

            /// <summary>
            /// Property Indexer for CheckBilled
            /// </summary>
            public const int CheckBilled = 216;

            /// <summary>
            /// Property Indexer for CheckSpeciality
            /// </summary>
            public const int CheckSpeciality = 217;

            /// <summary>
            /// Property Indexer for MobileApp
            /// </summary>
            public const int MobileApp = 218;

            /// <summary>
            /// Property Indexer for IsPreviousInitialVisit
            /// </summary>
            public const int IsPreviousInitialVisit = 219;

            /// <summary>
            /// Property Indexer for IsOrdered
            /// </summary>
            public const int IsOrdered = 220;

            /// <summary>
            /// Property Indexer for IsPreOrdered
            /// </summary>
            public const int IsPreOrdered = 221;

            /// <summary>
            /// Property Indexer for LabAutomation
            /// </summary>
            public const int LabAutomation = 222;

            /// <summary>
            /// Property Indexer for AdvanceAlert
            /// </summary>
            public const int AdvanceAlert = 223;

            /// <summary>
            /// Property Indexer for AdvanceUtilize
            /// </summary>
            public const int AdvanceUtilize = 224;

            /// <summary>
            /// Property Indexer for ReferralVisitCheck
            /// </summary>
            public const int ReferralVisitCheck = 225;

            /// <summary>
            /// Property Indexer for ApplyVisitLimit
            /// </summary>
            public const int ApplyVisitLimit = 226;

            /// <summary>
            /// Property Indexer for ApplyCoPayLimit
            /// </summary>
            public const int ApplyCoPayLimit = 227;

            /// <summary>
            /// Property Indexer for IPAddress
            /// </summary>
            public const int IPAddress = 228;

            /// <summary>
            /// Property Indexer for IsConsultation
            /// </summary>
            public const int IsConsultation = 229;


        }

        #endregion

    }
}