// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for IsConsultation
    /// </summary>
    public enum IsConsultation
    {
        /// <summary>
        /// Gets or sets No
        /// </summary>
        [EnumValue("No", typeof(MRDVisitResx))]
        No = 0,
        /// <summary>
        /// Gets or sets Yes
        /// </summary>
        [EnumValue("Yes", typeof(MRDVisitResx))]
        Yes = 1
    }
}