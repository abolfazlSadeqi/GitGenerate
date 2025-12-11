using Core;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class GitConflictController : Controller
{
    private readonly GitConflictModel _model = new GitConflictModel();

    public IActionResult Index()
    {
        // نمایش لیست کانفلیکت‌ها
        return View(_model);
    }

    public IActionResult Details(string type)
    {
        var conflict = _model.Conflicts.FirstOrDefault(c => c.Type == type);
        if (conflict == null) return NotFound();
        return View(conflict);
    }
}

