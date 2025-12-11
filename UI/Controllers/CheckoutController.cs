using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class CheckoutController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new CheckoutCommandModel();
        return View(model);
    }
}
