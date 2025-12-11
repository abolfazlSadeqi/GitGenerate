using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class MvController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new MvCommandModel();
        return View(model);
    }
}
