// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for MessageCenterFlag
    /// </summary>
    public enum MessageCenterFlag
    {
        /// <summary>
        /// Gets or sets No
        /// </summary>
        [EnumValue("No", typeof(MSVisitResx))]
        No = 0,
        /// <summary>
        /// Gets or sets Yes
        /// </summary>
        [EnumValue("Yes", typeof(MSVisitResx))]
        Yes = 1
    }
}