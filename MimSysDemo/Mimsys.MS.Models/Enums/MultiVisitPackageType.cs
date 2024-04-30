// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for MultiVisitPackageType
    /// </summary>
    public enum MultiVisitPackageType
    {
        /// <summary>
        /// Gets or sets New
        /// </summary>
        [EnumValue("New", typeof(MSVisitResx))]
        New = 0,
        /// <summary>
        /// Gets or sets Existing
        /// </summary>
        [EnumValue("Existing", typeof(MSVisitResx))]
        Existing = 1
    }
}