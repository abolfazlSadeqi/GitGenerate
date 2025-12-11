using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class ShortlogController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ShortlogCommandModel();
        return View(model);
    }
}
