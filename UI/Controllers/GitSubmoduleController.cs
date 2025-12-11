using Core;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

namespace UI.Controllers;

public class GitSubmoduleController : Controller
{
    private readonly IGitSubmoduleService _service;

    public GitSubmoduleController(IGitSubmoduleService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Index()
    {
        // Default model for the form
        var model = new GitSubmoduleInputModel
        {
            OperationType = "add",
            Recursive = true,
            AutoCommit = true,
            PushToRemote = false
        };
        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Generate(GitSubmoduleInputModel model)
    {
        var lang = (ViewBag.Lang as string) ?? System.Globalization.CultureInfo.CurrentUICulture.Name;
        var output = _service.GenerateCommands(model, lang);
        ViewBag.Output = output;
        return View("Index", model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult ResolveConflict(GitSubmoduleInputModel model)
    {
        var lang = (ViewBag.Lang as string) ?? System.Globalization.CultureInfo.CurrentUICulture.Name;
        var output = _service.SuggestConflictResolution(model, lang);
        ViewBag.ConflictOutput = output;
        return View("Index", model);
    }
}
