using Core;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;
using System.Globalization;

namespace UI.Controllers
{
    public class GitFlowController : Controller
    {
        private readonly IGitFlowService _gitFlow;
        private readonly IVersionService _versionService;

        public GitFlowController(IGitFlowService gitFlow, IVersionService versionService)
        {
            _gitFlow = gitFlow;
            _versionService = versionService;
        }

        // فرم ایجاد شاخه جدید (GET)
        [HttpGet]
        public IActionResult New()
        {
            var versions = _versionService.GetAllVersions();
            ViewBag.Versions = versions;
            ViewBag.Lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name.StartsWith("fa") ? "fa" : "en";
            return View(); 
        }

        [HttpPost]
        public IActionResult Generate([FromForm] BranchRequest req)
        {
            var plan = _gitFlow.GenerateBranchPlan(req);
            ViewBag.Lang = req.Lang ?? (System.Threading.Thread.CurrentThread.CurrentUICulture.Name.StartsWith("fa") ? "fa" : "en");
            return View("Result", plan);
        }
    


        // Index action: نمایش شاخه‌ها
        public IActionResult Index()
        {
            var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            if (string.IsNullOrEmpty(lang)) lang = "en";

            var branches = _gitFlow.GetBranchesByLanguage(lang);
            ViewBag.Lang = lang;
            return View(branches);
        }
      

        [HttpGet]
        public IActionResult GetBranches(string lang = "en")
        {
            var branches = _gitFlow.GetBranchesByLanguage(lang);
            return Json(branches);
        }
    }
}

