// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for InitialVisit
    /// </summary>
    public enum InitialVisit
    {
        /// <summary>
        /// Gets or sets NewVisit
        /// </summary>
        [EnumValue("NewVisit", typeof(MSVisitResx))]
        NewVisit = 1,
        /// <summary>
        /// Gets or sets FreeVisit
        /// </summary>
        [EnumValue("FreeVisit", typeof(MSVisitResx))]
        FreeVisit = 2,
        /// <summary>
        /// Gets or sets PaidFollowUp
        /// </summary>
        [EnumValue("PaidFollowUp", typeof(MSVisitResx))]
        PaidFollowUp = 3,
        /// <summary>
        /// Gets or sets ReVisit
        /// </summary>
        [EnumValue("ReVisit", typeof(MSVisitResx))]
        ReVisit = 4
    }
}