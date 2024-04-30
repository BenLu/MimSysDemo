// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for MaternityPatient
    /// </summary>
    public enum MaternityPatient
    {
        /// <summary>
        /// Gets or sets OPD
        /// </summary>
        [EnumValue("OPD", typeof(MSVisitResx))]
        OPD = 0,
        /// <summary>
        /// Gets or sets Maternity
        /// </summary>
        [EnumValue("Maternity", typeof(MSVisitResx))]
        Maternity = 1,
        /// <summary>
        /// Gets or sets Dental
        /// </summary>
        [EnumValue("Dental", typeof(MSVisitResx))]
        Dental = 2,
        /// <summary>
        /// Gets or sets Ophthalmology
        /// </summary>
        [EnumValue("Ophthalmology", typeof(MSVisitResx))]
        Ophthalmology = 3,
        /// <summary>
        /// Gets or sets Dermatology
        /// </summary>
        [EnumValue("Dermatology", typeof(MSVisitResx))]
        Dermatology = 4
    }
}