// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for Source
    /// </summary>
    public enum Source
    {
        /// <summary>
        /// Gets or sets Manual
        /// </summary>
        [EnumValue("Manual", typeof(MSVisitResx))]
        Manual = 0,
        /// <summary>
        /// Gets or sets MobileCheckIn
        /// </summary>
        [EnumValue("MobileCheckIn", typeof(MSVisitResx))]
        MobileCheckIn = 1
    }
}