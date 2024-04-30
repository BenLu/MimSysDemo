// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using Mimsys.MS.Models;
using Mimsys.MS.Models.Enums; // For common enumerations
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;

#endregion

namespace Mimsys.MS.BusinessRepository.Mappers
{
    /// <summary>
    /// Class for MSVisit mapping
    /// </summary>
    /// <typeparam name="T">MSVisit</typeparam>
    public class MSVisitMapper<T> : ModelMapper<T> where T : MSVisit, new ()
    {
        #region Constructor

        /// <summary>
        /// Constructor to set the Context
        /// </summary>
        /// <param name="context">Context</param>
        public MSVisitMapper(Context context)
            : base(context)
        {
        }

        #endregion

        #region ModelMapper methods

        /// <summary>
        /// Map entity to model
        /// </summary>
        /// <param name="entity">Business Entity</param>
        /// <returns>Mapped Model</returns>
        public override T Map(IBusinessEntity entity)
        {
            var model = base.Map(entity);

            model.VisitCode = entity.GetValue<string>(MSVisit.Index.VisitCode);
            model.VisitDate = entity.GetValue<DateTime>(MSVisit.Index.VisitDate);
            model.VisitTime = entity.GetValue<DateTime>(MSVisit.Index.VisitTime).TimeOfDay;
			model.VisitType = (Mimsys.MS.Models.Enums.VisitType)(entity.GetValue<int>(MSVisit.Index.VisitType));
            model.PatientCode = entity.GetValue<string>(MSVisit.Index.PatientCode);
            model.ProviderCode = entity.GetValue<string>(MSVisit.Index.ProviderCode);
            model.DepartmentCode = entity.GetValue<string>(MSVisit.Index.DepartmentCode);
			model.VisitClosed = (Mimsys.MS.Models.Enums.VisitClosed)(entity.GetValue<int>(MSVisit.Index.VisitClosed));
			model.ReferenceType = (Mimsys.MS.Models.Enums.ReferenceType)(entity.GetValue<int>(MSVisit.Index.ReferenceType));
            model.ReferralProviderCode = entity.GetValue<string>(MSVisit.Index.ReferralProviderCode);
            model.Facility = entity.GetValue<string>(MSVisit.Index.Facility);
            model.OtherReferrals = entity.GetValue<string>(MSVisit.Index.OtherReferrals);
            model.ReferenceCode = entity.GetValue<string>(MSVisit.Index.ReferenceCode);
            model.ReferenceDetail = entity.GetValue<string>(MSVisit.Index.ReferenceDetail);
			model.Billed = (Mimsys.MS.Models.Enums.Billed)(entity.GetValue<int>(MSVisit.Index.Billed));
            model.QueueNumber2 = entity.GetValue<string>(MSVisit.Index.QueueNumber2);
            model.CheckTime = entity.GetValue<DateTime>(MSVisit.Index.CheckTime).TimeOfDay;
			model.CheckOut = (Mimsys.MS.Models.Enums.CheckOut)(entity.GetValue<int>(MSVisit.Index.CheckOut));
            model.CheckOutTime = entity.GetValue<DateTime>(MSVisit.Index.CheckOutTime).TimeOfDay;
            model.VisitLevelCopay = entity.GetValue<decimal>(MSVisit.Index.VisitLevelCopay);
			model.Inactive = (Mimsys.MS.Models.Enums.Inactive)(entity.GetValue<int>(MSVisit.Index.Inactive));
            model.InsuranceCompanyCode = entity.GetValue<string>(MSVisit.Index.InsuranceCompanyCode);
            model.PlanCode = entity.GetValue<string>(MSVisit.Index.PlanCode);
            model.PolicyNumber = entity.GetValue<string>(MSVisit.Index.PolicyNumber);
            model.DeductibleBalance = entity.GetValue<decimal>(MSVisit.Index.DeductibleBalance);
			model.CustomerType = (Mimsys.MS.Models.Enums.CustomerType)(entity.GetValue<int>(MSVisit.Index.CustomerType));
            model.Customer = entity.GetValue<string>(MSVisit.Index.Customer);
            model.BillNumber = entity.GetValue<string>(MSVisit.Index.BillNumber);
            model.BillingCode = entity.GetValue<string>(MSVisit.Index.BillingCode);
            model.ConsultationType = entity.GetValue<string>(MSVisit.Index.ConsultationType);
            model.Others = entity.GetValue<string>(MSVisit.Index.Others);
            model.EpisodeCode = entity.GetValue<decimal>(MSVisit.Index.EpisodeCode);
            model.PreviousVisitDate = entity.GetValue<DateTime>(MSVisit.Index.PreviousVisitDate);
            model.PreviousVisitProviderCode = entity.GetValue<string>(MSVisit.Index.PreviousVisitProviderCode);
			model.CaseTransfer = (Mimsys.MS.Models.Enums.CaseTransfer)(entity.GetValue<int>(MSVisit.Index.CaseTransfer));
            model.TransferDate = entity.GetValue<DateTime>(MSVisit.Index.TransferDate);
            model.RequisitionNo = entity.GetValue<string>(MSVisit.Index.RequisitionNo);
			model.CaseSelect = (Mimsys.MS.Models.Enums.CaseSelect)(entity.GetValue<int>(MSVisit.Index.CaseSelect));
			model.SponsoredBy = (Mimsys.MS.Models.Enums.SponsoredBy)(entity.GetValue<int>(MSVisit.Index.SponsoredBy));
            model.SponsorCode = entity.GetValue<string>(MSVisit.Index.SponsorCode);
			model.IsEmergency = (Mimsys.MS.Models.Enums.IsEmergency)(entity.GetValue<int>(MSVisit.Index.IsEmergency));
			model.VisitPurpose = (Mimsys.MS.Models.Enums.VisitPurpose)(entity.GetValue<int>(MSVisit.Index.VisitPurpose));
            model.ClinicCode = entity.GetValue<string>(MSVisit.Index.ClinicCode);
			model.IsPackagePatient = (Mimsys.MS.Models.Enums.IsPackagePatient)(entity.GetValue<int>(MSVisit.Index.IsPackagePatient));
			model.FreeVisit = (Mimsys.MS.Models.Enums.FreeVisit)(entity.GetValue<int>(MSVisit.Index.FreeVisit));
            model.PackageCode = entity.GetValue<string>(MSVisit.Index.PackageCode);
            model.ConsultationTypeCode = entity.GetValue<string>(MSVisit.Index.ConsultationTypeCode);
			model.IsReferring = (Mimsys.MS.Models.Enums.IsReferring)(entity.GetValue<int>(MSVisit.Index.IsReferring));
			model.InitialVisit = (Mimsys.MS.Models.Enums.InitialVisit)(entity.GetValue<int>(MSVisit.Index.InitialVisit));
			model.IsDeductibleCollected = (Mimsys.MS.Models.Enums.IsDeductibleCollected)(entity.GetValue<int>(MSVisit.Index.IsDeductibleCollected));
            model.DeductibleAmount = entity.GetValue<decimal>(MSVisit.Index.DeductibleAmount);
            model.GenCount = entity.GetValue<short>(MSVisit.Index.GenCount);
            model.SpecialCount = entity.GetValue<short>(MSVisit.Index.SpecialCount);
            model.ConsultationCount = entity.GetValue<short>(MSVisit.Index.ConsultationCount);
			model.IsMLC = (Mimsys.MS.Models.Enums.IsMLC)(entity.GetValue<int>(MSVisit.Index.IsMLC));
            model.MLCCode = entity.GetValue<string>(MSVisit.Index.MLCCode);
            model.SOAPNumber = entity.GetValue<string>(MSVisit.Index.SOAPNumber);
            model.PolicyGroupCode = entity.GetValue<string>(MSVisit.Index.PolicyGroupCode);
            model.PolicyGroupDescription = entity.GetValue<string>(MSVisit.Index.PolicyGroupDescription);
            model.PlanName = entity.GetValue<string>(MSVisit.Index.PlanName);
            model.InsuranceName = entity.GetValue<string>(MSVisit.Index.InsuranceName);
            model.CreatedBy = entity.GetValue<string>(MSVisit.Index.CreatedBy);
            model.CreatedDate = entity.GetValue<DateTime>(MSVisit.Index.CreatedDate);
            model.ModifiedBy = entity.GetValue<string>(MSVisit.Index.ModifiedBy);
            model.ModifiedDate = entity.GetValue<DateTime>(MSVisit.Index.ModifiedDate);
            model.NumberOfBills = entity.GetValue<short>(MSVisit.Index.NumberOfBills);
			model.ConsultBills = (Mimsys.MS.Models.Enums.ConsultBills)(entity.GetValue<int>(MSVisit.Index.ConsultBills));
            model.RegisterBills = entity.GetValue<short>(MSVisit.Index.RegisterBills);
            model.TransferBy = entity.GetValue<string>(MSVisit.Index.TransferBy);
            model.TransferTime = entity.GetValue<DateTime>(MSVisit.Index.TransferTime).TimeOfDay;
            model.TransferredAdmissionCode = entity.GetValue<string>(MSVisit.Index.TransferredAdmissionCode);
            model.TransferReason = entity.GetValue<string>(MSVisit.Index.TransferReason);
			model.IsChronic = (Mimsys.MS.Models.Enums.IsChronic)(entity.GetValue<int>(MSVisit.Index.IsChronic));
            model.UnitCode = entity.GetValue<string>(MSVisit.Index.UnitCode);
            model.UnitDescription = entity.GetValue<string>(MSVisit.Index.UnitDescription);
            model.DiscountCategoryCode = entity.GetValue<string>(MSVisit.Index.DiscountCategoryCode);
            model.DiscountCategoryDescription = entity.GetValue<string>(MSVisit.Index.DiscountCategoryDescription);
            model.AccidentRegCode = entity.GetValue<string>(MSVisit.Index.AccidentRegCode);
            model.AccidentPlace = entity.GetValue<string>(MSVisit.Index.AccidentPlace);
            model.PoliceStationName = entity.GetValue<string>(MSVisit.Index.PoliceStationName);
			model.IsIntimated = (Mimsys.MS.Models.Enums.IsIntimated)(entity.GetValue<int>(MSVisit.Index.IsIntimated));
            model.WoundCertifiedDate = entity.GetValue<DateTime>(MSVisit.Index.WoundCertifiedDate);
            model.ExternalProviderCode = entity.GetValue<string>(MSVisit.Index.ExternalProviderCode);
            model.ExternalProviderName = entity.GetValue<string>(MSVisit.Index.ExternalProviderName);
            model.PatientType = entity.GetValue<string>(MSVisit.Index.PatientType);
            model.VisitExpiryDate = entity.GetValue<DateTime>(MSVisit.Index.VisitExpiryDate);
            model.SpecialityCode = entity.GetValue<string>(MSVisit.Index.SpecialityCode);
            model.LimitUtilized = entity.GetValue<decimal>(MSVisit.Index.LimitUtilized);
            model.LimitBalance = entity.GetValue<decimal>(MSVisit.Index.LimitBalance);
            model.OPLimitUtilized = entity.GetValue<decimal>(MSVisit.Index.OPLimitUtilized);
            model.OPLimitBalance = entity.GetValue<decimal>(MSVisit.Index.OPLimitBalance);
            model.QueueNumber = entity.GetValue<decimal>(MSVisit.Index.QueueNumber);
			model.SpecialityDepartment = (Mimsys.MS.Models.Enums.SpecialityDepartment)(entity.GetValue<int>(MSVisit.Index.SpecialityDepartment));
			model.PackageType = (Mimsys.MS.Models.Enums.PackageType)(entity.GetValue<int>(MSVisit.Index.PackageType));
			model.CheckedIn = (Mimsys.MS.Models.Enums.CheckedIn)(entity.GetValue<int>(MSVisit.Index.CheckedIn));
            model.ReferralEmployeeCode = entity.GetValue<string>(MSVisit.Index.ReferralEmployeeCode);
            model.EpisodeNo = entity.GetValue<decimal>(MSVisit.Index.EpisodeNo);
			model.VisitFromAppointment = (Mimsys.MS.Models.Enums.VisitFromAppointment)(entity.GetValue<int>(MSVisit.Index.VisitFromAppointment));
            model.InjuryCode = entity.GetValue<decimal>(MSVisit.Index.InjuryCode);
            model.MultiVisitPackageOrderCode = entity.GetValue<string>(MSVisit.Index.MultiVisitPackageOrderCode);
            model.PatientName = entity.GetValue<string>(MSVisit.Index.PatientName);
            model.ProviderName = entity.GetValue<string>(MSVisit.Index.ProviderName);
            model.DepartmentName = entity.GetValue<string>(MSVisit.Index.DepartmentName);
            model.ConsultName = entity.GetValue<string>(MSVisit.Index.ConsultName);
            model.ReferredName = entity.GetValue<string>(MSVisit.Index.ReferredName);
            model.EmployeeName = entity.GetValue<string>(MSVisit.Index.EmployeeName);
            model.ClinicDescription = entity.GetValue<string>(MSVisit.Index.ClinicDescription);
            model.PackageDescription = entity.GetValue<string>(MSVisit.Index.PackageDescription);
            model.ReferralName = entity.GetValue<string>(MSVisit.Index.ReferralName);
            model.SpecialityDescription = entity.GetValue<string>(MSVisit.Index.SpecialityDescription);
            model.ConsultationDescription = entity.GetValue<string>(MSVisit.Index.ConsultationDescription);
            model.MLCDescription = entity.GetValue<string>(MSVisit.Index.MLCDescription);
			model.TypeOfVisit = (Mimsys.MS.Models.Enums.TypeOfVisit)(entity.GetValue<int>(MSVisit.Index.TypeOfVisit));
            model.RegistrationDate = entity.GetValue<DateTime>(MSVisit.Index.RegistrationDate);
			model.IsFreeVisit = (Mimsys.MS.Models.Enums.IsFreeVisit)(entity.GetValue<int>(MSVisit.Index.IsFreeVisit));
            model.AgeYears = entity.GetValue<short>(MSVisit.Index.AgeYears);
            model.AgeMonths = entity.GetValue<short>(MSVisit.Index.AgeMonths);
            model.AgeDays = entity.GetValue<short>(MSVisit.Index.AgeDays);
			model.Authorized = (Mimsys.MS.Models.Enums.Authorized)(entity.GetValue<int>(MSVisit.Index.Authorized));
			model.ProvisionalICDCompleted = (Mimsys.MS.Models.Enums.ProvisionalICDCompleted)(entity.GetValue<int>(MSVisit.Index.ProvisionalICDCompleted));
			model.FinalICDCompleted = (Mimsys.MS.Models.Enums.FinalICDCompleted)(entity.GetValue<int>(MSVisit.Index.FinalICDCompleted));
            model.AuthorizationBy = entity.GetValue<string>(MSVisit.Index.AuthorizationBy);
            model.AuthorizationDate = entity.GetValue<DateTime>(MSVisit.Index.AuthorizationDate);
			model.ConsultationSetup = (Mimsys.MS.Models.Enums.ConsultationSetup)(entity.GetValue<int>(MSVisit.Index.ConsultationSetup));
            model.EpisodeNumber = entity.GetValue<decimal>(MSVisit.Index.EpisodeNumber);
            model.InsApplicationNumber = entity.GetValue<string>(MSVisit.Index.InsApplicationNumber);
			model.PrescriptionType = (Mimsys.MS.Models.Enums.PrescriptionType)(entity.GetValue<int>(MSVisit.Index.PrescriptionType));
            model.AppointmentNumber = entity.GetValue<decimal>(MSVisit.Index.AppointmentNumber);
            model.EncounterUniqueCode = entity.GetValue<decimal>(MSVisit.Index.EncounterUniqueCode);
			model.NursingAssessmentStatus = (Mimsys.MS.Models.Enums.NursingAssessmentStatus)(entity.GetValue<int>(MSVisit.Index.NursingAssessmentStatus));
			model.MultiVisitPackageType = (Mimsys.MS.Models.Enums.MultiVisitPackageType)(entity.GetValue<int>(MSVisit.Index.MultiVisitPackageType));
            model.ApplicationDate = entity.GetValue<DateTime>(MSVisit.Index.ApplicationDate);
            model.EligibleAmount = entity.GetValue<decimal>(MSVisit.Index.EligibleAmount);
			model.EligibleType = (Mimsys.MS.Models.Enums.EligibleType)(entity.GetValue<int>(MSVisit.Index.EligibleType));
			model.IsFallRisk = (Mimsys.MS.Models.Enums.IsFallRisk)(entity.GetValue<int>(MSVisit.Index.IsFallRisk));
			model.IsSecondaryPlan = (Mimsys.MS.Models.Enums.IsSecondaryPlan)(entity.GetValue<int>(MSVisit.Index.IsSecondaryPlan));
			model.SecondaryCustomerType = (Mimsys.MS.Models.Enums.SecondaryCustomerType)(entity.GetValue<int>(MSVisit.Index.SecondaryCustomerType));
            model.SecondaryCustomerCode = entity.GetValue<string>(MSVisit.Index.SecondaryCustomerCode);
            model.SecondaryPolicyGroupCode = entity.GetValue<string>(MSVisit.Index.SecondaryPolicyGroupCode);
            model.SecondaryPlanCode = entity.GetValue<string>(MSVisit.Index.SecondaryPlanCode);
            model.SecondaryPolicyNumber = entity.GetValue<string>(MSVisit.Index.SecondaryPolicyNumber);
            model.HospitalName = entity.GetValue<string>(MSVisit.Index.HospitalName);
            model.Network = entity.GetValue<string>(MSVisit.Index.Network);
            model.PolicyStartDate = entity.GetValue<DateTime>(MSVisit.Index.PolicyStartDate);
            model.PolicyExpiryDate = entity.GetValue<DateTime>(MSVisit.Index.PolicyExpiryDate);
            model.SecondaryPolicyStartDate = entity.GetValue<DateTime>(MSVisit.Index.SecondaryPolicyStartDate);
            model.SecondaryPolicyExpiryDate = entity.GetValue<DateTime>(MSVisit.Index.SecondaryPolicyExpiryDate);
            model.SecondarySponsorCode = entity.GetValue<string>(MSVisit.Index.SecondarySponsorCode);
            model.EHRAlertMessage = entity.GetValue<string>(MSVisit.Index.EHRAlertMessage);
            model.ModifiedPrimaryPolicyNo = entity.GetValue<string>(MSVisit.Index.ModifiedPrimaryPolicyNo);
            model.ModifiedSecPolicyNumber = entity.GetValue<string>(MSVisit.Index.ModifiedSecPolicyNumber);
			model.VisitExistEnd = (Mimsys.MS.Models.Enums.VisitExistEnd)(entity.GetValue<int>(MSVisit.Index.VisitExistEnd));
            model.VisitExistEndTime = entity.GetValue<DateTime>(MSVisit.Index.VisitExistEndTime).TimeOfDay;
			model.IsConsent = (Mimsys.MS.Models.Enums.IsConsent)(entity.GetValue<int>(MSVisit.Index.IsConsent));
			model.IsDisclosure = (Mimsys.MS.Models.Enums.IsDisclosure)(entity.GetValue<int>(MSVisit.Index.IsDisclosure));
			model.HL7Message = (Mimsys.MS.Models.Enums.HL7Message)(entity.GetValue<int>(MSVisit.Index.HL7Message));
			model.MaternityPatient = (Mimsys.MS.Models.Enums.MaternityPatient)(entity.GetValue<int>(MSVisit.Index.MaternityPatient));
			model.PreAuthorizationRequired = (Mimsys.MS.Models.Enums.PreAuthorizationRequired)(entity.GetValue<int>(MSVisit.Index.PreAuthorizationRequired));
			model.Authorize = (Mimsys.MS.Models.Enums.Authorize)(entity.GetValue<int>(MSVisit.Index.Authorize));
            model.AuthorizationStart = entity.GetValue<DateTime>(MSVisit.Index.AuthorizationStart);
            model.AuthorizationEnd = entity.GetValue<DateTime>(MSVisit.Index.AuthorizationEnd);
            model.PatientEmployerCode = entity.GetValue<string>(MSVisit.Index.PatientEmployerCode);
            model.IPEMCode = entity.GetValue<string>(MSVisit.Index.IPEMCode);
            model.AuthorizationNumber = entity.GetValue<string>(MSVisit.Index.AuthorizationNumber);
			model.ExternalMedication = (Mimsys.MS.Models.Enums.ExternalMedication)(entity.GetValue<int>(MSVisit.Index.ExternalMedication));
			model.PharmacyVisit = (Mimsys.MS.Models.Enums.PharmacyVisit)(entity.GetValue<int>(MSVisit.Index.PharmacyVisit));
            model.DeliveryOrder = entity.GetValue<short>(MSVisit.Index.DeliveryOrder);
            model.IntermediateVisit = entity.GetValue<short>(MSVisit.Index.IntermediateVisit);
			model.Source = (Mimsys.MS.Models.Enums.Source)(entity.GetValue<int>(MSVisit.Index.Source));
			model.AvailFirst = (Mimsys.MS.Models.Enums.AvailFirst)(entity.GetValue<int>(MSVisit.Index.AvailFirst));
			model.IsVideoConsultation = (Mimsys.MS.Models.Enums.IsVideoConsultation)(entity.GetValue<int>(MSVisit.Index.IsVideoConsultation));
            model.DefaultEMCode = entity.GetValue<string>(MSVisit.Index.DefaultEMCode);
            model.DiscountAmount = entity.GetValue<decimal>(MSVisit.Index.DiscountAmount);
            model.DiscountPercentage = entity.GetValue<decimal>(MSVisit.Index.DiscountPercentage);
			model.IsRIAYATIConsent = (Mimsys.MS.Models.Enums.IsRIAYATIConsent)(entity.GetValue<int>(MSVisit.Index.IsRIAYATIConsent));
			model.InjuryValidationRequired = (Mimsys.MS.Models.Enums.InjuryValidationRequired)(entity.GetValue<int>(MSVisit.Index.InjuryValidationRequired));
			model.InjuryIsOpen = (Mimsys.MS.Models.Enums.InjuryIsOpen)(entity.GetValue<int>(MSVisit.Index.InjuryIsOpen));
			model.VisitModified = (Mimsys.MS.Models.Enums.VisitModified)(entity.GetValue<int>(MSVisit.Index.VisitModified));
			model.Command = (Mimsys.MS.Models.Enums.Command)(entity.GetValue<int>(MSVisit.Index.Command));
			model.IsExtendEpisode = (Mimsys.MS.Models.Enums.IsExtendEpisode)(entity.GetValue<int>(MSVisit.Index.IsExtendEpisode));
			model.ConsultationCheck = (Mimsys.MS.Models.Enums.ConsultationCheck)(entity.GetValue<int>(MSVisit.Index.ConsultationCheck));
            model.VisitDepartmentNumber = entity.GetValue<string>(MSVisit.Index.VisitDepartmentNumber);
			model.AllergyFlag = (Mimsys.MS.Models.Enums.AllergyFlag)(entity.GetValue<int>(MSVisit.Index.AllergyFlag));
			model.InitialAssessmentFlag = (Mimsys.MS.Models.Enums.InitialAssessmentFlag)(entity.GetValue<int>(MSVisit.Index.InitialAssessmentFlag));
			model.AlertFlag = (Mimsys.MS.Models.Enums.AlertFlag)(entity.GetValue<int>(MSVisit.Index.AlertFlag));
			model.PatientComplainFlag = (Mimsys.MS.Models.Enums.PatientComplainFlag)(entity.GetValue<int>(MSVisit.Index.PatientComplainFlag));
			model.MessageCenterFlag = (Mimsys.MS.Models.Enums.MessageCenterFlag)(entity.GetValue<int>(MSVisit.Index.MessageCenterFlag));
			model.DoctorNotifyFlag = (Mimsys.MS.Models.Enums.DoctorNotifyFlag)(entity.GetValue<int>(MSVisit.Index.DoctorNotifyFlag));
			model.OrdersFlag = (Mimsys.MS.Models.Enums.OrdersFlag)(entity.GetValue<int>(MSVisit.Index.OrdersFlag));
			model.FallRiskFlag = (Mimsys.MS.Models.Enums.FallRiskFlag)(entity.GetValue<int>(MSVisit.Index.FallRiskFlag));
			model.ResultsFlag = (Mimsys.MS.Models.Enums.ResultsFlag)(entity.GetValue<int>(MSVisit.Index.ResultsFlag));
			model.CheckBilled = (Mimsys.MS.Models.Enums.CheckBilled)(entity.GetValue<int>(MSVisit.Index.CheckBilled));
			model.CheckSpeciality = (Mimsys.MS.Models.Enums.CheckSpeciality)(entity.GetValue<int>(MSVisit.Index.CheckSpeciality));
			model.MobileApp = (Mimsys.MS.Models.Enums.MobileApp)(entity.GetValue<int>(MSVisit.Index.MobileApp));
			model.IsPreviousInitialVisit = (Mimsys.MS.Models.Enums.IsPreviousInitialVisit)(entity.GetValue<int>(MSVisit.Index.IsPreviousInitialVisit));
			model.IsOrdered = (Mimsys.MS.Models.Enums.IsOrdered)(entity.GetValue<int>(MSVisit.Index.IsOrdered));
			model.IsPreOrdered = (Mimsys.MS.Models.Enums.IsPreOrdered)(entity.GetValue<int>(MSVisit.Index.IsPreOrdered));
			model.LabAutomation = (Mimsys.MS.Models.Enums.LabAutomation)(entity.GetValue<int>(MSVisit.Index.LabAutomation));
			model.AdvanceAlert = (Mimsys.MS.Models.Enums.AdvanceAlert)(entity.GetValue<int>(MSVisit.Index.AdvanceAlert));
			model.AdvanceUtilize = (Mimsys.MS.Models.Enums.AdvanceUtilize)(entity.GetValue<int>(MSVisit.Index.AdvanceUtilize));
			model.ReferralVisitCheck = (Mimsys.MS.Models.Enums.ReferralVisitCheck)(entity.GetValue<int>(MSVisit.Index.ReferralVisitCheck));
			model.ApplyVisitLimit = (Mimsys.MS.Models.Enums.ApplyVisitLimit)(entity.GetValue<int>(MSVisit.Index.ApplyVisitLimit));
			model.ApplyCoPayLimit = (Mimsys.MS.Models.Enums.ApplyCoPayLimit)(entity.GetValue<int>(MSVisit.Index.ApplyCoPayLimit));
            model.IPAddress = entity.GetValue<string>(MSVisit.Index.IPAddress);
			model.IsConsultation = (Mimsys.MS.Models.Enums.IsConsultation)(entity.GetValue<int>(MSVisit.Index.IsConsultation));
            return model;
        }

        /// <summary>
        /// Map model to entity
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="entity">Business Entity</param>
        public override void Map(T model, IBusinessEntity entity)
        {
            if (model == null)
            {
                return;
            }

            entity.SetValue(MSVisit.Index.VisitCode, model.VisitCode);
            entity.SetValue(MSVisit.Index.VisitDate, model.VisitDate);
            entity.SetValue(MSVisit.Index.VisitTime, DateUtil.GetMinDate().Add(model.VisitTime));
            entity.SetValue(MSVisit.Index.VisitType, model.VisitType);
            entity.SetValue(MSVisit.Index.PatientCode, model.PatientCode);
            entity.SetValue(MSVisit.Index.ProviderCode, model.ProviderCode);
            entity.SetValue(MSVisit.Index.DepartmentCode, model.DepartmentCode);
            entity.SetValue(MSVisit.Index.VisitClosed, model.VisitClosed);
            entity.SetValue(MSVisit.Index.ReferenceType, model.ReferenceType);
            entity.SetValue(MSVisit.Index.ReferralProviderCode, model.ReferralProviderCode);
            entity.SetValue(MSVisit.Index.Facility, model.Facility);
            entity.SetValue(MSVisit.Index.OtherReferrals, model.OtherReferrals);
            entity.SetValue(MSVisit.Index.ReferenceCode, model.ReferenceCode);
            entity.SetValue(MSVisit.Index.ReferenceDetail, model.ReferenceDetail);
            entity.SetValue(MSVisit.Index.Billed, model.Billed);
            entity.SetValue(MSVisit.Index.QueueNumber2, model.QueueNumber2);
            entity.SetValue(MSVisit.Index.CheckTime, DateUtil.GetMinDate().Add(model.CheckTime));
            entity.SetValue(MSVisit.Index.CheckOut, model.CheckOut);
            entity.SetValue(MSVisit.Index.CheckOutTime, DateUtil.GetMinDate().Add(model.CheckOutTime));
            entity.SetValue(MSVisit.Index.VisitLevelCopay, model.VisitLevelCopay);
            entity.SetValue(MSVisit.Index.Inactive, model.Inactive);
            entity.SetValue(MSVisit.Index.InsuranceCompanyCode, model.InsuranceCompanyCode);
            entity.SetValue(MSVisit.Index.PlanCode, model.PlanCode);
            entity.SetValue(MSVisit.Index.PolicyNumber, model.PolicyNumber);
            entity.SetValue(MSVisit.Index.DeductibleBalance, model.DeductibleBalance);
            entity.SetValue(MSVisit.Index.CustomerType, model.CustomerType);
            entity.SetValue(MSVisit.Index.Customer, model.Customer);
            entity.SetValue(MSVisit.Index.BillNumber, model.BillNumber);
            entity.SetValue(MSVisit.Index.BillingCode, model.BillingCode);
            entity.SetValue(MSVisit.Index.ConsultationType, model.ConsultationType);
            entity.SetValue(MSVisit.Index.Others, model.Others);
            entity.SetValue(MSVisit.Index.EpisodeCode, model.EpisodeCode);
            // entity.SetValue(MSVisit.Index.PreviousVisitDate, model.PreviousVisitDate);
            entity.SetValue(MSVisit.Index.PreviousVisitProviderCode, model.PreviousVisitProviderCode);
            entity.SetValue(MSVisit.Index.CaseTransfer, model.CaseTransfer);
            // entity.SetValue(MSVisit.Index.TransferDate, model.TransferDate);
            entity.SetValue(MSVisit.Index.RequisitionNo, model.RequisitionNo);
            entity.SetValue(MSVisit.Index.CaseSelect, model.CaseSelect);
            entity.SetValue(MSVisit.Index.SponsoredBy, model.SponsoredBy);
            entity.SetValue(MSVisit.Index.SponsorCode, model.SponsorCode);
            entity.SetValue(MSVisit.Index.IsEmergency, model.IsEmergency);
            entity.SetValue(MSVisit.Index.VisitPurpose, model.VisitPurpose);
            entity.SetValue(MSVisit.Index.ClinicCode, model.ClinicCode);
            entity.SetValue(MSVisit.Index.IsPackagePatient, model.IsPackagePatient);
            entity.SetValue(MSVisit.Index.FreeVisit, model.FreeVisit);
            entity.SetValue(MSVisit.Index.PackageCode, model.PackageCode);
            entity.SetValue(MSVisit.Index.ConsultationTypeCode, model.ConsultationTypeCode);
            entity.SetValue(MSVisit.Index.IsReferring, model.IsReferring);
            entity.SetValue(MSVisit.Index.InitialVisit, model.InitialVisit);
            entity.SetValue(MSVisit.Index.IsDeductibleCollected, model.IsDeductibleCollected);
            entity.SetValue(MSVisit.Index.DeductibleAmount, model.DeductibleAmount);
            entity.SetValue(MSVisit.Index.GenCount, model.GenCount);
            entity.SetValue(MSVisit.Index.SpecialCount, model.SpecialCount);
            entity.SetValue(MSVisit.Index.ConsultationCount, model.ConsultationCount);
            entity.SetValue(MSVisit.Index.IsMLC, model.IsMLC);
            entity.SetValue(MSVisit.Index.MLCCode, model.MLCCode);
            entity.SetValue(MSVisit.Index.SOAPNumber, model.SOAPNumber);
            entity.SetValue(MSVisit.Index.PolicyGroupCode, model.PolicyGroupCode);
            // entity.SetValue(MSVisit.Index.PolicyGroupDescription, model.PolicyGroupDescription);
            // entity.SetValue(MSVisit.Index.PlanName, model.PlanName);
            // entity.SetValue(MSVisit.Index.InsuranceName, model.InsuranceName);
            // entity.SetValue(MSVisit.Index.CreatedBy, model.CreatedBy);
            // entity.SetValue(MSVisit.Index.CreatedDate, model.CreatedDate);
            // entity.SetValue(MSVisit.Index.ModifiedBy, model.ModifiedBy);
            // entity.SetValue(MSVisit.Index.ModifiedDate, model.ModifiedDate);
            entity.SetValue(MSVisit.Index.NumberOfBills, model.NumberOfBills);
            entity.SetValue(MSVisit.Index.ConsultBills, model.ConsultBills);
            entity.SetValue(MSVisit.Index.RegisterBills, model.RegisterBills);
            entity.SetValue(MSVisit.Index.TransferBy, model.TransferBy);
            entity.SetValue(MSVisit.Index.TransferTime, DateUtil.GetMinDate().Add(model.TransferTime));
            entity.SetValue(MSVisit.Index.TransferredAdmissionCode, model.TransferredAdmissionCode);
            entity.SetValue(MSVisit.Index.TransferReason, model.TransferReason);
            entity.SetValue(MSVisit.Index.IsChronic, model.IsChronic);
            entity.SetValue(MSVisit.Index.UnitCode, model.UnitCode);
            // entity.SetValue(MSVisit.Index.UnitDescription, model.UnitDescription);
            entity.SetValue(MSVisit.Index.DiscountCategoryCode, model.DiscountCategoryCode);
            // entity.SetValue(MSVisit.Index.DiscountCategoryDescription, model.DiscountCategoryDescription);
            entity.SetValue(MSVisit.Index.AccidentRegCode, model.AccidentRegCode);
            entity.SetValue(MSVisit.Index.AccidentPlace, model.AccidentPlace);
            entity.SetValue(MSVisit.Index.PoliceStationName, model.PoliceStationName);
            entity.SetValue(MSVisit.Index.IsIntimated, model.IsIntimated);
            entity.SetValue(MSVisit.Index.WoundCertifiedDate, model.WoundCertifiedDate);
            entity.SetValue(MSVisit.Index.ExternalProviderCode, model.ExternalProviderCode);
            // entity.SetValue(MSVisit.Index.ExternalProviderName, model.ExternalProviderName);
            entity.SetValue(MSVisit.Index.PatientType, model.PatientType);
            // entity.SetValue(MSVisit.Index.VisitExpiryDate, model.VisitExpiryDate);
            entity.SetValue(MSVisit.Index.SpecialityCode, model.SpecialityCode);
            entity.SetValue(MSVisit.Index.LimitUtilized, model.LimitUtilized);
            entity.SetValue(MSVisit.Index.LimitBalance, model.LimitBalance);
            entity.SetValue(MSVisit.Index.OPLimitUtilized, model.OPLimitUtilized);
            entity.SetValue(MSVisit.Index.OPLimitBalance, model.OPLimitBalance);
            entity.SetValue(MSVisit.Index.QueueNumber, model.QueueNumber);
            entity.SetValue(MSVisit.Index.SpecialityDepartment, model.SpecialityDepartment);
            entity.SetValue(MSVisit.Index.PackageType, model.PackageType);
            entity.SetValue(MSVisit.Index.CheckedIn, model.CheckedIn);
            entity.SetValue(MSVisit.Index.ReferralEmployeeCode, model.ReferralEmployeeCode);
            entity.SetValue(MSVisit.Index.EpisodeNo, model.EpisodeNo);
            entity.SetValue(MSVisit.Index.VisitFromAppointment, model.VisitFromAppointment);
            entity.SetValue(MSVisit.Index.InjuryCode, model.InjuryCode);
            entity.SetValue(MSVisit.Index.MultiVisitPackageOrderCode, model.MultiVisitPackageOrderCode);
            // entity.SetValue(MSVisit.Index.PatientName, model.PatientName);
            // entity.SetValue(MSVisit.Index.ProviderName, model.ProviderName);
            // entity.SetValue(MSVisit.Index.DepartmentName, model.DepartmentName);
            // entity.SetValue(MSVisit.Index.ConsultName, model.ConsultName);
            // entity.SetValue(MSVisit.Index.ReferredName, model.ReferredName);
            // entity.SetValue(MSVisit.Index.EmployeeName, model.EmployeeName);
            // entity.SetValue(MSVisit.Index.ClinicDescription, model.ClinicDescription);
            // entity.SetValue(MSVisit.Index.PackageDescription, model.PackageDescription);
            // entity.SetValue(MSVisit.Index.ReferralName, model.ReferralName);
            // entity.SetValue(MSVisit.Index.SpecialityDescription, model.SpecialityDescription);
            // entity.SetValue(MSVisit.Index.ConsultationDescription, model.ConsultationDescription);
            // entity.SetValue(MSVisit.Index.MLCDescription, model.MLCDescription);
            entity.SetValue(MSVisit.Index.TypeOfVisit, model.TypeOfVisit);
            // entity.SetValue(MSVisit.Index.RegistrationDate, model.RegistrationDate);
            entity.SetValue(MSVisit.Index.IsFreeVisit, model.IsFreeVisit);
            entity.SetValue(MSVisit.Index.AgeYears, model.AgeYears);
            entity.SetValue(MSVisit.Index.AgeMonths, model.AgeMonths);
            entity.SetValue(MSVisit.Index.AgeDays, model.AgeDays);
            entity.SetValue(MSVisit.Index.Authorized, model.Authorized);
            entity.SetValue(MSVisit.Index.ProvisionalICDCompleted, model.ProvisionalICDCompleted);
            entity.SetValue(MSVisit.Index.FinalICDCompleted, model.FinalICDCompleted);
            entity.SetValue(MSVisit.Index.AuthorizationBy, model.AuthorizationBy);
            entity.SetValue(MSVisit.Index.AuthorizationDate, model.AuthorizationDate);
            entity.SetValue(MSVisit.Index.ConsultationSetup, model.ConsultationSetup);
            entity.SetValue(MSVisit.Index.EpisodeNumber, model.EpisodeNumber);
            entity.SetValue(MSVisit.Index.InsApplicationNumber, model.InsApplicationNumber);
            entity.SetValue(MSVisit.Index.PrescriptionType, model.PrescriptionType);
            entity.SetValue(MSVisit.Index.AppointmentNumber, model.AppointmentNumber);
            entity.SetValue(MSVisit.Index.EncounterUniqueCode, model.EncounterUniqueCode);
            entity.SetValue(MSVisit.Index.NursingAssessmentStatus, model.NursingAssessmentStatus);
            entity.SetValue(MSVisit.Index.MultiVisitPackageType, model.MultiVisitPackageType);
            entity.SetValue(MSVisit.Index.ApplicationDate, model.ApplicationDate);
            entity.SetValue(MSVisit.Index.EligibleAmount, model.EligibleAmount);
            entity.SetValue(MSVisit.Index.EligibleType, model.EligibleType);
            entity.SetValue(MSVisit.Index.IsFallRisk, model.IsFallRisk);
            entity.SetValue(MSVisit.Index.IsSecondaryPlan, model.IsSecondaryPlan);
            entity.SetValue(MSVisit.Index.SecondaryCustomerType, model.SecondaryCustomerType);
            entity.SetValue(MSVisit.Index.SecondaryCustomerCode, model.SecondaryCustomerCode);
            entity.SetValue(MSVisit.Index.SecondaryPolicyGroupCode, model.SecondaryPolicyGroupCode);
            entity.SetValue(MSVisit.Index.SecondaryPlanCode, model.SecondaryPlanCode);
            entity.SetValue(MSVisit.Index.SecondaryPolicyNumber, model.SecondaryPolicyNumber);
            entity.SetValue(MSVisit.Index.HospitalName, model.HospitalName);
            entity.SetValue(MSVisit.Index.Network, model.Network);
            entity.SetValue(MSVisit.Index.PolicyStartDate, model.PolicyStartDate);
            entity.SetValue(MSVisit.Index.PolicyExpiryDate, model.PolicyExpiryDate);
            entity.SetValue(MSVisit.Index.SecondaryPolicyStartDate, model.SecondaryPolicyStartDate);
            entity.SetValue(MSVisit.Index.SecondaryPolicyExpiryDate, model.SecondaryPolicyExpiryDate);
            entity.SetValue(MSVisit.Index.SecondarySponsorCode, model.SecondarySponsorCode);
            entity.SetValue(MSVisit.Index.EHRAlertMessage, model.EHRAlertMessage);
            entity.SetValue(MSVisit.Index.ModifiedPrimaryPolicyNo, model.ModifiedPrimaryPolicyNo);
            entity.SetValue(MSVisit.Index.ModifiedSecPolicyNumber, model.ModifiedSecPolicyNumber);
            entity.SetValue(MSVisit.Index.VisitExistEnd, model.VisitExistEnd);
            entity.SetValue(MSVisit.Index.VisitExistEndTime, DateUtil.GetMinDate().Add(model.VisitExistEndTime));
            entity.SetValue(MSVisit.Index.IsConsent, model.IsConsent);
            entity.SetValue(MSVisit.Index.IsDisclosure, model.IsDisclosure);
            entity.SetValue(MSVisit.Index.HL7Message, model.HL7Message);
            entity.SetValue(MSVisit.Index.MaternityPatient, model.MaternityPatient);
            entity.SetValue(MSVisit.Index.PreAuthorizationRequired, model.PreAuthorizationRequired);
            entity.SetValue(MSVisit.Index.Authorize, model.Authorize);
            entity.SetValue(MSVisit.Index.AuthorizationStart, model.AuthorizationStart);
            entity.SetValue(MSVisit.Index.AuthorizationEnd, model.AuthorizationEnd);
            entity.SetValue(MSVisit.Index.PatientEmployerCode, model.PatientEmployerCode);
            entity.SetValue(MSVisit.Index.IPEMCode, model.IPEMCode);
            entity.SetValue(MSVisit.Index.AuthorizationNumber, model.AuthorizationNumber);
            entity.SetValue(MSVisit.Index.ExternalMedication, model.ExternalMedication);
            entity.SetValue(MSVisit.Index.PharmacyVisit, model.PharmacyVisit);
            entity.SetValue(MSVisit.Index.DeliveryOrder, model.DeliveryOrder);
            entity.SetValue(MSVisit.Index.IntermediateVisit, model.IntermediateVisit);
            entity.SetValue(MSVisit.Index.Source, model.Source);
            entity.SetValue(MSVisit.Index.AvailFirst, model.AvailFirst);
            entity.SetValue(MSVisit.Index.IsVideoConsultation, model.IsVideoConsultation);
            entity.SetValue(MSVisit.Index.DefaultEMCode, model.DefaultEMCode);
            entity.SetValue(MSVisit.Index.DiscountAmount, model.DiscountAmount);
            entity.SetValue(MSVisit.Index.DiscountPercentage, model.DiscountPercentage);
            entity.SetValue(MSVisit.Index.IsRIAYATIConsent, model.IsRIAYATIConsent);
            entity.SetValue(MSVisit.Index.InjuryValidationRequired, model.InjuryValidationRequired);
            entity.SetValue(MSVisit.Index.InjuryIsOpen, model.InjuryIsOpen);
            entity.SetValue(MSVisit.Index.VisitModified, model.VisitModified);
            entity.SetValue(MSVisit.Index.Command, model.Command);
            // entity.SetValue(MSVisit.Index.IsExtendEpisode, model.IsExtendEpisode);
            entity.SetValue(MSVisit.Index.ConsultationCheck, model.ConsultationCheck);
            entity.SetValue(MSVisit.Index.VisitDepartmentNumber, model.VisitDepartmentNumber);
            entity.SetValue(MSVisit.Index.AllergyFlag, model.AllergyFlag);
            entity.SetValue(MSVisit.Index.InitialAssessmentFlag, model.InitialAssessmentFlag);
            entity.SetValue(MSVisit.Index.AlertFlag, model.AlertFlag);
            entity.SetValue(MSVisit.Index.PatientComplainFlag, model.PatientComplainFlag);
            entity.SetValue(MSVisit.Index.MessageCenterFlag, model.MessageCenterFlag);
            entity.SetValue(MSVisit.Index.DoctorNotifyFlag, model.DoctorNotifyFlag);
            entity.SetValue(MSVisit.Index.OrdersFlag, model.OrdersFlag);
            entity.SetValue(MSVisit.Index.FallRiskFlag, model.FallRiskFlag);
            entity.SetValue(MSVisit.Index.ResultsFlag, model.ResultsFlag);
            entity.SetValue(MSVisit.Index.CheckBilled, model.CheckBilled);
            entity.SetValue(MSVisit.Index.CheckSpeciality, model.CheckSpeciality);
            entity.SetValue(MSVisit.Index.MobileApp, model.MobileApp);
            entity.SetValue(MSVisit.Index.IsPreviousInitialVisit, model.IsPreviousInitialVisit);
            entity.SetValue(MSVisit.Index.IsOrdered, model.IsOrdered);
            entity.SetValue(MSVisit.Index.IsPreOrdered, model.IsPreOrdered);
            entity.SetValue(MSVisit.Index.LabAutomation, model.LabAutomation);
            entity.SetValue(MSVisit.Index.AdvanceAlert, model.AdvanceAlert);
            entity.SetValue(MSVisit.Index.AdvanceUtilize, model.AdvanceUtilize);
            entity.SetValue(MSVisit.Index.ReferralVisitCheck, model.ReferralVisitCheck);
            entity.SetValue(MSVisit.Index.ApplyVisitLimit, model.ApplyVisitLimit);
            entity.SetValue(MSVisit.Index.ApplyCoPayLimit, model.ApplyCoPayLimit);
            entity.SetValue(MSVisit.Index.IPAddress, model.IPAddress);
            entity.SetValue(MSVisit.Index.IsConsultation, model.IsConsultation);
        }

        /// <summary>
        /// Map Key
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="entity">Business Entity</param>
        public override void MapKey(T model, IBusinessEntity entity)
        {
            entity.SetValue(MSVisit.Index.VisitCode, model.VisitCode);
        }

        #endregion
    }
}