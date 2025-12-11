using Core;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Globalization;

namespace UI.Controllers;

public class CloneController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new CloneCommandModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult Build(CloneCommandModel model, [FromForm] Dictionary<string, string> form)
    {
        string cmd = "git clone";

        if (form.ContainsKey("Mirror") && form["Mirror"] == "on") cmd += " --mirror";
        if (form.ContainsKey("Bare") && form["Bare"] == "on") cmd += " --bare";
        if (form.ContainsKey("SingleBranch") && form["SingleBranch"] == "on") cmd += " --single-branch";
        if (form.ContainsKey("RecurseSubmodules") && form["RecurseSubmodules"] == "on") cmd += " --recurse-submodules";
        if (form.ContainsKey("Branch") && !string.IsNullOrWhiteSpace(form["Branch"])) cmd += $" -b {form["Branch"]}";
        if (form.ContainsKey("Depth") && !string.IsNullOrWhiteSpace(form["Depth"])) cmd += $" --depth {form["Depth"]}";
        if (form.ContainsKey("RemoteName") && !string.IsNullOrWhiteSpace(form["RemoteName"])) cmd += $" -o {form["RemoteName"]}";
        if (form.ContainsKey("Config") && !string.IsNullOrWhiteSpace(form["Config"])) cmd += $" --config {form["Config"]}";
        if (form.ContainsKey("Repository") && !string.IsNullOrWhiteSpace(form["Repository"])) cmd += $" {form["Repository"]}";
        if (form.ContainsKey("Directory") && !string.IsNullOrWhiteSpace(form["Directory"])) cmd += $" {form["Directory"]}";

        ViewBag.Command = cmd;
        return View("Index", model);
    }
}

