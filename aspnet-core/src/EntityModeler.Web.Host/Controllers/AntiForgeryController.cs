using Microsoft.AspNetCore.Antiforgery;
using EntityModeler.Controllers;

namespace EntityModeler.Web.Host.Controllers
{
    public class AntiForgeryController : EntityModelerControllerBase
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
