using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class DiffController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new DiffCommandModel();
        return View(model);
    }
}