/* Copyright (c) 2024 Mimsys.  All rights reserved. */

using System.Web.Optimization;

namespace Mimsys.MS.Web
{
    /// <summary>
    /// Class for bundle registration
    /// </summary>
    internal static class BundleRegistration
    {
        /// <summary>
        /// Register bundles
        /// </summary>
        /// <param name="bundles"></param> 
        internal static void RegisterBundles(BundleCollection bundles)
        {
			#region Visit
			bundles.Add(new Bundle("~/bundles/MSVisit").Include(
				"~/Areas/MS/Scripts/Visit/Mimsys.MS.VisitBehaviour.js",
				"~/Areas/MS/Scripts/Visit/Mimsys.MS.VisitKoExtn.js",
				"~/Areas/MS/Scripts/Visit/Mimsys.MS.VisitRepository.js",
				"~/Areas/MS/Scripts/FinderDef.js",
				"~/Areas/Core/Scripts/Process/Sage.CA.SBS.Sage300.Common.Process.js"));
			#endregion


        }
    }
}
