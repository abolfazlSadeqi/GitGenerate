namespace Core;


public class GitBestPracticeModel
{
    public string TitleEn => "Git Best Practices for Enterprise & Large Teams";
    public string TitleFa => "بهترین شیوه‌های گیت برای تیم‌های بزرگ و پروژه‌های سازمانی";

    public string OverviewEn => @"<h3>Overview</h3>
<p>These practices are selected specifically for large-scale, long-running, multi-team enterprise environments.</p>";

    public string OverviewFa => @"<h3>نمای کلی</h3>
<p>این مجموعه بهترین شیوه‌ها مخصوص تیم‌های بزرگ، سازمانی و پروژه‌های طولانی‌مدت است.</p>";

    public string[] TabsEn => new[]
    {
        "Branching Strategy",
        "Commit Practices",
        "Pull Request Workflow",
        "Release & Versioning",
        "Repository Structure"
    };

    public string[] TabsFa => new[]
    {
        "استراتژی برنچینگ",
        "استانداردهای کامیت",
        "جریان کار Pull Request",
        "انتشار و نسخه‌گذاری",
        "ساختار مخزن",
    };

    public Dictionary<string, string> ContentEn => new()
    {
        ["Branching Strategy"] = @"
<h3>1. Prefer Long-Running Protected Branches</h3>
<ul>
<li>Main / Trunk is always deployable</li>
<li>Development branch optional depending on scale</li>
<li>Feature branches must be short-lived</li>
</ul>

<h3>2. Use GitFlow Only When Necessary</h3>
<ul>
<li>Enterprise apps with separated QA/Release trains ✔</li>
<li>Microservices (CI-heavy) → Use Trunk Based Development</li>
<li>Mobile apps → GitFlow recommended</li>
</ul>
",

        ["Commit Practices"] = @"
<h3>1. Atomic, Reversible Commits</h3>
<ul>
<li>Each commit = one logical change</li>
<li>Commits must always be reversible without side-effects</li>
<li>Commit messages follow Conventional Commits</li>
</ul>

<h3>2. Avoid Commit Noise</h3>
<ul>
<li>No commit containing both code + formatting</li>
<li>No committing build outputs, logs, temporary files</li>
<li>Use pre-commit hooks for auto-linting</li>
</ul>
",

        ["Pull Request Workflow"] = @"
<h3>1. PRs Must Be Small</h3>
<ul><li>Max 300 lines diff</li><li>Must be reviewable within 10 minutes</li></ul>

<h3>2. PR Review Rules</h3>
<ul>
<li>Minimum 2 approvals</li>
<li>No self-merge</li>
<li>Mandatory CI passing</li>
<li>Block merge if new comments added</li>
</ul>

<h3>3. PR Templates</h3>
<ul>
<li>What / Why / Testing evidence / Risk level</li>
<li>Linked Jira / Azure DevOps ticket required</li>
</ul>
",

        ["Release & Versioning"] = @"
<h3>1. Semantic Versioning</h3>
<p><b>MAJOR.MINOR.PATCH</b></p>

<h3>2. Release Tags</h3>
<ul>
<li>Always tag from main branch</li>
<li>Hotfix tags from release branch</li>
</ul>

<h3>3. Automated Releases</h3>
<ul>
<li>CI automatically bumps version based on commit type</li>
<li>Changelogs generated automatically</li>
</ul>
",

        ["Repository Structure"] = @"
<h3>1. Monorepo Considerations</h3>
<ul>
<li>Use submodules for external dependencies</li>
<li>Use worktrees for multi-branch parallel development</li>
<li>Use CODEOWNERS for responsibility mapping</li>
</ul>

<h3>2. Folder Structure Rules</h3>
<ul>
<li>/src</li>
<li>/tests</li>
<li>/docs</li>
<li>/scripts</li>
<li>/infra</li>
</ul>
",

  
    };

    public Dictionary<string, string> ContentFa => new()
    {
        ["استراتژی برنچینگ"] = @"
<h3>۱. استفاده از برنچ‌های محافظت‌شده</h3>
<ul>
<li>Main همیشه قابل استقرار است</li>
<li>Feature Branch باید کوتاه‌عمر باشد</li>
<li>برنچ Develop در تیم‌های بسیار بزرگ مفید است</li>
</ul>

<h3>۲. GitFlow فقط زمانی که لازم است</h3>
<ul>
<li>اپلیکیشن‌های بزرگ سازمانی ✔</li>
<li>مایکروسرویس‌ها ✘ — بهتر است Trunk Based باشد</li>
<li>اپ موبایل ✔</li>
</ul>
",

        ["استانداردهای کامیت"] = @"
<h3>۱. کامیت‌های اتمیک و قابل بازگشت</h3>
<ul>
<li>هر کامیت یک تغییر مستقل</li>
<li>قابل برگشت بدون عارضه</li>
<li>بر اساس Conventional Commits</li>
</ul>

<h3>۲. جلوگیری از نویز</h3>
<ul>
<li>فرمت و کد در کامیت جداگانه</li>
<li>عدم کامیت فایل‌های build و log</li>
<li>هوک pre-commit برای lint</li>
</ul>
",

        ["جریان کار Pull Request"] = @"
<h3>۱. PR باید کوچک باشد</h3>
<ul><li>حداکثر ۳۰۰ خط تفاوت</li><li>قابل بررسی در ۱۰ دقیقه</li></ul>

<h3>۲. قوانین Review</h3>
<ul>
<li>حداقل ۲ تأیید</li>
<li>عدم Merge خودکار</li>
<li>CI باید سبز باشد</li>
<li>وجود کامنت جدید = بلاک Merge</li>
</ul>

<h3>۳. قالب PR استاندارد</h3>
<ul>
<li>What / Why / Tests / Risk</li>
<li>لینک تیکت Jira الزامی</li>
</ul>
",

        ["انتشار و نسخه‌گذاری"] = @"
<h3>۱. نسخه‌گذاری Semantic</h3>
<p><b>MAJOR.MINOR.PATCH</b></p>

<h3>۲. Tag کردن نسخه</h3>
<ul>
<li>فقط از برنچ Main</li>
<li>Hotfix از برنچ Release</li>
</ul>

<h3>۳. انتشار خودکار</h3>
<ul>
<li>CI نسخه را بر اساس نوع کامیت بالا می‌برد</li>
<li>تولید Changelog خودکار</li>
</ul>
",

        ["ساختار مخزن"] = @"
<h3>۱. Monorepo حرفه‌ای</h3>
<ul>
<li>استفاده از submodule</li>
<li>استفاده از worktree برای توسعه موازی</li>
<li>استفاده از CODEOWNERS</li>
</ul>

<h3>۲. ساختار پوشه‌ها</h3>
<ul>
<li>/src</li>
<li>/tests</li>
<li>/docs</li>
<li>/scripts</li>
<li>/infra</li>
</ul>
",

      
    };
}
