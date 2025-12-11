using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class ShowController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new ShowCommandModel();
        return View(model);
    }
}
