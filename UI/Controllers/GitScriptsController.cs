using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class GitScriptsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new GitScriptsModel();
            return View(model);
        }
   }

