using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class RebaseController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new RebaseCommandModel();
        return View(model);
    }
}
