// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for VisitType
    /// </summary>
    public enum VisitType
    {
        /// <summary>
        /// Gets or sets Consultation
        /// </summary>
        [EnumValue("Consultation", typeof(MRDVisitResx))]
        Consultation = 1,
        /// <summary>
        /// Gets or sets Immunization
        /// </summary>
        [EnumValue("Immunization", typeof(MRDVisitResx))]
        Immunization = 2,
        /// <summary>
        /// Gets or sets FollowUp
        /// </summary>
        [EnumValue("FollowUp", typeof(MRDVisitResx))]
        FollowUp = 3,
        /// <summary>
        /// Gets or sets PostSurgical
        /// </summary>
        [EnumValue("PostSurgical", typeof(MRDVisitResx))]
        PostSurgical = 4,
        /// <summary>
        /// Gets or sets GeneralVisit
        /// </summary>
        [EnumValue("GeneralVisit", typeof(MRDVisitResx))]
        GeneralVisit = 5,
        /// <summary>
        /// Gets or sets NonConsultation
        /// </summary>
        [EnumValue("NonConsultation", typeof(MRDVisitResx))]
        NonConsultation = 6
    }
}