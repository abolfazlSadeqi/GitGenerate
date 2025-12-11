using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class blameController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new BlameCommandModel();
        return View(model);
    }
}