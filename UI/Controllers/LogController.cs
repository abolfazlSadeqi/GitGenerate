using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class LogController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new LogCommandModel();
        return View(model);
    }
}
