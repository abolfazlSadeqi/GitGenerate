using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class StatusController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new StatusCommandModel();
        return View(model);
    }
}