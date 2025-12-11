using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class archiveController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ArchiveCommandModel();
        return View(model);
    }
}
