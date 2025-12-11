using Core;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;
using System.Globalization;

namespace UI.Controllers;

public class GitConceptController : Controller
{
    private readonly IGitConceptService _service;

    public GitConceptController(IGitConceptService service)
    {
        _service = service;
    }

    // گرفتن زبان سایت به صورت خودکار
    private Language GetCurrentLanguage()
    {
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        return lang == "fa" ? Language.Fa : Language.En;
    }

    // لیست مفاهیم بر اساس دسته بندی و زبان سایت
    public IActionResult List(GitConceptCategory category = GitConceptCategory.Basic)
    {
        var lang = GetCurrentLanguage();
        var data = _service.GetByCategory(category, lang);
        ViewBag.Category = category;
        return View(data);
    }

    // جزئیات هر مفهوم
    public IActionResult Detail(string key)
    {
        var lang = GetCurrentLanguage();
        var data = _service.GetConcept(key, lang);
        if (data == null) return NotFound();

        return View(data);
    }



    public IActionResult GitGuide()
    {
       

        return View();
    }


    [HttpGet]
    public IActionResult bestPractice()
    {
        var model = new GitBestPracticeModel();
        return View(model);
    }

    [HttpGet]
    public IActionResult Standards()
    {
        var model = new GitStandardsModel();
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToUpper();
        model.Language = (lang == "FA") ? "FA" : "EN";
        return View(model);
    }
}

