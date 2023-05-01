using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using NavesPortalforWebWithCoreMvc.Controllers.AuthFromIntranetController;

namespace NavesPortalforWebWithCoreMvc.Controllers.DIS
{
    [Authorize]
    [CheckSession]
    public class DisInspectionReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}