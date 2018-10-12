using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TeknoLabs.Crm.Controllers;

namespace TeknoLabs.Crm.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CrmControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
