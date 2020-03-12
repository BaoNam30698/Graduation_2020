using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Graduation.App.Web.Controllers
{
    public class HomeController : AppControllerBase
    {
        public ActionResult Index()
        {
            return View(); 
        }
	}
}