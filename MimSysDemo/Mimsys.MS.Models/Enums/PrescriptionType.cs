// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for PrescriptionType
    /// </summary>
    public enum PrescriptionType
    {
        /// <summary>
        /// Gets or sets Cash
        /// </summary>
        [EnumValue("Cash", typeof(MSVisitResx))]
        Cash = 1,
        /// <summary>
        /// Gets or sets Credit
        /// </summary>
        [EnumValue("Credit", typeof(MSVisitResx))]
        Credit = 2
    }
}