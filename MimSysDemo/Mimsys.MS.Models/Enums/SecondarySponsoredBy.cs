// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for SecondarySponsoredBy
    /// </summary>
    public enum SecondarySponsoredBy
    {
        /// <summary>
        /// Gets or sets Self
        /// </summary>
        [EnumValue("Self", typeof(PatientPolicyResx))]
        Self = 0,
        /// <summary>
        /// Gets or sets Employer
        /// </summary>
        [EnumValue("Employer", typeof(PatientPolicyResx))]
        Employer = 1
    }
}