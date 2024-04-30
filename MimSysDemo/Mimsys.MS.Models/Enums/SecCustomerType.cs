// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Models.Enums;

#endregion

namespace Mimsys.MS.Models.Enums
{
    /// <summary>
    /// Enum for SecCustomerType
    /// </summary>
    public enum SecCustomerType
    {
        /// <summary>
        /// Gets or sets Self
        /// </summary>
        [EnumValue("Self", typeof(PatientPolicyResx))]
        Self = 0,
        /// <summary>
        /// Gets or sets InsuranceCompany
        /// </summary>
        [EnumValue("InsuranceCompany", typeof(PatientPolicyResx))]
        InsuranceCompany = 1,
        /// <summary>
        /// Gets or sets CorporateClients
        /// </summary>
        [EnumValue("CorporateClients", typeof(PatientPolicyResx))]
        CorporateClients = 2,
        /// <summary>
        /// Gets or sets CriedtPatient
        /// </summary>
        [EnumValue("CriedtPatient", typeof(PatientPolicyResx))]
        CriedtPatient = 3,
        /// <summary>
        /// Gets or sets TPA
        /// </summary>
        [EnumValue("TPA", typeof(PatientPolicyResx))]
        TPA = 4
    }
}