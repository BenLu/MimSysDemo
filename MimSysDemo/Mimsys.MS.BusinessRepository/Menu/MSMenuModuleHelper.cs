/* Copyright (c) 2024 Mimsys  All rights reserved. */

using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository.Menu;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Bootstrap;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Repository.Menu;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.Models.Portal;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace Mimsys.BusinessRepository.Menu
{
    /// <summary>
    /// MS Menu Module helper
    /// </summary>
    [Export(typeof(IMenuModuleHelper))]
    [BootstrapMetadataExport("MS", new[] { BootstrapAppliesTo.Web }, 10)]
    class MSMenuModuleHelper : AbstractMenuModuleHelper
    {
        /// <summary>
        /// Return Module specified
        /// </summary>
        public override string Module
        {
            get { return "MS"; }
        }

        /// <summary>
        /// Return Name of the screen file
        /// </summary>
        public override string MenuDetailFileName
        {
            get { return "MSMenuDetails.xml"; }
        }

        /// <summary>
        /// Return MultiCurrency status
        /// </summary>
        public bool IsMultiCurrency { get; private set; }

        /// <summary>
        /// Initialize the module manager
        /// </summary>
        /// <param name="company">string</param>
        /// <param name="context">Context</param>
        public override void Initialize(string company, Context context)
        {
            PrepareDataFile(company);
        }

        /// <summary>
        /// Return Menu Items with activation filter applied
        /// </summary>
        /// <returns>List</returns>
        public override List<NavigableMenu> GetFilteredMenuItems()
        {
            var criteriaList = new List<Func<NavigableMenu, bool>>();
            return GetApplyFilteredMenuItems(criteriaList);
        }


        /// <summary>
        /// Flag to indicate whether the menu is third party development menu
        /// </summary>
        public override bool IsPlugInMenu
        {
            get { return true; }
        }
    }
}
