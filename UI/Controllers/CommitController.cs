using Core;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace UI.Controllers;

public class CommitController : Controller
{
    public IActionResult Index()
    {
        var lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName.ToLower();

        var model = new CommitMessageModel
        {
            Lang = lang == "fa" ? "FA" : "EN"
        };

        return View(model);
    }
}


