// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for HL7Message
    /// </summary>
    public enum HL7Message
    {
        /// <summary>
        /// Gets or sets Success
        /// </summary>
        [EnumValue("Success", typeof(MSVisitResx))]
        Success = 0,
        /// <summary>
        /// Gets or sets Failure
        /// </summary>
        [EnumValue("Failure", typeof(MSVisitResx))]
        Failure = 1
    }
}