using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class AmController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new AmCommandModel();
        return View(model);
    }
}
