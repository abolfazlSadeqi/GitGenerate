using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class LargeFilesController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new LargeFilesModel();
        return View(model);
    }
}

