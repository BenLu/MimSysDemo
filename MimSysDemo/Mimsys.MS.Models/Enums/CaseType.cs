// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for CaseType
    /// </summary>
    public enum CaseType
    {
        /// <summary>
        /// Gets or sets OP
        /// </summary>
        [EnumValue("OP", typeof(MRDVisitResx))]
        OP = 1,
        /// <summary>
        /// Gets or sets IP
        /// </summary>
        [EnumValue("IP", typeof(MRDVisitResx))]
        IP = 2
    }
}