using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class MergeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new MergeCommandModel();
        return View(model);
    }
}
