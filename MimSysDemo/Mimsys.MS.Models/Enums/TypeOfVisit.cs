// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for TypeOfVisit
    /// </summary>
    public enum TypeOfVisit
    {
        /// <summary>
        /// Gets or sets Others
        /// </summary>
        [EnumValue("Others", typeof(MSVisitResx))]
        Others = 0,
        /// <summary>
        /// Gets or sets NewVisit
        /// </summary>
        [EnumValue("NewVisit", typeof(MSVisitResx))]
        NewVisit = 1,
        /// <summary>
        /// Gets or sets ReVisit
        /// </summary>
        [EnumValue("ReVisit", typeof(MSVisitResx))]
        ReVisit = 2,
        /// <summary>
        /// Gets or sets ReferralVisit
        /// </summary>
        [EnumValue("ReferralVisit", typeof(MSVisitResx))]
        ReferralVisit = 3
    }
}