// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for ReferenceType
    /// </summary>
    public enum ReferenceType
    {
        /// <summary>
        /// Gets or sets NonReferral
        /// </summary>
        [EnumValue("NonReferral", typeof(MSVisitResx))]
        NonReferral = 0,
        /// <summary>
        /// Gets or sets Provider
        /// </summary>
        [EnumValue("Provider", typeof(MSVisitResx))]
        Provider = 1,
        /// <summary>
        /// Gets or sets Facility
        /// </summary>
        [EnumValue("Facility", typeof(MSVisitResx))]
        Facility = 2,
        /// <summary>
        /// Gets or sets Others
        /// </summary>
        [EnumValue("Others", typeof(MSVisitResx))]
        Others = 3,
        /// <summary>
        /// Gets or sets ExternalProvider
        /// </summary>
        [EnumValue("ExternalProvider", typeof(MSVisitResx))]
        ExternalProvider = 4
    }
}