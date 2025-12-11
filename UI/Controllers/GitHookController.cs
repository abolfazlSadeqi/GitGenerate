using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class GitHookController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new GitHookModel();
        return View(model);
    }
}

