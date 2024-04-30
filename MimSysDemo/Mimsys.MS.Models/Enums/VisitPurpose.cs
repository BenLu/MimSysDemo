// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for VisitPurpose
    /// </summary>
    public enum VisitPurpose
    {
        /// <summary>
        /// Gets or sets Consultation
        /// </summary>
        [EnumValue("Consultation", typeof(MSVisitResx))]
        Consultation = 1,
        /// <summary>
        /// Gets or sets Procedure
        /// </summary>
        [EnumValue("Procedure", typeof(MSVisitResx))]
        Procedure = 2,
        /// <summary>
        /// Gets or sets Documentation
        /// </summary>
        [EnumValue("Documentation", typeof(MSVisitResx))]
        Documentation = 3
    }
}