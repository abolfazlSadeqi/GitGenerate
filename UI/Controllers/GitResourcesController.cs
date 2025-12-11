using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Globalization;

namespace UI.Controllers;

public class GitResourcesController : Controller
{
    private readonly IGitResourceService _svc;
    public GitResourcesController(IGitResourceService svc)
    {
        _svc = svc;
    }


    // GET /GitResources?lang=FA&q=stash&category=Advanced
    public IActionResult Index(string q = null, string category = null, int page = 1)
    {
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        ViewBag.Lang = lang;
        var pageSize = 30; // show 30 per page for better UI
        var items = _svc.GetAll(lang, category, q, page, pageSize);
        ViewData["lang"] = lang;
        ViewData["q"] = q;
        ViewData["category"] = category;
        ViewData["page"] = page;
        ViewData["pageSize"] = pageSize;
        ViewData["categories"] = _svc.GetCategories(lang);
        return View(items);
    }


    public IActionResult Details(int id)
    {
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
        ViewBag.Lang = lang;
        var item = _svc.GetById(id);
        if (item == null) return NotFound();
        return View(item);
    }
}

