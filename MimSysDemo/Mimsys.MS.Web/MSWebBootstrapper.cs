/* Copyright (c) 2024 Mimsys  All rights reserved. */

using Mimsys.MS.Models;
using Mimsys.MS.Web.Areas.MS.Controllers;
using Sage.CA.SBS.ERP.Sage300.Common.Web.Controllers.ExportImport;
using Mimsys.MS.Interfaces.BusinessRepository;
using Microsoft.Practices.Unity;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Controller;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Repository;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;
using System.ComponentModel.Composition;
using System.Web.Mvc;

using Constants = Mimsys.MS.Web.Areas.MS.Constants;

namespace Mimsys.MS.Web
{
    /// <summary>
    /// MS Bootstrapper Class
    /// </summary>
    [Export(typeof(IBootstrapperTask))]
    [BootstrapMetadataExport("MS", new[] { BootstrapAppliesTo.Web }, 20)]
    public class MSWebBootstrapper : IBootstrapperTask
    {
        /// <summary>
        /// Bootstrap activity execution
        /// </summary>
        /// <param name="container">The Unity container</param>
        public void Execute(IUnityContainer container)
        {
            RegisterController(container);
            RegisterExportImportController(container);
        }

        /// <summary>
        /// Register controllers
        /// </summary>
        /// <param name="container">The Unity container</param>
        private void RegisterController(IUnityContainer container)
        {
			UnityUtil.RegisterType<IController, VisitController>(container, "MSVisit");
        }

        /// <summary>
        /// Register import/export controllers
        /// </summary>
        /// <param name="container">The Unity container</param>
        private void RegisterExportImportController(IUnityContainer container)
        {
			UnityUtil.RegisterType<IExportImportController, ImportExportControllerInternal<IVisitRepository>>(container, "msvisit", new InjectionConstructor(typeof(Context)));
        }
    }
}
