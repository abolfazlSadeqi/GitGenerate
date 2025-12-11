using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class RemoteController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new RemoteCommandModel();
        return View(model);
    }
}
