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
    /// Partial class for PatientPolicy
    /// </summary>
    public partial class PatientPolicy : ModelBase
    {
        /// <summary>
        /// Gets or sets PatientCode
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientCode", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PatientCode, Id = Index.PatientCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string PatientCode { get; set; }

        /// <summary>
        /// Gets or sets MedicalAidCompany
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "MedicalAidCompany", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.MedicalAidCompany, Id = Index.MedicalAidCompany, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string MedicalAidCompany { get; set; }

        /// <summary>
        /// Gets or sets PlanCode
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PlanCode", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PlanCode, Id = Index.PlanCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string PlanCode { get; set; }

        /// <summary>
        /// Gets or sets PolicyNumber
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PolicyNumber, Id = Index.PolicyNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string PolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets StartDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "StartDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.StartDate, Id = Index.StartDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets ExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ExpiryDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.ExpiryDate, Id = Index.ExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets DeductibleBalance
        /// </summary>
        [Display(Name = "DeductibleBalance", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.DeductibleBalance, Id = Index.DeductibleBalance, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal DeductibleBalance { get; set; }

        /// <summary>
        /// Gets or sets CoPaymentAmount
        /// </summary>
        [Display(Name = "CoPaymentAmount", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CoPaymentAmount, Id = Index.CoPaymentAmount, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal CoPaymentAmount { get; set; }

        /// <summary>
        /// Gets or sets CurrentPrimaryInsurance
        /// </summary>
        [Display(Name = "CurrentPrimaryInsurance", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CurrentPrimaryInsurance, Id = Index.CurrentPrimaryInsurance, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CurrentPrimaryInsurance CurrentPrimaryInsurance { get; set; }

        /// <summary>
        /// Gets or sets AnnualDeductible
        /// </summary>
        [Display(Name = "AnnualDeductible", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.AnnualDeductible, Id = Index.AnnualDeductible, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal AnnualDeductible { get; set; }

        /// <summary>
        /// Gets or sets PrincipleType
        /// </summary>
        [Display(Name = "PrincipleType", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PrincipleType, Id = Index.PrincipleType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.PrincipleType PrincipleType { get; set; }

        /// <summary>
        /// Gets or sets InsuranceReferral
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsuranceReferral", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.InsuranceReferral, Id = Index.InsuranceReferral, FieldType = EntityFieldType.Char, Size = 15)]
        public string InsuranceReferral { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedBy", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CreatedBy, Id = Index.CreatedBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets CreatedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CreatedDate, Id = Index.CreatedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets ModifiedBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedBy", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.ModifiedBy, Id = Index.ModifiedBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// Gets or sets ModifiedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifiedDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.ModifiedDate, Id = Index.ModifiedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets CustomerType
        /// </summary>
        [Display(Name = "CustomerType", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CustomerType, Id = Index.CustomerType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CustomerType CustomerType { get; set; }

        /// <summary>
        /// Gets or sets SponsoredBy
        /// </summary>
        [Display(Name = "SponsoredBy", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SponsoredBy, Id = Index.SponsoredBy, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SponsoredBy SponsoredBy { get; set; }

        /// <summary>
        /// Gets or sets SponsorCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SponsorCode", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SponsorCode, Id = Index.SponsorCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string SponsorCode { get; set; }

        /// <summary>
        /// Gets or sets PlanType
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PlanType", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PlanType, Id = Index.PlanType, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string PlanType { get; set; }

        /// <summary>
        /// Gets or sets InsuranceIDPath
        /// </summary>
        [StringLength(150, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsuranceIDPath", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.InsuranceIDPath, Id = Index.InsuranceIDPath, FieldType = EntityFieldType.Char, Size = 150)]
        public string InsuranceIDPath { get; set; }

        /// <summary>
        /// Gets or sets PrincipalEmployeeNumber
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PrincipalEmployeeNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PrincipalEmployeeNumber, Id = Index.PrincipalEmployeeNumber, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string PrincipalEmployeeNumber { get; set; }

        /// <summary>
        /// Gets or sets EmployeeID
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "EmployeeID", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.EmployeeID, Id = Index.EmployeeID, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets EmployeeMRNNumber
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "EmployeeMRNNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.EmployeeMRNNumber, Id = Index.EmployeeMRNNumber, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string EmployeeMRNNumber { get; set; }

        /// <summary>
        /// Gets or sets InsApplicationRequired
        /// </summary>
        [Display(Name = "InsApplicationRequired", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.InsApplicationRequired, Id = Index.InsApplicationRequired, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.InsApplicationRequired InsApplicationRequired { get; set; }

        /// <summary>
        /// Gets or sets InsApplicationNumber
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "InsApplicationNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.InsApplicationNumber, Id = Index.InsApplicationNumber, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string InsApplicationNumber { get; set; }

        /// <summary>
        /// Gets or sets EmployerName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "EmployerName", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.EmployerName, Id = Index.EmployerName, FieldType = EntityFieldType.Char, Size = 60)]
        public string EmployerName { get; set; }

        /// <summary>
        /// Gets or sets OldExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "OldExpiryDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.OldExpiryDate, Id = Index.OldExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime OldExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets BasicSalary
        /// </summary>
        [Display(Name = "BasicSalary", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.BasicSalary, Id = Index.BasicSalary, FieldType = EntityFieldType.Decimal, Size = 10, Precision = 3)]
        public decimal BasicSalary { get; set; }

        /// <summary>
        /// Gets or sets NetworkYN
        /// </summary>
        [Display(Name = "NetworkYN", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.NetworkYN, Id = Index.NetworkYN, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.NetworkYN NetworkYN { get; set; }

        /// <summary>
        /// Gets or sets Network
        /// </summary>
        [StringLength(50, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "Network", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.Network, Id = Index.Network, FieldType = EntityFieldType.Char, Size = 50)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or sets SecondaryPlanApplicable
        /// </summary>
        [Display(Name = "SecondaryPlanApplicable", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecondaryPlanApplicable, Id = Index.SecondaryPlanApplicable, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SecondaryPlanApplicable SecondaryPlanApplicable { get; set; }

        /// <summary>
        /// Gets or sets SecInsuranceCompany
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecInsuranceCompany", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecInsuranceCompany, Id = Index.SecInsuranceCompany, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecInsuranceCompany { get; set; }

        /// <summary>
        /// Gets or sets SecPolicyGroupCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecPolicyGroupCode", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecPolicyGroupCode, Id = Index.SecPolicyGroupCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecPolicyGroupCode { get; set; }

        /// <summary>
        /// Gets or sets SecInsurancePolicy
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecInsurancePolicy", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecInsurancePolicy, Id = Index.SecInsurancePolicy, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecInsurancePolicy { get; set; }

        /// <summary>
        /// Gets or sets SecPolicyNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecPolicyNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecPolicyNumber, Id = Index.SecPolicyNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string SecPolicyNumber { get; set; }

        /// <summary>
        /// Gets or sets SecCustomerType
        /// </summary>
        [Display(Name = "SecCustomerType", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecCustomerType, Id = Index.SecCustomerType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SecCustomerType SecCustomerType { get; set; }

        /// <summary>
        /// Gets or sets SecStartDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecStartDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecStartDate, Id = Index.SecStartDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime SecStartDate { get; set; }

        /// <summary>
        /// Gets or sets SecExpiryDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecExpiryDate", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecExpiryDate, Id = Index.SecExpiryDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime SecExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets PrimaryInsuranceCardNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PrimaryInsuranceCardNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PrimaryInsuranceCardNumber, Id = Index.PrimaryInsuranceCardNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string PrimaryInsuranceCardNumber { get; set; }

        /// <summary>
        /// Gets or sets DependentNumber
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DependentNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.DependentNumber, Id = Index.DependentNumber, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string DependentNumber { get; set; }

        /// <summary>
        /// Gets or sets SecPlanCardNumber
        /// </summary>
        [StringLength(40, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecPlanCardNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecPlanCardNumber, Id = Index.SecPlanCardNumber, FieldType = EntityFieldType.Char, Size = 40, Mask = "%-40C")]
        public string SecPlanCardNumber { get; set; }

        /// <summary>
        /// Gets or sets SecPlanDependentNumber
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecPlanDependentNumber", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecPlanDependentNumber, Id = Index.SecPlanDependentNumber, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15C")]
        public string SecPlanDependentNumber { get; set; }

        /// <summary>
        /// Gets or sets SecondarySponsoredBy
        /// </summary>
        [Display(Name = "SecondarySponsoredBy", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecondarySponsoredBy, Id = Index.SecondarySponsoredBy, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.SecondarySponsoredBy SecondarySponsoredBy { get; set; }

        /// <summary>
        /// Gets or sets SecondarySponsorCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondarySponsorCode", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecondarySponsorCode, Id = Index.SecondarySponsorCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string SecondarySponsorCode { get; set; }

        /// <summary>
        /// Gets or sets SecondarySponsorName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SecondarySponsorName", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SecondarySponsorName, Id = Index.SecondarySponsorName, FieldType = EntityFieldType.Char, Size = 60)]
        public string SecondarySponsorName { get; set; }

        /// <summary>
        /// Gets or sets FundBrandID
        /// </summary>
        [StringLength(3, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "FundBrandID", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.FundBrandID, Id = Index.FundBrandID, FieldType = EntityFieldType.Char, Size = 3, Mask = "%-3A")]
        public string FundBrandID { get; set; }

        /// <summary>
        /// Gets or sets UniversalPatientIdentifierUPI
        /// </summary>
        [StringLength(2, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "UniversalPatientIdentifierUPI", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.UniversalPatientIdentifierUPI, Id = Index.UniversalPatientIdentifierUPI, FieldType = EntityFieldType.Char, Size = 2, Mask = "%-2D")]
        public string UniversalPatientIdentifierUPI { get; set; }

        /// <summary>
        /// Gets or sets VideoConsultationEligiblity
        /// </summary>
        [Display(Name = "VideoConsultationEligiblity", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.VideoConsultationEligiblity, Id = Index.VideoConsultationEligiblity, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VideoConsultationEligiblity VideoConsultationEligiblity { get; set; }

        /// <summary>
        /// Gets or sets CompanyName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CompanyName", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.CompanyName, Id = Index.CompanyName, FieldType = EntityFieldType.Char, Size = 60)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets PolicyName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyName", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PolicyName, Id = Index.PolicyName, FieldType = EntityFieldType.Char, Size = 60)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or sets PolicyDescription
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PolicyDescription", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PolicyDescription, Id = Index.PolicyDescription, FieldType = EntityFieldType.Char, Size = 60)]
        public string PolicyDescription { get; set; }

        /// <summary>
        /// Gets or sets Command
        /// </summary>
        [Display(Name = "Command", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.Command, Id = Index.Command, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Command Command { get; set; }

        // TODO The naming convention of this property has to be manually evaluated
        /// <summary>
        /// Gets or sets VISITID
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VISITID", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.VISITID, Id = Index.VISITID, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string VISITID { get; set; }

        // TODO The naming convention of this property has to be manually evaluated
        /// <summary>
        /// Gets or sets PRPOLEXPDT
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PRPOLEXPDT", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.PRPOLEXPDT, Id = Index.PRPOLEXPDT, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime PRPOLEXPDT { get; set; }

        // TODO The naming convention of this property has to be manually evaluated
        /// <summary>
        /// Gets or sets SEPOLEXPDT
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "SEPOLEXPDT", ResourceType = typeof (PatientPolicyResx))]
        [ViewField(Name = Fields.SEPOLEXPDT, Id = Index.SEPOLEXPDT, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime SEPOLEXPDT { get; set; }

        #region UI Strings

        /// <summary>
        /// Gets CurrentPrimaryInsurance string value
        /// </summary>
        public string CurrentPrimaryInsuranceString => EnumUtility.GetStringValue(CurrentPrimaryInsurance);

        /// <summary>
        /// Gets PrincipleType string value
        /// </summary>
        public string PrincipleTypeString => EnumUtility.GetStringValue(PrincipleType);

        /// <summary>
        /// Gets CustomerType string value
        /// </summary>
        public string CustomerTypeString => EnumUtility.GetStringValue(CustomerType);

        /// <summary>
        /// Gets SponsoredBy string value
        /// </summary>
        public string SponsoredByString => EnumUtility.GetStringValue(SponsoredBy);

        /// <summary>
        /// Gets InsApplicationRequired string value
        /// </summary>
        public string InsApplicationRequiredString => EnumUtility.GetStringValue(InsApplicationRequired);

        /// <summary>
        /// Gets NetworkYN string value
        /// </summary>
        public string NetworkYNString => EnumUtility.GetStringValue(NetworkYN);

        /// <summary>
        /// Gets SecondaryPlanApplicable string value
        /// </summary>
        public string SecondaryPlanApplicableString => EnumUtility.GetStringValue(SecondaryPlanApplicable);

        /// <summary>
        /// Gets SecCustomerType string value
        /// </summary>
        public string SecCustomerTypeString => EnumUtility.GetStringValue(SecCustomerType);

        /// <summary>
        /// Gets SecondarySponsoredBy string value
        /// </summary>
        public string SecondarySponsoredByString => EnumUtility.GetStringValue(SecondarySponsoredBy);

        /// <summary>
        /// Gets VideoConsultationEligiblity string value
        /// </summary>
        public string VideoConsultationEligiblityString => EnumUtility.GetStringValue(VideoConsultationEligiblity);

        /// <summary>
        /// Gets Command string value
        /// </summary>
        public string CommandString => EnumUtility.GetStringValue(Command);

        #endregion
    }
}
