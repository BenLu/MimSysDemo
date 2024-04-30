// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using System.ComponentModel.DataAnnotations;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Attributes;
using Sage.CA.SBS.ERP.Sage300.Common.Resources;

using Mimsys.MS.Models.Enums; // For common enumerations
using Mimsys.MS.Resources; // For common resources
using Mimsys.MS.Resources.Forms;

#endregion

namespace Mimsys.MS.Models
{
    /// <summary>
    /// Partial class for MSVisit
    /// </summary>
    public partial class MSVisit : ModelBase
    {
        /// <summary>
        /// Gets or sets VisitCode
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitCode, Id = Index.VisitCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string VisitCode { get; set; }

        /// <summary>
        /// Gets or sets VisitDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitDate, Id = Index.VisitDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime VisitDate { get; set; }

        /// <summary>
        /// Gets or sets VisitTime
        /// </summary>
        [Display(Name = "VisitTime", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitTime, Id = Index.VisitTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan VisitTime { get; set; }

        /// <summary>
        /// Gets or sets VisitType
        /// </summary>
        [Display(Name = "VisitType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitType, Id = Index.VisitType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitType VisitType { get; set; }

        /// <summary>
        /// Gets or sets PatientCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PatientCode, Id = Index.PatientCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string PatientCode { get; set; }

        /// <summary>
        /// Gets or sets ProviderCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ProviderCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ProviderCode, Id = Index.ProviderCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string ProviderCode { get; set; }

        /// <summary>
        /// Gets or sets DepartmentCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DepartmentCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DepartmentCode, Id = Index.DepartmentCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Gets or sets VisitClosed
        /// </summary>
        [Display(Name = "VisitClosed", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitClosed, Id = Index.VisitClosed, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitClosed VisitClosed { get; set; }

        /// <summary>
        /// Gets or sets ReferenceType
        /// </summary>
        [Display(Name = "ReferenceType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferenceType, Id = Index.ReferenceType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ReferenceType ReferenceType { get; set; }

        /// <summary>
        /// Gets or sets ReferralProviderCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferralProviderCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferralProviderCode, Id = Index.ReferralProviderCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string ReferralProviderCode { get; set; }

        /// <summary>
        /// Gets or sets Facility
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "Facility", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Facility, Id = Index.Facility, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string Facility { get; set; }

        /// <summary>
        /// Gets or sets OtherReferrals
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "OtherReferrals", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.OtherReferrals, Id = Index.OtherReferrals, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string OtherReferrals { get; set; }

        /// <summary>
        /// Gets or sets ReferenceCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferenceCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferenceCode, Id = Index.ReferenceCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string ReferenceCode { get; set; }

        /// <summary>
        /// Gets or sets ReferenceDetail
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferenceDetail", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferenceDetail, Id = Index.ReferenceDetail, FieldType = EntityFieldType.Char, Size = 40)]
        public string ReferenceDetail { get; set; }

        /// <summary>
        /// Gets or sets Billed
        /// </summary>
        [Display(Name = "Billed", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Billed, Id = Index.Billed, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Billed Billed { get; set; }

        /// <summary>
        /// Gets or sets QueueNumber2
        /// </summary>
        [StringLength(20, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "QueueNumber2", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.QueueNumber2, Id = Index.QueueNumber2, FieldType = EntityFieldType.Char, Size = 20)]
        public string QueueNumber2 { get; set; }

        /// <summary>
        /// Gets or sets CheckTime
        /// </summary>
        [Display(Name = "CheckTime", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckTime, Id = Index.CheckTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan CheckTime { get; set; }

        /// <summary>
        /// Gets or sets CheckOut
        /// </summary>
        [Display(Name = "CheckOut", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckOut, Id = Index.CheckOut, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CheckOut CheckOut { get; set; }

        /// <summary>
        /// Gets or sets CheckOutTime
        /// </summary>
        [Display(Name = "CheckOutTime", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckOutTime, Id = Index.CheckOutTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan CheckOutTime { get; set; }

        /// <summary>
        /// Gets or sets VisitLevelCopay
        /// </summary>
        [Display(Name = "VisitLevelCopay", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitLevelCopay, Id = Index.VisitLevelCopay, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal VisitLevelCopay { get; set; }

        /// <summary>
        /// Gets or sets Inactive
        /// </summary>
        [Display(Name = "Inactive", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Inactive, Id = Index.Inactive, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Inactive Inactive { get; set; }

        /// <summary>
        /// Gets or sets InsuranceCompanyCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsuranceCompanyCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InsuranceCompanyCode, Id = Index.InsuranceCompanyCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string InsuranceCompanyCode { get; set; }

        /// <summary>
        /// Gets or sets PlanCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PlanCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PlanCode, Id = Index.PlanCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string PlanCode { get; set; }

        /// <summary>
        /// Gets or sets PolicyNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PolicyNumber, Id = Index.PolicyNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets DeductibleBalance
        /// </summary>
        [Display(Name = "DeductibleBalance", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DeductibleBalance, Id = Index.DeductibleBalance, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal DeductibleBalance { get; set; }

        /// <summary>
        /// Gets or sets CustomerType
        /// </summary>
        [Display(Name = "CustomerType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CustomerType, Id = Index.CustomerType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CustomerType CustomerType { get; set; }

        /// <summary>
        /// Gets or sets Customer
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "Customer", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Customer, Id = Index.Customer, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string Customer { get; set; }

        /// <summary>
        /// Gets or sets BillNumber
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "BillNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.BillNumber, Id = Index.BillNumber, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string BillNumber { get; set; }

        /// <summary>
        /// Gets or sets BillingCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "BillingCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.BillingCode, Id = Index.BillingCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string BillingCode { get; set; }

        /// <summary>
        /// Gets or sets ConsultationType
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ConsultationType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationType, Id = Index.ConsultationType, FieldType = EntityFieldType.Char, Size = 15)]
        public string ConsultationType { get; set; }

        /// <summary>
        /// Gets or sets Others
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "Others", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Others, Id = Index.Others, FieldType = EntityFieldType.Char, Size = 15)]
        public string Others { get; set; }

        /// <summary>
        /// Gets or sets EpisodeCode
        /// </summary>
        [Display(Name = "EpisodeCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EpisodeCode, Id = Index.EpisodeCode, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal EpisodeCode { get; set; }

        /// <summary>
        /// Gets or sets PreviousVisitDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PreviousVisitDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PreviousVisitDate, Id = Index.PreviousVisitDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime PreviousVisitDate { get; set; }

        /// <summary>
        /// Gets or sets PreviousVisitProviderCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PreviousVisitProviderCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PreviousVisitProviderCode, Id = Index.PreviousVisitProviderCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string PreviousVisitProviderCode { get; set; }

        /// <summary>
        /// Gets or sets CaseTransfer
        /// </summary>
        [Display(Name = "CaseTransfer", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CaseTransfer, Id = Index.CaseTransfer, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CaseTransfer CaseTransfer { get; set; }

        /// <summary>
        /// Gets or sets TransferDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "TransferDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TransferDate, Id = Index.TransferDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// Gets or sets RequisitionNo
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "RequisitionNo", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.RequisitionNo, Id = Index.RequisitionNo, FieldType = EntityFieldType.Char, Size = 22)]
        public string RequisitionNo { get; set; }

        /// <summary>
        /// Gets or sets CaseSelect
        /// </summary>
        [Display(Name = "CaseSelect", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CaseSelect, Id = Index.CaseSelect, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CaseSelect CaseSelect { get; set; }

        /// <summary>
        /// Gets or sets SponsoredBy
        /// </summary>
        [Display(Name = "SponsoredBy", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SponsoredBy, Id = Index.SponsoredBy, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SponsoredBy SponsoredBy { get; set; }

        /// <summary>
        /// Gets or sets SponsorCode
        /// </summary>
        [StringLength(30, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SponsorCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SponsorCode, Id = Index.SponsorCode, FieldType = EntityFieldType.Char, Size = 30)]
        public string SponsorCode { get; set; }

        /// <summary>
        /// Gets or sets IsEmergency
        /// </summary>
        [Display(Name = "IsEmergency", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsEmergency, Id = Index.IsEmergency, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsEmergency IsEmergency { get; set; }

        /// <summary>
        /// Gets or sets VisitPurpose
        /// </summary>
        [Display(Name = "VisitPurpose", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitPurpose, Id = Index.VisitPurpose, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitPurpose VisitPurpose { get; set; }

        /// <summary>
        /// Gets or sets ClinicCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ClinicCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ClinicCode, Id = Index.ClinicCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string ClinicCode { get; set; }

        /// <summary>
        /// Gets or sets IsPackagePatient
        /// </summary>
        [Display(Name = "IsPackagePatient", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsPackagePatient, Id = Index.IsPackagePatient, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsPackagePatient IsPackagePatient { get; set; }

        /// <summary>
        /// Gets or sets FreeVisit
        /// </summary>
        [Display(Name = "FreeVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.FreeVisit, Id = Index.FreeVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.FreeVisit FreeVisit { get; set; }

        /// <summary>
        /// Gets or sets PackageCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PackageCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PackageCode, Id = Index.PackageCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22N")]
        public string PackageCode { get; set; }

        /// <summary>
        /// Gets or sets ConsultationTypeCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ConsultationTypeCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationTypeCode, Id = Index.ConsultationTypeCode, FieldType = EntityFieldType.Char, Size = 22)]
        public string ConsultationTypeCode { get; set; }

        /// <summary>
        /// Gets or sets IsReferring
        /// </summary>
        [Display(Name = "IsReferring", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsReferring, Id = Index.IsReferring, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsReferring IsReferring { get; set; }

        /// <summary>
        /// Gets or sets InitialVisit
        /// </summary>
        [Display(Name = "InitialVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InitialVisit, Id = Index.InitialVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.InitialVisit InitialVisit { get; set; }

        /// <summary>
        /// Gets or sets IsDeductibleCollected
        /// </summary>
        [Display(Name = "IsDeductibleCollected", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsDeductibleCollected, Id = Index.IsDeductibleCollected, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsDeductibleCollected IsDeductibleCollected { get; set; }

        /// <summary>
        /// Gets or sets DeductibleAmount
        /// </summary>
        [Display(Name = "DeductibleAmount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DeductibleAmount, Id = Index.DeductibleAmount, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal DeductibleAmount { get; set; }

        /// <summary>
        /// Gets or sets GenCount
        /// </summary>
        [Display(Name = "GenCount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.GenCount, Id = Index.GenCount, FieldType = EntityFieldType.Int, Size = 2)]
        public short GenCount { get; set; }

        /// <summary>
        /// Gets or sets SpecialCount
        /// </summary>
        [Display(Name = "SpecialCount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SpecialCount, Id = Index.SpecialCount, FieldType = EntityFieldType.Int, Size = 2)]
        public short SpecialCount { get; set; }

        /// <summary>
        /// Gets or sets ConsultationCount
        /// </summary>
        [Display(Name = "ConsultationCount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationCount, Id = Index.ConsultationCount, FieldType = EntityFieldType.Int, Size = 2)]
        public short ConsultationCount { get; set; }

        /// <summary>
        /// Gets or sets IsMLC
        /// </summary>
        [Display(Name = "IsMLC", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsMLC, Id = Index.IsMLC, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsMLC IsMLC { get; set; }

        /// <summary>
        /// Gets or sets MLCCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "MLCCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MLCCode, Id = Index.MLCCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string MLCCode { get; set; }

        /// <summary>
        /// Gets or sets SOAPNumber
        /// </summary>
        [StringLength(25, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SOAPNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SOAPNumber, Id = Index.SOAPNumber, FieldType = EntityFieldType.Char, Size = 25)]
        public string SOAPNumber { get; set; }

        /// <summary>
        /// Gets or sets PolicyGroupCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyGroupCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PolicyGroupCode, Id = Index.PolicyGroupCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string PolicyGroupCode { get; set; }

        /// <summary>
        /// Gets or sets PolicyGroupDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyGroupDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PolicyGroupDescription, Id = Index.PolicyGroupDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string PolicyGroupDescription { get; set; }

        /// <summary>
        /// Gets or sets PlanName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PlanName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PlanName, Id = Index.PlanName, FieldType = EntityFieldType.Char, Size = 60)]
        public string PlanName { get; set; }

        /// <summary>
        /// Gets or sets InsuranceName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsuranceName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InsuranceName, Id = Index.InsuranceName, FieldType = EntityFieldType.Char, Size = 60)]
        public string InsuranceName { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedBy", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CreatedBy, Id = Index.CreatedBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets CreatedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CreatedDate, Id = Index.CreatedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets ModifiedBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedBy", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ModifiedBy, Id = Index.ModifiedBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets ModifiedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ModifiedDate, Id = Index.ModifiedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets NumberOfBills
        /// </summary>
        [Display(Name = "NumberOfBills", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.NumberOfBills, Id = Index.NumberOfBills, FieldType = EntityFieldType.Int, Size = 2)]
        public short NumberOfBills { get; set; }

        /// <summary>
        /// Gets or sets ConsultBills
        /// </summary>
        [Display(Name = "ConsultBills", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultBills, Id = Index.ConsultBills, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ConsultBills ConsultBills { get; set; }

        /// <summary>
        /// Gets or sets RegisterBills
        /// </summary>
        [Display(Name = "RegisterBills", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.RegisterBills, Id = Index.RegisterBills, FieldType = EntityFieldType.Int, Size = 2)]
        public short RegisterBills { get; set; }

        /// <summary>
        /// Gets or sets TransferBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "TransferBy", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TransferBy, Id = Index.TransferBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string TransferBy { get; set; }

        /// <summary>
        /// Gets or sets TransferTime
        /// </summary>
        [Display(Name = "TransferTime", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TransferTime, Id = Index.TransferTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan TransferTime { get; set; }

        /// <summary>
        /// Gets or sets TransferredAdmissionCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "TransferredAdmissionCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TransferredAdmissionCode, Id = Index.TransferredAdmissionCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string TransferredAdmissionCode { get; set; }

        /// <summary>
        /// Gets or sets TransferReason
        /// </summary>
        [StringLength(250, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "TransferReason", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TransferReason, Id = Index.TransferReason, FieldType = EntityFieldType.Char, Size = 250)]
        public string TransferReason { get; set; }

        /// <summary>
        /// Gets or sets IsChronic
        /// </summary>
        [Display(Name = "IsChronic", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsChronic, Id = Index.IsChronic, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsChronic IsChronic { get; set; }

        /// <summary>
        /// Gets or sets UnitCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "UnitCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.UnitCode, Id = Index.UnitCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Gets or sets UnitDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "UnitDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.UnitDescription, Id = Index.UnitDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string UnitDescription { get; set; }

        /// <summary>
        /// Gets or sets DiscountCategoryCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DiscountCategoryCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DiscountCategoryCode, Id = Index.DiscountCategoryCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string DiscountCategoryCode { get; set; }

        /// <summary>
        /// Gets or sets DiscountCategoryDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DiscountCategoryDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DiscountCategoryDescription, Id = Index.DiscountCategoryDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string DiscountCategoryDescription { get; set; }

        /// <summary>
        /// Gets or sets AccidentRegCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AccidentRegCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AccidentRegCode, Id = Index.AccidentRegCode, FieldType = EntityFieldType.Char, Size = 22)]
        public string AccidentRegCode { get; set; }

        /// <summary>
        /// Gets or sets AccidentPlace
        /// </summary>
        [StringLength(70, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AccidentPlace", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AccidentPlace, Id = Index.AccidentPlace, FieldType = EntityFieldType.Char, Size = 70)]
        public string AccidentPlace { get; set; }

        /// <summary>
        /// Gets or sets PoliceStationName
        /// </summary>
        [StringLength(70, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PoliceStationName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PoliceStationName, Id = Index.PoliceStationName, FieldType = EntityFieldType.Char, Size = 70)]
        public string PoliceStationName { get; set; }

        /// <summary>
        /// Gets or sets IsIntimated
        /// </summary>
        [Display(Name = "IsIntimated", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsIntimated, Id = Index.IsIntimated, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsIntimated IsIntimated { get; set; }

        /// <summary>
        /// Gets or sets WoundCertifiedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "WoundCertifiedDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.WoundCertifiedDate, Id = Index.WoundCertifiedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime WoundCertifiedDate { get; set; }

        /// <summary>
        /// Gets or sets ExternalProviderCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ExternalProviderCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ExternalProviderCode, Id = Index.ExternalProviderCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string ExternalProviderCode { get; set; }

        /// <summary>
        /// Gets or sets ExternalProviderName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ExternalProviderName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ExternalProviderName, Id = Index.ExternalProviderName, FieldType = EntityFieldType.Char, Size = 60)]
        public string ExternalProviderName { get; set; }

        /// <summary>
        /// Gets or sets PatientType
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PatientType, Id = Index.PatientType, FieldType = EntityFieldType.Char, Size = 22)]
        public string PatientType { get; set; }

        /// <summary>
        /// Gets or sets VisitExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitExpiryDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitExpiryDate, Id = Index.VisitExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime VisitExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets SpecialityCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SpecialityCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SpecialityCode, Id = Index.SpecialityCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string SpecialityCode { get; set; }

        /// <summary>
        /// Gets or sets LimitUtilized
        /// </summary>
        [Display(Name = "LimitUtilized", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.LimitUtilized, Id = Index.LimitUtilized, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal LimitUtilized { get; set; }

        /// <summary>
        /// Gets or sets LimitBalance
        /// </summary>
        [Display(Name = "LimitBalance", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.LimitBalance, Id = Index.LimitBalance, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal LimitBalance { get; set; }

        /// <summary>
        /// Gets or sets OPLimitUtilized
        /// </summary>
        [Display(Name = "OPLimitUtilized", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.OPLimitUtilized, Id = Index.OPLimitUtilized, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal OPLimitUtilized { get; set; }

        /// <summary>
        /// Gets or sets OPLimitBalance
        /// </summary>
        [Display(Name = "OPLimitBalance", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.OPLimitBalance, Id = Index.OPLimitBalance, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal OPLimitBalance { get; set; }

        /// <summary>
        /// Gets or sets QueueNumber
        /// </summary>
        [Display(Name = "QueueNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.QueueNumber, Id = Index.QueueNumber, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal QueueNumber { get; set; }

        /// <summary>
        /// Gets or sets SpecialityDepartment
        /// </summary>
        [Display(Name = "SpecialityDepartment", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SpecialityDepartment, Id = Index.SpecialityDepartment, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SpecialityDepartment SpecialityDepartment { get; set; }

        /// <summary>
        /// Gets or sets PackageType
        /// </summary>
        [Display(Name = "PackageType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PackageType, Id = Index.PackageType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PackageType PackageType { get; set; }

        /// <summary>
        /// Gets or sets CheckedIn
        /// </summary>
        [Display(Name = "CheckedIn", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckedIn, Id = Index.CheckedIn, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CheckedIn CheckedIn { get; set; }

        /// <summary>
        /// Gets or sets ReferralEmployeeCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferralEmployeeCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferralEmployeeCode, Id = Index.ReferralEmployeeCode, FieldType = EntityFieldType.Char, Size = 22)]
        public string ReferralEmployeeCode { get; set; }

        /// <summary>
        /// Gets or sets EpisodeNo
        /// </summary>
        [Display(Name = "EpisodeNo", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EpisodeNo, Id = Index.EpisodeNo, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal EpisodeNo { get; set; }

        /// <summary>
        /// Gets or sets VisitFromAppointment
        /// </summary>
        [Display(Name = "VisitFromAppointment", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitFromAppointment, Id = Index.VisitFromAppointment, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitFromAppointment VisitFromAppointment { get; set; }

        /// <summary>
        /// Gets or sets InjuryCode
        /// </summary>
        [Display(Name = "InjuryCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InjuryCode, Id = Index.InjuryCode, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal InjuryCode { get; set; }

        /// <summary>
        /// Gets or sets MultiVisitPackageOrderCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "MultiVisitPackageOrderCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MultiVisitPackageOrderCode, Id = Index.MultiVisitPackageOrderCode, FieldType = EntityFieldType.Char, Size = 22)]
        public string MultiVisitPackageOrderCode { get; set; }

        /// <summary>
        /// Gets or sets PatientName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PatientName, Id = Index.PatientName, FieldType = EntityFieldType.Char, Size = 60)]
        public string PatientName { get; set; }

        /// <summary>
        /// Gets or sets ProviderName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ProviderName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ProviderName, Id = Index.ProviderName, FieldType = EntityFieldType.Char, Size = 60)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets DepartmentName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DepartmentName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DepartmentName, Id = Index.DepartmentName, FieldType = EntityFieldType.Char, Size = 60)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets ConsultName
        /// </summary>
        [StringLength(90, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ConsultName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultName, Id = Index.ConsultName, FieldType = EntityFieldType.Char, Size = 90)]
        public string ConsultName { get; set; }

        /// <summary>
        /// Gets or sets ReferredName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferredName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferredName, Id = Index.ReferredName, FieldType = EntityFieldType.Char, Size = 60)]
        public string ReferredName { get; set; }

        /// <summary>
        /// Gets or sets EmployeeName
        /// </summary>
        [StringLength(90, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "EmployeeName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EmployeeName, Id = Index.EmployeeName, FieldType = EntityFieldType.Char, Size = 90)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// Gets or sets ClinicDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ClinicDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ClinicDescription, Id = Index.ClinicDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string ClinicDescription { get; set; }

        /// <summary>
        /// Gets or sets PackageDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PackageDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PackageDescription, Id = Index.PackageDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string PackageDescription { get; set; }

        /// <summary>
        /// Gets or sets ReferralName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ReferralName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferralName, Id = Index.ReferralName, FieldType = EntityFieldType.Char, Size = 60)]
        public string ReferralName { get; set; }

        /// <summary>
        /// Gets or sets SpecialityDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SpecialityDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SpecialityDescription, Id = Index.SpecialityDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string SpecialityDescription { get; set; }

        /// <summary>
        /// Gets or sets ConsultationDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ConsultationDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationDescription, Id = Index.ConsultationDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string ConsultationDescription { get; set; }

        /// <summary>
        /// Gets or sets MLCDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "MLCDescription", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MLCDescription, Id = Index.MLCDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string MLCDescription { get; set; }

        /// <summary>
        /// Gets or sets TypeOfVisit
        /// </summary>
        [Display(Name = "TypeOfVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.TypeOfVisit, Id = Index.TypeOfVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.TypeOfVisit TypeOfVisit { get; set; }

        /// <summary>
        /// Gets or sets RegistrationDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "RegistrationDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.RegistrationDate, Id = Index.RegistrationDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Gets or sets IsFreeVisit
        /// </summary>
        [Display(Name = "IsFreeVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsFreeVisit, Id = Index.IsFreeVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsFreeVisit IsFreeVisit { get; set; }

        /// <summary>
        /// Gets or sets AgeYears
        /// </summary>
        [Display(Name = "AgeYears", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AgeYears, Id = Index.AgeYears, FieldType = EntityFieldType.Int, Size = 2)]
        public short AgeYears { get; set; }

        /// <summary>
        /// Gets or sets AgeMonths
        /// </summary>
        [Display(Name = "AgeMonths", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AgeMonths, Id = Index.AgeMonths, FieldType = EntityFieldType.Int, Size = 2)]
        public short AgeMonths { get; set; }

        /// <summary>
        /// Gets or sets AgeDays
        /// </summary>
        [Display(Name = "AgeDays", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AgeDays, Id = Index.AgeDays, FieldType = EntityFieldType.Int, Size = 2)]
        public short AgeDays { get; set; }

        /// <summary>
        /// Gets or sets Authorized
        /// </summary>
        [Display(Name = "Authorized", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Authorized, Id = Index.Authorized, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Authorized Authorized { get; set; }

        /// <summary>
        /// Gets or sets ProvisionalICDCompleted
        /// </summary>
        [Display(Name = "ProvisionalICDCompleted", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ProvisionalICDCompleted, Id = Index.ProvisionalICDCompleted, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ProvisionalICDCompleted ProvisionalICDCompleted { get; set; }

        /// <summary>
        /// Gets or sets FinalICDCompleted
        /// </summary>
        [Display(Name = "FinalICDCompleted", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.FinalICDCompleted, Id = Index.FinalICDCompleted, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.FinalICDCompleted FinalICDCompleted { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AuthorizationBy", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AuthorizationBy, Id = Index.AuthorizationBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string AuthorizationBy { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AuthorizationDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AuthorizationDate, Id = Index.AuthorizationDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime AuthorizationDate { get; set; }

        /// <summary>
        /// Gets or sets ConsultationSetup
        /// </summary>
        [Display(Name = "ConsultationSetup", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationSetup, Id = Index.ConsultationSetup, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ConsultationSetup ConsultationSetup { get; set; }

        /// <summary>
        /// Gets or sets EpisodeNumber
        /// </summary>
        [Display(Name = "EpisodeNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EpisodeNumber, Id = Index.EpisodeNumber, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or sets InsApplicationNumber
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsApplicationNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InsApplicationNumber, Id = Index.InsApplicationNumber, FieldType = EntityFieldType.Char, Size = 22)]
        public string InsApplicationNumber { get; set; }

        /// <summary>
        /// Gets or sets PrescriptionType
        /// </summary>
        [Display(Name = "PrescriptionType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PrescriptionType, Id = Index.PrescriptionType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PrescriptionType PrescriptionType { get; set; }

        /// <summary>
        /// Gets or sets AppointmentNumber
        /// </summary>
        [Display(Name = "AppointmentNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AppointmentNumber, Id = Index.AppointmentNumber, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal AppointmentNumber { get; set; }

        /// <summary>
        /// Gets or sets EncounterUniqueCode
        /// </summary>
        [Display(Name = "EncounterUniqueCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EncounterUniqueCode, Id = Index.EncounterUniqueCode, FieldType = EntityFieldType.Decimal, Size = 10)]
        public decimal EncounterUniqueCode { get; set; }

        /// <summary>
        /// Gets or sets NursingAssessmentStatus
        /// </summary>
        [Display(Name = "NursingAssessmentStatus", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.NursingAssessmentStatus, Id = Index.NursingAssessmentStatus, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.NursingAssessmentStatus NursingAssessmentStatus { get; set; }

        /// <summary>
        /// Gets or sets MultiVisitPackageType
        /// </summary>
        [Display(Name = "MultiVisitPackageType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MultiVisitPackageType, Id = Index.MultiVisitPackageType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.MultiVisitPackageType MultiVisitPackageType { get; set; }

        /// <summary>
        /// Gets or sets ApplicationDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ApplicationDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ApplicationDate, Id = Index.ApplicationDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime ApplicationDate { get; set; }

        /// <summary>
        /// Gets or sets EligibleAmount
        /// </summary>
        [Display(Name = "EligibleAmount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EligibleAmount, Id = Index.EligibleAmount, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal EligibleAmount { get; set; }

        /// <summary>
        /// Gets or sets EligibleType
        /// </summary>
        [Display(Name = "EligibleType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EligibleType, Id = Index.EligibleType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.EligibleType EligibleType { get; set; }

        /// <summary>
        /// Gets or sets IsFallRisk
        /// </summary>
        [Display(Name = "IsFallRisk", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsFallRisk, Id = Index.IsFallRisk, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsFallRisk IsFallRisk { get; set; }

        /// <summary>
        /// Gets or sets IsSecondaryPlan
        /// </summary>
        [Display(Name = "IsSecondaryPlan", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsSecondaryPlan, Id = Index.IsSecondaryPlan, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsSecondaryPlan IsSecondaryPlan { get; set; }

        /// <summary>
        /// Gets or sets SecondaryCustomerType
        /// </summary>
        [Display(Name = "SecondaryCustomerType", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryCustomerType, Id = Index.SecondaryCustomerType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SecondaryCustomerType SecondaryCustomerType { get; set; }

        /// <summary>
        /// Gets or sets SecondaryCustomerCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryCustomerCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryCustomerCode, Id = Index.SecondaryCustomerCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecondaryCustomerCode { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPolicyGroupCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryPolicyGroupCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryPolicyGroupCode, Id = Index.SecondaryPolicyGroupCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecondaryPolicyGroupCode { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPlanCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryPlanCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryPlanCode, Id = Index.SecondaryPlanCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecondaryPlanCode { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPolicyNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryPolicyNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryPolicyNumber, Id = Index.SecondaryPolicyNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string SecondaryPolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets HospitalName
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "HospitalName", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.HospitalName, Id = Index.HospitalName, FieldType = EntityFieldType.Char, Size = 50)]
        public string HospitalName { get; set; }

        /// <summary>
        /// Gets or sets Network
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "Network", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Network, Id = Index.Network, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string Network { get; set; }

        /// <summary>
        /// Gets or sets PolicyStartDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyStartDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PolicyStartDate, Id = Index.PolicyStartDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime PolicyStartDate { get; set; }

        /// <summary>
        /// Gets or sets PolicyExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyExpiryDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PolicyExpiryDate, Id = Index.PolicyExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime PolicyExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPolicyStartDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryPolicyStartDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryPolicyStartDate, Id = Index.SecondaryPolicyStartDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime SecondaryPolicyStartDate { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPolicyExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondaryPolicyExpiryDate", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondaryPolicyExpiryDate, Id = Index.SecondaryPolicyExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime SecondaryPolicyExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets SecondarySponsorCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondarySponsorCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.SecondarySponsorCode, Id = Index.SecondarySponsorCode, FieldType = EntityFieldType.Char, Size = 22)]
        public string SecondarySponsorCode { get; set; }

        /// <summary>
        /// Gets or sets EHRAlertMessage
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "EHRAlertMessage", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.EHRAlertMessage, Id = Index.EHRAlertMessage, FieldType = EntityFieldType.Char, Size = 60)]
        public string EHRAlertMessage { get; set; }

        /// <summary>
        /// Gets or sets ModifiedPrimaryPolicyNo
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedPrimaryPolicyNo", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ModifiedPrimaryPolicyNo, Id = Index.ModifiedPrimaryPolicyNo, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string ModifiedPrimaryPolicyNo { get; set; }

        /// <summary>
        /// Gets or sets ModifiedSecPolicyNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedSecPolicyNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ModifiedSecPolicyNumber, Id = Index.ModifiedSecPolicyNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string ModifiedSecPolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets VisitExistEnd
        /// </summary>
        [Display(Name = "VisitExistEnd", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitExistEnd, Id = Index.VisitExistEnd, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitExistEnd VisitExistEnd { get; set; }

        /// <summary>
        /// Gets or sets VisitExistEndTime
        /// </summary>
        [Display(Name = "VisitExistEndTime", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitExistEndTime, Id = Index.VisitExistEndTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan VisitExistEndTime { get; set; }

        /// <summary>
        /// Gets or sets IsConsent
        /// </summary>
        [Display(Name = "IsConsent", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsConsent, Id = Index.IsConsent, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsConsent IsConsent { get; set; }

        /// <summary>
        /// Gets or sets IsDisclosure
        /// </summary>
        [Display(Name = "IsDisclosure", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsDisclosure, Id = Index.IsDisclosure, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsDisclosure IsDisclosure { get; set; }

        /// <summary>
        /// Gets or sets HL7Message
        /// </summary>
        [Display(Name = "HL7Message", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.HL7Message, Id = Index.HL7Message, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.HL7Message HL7Message { get; set; }

        /// <summary>
        /// Gets or sets MaternityPatient
        /// </summary>
        [Display(Name = "MaternityPatient", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MaternityPatient, Id = Index.MaternityPatient, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.MaternityPatient MaternityPatient { get; set; }

        /// <summary>
        /// Gets or sets PreAuthorizationRequired
        /// </summary>
        [Display(Name = "PreAuthorizationRequired", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PreAuthorizationRequired, Id = Index.PreAuthorizationRequired, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PreAuthorizationRequired PreAuthorizationRequired { get; set; }

        /// <summary>
        /// Gets or sets Authorize
        /// </summary>
        [Display(Name = "Authorize", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Authorize, Id = Index.Authorize, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Authorize Authorize { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationStart
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AuthorizationStart", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AuthorizationStart, Id = Index.AuthorizationStart, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime AuthorizationStart { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationEnd
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AuthorizationEnd", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AuthorizationEnd, Id = Index.AuthorizationEnd, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime AuthorizationEnd { get; set; }

        /// <summary>
        /// Gets or sets PatientEmployerCode
        /// </summary>
        [StringLength(30, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientEmployerCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PatientEmployerCode, Id = Index.PatientEmployerCode, FieldType = EntityFieldType.Char, Size = 30)]
        public string PatientEmployerCode { get; set; }

        /// <summary>
        /// Gets or sets IPEMCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "IPEMCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IPEMCode, Id = Index.IPEMCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string IPEMCode { get; set; }

        /// <summary>
        /// Gets or sets AuthorizationNumber
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "AuthorizationNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AuthorizationNumber, Id = Index.AuthorizationNumber, FieldType = EntityFieldType.Char, Size = 22)]
        public string AuthorizationNumber { get; set; }

        /// <summary>
        /// Gets or sets ExternalMedication
        /// </summary>
        [Display(Name = "ExternalMedication", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ExternalMedication, Id = Index.ExternalMedication, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ExternalMedication ExternalMedication { get; set; }

        /// <summary>
        /// Gets or sets PharmacyVisit
        /// </summary>
        [Display(Name = "PharmacyVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PharmacyVisit, Id = Index.PharmacyVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PharmacyVisit PharmacyVisit { get; set; }

        /// <summary>
        /// Gets or sets DeliveryOrder
        /// </summary>
        [Display(Name = "DeliveryOrder", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DeliveryOrder, Id = Index.DeliveryOrder, FieldType = EntityFieldType.Int, Size = 2)]
        public short DeliveryOrder { get; set; }

        /// <summary>
        /// Gets or sets IntermediateVisit
        /// </summary>
        [Display(Name = "IntermediateVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IntermediateVisit, Id = Index.IntermediateVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public short IntermediateVisit { get; set; }

        /// <summary>
        /// Gets or sets Source
        /// </summary>
        [Display(Name = "Source", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Source, Id = Index.Source, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Source Source { get; set; }

        /// <summary>
        /// Gets or sets AvailFirst
        /// </summary>
        [Display(Name = "AvailFirst", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AvailFirst, Id = Index.AvailFirst, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.AvailFirst AvailFirst { get; set; }

        /// <summary>
        /// Gets or sets IsVideoConsultation
        /// </summary>
        [Display(Name = "IsVideoConsultation", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsVideoConsultation, Id = Index.IsVideoConsultation, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsVideoConsultation IsVideoConsultation { get; set; }

        /// <summary>
        /// Gets or sets DefaultEMCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DefaultEMCode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DefaultEMCode, Id = Index.DefaultEMCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string DefaultEMCode { get; set; }

        /// <summary>
        /// Gets or sets DiscountAmount
        /// </summary>
        [Display(Name = "DiscountAmount", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DiscountAmount, Id = Index.DiscountAmount, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets DiscountPercentage
        /// </summary>
        [Display(Name = "DiscountPercentage", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DiscountPercentage, Id = Index.DiscountPercentage, FieldType = EntityFieldType.Decimal, Size = 5, Precision = 5)]
        public decimal DiscountPercentage { get; set; }

        /// <summary>
        /// Gets or sets IsRIAYATIConsent
        /// </summary>
        [Display(Name = "IsRIAYATIConsent", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsRIAYATIConsent, Id = Index.IsRIAYATIConsent, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsRIAYATIConsent IsRIAYATIConsent { get; set; }

        /// <summary>
        /// Gets or sets InjuryValidationRequired
        /// </summary>
        [Display(Name = "InjuryValidationRequired", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InjuryValidationRequired, Id = Index.InjuryValidationRequired, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.InjuryValidationRequired InjuryValidationRequired { get; set; }

        /// <summary>
        /// Gets or sets InjuryIsOpen
        /// </summary>
        [Display(Name = "InjuryIsOpen", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InjuryIsOpen, Id = Index.InjuryIsOpen, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.InjuryIsOpen InjuryIsOpen { get; set; }

        /// <summary>
        /// Gets or sets VisitModified
        /// </summary>
        [Display(Name = "VisitModified", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitModified, Id = Index.VisitModified, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitModified VisitModified { get; set; }

        /// <summary>
        /// Gets or sets Command
        /// </summary>
        [Display(Name = "Command", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.Command, Id = Index.Command, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Command Command { get; set; }

        /// <summary>
        /// Gets or sets IsExtendEpisode
        /// </summary>
        [Display(Name = "IsExtendEpisode", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsExtendEpisode, Id = Index.IsExtendEpisode, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsExtendEpisode IsExtendEpisode { get; set; }

        /// <summary>
        /// Gets or sets ConsultationCheck
        /// </summary>
        [Display(Name = "ConsultationCheck", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ConsultationCheck, Id = Index.ConsultationCheck, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ConsultationCheck ConsultationCheck { get; set; }

        /// <summary>
        /// Gets or sets VisitDepartmentNumber
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitDepartmentNumber", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.VisitDepartmentNumber, Id = Index.VisitDepartmentNumber, FieldType = EntityFieldType.Char, Size = 60)]
        public string VisitDepartmentNumber { get; set; }

        /// <summary>
        /// Gets or sets AllergyFlag
        /// </summary>
        [Display(Name = "AllergyFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AllergyFlag, Id = Index.AllergyFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.AllergyFlag AllergyFlag { get; set; }

        /// <summary>
        /// Gets or sets InitialAssessmentFlag
        /// </summary>
        [Display(Name = "InitialAssessmentFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.InitialAssessmentFlag, Id = Index.InitialAssessmentFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.InitialAssessmentFlag InitialAssessmentFlag { get; set; }

        /// <summary>
        /// Gets or sets AlertFlag
        /// </summary>
        [Display(Name = "AlertFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AlertFlag, Id = Index.AlertFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.AlertFlag AlertFlag { get; set; }

        /// <summary>
        /// Gets or sets PatientComplainFlag
        /// </summary>
        [Display(Name = "PatientComplainFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.PatientComplainFlag, Id = Index.PatientComplainFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PatientComplainFlag PatientComplainFlag { get; set; }

        /// <summary>
        /// Gets or sets MessageCenterFlag
        /// </summary>
        [Display(Name = "MessageCenterFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MessageCenterFlag, Id = Index.MessageCenterFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.MessageCenterFlag MessageCenterFlag { get; set; }

        /// <summary>
        /// Gets or sets DoctorNotifyFlag
        /// </summary>
        [Display(Name = "DoctorNotifyFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.DoctorNotifyFlag, Id = Index.DoctorNotifyFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.DoctorNotifyFlag DoctorNotifyFlag { get; set; }

        /// <summary>
        /// Gets or sets OrdersFlag
        /// </summary>
        [Display(Name = "OrdersFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.OrdersFlag, Id = Index.OrdersFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.OrdersFlag OrdersFlag { get; set; }

        /// <summary>
        /// Gets or sets FallRiskFlag
        /// </summary>
        [Display(Name = "FallRiskFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.FallRiskFlag, Id = Index.FallRiskFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.FallRiskFlag FallRiskFlag { get; set; }

        /// <summary>
        /// Gets or sets ResultsFlag
        /// </summary>
        [Display(Name = "ResultsFlag", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ResultsFlag, Id = Index.ResultsFlag, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ResultsFlag ResultsFlag { get; set; }

        /// <summary>
        /// Gets or sets CheckBilled
        /// </summary>
        [Display(Name = "CheckBilled", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckBilled, Id = Index.CheckBilled, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CheckBilled CheckBilled { get; set; }

        /// <summary>
        /// Gets or sets CheckSpeciality
        /// </summary>
        [Display(Name = "CheckSpeciality", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.CheckSpeciality, Id = Index.CheckSpeciality, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CheckSpeciality CheckSpeciality { get; set; }

        /// <summary>
        /// Gets or sets MobileApp
        /// </summary>
        [Display(Name = "MobileApp", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.MobileApp, Id = Index.MobileApp, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.MobileApp MobileApp { get; set; }

        /// <summary>
        /// Gets or sets IsPreviousInitialVisit
        /// </summary>
        [Display(Name = "IsPreviousInitialVisit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsPreviousInitialVisit, Id = Index.IsPreviousInitialVisit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsPreviousInitialVisit IsPreviousInitialVisit { get; set; }

        /// <summary>
        /// Gets or sets IsOrdered
        /// </summary>
        [Display(Name = "IsOrdered", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsOrdered, Id = Index.IsOrdered, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsOrdered IsOrdered { get; set; }

        /// <summary>
        /// Gets or sets IsPreOrdered
        /// </summary>
        [Display(Name = "IsPreOrdered", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsPreOrdered, Id = Index.IsPreOrdered, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsPreOrdered IsPreOrdered { get; set; }

        /// <summary>
        /// Gets or sets LabAutomation
        /// </summary>
        [Display(Name = "LabAutomation", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.LabAutomation, Id = Index.LabAutomation, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.LabAutomation LabAutomation { get; set; }

        /// <summary>
        /// Gets or sets AdvanceAlert
        /// </summary>
        [Display(Name = "AdvanceAlert", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AdvanceAlert, Id = Index.AdvanceAlert, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.AdvanceAlert AdvanceAlert { get; set; }

        /// <summary>
        /// Gets or sets AdvanceUtilize
        /// </summary>
        [Display(Name = "AdvanceUtilize", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.AdvanceUtilize, Id = Index.AdvanceUtilize, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.AdvanceUtilize AdvanceUtilize { get; set; }

        /// <summary>
        /// Gets or sets ReferralVisitCheck
        /// </summary>
        [Display(Name = "ReferralVisitCheck", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ReferralVisitCheck, Id = Index.ReferralVisitCheck, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ReferralVisitCheck ReferralVisitCheck { get; set; }

        /// <summary>
        /// Gets or sets ApplyVisitLimit
        /// </summary>
        [Display(Name = "ApplyVisitLimit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ApplyVisitLimit, Id = Index.ApplyVisitLimit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ApplyVisitLimit ApplyVisitLimit { get; set; }

        /// <summary>
        /// Gets or sets ApplyCoPayLimit
        /// </summary>
        [Display(Name = "ApplyCoPayLimit", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.ApplyCoPayLimit, Id = Index.ApplyCoPayLimit, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.ApplyCoPayLimit ApplyCoPayLimit { get; set; }

        /// <summary>
        /// Gets or sets IPAddress
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "IPAddress", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IPAddress, Id = Index.IPAddress, FieldType = EntityFieldType.Char, Size = 15)]
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets IsConsultation
        /// </summary>
        [Display(Name = "IsConsultation", ResourceType = typeof (MSVisitResx))]
        [ViewField(Name = Fields.IsConsultation, Id = Index.IsConsultation, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsConsultation IsConsultation { get; set; }

        #region UI Strings

        /// <summary>
        /// Gets VisitType string value
        /// </summary>
        public string VisitTypeString => EnumUtility.GetStringValue(VisitType);

        /// <summary>
        /// Gets VisitClosed string value
        /// </summary>
        public string VisitClosedString => EnumUtility.GetStringValue(VisitClosed);

        /// <summary>
        /// Gets ReferenceType string value
        /// </summary>
        public string ReferenceTypeString => EnumUtility.GetStringValue(ReferenceType);

        /// <summary>
        /// Gets Billed string value
        /// </summary>
        public string BilledString => EnumUtility.GetStringValue(Billed);

        /// <summary>
        /// Gets CheckOut string value
        /// </summary>
        public string CheckOutString => EnumUtility.GetStringValue(CheckOut);

        /// <summary>
        /// Gets Inactive string value
        /// </summary>
        public string InactiveString => EnumUtility.GetStringValue(Inactive);

        /// <summary>
        /// Gets CustomerType string value
        /// </summary>
        public string CustomerTypeString => EnumUtility.GetStringValue(CustomerType);

        /// <summary>
        /// Gets CaseTransfer string value
        /// </summary>
        public string CaseTransferString => EnumUtility.GetStringValue(CaseTransfer);

        /// <summary>
        /// Gets CaseSelect string value
        /// </summary>
        public string CaseSelectString => EnumUtility.GetStringValue(CaseSelect);

        /// <summary>
        /// Gets SponsoredBy string value
        /// </summary>
        public string SponsoredByString => EnumUtility.GetStringValue(SponsoredBy);

        /// <summary>
        /// Gets IsEmergency string value
        /// </summary>
        public string IsEmergencyString => EnumUtility.GetStringValue(IsEmergency);

        /// <summary>
        /// Gets VisitPurpose string value
        /// </summary>
        public string VisitPurposeString => EnumUtility.GetStringValue(VisitPurpose);

        /// <summary>
        /// Gets IsPackagePatient string value
        /// </summary>
        public string IsPackagePatientString => EnumUtility.GetStringValue(IsPackagePatient);

        /// <summary>
        /// Gets FreeVisit string value
        /// </summary>
        public string FreeVisitString => EnumUtility.GetStringValue(FreeVisit);

        /// <summary>
        /// Gets IsReferring string value
        /// </summary>
        public string IsReferringString => EnumUtility.GetStringValue(IsReferring);

        /// <summary>
        /// Gets InitialVisit string value
        /// </summary>
        public string InitialVisitString => EnumUtility.GetStringValue(InitialVisit);

        /// <summary>
        /// Gets IsDeductibleCollected string value
        /// </summary>
        public string IsDeductibleCollectedString => EnumUtility.GetStringValue(IsDeductibleCollected);

        /// <summary>
        /// Gets IsMLC string value
        /// </summary>
        public string IsMLCString => EnumUtility.GetStringValue(IsMLC);

        /// <summary>
        /// Gets ConsultBills string value
        /// </summary>
        public string ConsultBillsString => EnumUtility.GetStringValue(ConsultBills);

        /// <summary>
        /// Gets IsChronic string value
        /// </summary>
        public string IsChronicString => EnumUtility.GetStringValue(IsChronic);

        /// <summary>
        /// Gets IsIntimated string value
        /// </summary>
        public string IsIntimatedString => EnumUtility.GetStringValue(IsIntimated);

        /// <summary>
        /// Gets SpecialityDepartment string value
        /// </summary>
        public string SpecialityDepartmentString => EnumUtility.GetStringValue(SpecialityDepartment);

        /// <summary>
        /// Gets PackageType string value
        /// </summary>
        public string PackageTypeString => EnumUtility.GetStringValue(PackageType);

        /// <summary>
        /// Gets CheckedIn string value
        /// </summary>
        public string CheckedInString => EnumUtility.GetStringValue(CheckedIn);

        /// <summary>
        /// Gets VisitFromAppointment string value
        /// </summary>
        public string VisitFromAppointmentString => EnumUtility.GetStringValue(VisitFromAppointment);

        /// <summary>
        /// Gets TypeOfVisit string value
        /// </summary>
        public string TypeOfVisitString => EnumUtility.GetStringValue(TypeOfVisit);

        /// <summary>
        /// Gets IsFreeVisit string value
        /// </summary>
        public string IsFreeVisitString => EnumUtility.GetStringValue(IsFreeVisit);

        /// <summary>
        /// Gets Authorized string value
        /// </summary>
        public string AuthorizedString => EnumUtility.GetStringValue(Authorized);

        /// <summary>
        /// Gets ProvisionalICDCompleted string value
        /// </summary>
        public string ProvisionalICDCompletedString => EnumUtility.GetStringValue(ProvisionalICDCompleted);

        /// <summary>
        /// Gets FinalICDCompleted string value
        /// </summary>
        public string FinalICDCompletedString => EnumUtility.GetStringValue(FinalICDCompleted);

        /// <summary>
        /// Gets ConsultationSetup string value
        /// </summary>
        public string ConsultationSetupString => EnumUtility.GetStringValue(ConsultationSetup);

        /// <summary>
        /// Gets PrescriptionType string value
        /// </summary>
        public string PrescriptionTypeString => EnumUtility.GetStringValue(PrescriptionType);

        /// <summary>
        /// Gets NursingAssessmentStatus string value
        /// </summary>
        public string NursingAssessmentStatusString => EnumUtility.GetStringValue(NursingAssessmentStatus);

        /// <summary>
        /// Gets MultiVisitPackageType string value
        /// </summary>
        public string MultiVisitPackageTypeString => EnumUtility.GetStringValue(MultiVisitPackageType);

        /// <summary>
        /// Gets EligibleType string value
        /// </summary>
        public string EligibleTypeString => EnumUtility.GetStringValue(EligibleType);

        /// <summary>
        /// Gets IsFallRisk string value
        /// </summary>
        public string IsFallRiskString => EnumUtility.GetStringValue(IsFallRisk);

        /// <summary>
        /// Gets IsSecondaryPlan string value
        /// </summary>
        public string IsSecondaryPlanString => EnumUtility.GetStringValue(IsSecondaryPlan);

        /// <summary>
        /// Gets SecondaryCustomerType string value
        /// </summary>
        public string SecondaryCustomerTypeString => EnumUtility.GetStringValue(SecondaryCustomerType);

        /// <summary>
        /// Gets VisitExistEnd string value
        /// </summary>
        public string VisitExistEndString => EnumUtility.GetStringValue(VisitExistEnd);

        /// <summary>
        /// Gets IsConsent string value
        /// </summary>
        public string IsConsentString => EnumUtility.GetStringValue(IsConsent);

        /// <summary>
        /// Gets IsDisclosure string value
        /// </summary>
        public string IsDisclosureString => EnumUtility.GetStringValue(IsDisclosure);

        /// <summary>
        /// Gets HL7Message string value
        /// </summary>
        public string HL7MessageString => EnumUtility.GetStringValue(HL7Message);

        /// <summary>
        /// Gets MaternityPatient string value
        /// </summary>
        public string MaternityPatientString => EnumUtility.GetStringValue(MaternityPatient);

        /// <summary>
        /// Gets PreAuthorizationRequired string value
        /// </summary>
        public string PreAuthorizationRequiredString => EnumUtility.GetStringValue(PreAuthorizationRequired);

        /// <summary>
        /// Gets Authorize string value
        /// </summary>
        public string AuthorizeString => EnumUtility.GetStringValue(Authorize);

        /// <summary>
        /// Gets ExternalMedication string value
        /// </summary>
        public string ExternalMedicationString => EnumUtility.GetStringValue(ExternalMedication);

        /// <summary>
        /// Gets PharmacyVisit string value
        /// </summary>
        public string PharmacyVisitString => EnumUtility.GetStringValue(PharmacyVisit);

        /// <summary>
        /// Gets Source string value
        /// </summary>
        public string SourceString => EnumUtility.GetStringValue(Source);

        /// <summary>
        /// Gets AvailFirst string value
        /// </summary>
        public string AvailFirstString => EnumUtility.GetStringValue(AvailFirst);

        /// <summary>
        /// Gets IsVideoConsultation string value
        /// </summary>
        public string IsVideoConsultationString => EnumUtility.GetStringValue(IsVideoConsultation);

        /// <summary>
        /// Gets IsRIAYATIConsent string value
        /// </summary>
        public string IsRIAYATIConsentString => EnumUtility.GetStringValue(IsRIAYATIConsent);

        /// <summary>
        /// Gets InjuryValidationRequired string value
        /// </summary>
        public string InjuryValidationRequiredString => EnumUtility.GetStringValue(InjuryValidationRequired);

        /// <summary>
        /// Gets InjuryIsOpen string value
        /// </summary>
        public string InjuryIsOpenString => EnumUtility.GetStringValue(InjuryIsOpen);

        /// <summary>
        /// Gets VisitModified string value
        /// </summary>
        public string VisitModifiedString => EnumUtility.GetStringValue(VisitModified);

        /// <summary>
        /// Gets Command string value
        /// </summary>
        public string CommandString => EnumUtility.GetStringValue(Command);

        /// <summary>
        /// Gets IsExtendEpisode string value
        /// </summary>
        public string IsExtendEpisodeString => EnumUtility.GetStringValue(IsExtendEpisode);

        /// <summary>
        /// Gets ConsultationCheck string value
        /// </summary>
        public string ConsultationCheckString => EnumUtility.GetStringValue(ConsultationCheck);

        /// <summary>
        /// Gets AllergyFlag string value
        /// </summary>
        public string AllergyFlagString => EnumUtility.GetStringValue(AllergyFlag);

        /// <summary>
        /// Gets InitialAssessmentFlag string value
        /// </summary>
        public string InitialAssessmentFlagString => EnumUtility.GetStringValue(InitialAssessmentFlag);

        /// <summary>
        /// Gets AlertFlag string value
        /// </summary>
        public string AlertFlagString => EnumUtility.GetStringValue(AlertFlag);

        /// <summary>
        /// Gets PatientComplainFlag string value
        /// </summary>
        public string PatientComplainFlagString => EnumUtility.GetStringValue(PatientComplainFlag);

        /// <summary>
        /// Gets MessageCenterFlag string value
        /// </summary>
        public string MessageCenterFlagString => EnumUtility.GetStringValue(MessageCenterFlag);

        /// <summary>
        /// Gets DoctorNotifyFlag string value
        /// </summary>
        public string DoctorNotifyFlagString => EnumUtility.GetStringValue(DoctorNotifyFlag);

        /// <summary>
        /// Gets OrdersFlag string value
        /// </summary>
        public string OrdersFlagString => EnumUtility.GetStringValue(OrdersFlag);

        /// <summary>
        /// Gets FallRiskFlag string value
        /// </summary>
        public string FallRiskFlagString => EnumUtility.GetStringValue(FallRiskFlag);

        /// <summary>
        /// Gets ResultsFlag string value
        /// </summary>
        public string ResultsFlagString => EnumUtility.GetStringValue(ResultsFlag);

        /// <summary>
        /// Gets CheckBilled string value
        /// </summary>
        public string CheckBilledString => EnumUtility.GetStringValue(CheckBilled);

        /// <summary>
        /// Gets CheckSpeciality string value
        /// </summary>
        public string CheckSpecialityString => EnumUtility.GetStringValue(CheckSpeciality);

        /// <summary>
        /// Gets MobileApp string value
        /// </summary>
        public string MobileAppString => EnumUtility.GetStringValue(MobileApp);

        /// <summary>
        /// Gets IsPreviousInitialVisit string value
        /// </summary>
        public string IsPreviousInitialVisitString => EnumUtility.GetStringValue(IsPreviousInitialVisit);

        /// <summary>
        /// Gets IsOrdered string value
        /// </summary>
        public string IsOrderedString => EnumUtility.GetStringValue(IsOrdered);

        /// <summary>
        /// Gets IsPreOrdered string value
        /// </summary>
        public string IsPreOrderedString => EnumUtility.GetStringValue(IsPreOrdered);

        /// <summary>
        /// Gets LabAutomation string value
        /// </summary>
        public string LabAutomationString => EnumUtility.GetStringValue(LabAutomation);

        /// <summary>
        /// Gets AdvanceAlert string value
        /// </summary>
        public string AdvanceAlertString => EnumUtility.GetStringValue(AdvanceAlert);

        /// <summary>
        /// Gets AdvanceUtilize string value
        /// </summary>
        public string AdvanceUtilizeString => EnumUtility.GetStringValue(AdvanceUtilize);

        /// <summary>
        /// Gets ReferralVisitCheck string value
        /// </summary>
        public string ReferralVisitCheckString => EnumUtility.GetStringValue(ReferralVisitCheck);

        /// <summary>
        /// Gets ApplyVisitLimit string value
        /// </summary>
        public string ApplyVisitLimitString => EnumUtility.GetStringValue(ApplyVisitLimit);

        /// <summary>
        /// Gets ApplyCoPayLimit string value
        /// </summary>
        public string ApplyCoPayLimitString => EnumUtility.GetStringValue(ApplyCoPayLimit);

        /// <summary>
        /// Gets IsConsultation string value
        /// </summary>
        public string IsConsultationString => EnumUtility.GetStringValue(IsConsultation);

        #endregion
    }
}
