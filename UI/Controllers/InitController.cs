using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class InitController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new InitCommandModel();
        return View(model);
    }
}


public class RmController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new RmCommandModel();
        return View(model);
    }
}