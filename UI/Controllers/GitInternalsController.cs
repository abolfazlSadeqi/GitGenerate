using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class GitInternalsController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new GitInternalsModel();
        return View(model);
    }
}
