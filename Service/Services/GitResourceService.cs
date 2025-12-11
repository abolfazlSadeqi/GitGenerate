
using Core;
using Service.Interfaces;

namespace Service.Services;
public class GitResourceService : IGitResourceService
{
    private readonly List<GitResource> _resources;

    public GitResourceService()
    {
        _resources = Seed();
    }

    public IEnumerable<GitResource> GetAll(string lang = "EN", string category = null, string q = null, int page = 1, int pageSize = 50)
    {
        var items = _resources.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(lang))
            items = items.Where(x => string.Equals(x.Language, lang, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(category))
            items = items.Where(x => string.Equals(x.Category, category, StringComparison.OrdinalIgnoreCase));
        if (!string.IsNullOrWhiteSpace(q))
        {
            var qq = q.Trim().ToLowerInvariant();
            items = items.Where(x => (x.SiteName ?? "").ToLowerInvariant().Contains(qq)
                || (x.Description ?? "").ToLowerInvariant().Contains(qq)
                || (x.Url ?? "").ToLowerInvariant().Contains(qq));
        }

        return items.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }

    public IEnumerable<string> GetCategories(string lang = "EN")
    {
        return _resources.Where(x => string.Equals(x.Language, lang, StringComparison.OrdinalIgnoreCase))
            .Select(x => x.Category).Distinct().OrderBy(x => x).ToList();
    }

    public GitResource GetById(int id) => _resources.FirstOrDefault(x => x.Id == id);

    // --------------------------
    // SEED: Real curated resources (EN + FA)
    // Focus: core Git (internals, commands, workflows, troubleshooting, cheat-sheets, tutorials, PDFs)
    // Exclude heavy platform-specific (GitHub/GitLab) per request
    // --------------------------
    private List<GitResource> Seed()
    {
        var list = new List<GitResource>();
        int id = 1;
        void Add(string site, string cat, string url, string lang, string desc)
        {
            list.Add(new GitResource { Id = id++, SiteName = site, Category = cat, Url = url, Language = lang, Description = desc });
        }

        Add("Pro Git (complete book)", "Book", "https://git-scm.com/book/en/v2", "EN", "Official Git book — basic to advanced concepts."); // Official book covering all Git basics and workflows :contentReference[oaicite:0]{index=0}
        Add("Git Official Docs (reference)", "Reference", "https://git-scm.com/docs", "EN", "Complete Git command reference and guides."); // Documentation and command details :contentReference[oaicite:1]{index=1}
        Add("Git Basics - Getting Started", "Tutorial", "https://git-scm.com/book/en/v2/Git-Basics-Getting-a-Git-Repository", "EN", "Start learning Git commands and core concepts."); // First steps and common git basics :contentReference[oaicite:2]{index=2}
        Add("Git Internals - Plumbing & Porcelain", "Internals", "https://git-scm.com/book/en/v2/Git-Internals-Plumbing-and-Porcelain", "EN", "Understanding Git internals and low-level commands."); // Internals and plumbing commands explained :contentReference[oaicite:3]{index=3}
        Add("Git Internals - Git Objects", "Internals", "https://git-scm.com/book/en/v2/Git-Internals-Git-Objects", "EN", "Deep dive into Git object storage and structure."); // How Git stores data internally :contentReference[oaicite:4]{index=4}
        Add("Git Branching - Branches in a Nutshell", "Reference", "https://git-scm.com/book/en/v2/Git-Branching-Branches-in-a-Nutshell", "EN", "Explanation of Git branches and workflow."); // Branch concept and usage :contentReference[oaicite:5]{index=5}
        Add("GitHub Cheat Sheet", "Cheatsheet", "https://docs.github.com/articles/git-cheatsheet", "EN", "Git & GitHub command cheatsheet by GitHub Docs."); // Official GitHub cheat sheet :contentReference[oaicite:6]{index=6}
        Add("Atlassian Git Cheat Sheet", "Cheatsheet", "https://www.atlassian.com/git/tutorials/atlassian-git-cheatsheet", "EN", "Practical Git cheat sheet for common tasks."); // Another practical cheat sheet :contentReference[oaicite:7]{index=7}
        Add("Git Cheat Sheet (ArslanBilal)", "Cheatsheet", "https://github.com/arslanbilal/git-cheat-sheet", "EN", "Comprehensive command cheat sheet on GitHub."); // Community-maintained cheat sheet :contentReference[oaicite:8]{index=8}
       
      
        Add("Git Tutorial (Practicalli)", "Tutorial", "https://practical.li/gitops/git/tutorial/", "EN", "Practical Git tutorial covering workflow steps."); // Step‑by‑step practical tutorial :contentReference[oaicite:10]{index=10}
        Add("Brad Traversy Git Cheatsheet (Gist)", "Cheatsheet", "https://gist.github.com/bradtraversy/518b1bd6fe26c83c3a184b3a98a2fcd0", "EN", "Community cheatsheet with commands and key workflows."); // Useful command list :contentReference[oaicite:11]{index=11}
        Add("Persian Git Cheatsheet (Gist)", "Cheatsheet", "https://gist.github.com/monirehbastami/1e75d147b810249a6ffbec3eddf9c88d", "FA", "Git command cheat sheet in Persian."); // Persian cheat sheet example :contentReference[oaicite:12]{index=12}


        Add("WebProg - آموزش رایگان Git و GitHub", "Tutorial", "https://webprog.io/course/آموزش-رایگان-گیت-و-گیت-هاب-git-github", "FA", "آموزش گیت و GitHub به زبان فارسی."); // آموزش جامع رایگان Git و GitHub :contentReference[oaicite:13]{index=13}
        Add("Faradars - Git، GitHub و GitLab رایگان", "Course", "https://faradars.org/courses/fvgit9609-git-github-gitlab", "FA", "دوره رایگان گیت با ویدئو و مثال‌های واقعی."); // دوره آموزشی کامل در فرادرس :contentReference[oaicite:14]{index=14}
        Add("YouTube - Git & GitHub Farsi Playlist", "Video", "https://www.youtube.com/results?search_query=Git+GitHub+آموزش+فارسی", "FA", "لیست ویدئوهای آموزش فارسی Git در یوتیوب."); // مجموعه ویدئوهای فارسی Git :contentReference[oaicite:15]{index=15}

        return list;
    }
}
