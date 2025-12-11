using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System.Globalization;

namespace UI.Controllers;

public class VersionController : Controller
{
    private readonly IVersionService _versionService;

    public VersionController(IVersionService versionService)
    {
        _versionService = versionService;
    }

    public IActionResult Index()
    {
        var versions = _versionService.GetAllVersions();
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

        ViewBag.Lang = lang;
        return View(versions);
    }

    public IActionResult Details(int id)
    {
        var version = _versionService.GetVersion(id);
        if (version == null) return NotFound();
        return View(version);
    }

    [HttpGet("new")]
    public IActionResult New()
    {
      
        return View();
    }

    [HttpPost("new")]
    public IActionResult NewPost(int previousVersionId, string changeType, string preRelease, string description)
    {
        var newVersion = _versionService.CreateNextVersion(previousVersionId, changeType, preRelease, description);
        return RedirectToAction("Details", new { id = newVersion.Id });
    }
}
