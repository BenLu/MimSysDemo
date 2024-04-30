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
    /// Partial class for MRDVisit
    /// </summary>
    public partial class MRDVisit : ModelBase
    {
        /// <summary>
        /// Gets or sets VisitCode
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitCode", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.VisitCode, Id = Index.VisitCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string VisitCode { get; set; }

        /// <summary>
        /// Gets or sets VisitDate
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitDate", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.VisitDate, Id = Index.VisitDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime VisitDate { get; set; }

        /// <summary>
        /// Gets or sets VisitTime
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "VisitTime", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.VisitTime, Id = Index.VisitTime, FieldType = EntityFieldType.Time, Size = 5)]
        public TimeSpan VisitTime { get; set; }

        /// <summary>
        /// Gets or sets ProviderCode
        /// </summary>
        [Key]
        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ProviderCode", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.ProviderCode, Id = Index.ProviderCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string ProviderCode { get; set; }

        /// <summary>
        /// Gets or sets DepartmentCode
        /// </summary>
        [StringLength(15, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DepartmentCode", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.DepartmentCode, Id = Index.DepartmentCode, FieldType = EntityFieldType.Char, Size = 15, Mask = "%-15N")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// Gets or sets DepartmentName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "DepartmentName", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.DepartmentName, Id = Index.DepartmentName, FieldType = EntityFieldType.Char, Size = 60)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Gets or sets PatientCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientCode", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.PatientCode, Id = Index.PatientCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string PatientCode { get; set; }

        /// <summary>
        /// Gets or sets PatientName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "PatientName", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.PatientName, Id = Index.PatientName, FieldType = EntityFieldType.Char, Size = 60)]
        public string PatientName { get; set; }

        /// <summary>
        /// Gets or sets ProviderName
        /// </summary>
        [StringLength(60, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ProviderName", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.ProviderName, Id = Index.ProviderName, FieldType = EntityFieldType.Char, Size = 60)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Gets or sets CaseType
        /// </summary>
        [Display(Name = "CaseType", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.CaseType, Id = Index.CaseType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.CaseType CaseType { get; set; }

        /// <summary>
        /// Gets or sets VisitStatus
        /// </summary>
        [Display(Name = "VisitStatus", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.VisitStatus, Id = Index.VisitStatus, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitStatus VisitStatus { get; set; }

        /// <summary>
        /// Gets or sets Inactive
        /// </summary>
        [Display(Name = "Inactive", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.Inactive, Id = Index.Inactive, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.Inactive Inactive { get; set; }

        /// <summary>
        /// Gets or sets IsConsultation
        /// </summary>
        [Display(Name = "IsConsultation", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.IsConsultation, Id = Index.IsConsultation, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.IsConsultation IsConsultation { get; set; }

        /// <summary>
        /// Gets or sets CreatedBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedBy", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.CreatedBy, Id = Index.CreatedBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets CreatedDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "CreatedDate", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.CreatedDate, Id = Index.CreatedDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets ModifyBy
        /// </summary>
        [StringLength(8, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifyBy", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.ModifyBy, Id = Index.ModifyBy, FieldType = EntityFieldType.Char, Size = 8, Mask = "%-8N")]
        public string ModifyBy { get; set; }

        /// <summary>
        /// Gets or sets ModifyDate
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "ModifyDate", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.ModifyDate, Id = Index.ModifyDate, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// Gets or sets LastMaintained
        /// </summary>
        [ValidateDateFormat(ErrorMessageResourceName="DateFormat", ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "LastMaintained", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.LastMaintained, Id = Index.LastMaintained, FieldType = EntityFieldType.Date, Size = 5)]
        public DateTime LastMaintained { get; set; }

        /// <summary>
        /// Gets or sets BillingCode
        /// </summary>
        [StringLength(22, ErrorMessageResourceName = "MaxLength",ErrorMessageResourceType = typeof(AnnotationsResx))]
        [Display(Name = "BillingCode", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.BillingCode, Id = Index.BillingCode, FieldType = EntityFieldType.Char, Size = 22, Mask = "%-22C")]
        public string BillingCode { get; set; }

        /// <summary>
        /// Gets or sets VisitType
        /// </summary>
        [Display(Name = "VisitType", ResourceType = typeof (MRDVisitResx))]
        [ViewField(Name = Fields.VisitType, Id = Index.VisitType, FieldType = EntityFieldType.Int, Size = 2)]
        public Mimsys.MS.Models.Enums.VisitType VisitType { get; set; }

        #region UI Strings

        /// <summary>
        /// Gets CaseType string value
        /// </summary>
        public string CaseTypeString => EnumUtility.GetStringValue(CaseType);

        /// <summary>
        /// Gets VisitStatus string value
        /// </summary>
        public string VisitStatusString => EnumUtility.GetStringValue(VisitStatus);

        /// <summary>
        /// Gets Inactive string value
        /// </summary>
        public string InactiveString => EnumUtility.GetStringValue(Inactive);

        /// <summary>
        /// Gets IsConsultation string value
        /// </summary>
        public string IsConsultationString => EnumUtility.GetStringValue(IsConsultation);

        /// <summary>
        /// Gets VisitType string value
        /// </summary>
        public string VisitTypeString => EnumUtility.GetStringValue(VisitType);

        #endregion
    }
}
