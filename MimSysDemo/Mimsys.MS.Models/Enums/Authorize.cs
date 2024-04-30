// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for Authorize
    /// </summary>
    public enum Authorize
    {
        /// <summary>
        /// Gets or sets Pending
        /// </summary>
        [EnumValue("Pending", typeof(MSVisitResx))]
        Pending = 1,
        /// <summary>
        /// Gets or sets Authorized
        /// </summary>
        [EnumValue("Authorized", typeof(MSVisitResx))]
        Authorized = 2,
        /// <summary>
        /// Gets or sets Rejected
        /// </summary>
        [EnumValue("Rejected", typeof(MSVisitResx))]
        Rejected = 3
    }
}