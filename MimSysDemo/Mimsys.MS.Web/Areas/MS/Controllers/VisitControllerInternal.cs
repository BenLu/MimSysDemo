// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using System.Linq;
using Microsoft.Practices.Unity;
using System.Linq.Expressions;
using System.Collections.Generic;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Resources;
using Sage.CA.SBS.ERP.Sage300.Common.Web;
using Sage.CA.SBS.ERP.Sage300.Common.Web.Controllers.ExportImport;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository.Base;
using Mimsys.MS.Interfaces.BusinessRepository;
using Mimsys.MS.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Web.Areas.MS.Models;

#endregion

namespace Mimsys.MS.Web.Areas.MS.Controllers
{
    /// <summary>
    /// Visit Internal Controller
    /// </summary>
    public class VisitControllerInternal : ImportExportControllerInternal<IVisitRepository>
    {
        #region Private variables
         
        /// <summary>
        /// Variable for storing context.
        /// </summary>
        private readonly Context _context;

        private IVisitRepository _repository
        {
            get {
                return _context.Container.Resolve<IVisitRepository>(new ParameterOverride("context", _context));
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// New instance of <see cref="VisitControllerInternal"/>
        /// </summary>
        /// <param name="context">Context</param>
        public VisitControllerInternal(Context context)
            : base(context)
        {
            _context = context;
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Create a MSVisit
        /// </summary>
        /// <returns>view model for  MSVisit</returns>
        internal VisitViewModel Create()
        {
            var newData = _repository.CreateNewRecord();
            var viewModel = GetViewModel(newData, null);
            viewModel.UserAccess = GetAccessRights();

            return viewModel;
        }

        /// <summary>
        /// Get a MSVisit
        /// </summary>
        /// <param name="id">Id for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        internal VisitViewModel GetById(string id)
        {
            if (!string.IsNullOrEmpty(id))
            {
                var data = _repository.GetById(id);
                var userMessage = new UserMessage(data);

                return GetViewModel(data, userMessage);
            }
            else
            {
                return Create();
            }
        }
        /// <summary>
        /// Add a MSVisit
        /// </summary>
        /// <param name="model">Model for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        internal VisitViewModel Add(MSVisit model)
        {
            var data = _repository.Add(model);
            var userMessage = new UserMessage(data,
                string.Format(CommonResx.AddSuccessMessage, MSVisitResx.VisitCode, data.VisitCode));

            return GetViewModel(data, userMessage);
       }

        /// <summary>
        /// Update a MSVisit
        /// </summary>
        /// <param name="model">Model for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        internal VisitViewModel Save(MSVisit model)
        {
            var data = _repository.Save(model);
            var userMessage = new UserMessage(data, CommonResx.SaveSuccessMessage);

            return GetViewModel(data, userMessage);
        }

        /// <summary>
        /// Delete a MSVisit
        /// </summary>
        /// <param name="id">Id for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        internal VisitViewModel Delete(string id)
        {
			Expression<Func<MSVisit, bool>> filter = param => param.VisitCode == id;
			var data = _repository.Delete(filter);
            var userMessage = new UserMessage(data, string.Format(CommonResx.DeleteSuccessMessage, MSVisitResx.VisitCode, data.VisitCode));
            
            return GetViewModel(data, userMessage);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Generic routine to return a view model for MSVisit
        /// </summary>
        /// <param name="model">Model for MSVisit</param>
        /// <param name="userMessage">User Message for MSVisit</param>
        /// <returns>View Model for MSVisit</returns>
        private VisitViewModel GetViewModel(MSVisit model, UserMessage userMessage)
        {
            return new VisitViewModel
            {
                Data = model,
                UserMessage = userMessage
            };
        }

        #endregion

	}
}