using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class reflogController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ReflogCommandModel();
        return View(model);
    }
}
