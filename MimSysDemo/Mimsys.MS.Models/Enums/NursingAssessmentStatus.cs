// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for NursingAssessmentStatus
    /// </summary>
    public enum NursingAssessmentStatus
    {
        /// <summary>
        /// Gets or sets NotDone
        /// </summary>
        [EnumValue("NotDone", typeof(MSVisitResx))]
        NotDone = 0,
        /// <summary>
        /// Gets or sets Done
        /// </summary>
        [EnumValue("Done", typeof(MSVisitResx))]
        Done = 1,
        /// <summary>
        /// Gets or sets SendToProvider
        /// </summary>
        [EnumValue("SendToProvider", typeof(MSVisitResx))]
        SendToProvider = 2
    }
}