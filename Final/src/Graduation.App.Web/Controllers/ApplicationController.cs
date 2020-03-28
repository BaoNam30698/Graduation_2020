using Abp.Web.Mvc.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Graduation.App.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ApplicationController : AppControllerBase
    {
        // GET: Application
        public ActionResult Index()
        {
            return View("~/App/Main/common/layout/layout.cshtml");//Layout of the angular application.
        }
    }
}