using Microsoft.AspNetCore.Antiforgery;
using TeknoLabs.Crm.Controllers;

namespace TeknoLabs.Crm.Web.Host.Controllers
{
    public class AntiForgeryController : CrmControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
