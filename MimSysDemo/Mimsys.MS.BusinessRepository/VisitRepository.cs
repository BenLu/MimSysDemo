// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository.Base;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Enums;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Enums.ExportImport;
using Sage.CA.SBS.ERP.Sage300.Common.Models.ExportImport;
using Mimsys.MS.BusinessRepository.Mappers;
using Mimsys.MS.Interfaces.BusinessRepository;
using Mimsys.MS.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Exceptions;
using Sage.CA.SBS.ERP.Sage300.Common.Resources;

#endregion

namespace Mimsys.MS.BusinessRepository
{
    /// <summary>
    /// Class Visit Repository
    /// </summary>
    public class VisitRepository : BaseHeaderDetailRepository, IVisitRepository
    {
        #region Private Variables


        /// <summary>
        /// Business Entity - MS0510
        /// </summary>
        private IBusinessEntity _mSVisitEntity;

        /// <summary>
        /// Business Entity - MS0453
        /// </summary>
        private IBusinessEntity _mRDVisitEntity;

        /// <summary>
        /// Business Entity - MS0515
        /// </summary>
        private IBusinessEntity _patientPolicyEntity;

        /// <summary>
        /// Business Entity Mapper - MS0510
        /// </summary>
        private readonly MSVisitMapper<MSVisit> _mSVisitMapper;


        #endregion

        #region Constructors

        /// <summary>
        /// Sets Context and DBLink
        /// </summary>
        /// <param name="context">Context</param>
        public VisitRepository(Context context):base(context)
        {
            _mSVisitMapper = new MSVisitMapper<MSVisit>(context);
        
            CreateBusinessEntities();
        }

        #endregion

    
        #region Protected/public methods

        /// <summary>
        /// Additional Access Check for Export and Import
        /// </summary>
        /// <returns>User Access</returns>
        public UserAccess GetAccessRights()
        {

            var userAccess = base.GetAccessRights(_mSVisitEntity);
            if (SecurityCheck("MS" + "Import"))
            {
                userAccess.SecurityType |= SecurityType.Import;
            }
            if (SecurityCheck("MS" + "Export"))
            {
                userAccess.SecurityType |= SecurityType.Export;
            }
            return userAccess;
        }

         /// <summary>
        /// Open and compose business entities
        /// </summary>
        protected override void CreateBusinessEntities()
        {
            _mSVisitEntity = OpenEntity(MSVisit.EntityName, true);
            _mRDVisitEntity = OpenEntity(MRDVisit.EntityName, true);
            _patientPolicyEntity = OpenEntity(PatientPolicy.EntityName, true);
        }

        /// <summary>
        /// Get MSVisit based on the primary key
        /// </summary>
        /// <typeparam name="TKey">data type of the primary key</typeparam>
        /// <param name="id">key value</param>
        /// <returns>MSVisit</returns>
        public MSVisit GetById<TKey>(TKey id)
        {
            CheckRights(_mSVisitEntity, SecurityType.Inquire);
			_mSVisitEntity.Order = 0;
			_mSVisitEntity.SetValue(MSVisit.Fields.VisitCode, id.ToString(), true);
            return !_mSVisitEntity.Read(false) ? null : _mSVisitMapper.Map(_mSVisitEntity);
        }

       /// <summary>
        /// Save MSVisit record
        /// </summary>
        /// <param name="model">MSVisit model</param>
        /// <returns>MSVisit</returns>
        public MSVisit Save(MSVisit model)
        {
            CheckRights(_mSVisitEntity, SecurityType.Modify);

            _mSVisitMapper.Map(model, _mSVisitEntity);
            _mSVisitEntity.Update();
            
            return _mSVisitMapper.Map(_mSVisitEntity);
        }

        /// <summary>
        /// Add MSVisit record
        /// </summary>
        /// <param name="model">MSVisit model</param>
        /// <returns>MSVisit</returns>
        public MSVisit Add(MSVisit model)
        {
            CheckRights(_mSVisitEntity, SecurityType.Add);

            _mSVisitMapper.Map(model, _mSVisitEntity);
            _mSVisitEntity.Insert();
            
            return _mSVisitMapper.Map(_mSVisitEntity);
        }

        /// <summary>
        /// Delete MSVisit record
        /// </summary>
        /// <param name="filter">filter for deleting a record</param>
        /// <returns></returns>
        public MSVisit Delete(Expression<Func<MSVisit, Boolean>> filter)
        {
            CheckRights(_mSVisitEntity, SecurityType.Delete);
            if (Search(_mSVisitEntity, filter))
            {
                _mSVisitEntity.Delete();
            }
            else
            {
                throw ExceptionHelper.RowNotFoundException(CommonResx.DeleteFailedNoRecordMessage);
            }
            return _mSVisitMapper.Map(_mSVisitEntity);
        }

        /// <summary>
        /// Creates a new _mSVisitEntity record
        /// </summary>
        /// <returns>_mSVisitEntity viewModel</returns>
        public MSVisit CreateNewRecord()
        {
            CheckRights(_mSVisitEntity, SecurityType.Add);
            _mSVisitEntity.Init();
            return _mSVisitMapper.Map(_mSVisitEntity);
        }

        #endregion

        #region Export/Import

        /// <summary>
        /// Get export or import business entity property
        /// </summary>
        /// <param name="option">export/import option, default to null</param>
        /// <param name="isExport">true if for export, default to false</param>
        /// <returns>business entity property</returns>
        public override BusinessEntityProperty GetExportImportBusinessEntityProperty(string option = null, bool isExport = false)
        {
            var mSVisit = new BusinessEntityProperty(CommonUtil.EntityContextReplacement(MSVisit.EntityName, Context.ScreenContext.EntityContext), ViewKeyType.SystemGenerated /* FIXME ViewKeyType.UserSpecified */);
            var mRDVisit = new BusinessEntityProperty(CommonUtil.EntityContextReplacement(MRDVisit.EntityName, Context.ScreenContext.EntityContext), ViewKeyType.SystemGenerated /* FIXME ViewKeyType.UserSpecified */);
            var patientPolicy = new BusinessEntityProperty(CommonUtil.EntityContextReplacement(PatientPolicy.EntityName, Context.ScreenContext.EntityContext), ViewKeyType.SystemGenerated /* FIXME ViewKeyType.UserSpecified */);

            mSVisit.AddDetail(mRDVisit);
            mSVisit.AddDetail(patientPolicy);

            return mSVisit;
        }

        /// <summary>
        /// Get import types, i.e., insert, update, insert/update, etc.
        /// We only allow insert operation for batch type transactions.
        /// </summary>
        /// <param name="option">import option, default to null</param>
        /// <returns>a list of import types</returns>
        public override IEnumerable<ImportType> GetImportTypes(string option = null)
        {
            return new List<ImportType> { ImportType.Insert };
        }

        #endregion
    }
}

