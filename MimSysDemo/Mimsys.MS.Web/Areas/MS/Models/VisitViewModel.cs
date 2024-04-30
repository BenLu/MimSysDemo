// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using System.Collections;
using System.Collections.Generic;
using Sage.CA.SBS.ERP.Sage300.Common.Web;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Enums;
using Mimsys.MS.Models;
using Mimsys.MS.Models.Enums;
#endregion

namespace Mimsys.MS.Web.Areas.MS.Models
{
    /// <summary>
    /// Class for VisitViewModel
    /// </summary>
    public class VisitViewModel : ViewModelBase<MSVisit>
    {
        /// <summary>
        /// GetVisitType
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitType>();

        /// <summary>
        /// GetVisitClosed
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitClosed => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitClosed>();

        /// <summary>
        /// GetReferenceType
        /// </summary>
        public IEnumerable<CustomSelectList> GetReferenceType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ReferenceType>();

        /// <summary>
        /// GetBilled
        /// </summary>
        public IEnumerable<CustomSelectList> GetBilled => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Billed>();

        /// <summary>
        /// GetCheckOut
        /// </summary>
        public IEnumerable<CustomSelectList> GetCheckOut => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CheckOut>();

        /// <summary>
        /// GetInactive
        /// </summary>
        public IEnumerable<CustomSelectList> GetInactive => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Inactive>();

        /// <summary>
        /// GetCustomerType
        /// </summary>
        public IEnumerable<CustomSelectList> GetCustomerType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CustomerType>();

        /// <summary>
        /// GetCaseTransfer
        /// </summary>
        public IEnumerable<CustomSelectList> GetCaseTransfer => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CaseTransfer>();

        /// <summary>
        /// GetCaseSelect
        /// </summary>
        public IEnumerable<CustomSelectList> GetCaseSelect => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CaseSelect>();

        /// <summary>
        /// GetSponsoredBy
        /// </summary>
        public IEnumerable<CustomSelectList> GetSponsoredBy => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.SponsoredBy>();

        /// <summary>
        /// GetIsEmergency
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsEmergency => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsEmergency>();

        /// <summary>
        /// GetVisitPurpose
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitPurpose => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitPurpose>();

        /// <summary>
        /// GetIsPackagePatient
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsPackagePatient => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsPackagePatient>();

        /// <summary>
        /// GetFreeVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetFreeVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.FreeVisit>();

        /// <summary>
        /// GetIsReferring
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsReferring => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsReferring>();

        /// <summary>
        /// GetInitialVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetInitialVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.InitialVisit>();

        /// <summary>
        /// GetIsDeductibleCollected
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsDeductibleCollected => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsDeductibleCollected>();

        /// <summary>
        /// GetIsMLC
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsMLC => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsMLC>();

        /// <summary>
        /// GetConsultBills
        /// </summary>
        public IEnumerable<CustomSelectList> GetConsultBills => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ConsultBills>();

        /// <summary>
        /// GetIsChronic
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsChronic => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsChronic>();

        /// <summary>
        /// GetIsIntimated
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsIntimated => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsIntimated>();

        /// <summary>
        /// GetSpecialityDepartment
        /// </summary>
        public IEnumerable<CustomSelectList> GetSpecialityDepartment => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.SpecialityDepartment>();

        /// <summary>
        /// GetPackageType
        /// </summary>
        public IEnumerable<CustomSelectList> GetPackageType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.PackageType>();

        /// <summary>
        /// GetCheckedIn
        /// </summary>
        public IEnumerable<CustomSelectList> GetCheckedIn => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CheckedIn>();

        /// <summary>
        /// GetVisitFromAppointment
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitFromAppointment => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitFromAppointment>();

        /// <summary>
        /// GetTypeOfVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetTypeOfVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.TypeOfVisit>();

        /// <summary>
        /// GetIsFreeVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsFreeVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsFreeVisit>();

        /// <summary>
        /// GetAuthorized
        /// </summary>
        public IEnumerable<CustomSelectList> GetAuthorized => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Authorized>();

        /// <summary>
        /// GetProvisionalICDCompleted
        /// </summary>
        public IEnumerable<CustomSelectList> GetProvisionalICDCompleted => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ProvisionalICDCompleted>();

        /// <summary>
        /// GetFinalICDCompleted
        /// </summary>
        public IEnumerable<CustomSelectList> GetFinalICDCompleted => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.FinalICDCompleted>();

        /// <summary>
        /// GetConsultationSetup
        /// </summary>
        public IEnumerable<CustomSelectList> GetConsultationSetup => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ConsultationSetup>();

        /// <summary>
        /// GetPrescriptionType
        /// </summary>
        public IEnumerable<CustomSelectList> GetPrescriptionType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.PrescriptionType>();

        /// <summary>
        /// GetNursingAssessmentStatus
        /// </summary>
        public IEnumerable<CustomSelectList> GetNursingAssessmentStatus => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.NursingAssessmentStatus>();

        /// <summary>
        /// GetMultiVisitPackageType
        /// </summary>
        public IEnumerable<CustomSelectList> GetMultiVisitPackageType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.MultiVisitPackageType>();

        /// <summary>
        /// GetEligibleType
        /// </summary>
        public IEnumerable<CustomSelectList> GetEligibleType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.EligibleType>();

        /// <summary>
        /// GetIsFallRisk
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsFallRisk => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsFallRisk>();

        /// <summary>
        /// GetIsSecondaryPlan
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsSecondaryPlan => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsSecondaryPlan>();

        /// <summary>
        /// GetSecondaryCustomerType
        /// </summary>
        public IEnumerable<CustomSelectList> GetSecondaryCustomerType => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.SecondaryCustomerType>();

        /// <summary>
        /// GetVisitExistEnd
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitExistEnd => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitExistEnd>();

        /// <summary>
        /// GetIsConsent
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsConsent => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsConsent>();

        /// <summary>
        /// GetIsDisclosure
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsDisclosure => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsDisclosure>();

        /// <summary>
        /// GetHL7Message
        /// </summary>
        public IEnumerable<CustomSelectList> GetHL7Message => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.HL7Message>();

        /// <summary>
        /// GetMaternityPatient
        /// </summary>
        public IEnumerable<CustomSelectList> GetMaternityPatient => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.MaternityPatient>();

        /// <summary>
        /// GetPreAuthorizationRequired
        /// </summary>
        public IEnumerable<CustomSelectList> GetPreAuthorizationRequired => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.PreAuthorizationRequired>();

        /// <summary>
        /// GetAuthorize
        /// </summary>
        public IEnumerable<CustomSelectList> GetAuthorize => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Authorize>();

        /// <summary>
        /// GetExternalMedication
        /// </summary>
        public IEnumerable<CustomSelectList> GetExternalMedication => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ExternalMedication>();

        /// <summary>
        /// GetPharmacyVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetPharmacyVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.PharmacyVisit>();

        /// <summary>
        /// GetSource
        /// </summary>
        public IEnumerable<CustomSelectList> GetSource => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Source>();

        /// <summary>
        /// GetAvailFirst
        /// </summary>
        public IEnumerable<CustomSelectList> GetAvailFirst => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.AvailFirst>();

        /// <summary>
        /// GetIsVideoConsultation
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsVideoConsultation => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsVideoConsultation>();

        /// <summary>
        /// GetIsRIAYATIConsent
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsRIAYATIConsent => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsRIAYATIConsent>();

        /// <summary>
        /// GetInjuryValidationRequired
        /// </summary>
        public IEnumerable<CustomSelectList> GetInjuryValidationRequired => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.InjuryValidationRequired>();

        /// <summary>
        /// GetInjuryIsOpen
        /// </summary>
        public IEnumerable<CustomSelectList> GetInjuryIsOpen => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.InjuryIsOpen>();

        /// <summary>
        /// GetVisitModified
        /// </summary>
        public IEnumerable<CustomSelectList> GetVisitModified => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.VisitModified>();

        /// <summary>
        /// GetCommand
        /// </summary>
        public IEnumerable<CustomSelectList> GetCommand => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.Command>();

        /// <summary>
        /// GetIsExtendEpisode
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsExtendEpisode => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsExtendEpisode>();

        /// <summary>
        /// GetConsultationCheck
        /// </summary>
        public IEnumerable<CustomSelectList> GetConsultationCheck => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ConsultationCheck>();

        /// <summary>
        /// GetAllergyFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetAllergyFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.AllergyFlag>();

        /// <summary>
        /// GetInitialAssessmentFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetInitialAssessmentFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.InitialAssessmentFlag>();

        /// <summary>
        /// GetAlertFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetAlertFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.AlertFlag>();

        /// <summary>
        /// GetPatientComplainFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetPatientComplainFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.PatientComplainFlag>();

        /// <summary>
        /// GetMessageCenterFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetMessageCenterFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.MessageCenterFlag>();

        /// <summary>
        /// GetDoctorNotifyFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetDoctorNotifyFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.DoctorNotifyFlag>();

        /// <summary>
        /// GetOrdersFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetOrdersFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.OrdersFlag>();

        /// <summary>
        /// GetFallRiskFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetFallRiskFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.FallRiskFlag>();

        /// <summary>
        /// GetResultsFlag
        /// </summary>
        public IEnumerable<CustomSelectList> GetResultsFlag => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ResultsFlag>();

        /// <summary>
        /// GetCheckBilled
        /// </summary>
        public IEnumerable<CustomSelectList> GetCheckBilled => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CheckBilled>();

        /// <summary>
        /// GetCheckSpeciality
        /// </summary>
        public IEnumerable<CustomSelectList> GetCheckSpeciality => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.CheckSpeciality>();

        /// <summary>
        /// GetMobileApp
        /// </summary>
        public IEnumerable<CustomSelectList> GetMobileApp => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.MobileApp>();

        /// <summary>
        /// GetIsPreviousInitialVisit
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsPreviousInitialVisit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsPreviousInitialVisit>();

        /// <summary>
        /// GetIsOrdered
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsOrdered => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsOrdered>();

        /// <summary>
        /// GetIsPreOrdered
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsPreOrdered => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsPreOrdered>();

        /// <summary>
        /// GetLabAutomation
        /// </summary>
        public IEnumerable<CustomSelectList> GetLabAutomation => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.LabAutomation>();

        /// <summary>
        /// GetAdvanceAlert
        /// </summary>
        public IEnumerable<CustomSelectList> GetAdvanceAlert => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.AdvanceAlert>();

        /// <summary>
        /// GetAdvanceUtilize
        /// </summary>
        public IEnumerable<CustomSelectList> GetAdvanceUtilize => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.AdvanceUtilize>();

        /// <summary>
        /// GetReferralVisitCheck
        /// </summary>
        public IEnumerable<CustomSelectList> GetReferralVisitCheck => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ReferralVisitCheck>();

        /// <summary>
        /// GetApplyVisitLimit
        /// </summary>
        public IEnumerable<CustomSelectList> GetApplyVisitLimit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ApplyVisitLimit>();

        /// <summary>
        /// GetApplyCoPayLimit
        /// </summary>
        public IEnumerable<CustomSelectList> GetApplyCoPayLimit => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.ApplyCoPayLimit>();

        /// <summary>
        /// GetIsConsultation
        /// </summary>
        public IEnumerable<CustomSelectList> GetIsConsultation => EnumUtility.GetItemsList<Mimsys.MS.Models.Enums.IsConsultation>();

        /// <summary>
        /// Returns true if User has Modify Access
        /// </summary>
        public bool HasModifyAccess => UserAccess == null || UserAccess.SecurityType.HasFlag(SecurityType.Modify);
    }
}