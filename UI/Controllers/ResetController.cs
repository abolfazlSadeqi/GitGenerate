using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class ResetController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ResetCommandModel();
        return View(model);
    }
}
