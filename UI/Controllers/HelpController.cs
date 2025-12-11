using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class HelpController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new HelpCommandModel();
        return View(model);
    }
}
