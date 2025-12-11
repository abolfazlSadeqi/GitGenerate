using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class AddController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new AddCommandModel();
        return View(model);
    }
}


