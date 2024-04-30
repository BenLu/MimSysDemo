// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for Inactive
    /// </summary>
    public enum Inactive
    {
        /// <summary>
        /// Gets or sets Active
        /// </summary>
        [EnumValue("Active", typeof(MRDVisitResx))]
        Active = 0,
        /// <summary>
        /// Gets or sets Inactive
        /// </summary>
        [EnumValue("Inactive", typeof(MRDVisitResx))]
        Inactive = 1
    }
}