using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class CherrypickController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new CherryPickCommandModel();
        return View(model);
    }
}
