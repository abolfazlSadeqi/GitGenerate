using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class UpdateIndexController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new UpdateIndexCommandModel();
        return View(model);
    }
}
