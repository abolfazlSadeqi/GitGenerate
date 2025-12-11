using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class BranchController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new BranchCommandModel();
        return View(model); 
    }
}
