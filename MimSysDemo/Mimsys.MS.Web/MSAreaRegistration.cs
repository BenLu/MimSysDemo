/* Copyright (c) 2024 Mimsys  All rights reserved. */

using System.Web.Mvc;
using System.Web.Optimization;

namespace Mimsys.MS.Web
{
    /// <summary>
    /// Class MSAreaRegistration.
    /// </summary>
    public class MSAreaRegistration : AreaRegistration
    {
        /// <summary>
        /// Gets Area Name
        /// </summary>
        /// <value>The name of the area.</value>
        /// <returns>The name of the area to register.</returns>
        public override string AreaName
        {
            get { return "MS"; }
        }

        /// <summary>
        /// Registers Area
        /// </summary>
        /// <param name="context">Encapsulates the information that is required in order to register the area.</param>
        public override void RegisterArea(AreaRegistrationContext context)
        {
            RegisterRoutes(context);
            RegisterBundles();
        }

        /// <summary>
        /// Register routes
        /// </summary>
        /// <param name="context">The context.</param>
        private void RegisterRoutes(AreaRegistrationContext context)
        {
            context.MapRoute("MS_Tenant", "{tenantAlias}/{session}/MS/{controller}/{action}/{id}",
            new { action = "Index", id = UrlParameter.Optional });
        }

        /// <summary>
        /// Register bundles
        /// </summary>
        private void RegisterBundles()
        {
            BundleRegistration.RegisterBundles(BundleTable.Bundles);
        }
    }
}