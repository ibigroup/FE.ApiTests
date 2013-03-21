// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="IBI Group">
//   (c) Copyright IBI Group. Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// </copyright>
// <summary>
//   Defines the HomeController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ibi.Fe.ApiTests.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// Main controller for home page items.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Main home page.
        /// </summary>
        /// <returns>A view with the main home page.</returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}
