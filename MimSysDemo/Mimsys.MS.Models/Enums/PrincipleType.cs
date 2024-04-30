// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for PrincipleType
    /// </summary>
    public enum PrincipleType
    {
        /// <summary>
        /// Gets or sets Principal
        /// </summary>
        [EnumValue("Principal", typeof(PatientPolicyResx))]
        Principal = 0,
        /// <summary>
        /// Gets or sets Dependent
        /// </summary>
        [EnumValue("Dependent", typeof(PatientPolicyResx))]
        Dependent = 1
    }
}