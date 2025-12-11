using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class BisectController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new BisectCommandModel();
        return View(model);
    }
}
