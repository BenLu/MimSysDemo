// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for EligibleType
    /// </summary>
    public enum EligibleType
    {
        /// <summary>
        /// Gets or sets Visit
        /// </summary>
        [EnumValue("Visit", typeof(MSVisitResx))]
        Visit = 1,
        /// <summary>
        /// Gets or sets Service
        /// </summary>
        [EnumValue("Service", typeof(MSVisitResx))]
        Service = 2
    }
}