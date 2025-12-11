using Core;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Globalization;

namespace UI.Controllers;

public class GitTagController : Controller
{
    private readonly IGitTagService _service;

    public GitTagController(IGitTagService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Create()
    {
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpper();
        if (lang != "FA") lang = "EN"; // فقط EN و FA را قبول می‌کنیم

        var model = new GitTagModel
        {
            Language = lang,
            Message = "",
            Branch = "main",
            TagName = "",
            IsAnnotated = true,
            UseGpgSign = false,
            PushAfter = true
        };

        ViewData["DescriptionEN"] = _service.GetDescriptionEN();
        ViewData["DescriptionFA"] = _service.GetDescriptionFA();

        return View(model);
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(GitTagModel model)
    {
        model.Language = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpper();
        if (model.Language != "FA") model.Language = "EN";

        if (string.IsNullOrWhiteSpace(model.TagName))
            ModelState.AddModelError(nameof(model.TagName), "Tag name is required");

        if (!ModelState.IsValid)
        {
            ViewData["DescriptionEN"] = _service.GetDescriptionEN();
            ViewData["DescriptionFA"] = _service.GetDescriptionFA();
            return View(model);
        }

        model.GeneratedCommand = _service.GenerateCommand(model);

        ViewData["DescriptionEN"] = _service.GetDescriptionEN();
        ViewData["DescriptionFA"] = _service.GetDescriptionFA();

        return View(model);
    }

}

