// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for SecondaryCustomerType
    /// </summary>
    public enum SecondaryCustomerType
    {
        /// <summary>
        /// Gets or sets Self
        /// </summary>
        [EnumValue("Self", typeof(MSVisitResx))]
        Self = 0,
        /// <summary>
        /// Gets or sets InsuranceCompany
        /// </summary>
        [EnumValue("InsuranceCompany", typeof(MSVisitResx))]
        InsuranceCompany = 1,
        /// <summary>
        /// Gets or sets CorporateClients
        /// </summary>
        [EnumValue("CorporateClients", typeof(MSVisitResx))]
        CorporateClients = 2,
        /// <summary>
        /// Gets or sets CriedtPatient
        /// </summary>
        [EnumValue("CriedtPatient", typeof(MSVisitResx))]
        CriedtPatient = 3
    }
}