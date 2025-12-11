using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class FetchController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new FetchCommandModel();
        return View(model);
    }
}