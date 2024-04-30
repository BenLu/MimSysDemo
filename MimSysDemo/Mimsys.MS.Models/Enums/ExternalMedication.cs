// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for ExternalMedication
    /// </summary>
    public enum ExternalMedication
    {
        /// <summary>
        /// Gets or sets NotSelected
        /// </summary>
        [EnumValue("NotSelected", typeof(MSVisitResx))]
        NotSelected = 0,
        /// <summary>
        /// Gets or sets No
        /// </summary>
        [EnumValue("No", typeof(MSVisitResx))]
        No = 1,
        /// <summary>
        /// Gets or sets Yes
        /// </summary>
        [EnumValue("Yes", typeof(MSVisitResx))]
        Yes = 2
    }
}