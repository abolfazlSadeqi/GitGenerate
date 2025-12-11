using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class ConfigController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ConfigCommandModel();
        return View(model);
    }
}
