// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for VisitStatus
    /// </summary>
    public enum VisitStatus
    {
        /// <summary>
        /// Gets or sets Open
        /// </summary>
        [EnumValue("Open", typeof(MRDVisitResx))]
        Open = 0,
        /// <summary>
        /// Gets or sets Closed
        /// </summary>
        [EnumValue("Closed", typeof(MRDVisitResx))]
        Closed = 1,
        /// <summary>
        /// Gets or sets ClosedWithExceptions
        /// </summary>
        [EnumValue("ClosedWithExceptions", typeof(MRDVisitResx))]
        ClosedWithExceptions = 2
    }
}