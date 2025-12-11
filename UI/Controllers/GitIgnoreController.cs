using Core;
using Microsoft.AspNetCore.Mvc;
using Service.Services;

namespace UI.Controllers;

public class GitIgnoreController : Controller
{
    private readonly IGitIgnoreService _service;

    public GitIgnoreController(IGitIgnoreService service)
    {
        _service = service;
    }

    // GET: نمایش صفحه انتخاب‌ها
    public IActionResult Index()
    {
        var model = new GitIgnoreViewModel
        {
            Languages = _service.GetLanguages(),
            Templates = _service.GetTemplates(),
            CustomRules = new List<GitIgnoreRule>()
        };

        return View(model);
    }

    [HttpPost]
    public IActionResult Generate([FromBody] GitIgnoreRequest request)
    {
        if (request == null)
            return BadRequest("Invalid request");

        var content = _service.Generate(request);
        return Json(new { content });
    }

    [HttpPost]
    public IActionResult Download([FromBody] GitIgnoreRequest request)
    {
        if (request == null)
            return BadRequest("Invalid request");

        var content = _service.Generate(request);
        var bytes = System.Text.Encoding.UTF8.GetBytes(content);
        return File(bytes, "text/plain", ".gitignore");
    }

}
