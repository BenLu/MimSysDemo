// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for PackageType
    /// </summary>
    public enum PackageType
    {
        /// <summary>
        /// Gets or sets StaticPackage
        /// </summary>
        [EnumValue("StaticPackage", typeof(MSVisitResx))]
        StaticPackage = 0,
        /// <summary>
        /// Gets or sets MultiVisitPackage
        /// </summary>
        [EnumValue("MultiVisitPackage", typeof(MSVisitResx))]
        MultiVisitPackage = 1
    }
}