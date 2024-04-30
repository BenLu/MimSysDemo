// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for VideoConsultationEligiblity
    /// </summary>
    public enum VideoConsultationEligiblity
    {
        /// <summary>
        /// Gets or sets NotSelected
        /// </summary>
        [EnumValue("NotSelected", typeof(PatientPolicyResx))]
        NotSelected = 0,
        /// <summary>
        /// Gets or sets NotEligible
        /// </summary>
        [EnumValue("NotEligible", typeof(PatientPolicyResx))]
        NotEligible = 1,
        /// <summary>
        /// Gets or sets Eligible
        /// </summary>
        [EnumValue("Eligible", typeof(PatientPolicyResx))]
        Eligible = 2
    }
}