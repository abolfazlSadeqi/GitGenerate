using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class PullController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new PullCommandModel();
        return View(model);
    }
}
