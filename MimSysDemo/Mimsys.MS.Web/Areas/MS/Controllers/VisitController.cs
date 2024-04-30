// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using Microsoft.Practices.Unity;
using System.Web.Mvc;
using Sage.CA.SBS.ERP.Sage300.Common.Exceptions;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Enums;
using Sage.CA.SBS.ERP.Sage300.Common.Resources;
using Sage.CA.SBS.ERP.Sage300.Common.Web;
using Mimsys.MS.Models;
using Mimsys.MS.Resources.Forms;
using Mimsys.MS.Web.Areas.MS.Models;

#endregion

namespace Mimsys.MS.Web.Areas.MS.Controllers
{
    /// <summary>
    /// Visit Public Controller
    /// </summary>
    public class VisitController : MultitenantControllerBase<VisitViewModel>
    {
        #region Public variables

        /// <summary>
        /// Gets or sets the internal controller
        /// </summary>
        public VisitControllerInternal ControllerInternal { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for Visit
        /// </summary>
        /// <param name="container">Unity Container</param>
        public VisitController(IUnityContainer container)
            : base(container,"MSVisit")
        {
        }

        #endregion

        #region Initialize MultitenantControllerBase

        /// <summary>
        /// Override Initialize method
        /// </summary>
        /// <param name="requestContext">Request Context</param>
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ControllerInternal = new VisitControllerInternal(Context);
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Load screen
        /// </summary>
        /// <param name="id">Id for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        public virtual ActionResult Index(string id)
        {
			ViewBag.MRDVisitGrid = ControllerInternal.CreateGridDefinitionAndPreference(GetGridJsonFilePath("MRDVisitGrid"));
ViewBag.PatientPolicyGrid = ControllerInternal.CreateGridDefinitionAndPreference(GetGridJsonFilePath("PatientPolicyGrid"));
            return ViewWithCatch(() => ControllerInternal.GetById(id),
                CommonResx.GetFailedMessage, MSVisitResx.VisitCode);
        }

        /// <summary>
        /// Get MSVisit
        /// </summary>
        /// <param name="id">Id for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        [HttpPost]
        public virtual JsonNetResult Get(string id)
        {
            return CallWithCatch(() => ControllerInternal.GetById(id),
                CommonResx.GetFailedMessage, MSVisitResx.VisitCode);
        }

		/// <summary>
        /// Add MSVisit
        /// </summary>
        /// <param name="model">Model for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        [HttpPost]
        public virtual JsonNetResult Add(MSVisit model)
        {
            if (!ValidateModelState(ModelState, out ViewModelBase<ModelBase> viewModel))
            {
                return JsonNet(viewModel);
            }

            return CallWithCatch(() => ControllerInternal.Add(model),
                CommonResx.AddFailedMessage, MSVisitResx.VisitCode);
        }

        /// <summary>
        /// Create MSVisit
        /// </summary>
        /// <returns>JSON object for MSVisit</returns>
        [HttpPost]
        public virtual JsonNetResult Create()
        {
            return CallWithCatch(() => ControllerInternal.Create(),
                CommonResx.UnhandledExceptionMessage);
        }

        /// <summary>
        /// Update MSVisit
        /// </summary>
        /// <param name="model">Model for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        [HttpPost]
        public virtual JsonNetResult Save(MSVisit model)
        {
            if (!ValidateModelState(ModelState, out ViewModelBase<ModelBase> viewModel))
            {
                return JsonNet(viewModel);
            }

            return CallWithCatch(() => ControllerInternal.Save(model),
                CommonResx.SaveFailedMessage);
        }

        /// <summary>
        /// Delete MSVisit
        /// </summary>
        /// <param name="id">Id for MSVisit</param>
        /// <returns>JSON object for MSVisit</returns>
        [HttpPost]
        public virtual JsonNetResult Delete(string id)
        {
            return CallWithCatch(() => ControllerInternal.Delete(id),
                CommonResx.DeleteFailedMessage, MSVisitResx.VisitCode);
        }

        #endregion
    }
}