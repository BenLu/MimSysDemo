// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for ConsultationSetup
    /// </summary>
    public enum ConsultationSetup
    {
        /// <summary>
        /// Gets or sets ProviderWise
        /// </summary>
        [EnumValue("ProviderWise", typeof(MSVisitResx))]
        ProviderWise = 1,
        /// <summary>
        /// Gets or sets DepartmentWise
        /// </summary>
        [EnumValue("DepartmentWise", typeof(MSVisitResx))]
        DepartmentWise = 2
    }
}