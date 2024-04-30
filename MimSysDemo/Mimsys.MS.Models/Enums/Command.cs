// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for Command
    /// </summary>
    public enum Command
    {
        /// <summary>
        /// Gets or sets InvalidProcessCall
        /// </summary>
        [EnumValue("InvalidProcessCall", typeof(PatientPolicyResx))]
        InvalidProcessCall = 0,
        /// <summary>
        /// Gets or sets UpdateMalafi
        /// </summary>
        [EnumValue("UpdateMalafi", typeof(PatientPolicyResx))]
        UpdateMalafi = 1
    }
}