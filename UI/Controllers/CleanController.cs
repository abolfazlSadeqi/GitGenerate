using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class CleanController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new CleanCommandModel();
        return View(model);
    }
}
