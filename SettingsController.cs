﻿// // DotNetNuke® - http://www.dotnetnuke.com
// // Copyright (c) 2002-2012
// // by DotNetNuke Corporation
// // 
// // Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
// // documentation files (the "Software"), to deal in the Software without restriction, including without limitation 
// // the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and 
// // to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// // 
// // The above copyright notice and this permission notice shall be included in all copies or substantial portions 
// // of the Software.
// // 
// // THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// // TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// // THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// // CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// // DEALINGS IN THE SOFTWARE.

using System;
using System.Web.Mvc;
using DotNetNuke.Entities.Controllers;
using DotNetNuke.Web.Services;
using ExploreSettings.Testables;

namespace ExploreSettings
{
    /// <summary>
    /// Services Framework controller for accessing Settings
    /// <remarks>
    /// Path is DesktopModules/ExploreSettings/API/Settings/{action}
    /// </remarks>
    /// </summary>
    [SupportedModules("ExploreSettings")]
    [ValidateAntiForgeryToken]
    public class SettingsController : DnnController
    {
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult HostSettings()
        {
            var data = HostController.Instance.GetSettingsDictionary();

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult CurrentPortalSettings()
        {
            var data = TestablePortalController.Instance.GetPortalSettingsDictionary(PortalSettings.PortalId);

            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}