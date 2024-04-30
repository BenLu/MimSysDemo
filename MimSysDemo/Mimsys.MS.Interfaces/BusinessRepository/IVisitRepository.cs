
// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Mimsys.MS.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Repository;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Service;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using System.Linq.Expressions;
using System;
#endregion

namespace Mimsys.MS.Interfaces.BusinessRepository
{
    /// <summary>
    /// Interface IVisitRespository
    /// </summary>
    public interface IVisitRepository : ISecurity, ISecurityService, IImportExport 
    {
        /// <summary>
        /// Get a MSVisit record by id 
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="id">primary key value</param>
        /// <returns>MSVisitModel</returns>
        MSVisit GetById<TKey>(TKey id);

        /// <summary>
        /// Save MSVisit record
        /// </summary>
        /// <param name="model">MSVisit model</param>
        /// <returns></returns>
        MSVisit Save(MSVisit model);

        /// <summary>
        /// Insert MSVisit record
        /// </summary>
        /// <param name="model">MSVisit model</param>
        /// <returns></returns>
        MSVisit Add(MSVisit model);

        /// <summary>
        /// Delete MSVisit record
        /// </summary>
        /// <param name="filter">filter for deleting a record</param>
        /// <returns></returns>
        MSVisit Delete(Expression<Func<MSVisit, Boolean>> filter);

        /// <summary>
        /// Creates a new MSVisit record
        /// </summary>
        /// <returns>MSVisit viewModel</returns>
        MSVisit CreateNewRecord();
    }
}
