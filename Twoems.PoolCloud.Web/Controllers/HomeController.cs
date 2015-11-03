using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Twoems.PoolCloud.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PoolCloudControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}