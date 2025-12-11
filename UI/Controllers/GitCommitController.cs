using Core;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace UI.Controllers
{
    public class GitCommitController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new GitCommitPageModel();

            // Optionally: set culture for view (we'll use CultureInfo in view)
            ViewData["Lang"] = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpper();

            return View(model);
        }
    }
}
