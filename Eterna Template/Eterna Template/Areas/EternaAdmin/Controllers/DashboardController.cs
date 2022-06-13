using Microsoft.AspNetCore.Mvc;

namespace Eterna_Template.Areas.EternaAdmin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("EternaAdmin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
