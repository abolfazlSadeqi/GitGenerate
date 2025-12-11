using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class StashController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new StashCommandModel();
        return View(model);
    }
}
