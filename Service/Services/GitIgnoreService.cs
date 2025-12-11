using Core;
using Service.Interfaces;
using System.Text.RegularExpressions;

namespace Service.Services;

public class GitIgnoreService : IGitIgnoreService
{
    public List<GitIgnoreLanguage> GetLanguages()
    {
        return new List<GitIgnoreLanguage>
        {
            new GitIgnoreLanguage
            {
                Name = "DotNet",
                Display = ".NET / C#",
                Rules = new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="User files", Pattern="*.rsuser" },
                    new GitIgnoreRule { Description="Solution user options", Pattern="*.suo" },
                    new GitIgnoreRule { Description="User preferences", Pattern="*.user" },
                    new GitIgnoreRule { Description="Build results", Pattern="bin/" },
                    new GitIgnoreRule { Description="Build results", Pattern="obj/" },
                    new GitIgnoreRule { Description="Logs", Pattern="*.log" },
                    new GitIgnoreRule { Description="VS cache", Pattern=".vs/" },
                    new GitIgnoreRule { Description="NuGet packages", Pattern="**/[Pp]ackages/*" },
                    new GitIgnoreRule { Description="Generated code", Pattern="Generated_Code/" },
                    new GitIgnoreRule { Description="Backup files", Pattern="Backup*/" },
                    new GitIgnoreRule { Description="Database files", Pattern="*.mdf" },
                    new GitIgnoreRule { Description="Database log files", Pattern="*.ldf" },
                    new GitIgnoreRule { Description="Test results", Pattern="[Tt]est[Rr]esult*/" },
                    new GitIgnoreRule { Description="NUnit results", Pattern="*.VisualState.xml" },
                    new GitIgnoreRule { Description="Benchmark results", Pattern="BenchmarkDotNet.Artifacts/" },
                    new GitIgnoreRule { Description="StyleCop", Pattern="StyleCopReport.xml" },
                    new GitIgnoreRule { Description="Generated Files by Visual Studio", Pattern="*_i.c" },
                    new GitIgnoreRule { Description="Visual Studio profiler", Pattern="*.psess" },
                    new GitIgnoreRule { Description="DotCover", Pattern="*.dotCover" },
                    new GitIgnoreRule { Description="Coverlet", Pattern="coverage*.json" },
                    new GitIgnoreRule { Description="NCrunch", Pattern="_NCrunch_*" },
                    new GitIgnoreRule { Description="MightyMoose", Pattern="*.mm.*" },
                    new GitIgnoreRule { Description="Web workbench", Pattern=".sass-cache/" },
                    new GitIgnoreRule { Description="InstallShield output folder", Pattern="[Ee]xpress/" },
                    new GitIgnoreRule { Description="ClickOnce directory", Pattern="publish/" },
                    new GitIgnoreRule { Description="Visual Studio cache files", Pattern="*.[Cc]ache" },
                    new GitIgnoreRule { Description="Local history", Pattern=".localhistory/" },
                    new GitIgnoreRule { Description="Fody", Pattern="FodyWeavers.xsd" }
                }
            },
            new GitIgnoreLanguage
            {
                Name = "NodeJs",
                Display = "Node.js",
                Rules = new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Node modules", Pattern="node_modules/" },
                    new GitIgnoreRule { Description="Build folder", Pattern="dist/" },
                    new GitIgnoreRule { Description="Environment files", Pattern=".env" },
                    new GitIgnoreRule { Description="Coverage reports", Pattern="coverage/" },
                    new GitIgnoreRule { Description="Yarn errors", Pattern="yarn-error.log" },
                    new GitIgnoreRule { Description="npm debug log", Pattern="npm-debug.log" }
                }
            },
            new GitIgnoreLanguage
            {
                Name = "Python",
                Display = "Python",
                Rules = new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Bytecode files", Pattern="__pycache__/" },
                    new GitIgnoreRule { Description="Compiled python files", Pattern="*.pyc" },
                    new GitIgnoreRule { Description="Virtual environment", Pattern="env/" },
                    new GitIgnoreRule { Description="Pytest cache", Pattern=".pytest_cache/" },
                    new GitIgnoreRule { Description="Egg info", Pattern="*.egg-info/" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="Java",
                Display="Java",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Compiled class files", Pattern="*.class" },
                    new GitIgnoreRule { Description="Target folder", Pattern="target/" },
                    new GitIgnoreRule { Description="Logs", Pattern="*.log" },
                    new GitIgnoreRule { Description="IDE settings", Pattern=".idea/" },
                    new GitIgnoreRule { Description="Jar files", Pattern="*.jar" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="Go",
                Display="Go",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Binary output", Pattern="bin/" },
                    new GitIgnoreRule { Description="Test files", Pattern="*.test" },
                    new GitIgnoreRule { Description="Vendor folder", Pattern="vendor/" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="PHP",
                Display="PHP / Laravel",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Vendor folder", Pattern="vendor/" },
                    new GitIgnoreRule { Description="Environment", Pattern=".env" },
                    new GitIgnoreRule { Description="Storage logs", Pattern="storage/logs/" },
                    new GitIgnoreRule { Description="Storage cache", Pattern="storage/framework/cache/" },
                    new GitIgnoreRule { Description="Node modules", Pattern="node_modules/" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="Rust",
                Display="Rust",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Target folder", Pattern="target/" },
                    new GitIgnoreRule { Description="Backup files", Pattern="*.rs.bk" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="Swift",
                Display="Swift / iOS",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Build folder", Pattern="build/" },
                    new GitIgnoreRule { Description="DerivedData", Pattern="DerivedData/" },
                    new GitIgnoreRule { Description="Xcode user state", Pattern="*.xcuserstate" },
                    new GitIgnoreRule { Description="Workspace", Pattern="*.xcworkspace" },
                    new GitIgnoreRule { Description="IPA files", Pattern="*.ipa" },
                    new GitIgnoreRule { Description="Debug symbols", Pattern="*.dSYM/" }
                }
            },
            new GitIgnoreLanguage
            {
                Name="Android",
                Display="Android",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Build folder", Pattern="build/" },
                    new GitIgnoreRule { Description="APK files", Pattern="*.apk" },
                    new GitIgnoreRule { Description="AAB files", Pattern="*.aab" },
                    new GitIgnoreRule { Description="Gradle", Pattern=".gradle/" },
                    new GitIgnoreRule { Description="Local properties", Pattern="local.properties" }
                }
            }
            // می‌توانید به همین شکل React, Vue, Angular و سایر زبان‌ها را اضافه کنید
        };
    }

    public List<GitIgnoreTemplate> GetTemplates()
    {
        return new List<GitIgnoreTemplate>
        {
            new GitIgnoreTemplate
            {
                Name="VSCode",
                Display="VSCode IDE",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="VSCode settings folder", Pattern=".vscode/*" }
                }
            },
            new GitIgnoreTemplate
            {
                Name="JetBrains",
                Display="JetBrains IDE",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="IDE settings folder", Pattern=".idea/" },
                    new GitIgnoreRule { Description="Module files", Pattern="*.iml" }
                }
            },
            new GitIgnoreTemplate
            {
                Name="Windows",
                Display="Windows OS",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Thumbnail cache", Pattern="Thumbs.db" },
                    new GitIgnoreRule { Description="Desktop.ini", Pattern="Desktop.ini" }
                }
            },
            new GitIgnoreTemplate
            {
                Name="macOS",
                Display="macOS OS",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="System files", Pattern=".DS_Store" }
                }
            },
            new GitIgnoreTemplate
            {
                Name="Linux",
                Display="Linux OS",
                Rules=new List<GitIgnoreRule>
                {
                    new GitIgnoreRule { Description="Temp files", Pattern="*~" }
                }
            }
        };
    }

    public string Generate(GitIgnoreRequest request)
    {
        var result = new List<string>();
        var allLanguages = GetLanguages();
        var allTemplates = GetTemplates();

        // اضافه کردن زبان‌ها
        foreach (var langName in request.SelectedLanguages)
        {
            var lang = allLanguages.FirstOrDefault(x => x.Name == langName);
            if (lang != null)
            {
                result.Add($"# {lang.Display}");
                result.AddRange(lang.Rules.Where(r => r.Enabled).Select(r => r.Pattern));
                result.Add("");
            }
        }

        // اضافه کردن Template ها
        foreach (var templateName in request.SelectedTemplates)
        {
            var template = allTemplates.FirstOrDefault(x => x.Name == templateName);
            if (template != null)
            {
                result.Add($"# {template.Display}");
                result.AddRange(template.Rules.Where(r => r.Enabled).Select(r => r.Pattern));
                result.Add("");
            }
        }

        // اضافه کردن Custom Rules
        if (request.CustomRules.Any())
        {
            result.Add("# Custom Rules");
            result.AddRange(request.CustomRules.Where(r => r.Enabled).Select(r => r.Pattern));
            result.Add("");
        }

        return string.Join("\n", result);
    }
}


public class GitFlowService: IGitFlowService
{
    private readonly IVersionService _versionService; // برای دستیابی به نسخه‌های قبلی (اختیاری)

    public GitFlowService(IVersionService versionService)
    {
        _versionService = versionService;
    }

    public List<GitFlowBranch> GetBranches()
    {
        return new List<GitFlowBranch>
           {
               new GitFlowBranch
               {
                   Name="main",
                   Display="Main / Master",
                   Parent="N/A",
                   MergeTarget="Production Deployment",

                   Description = Lang(
                       "Stable production branch. Contains only final and tested releases.",
                       "شاخه اصلی و پایدار تولید. فقط نسخه‌های نهایی و تست‌شده در آن قرار می‌گیرد."
                   ),

                   Rules = LangList(
                       new[]{
                           "Always remains stable.",
                           "Direct commits are forbidden.",
                           "Accepts only merges from release and hotfix.",
                           "Tag each release version (v1.2.0)."
                       },
                       new[]{
                           "همیشه پایدار بماند.",
                           "کامیت مستقیم ممنوع.",
                           "فقط از release و hotfix merge شود.",
                           "برای هر نسخه یک تگ زده شود (v1.2.0)."
                       }
                   ),

                   Challenges = LangList(
                       new[]{
                           "Direct commits may break production.",
                           "Hotfix merges may conflict with ongoing development.",
                           "Improper release merges can override hotfixes."
                       },
                       new[]{
                           "کامیت مستقیم ممکن است production را خراب کند.",
                           "Merge شاخه hotfix با develop ممکن است conflict ایجاد کند.",
                           "Merge اشتباه release ممکن است hotfix را override کند."
                       }
                   ),

                   Solutions = LangList(
                       new[]{
                           "Use PRs for all merges.",
                           "Always merge hotfix back to develop.",
                           "Test release branches thoroughly."
                       },
                       new[]{
                           "برای هر مرجع از PR استفاده کنید.",
                           "Hotfix همیشه باید به develop merge شود.",
                           "شاخه release کامل تست شود."
                       }
                   ),

                   Notes = LangList(
                       new[]{
                           "Main is usually protected (GitHub, GitLab).",
                           "Only CI/CD merges are recommended."
                       },
                       new[]{
                           "main معمولاً محافظت‌شده است (GitHub, GitLab).",
                           "فقط merge از طریق CI/CD توصیه می‌شود."
                       }
                   ),

               },

               //============================== DEVELOP ==================================
               new GitFlowBranch
               {
                   Name="develop",
                   Display="Develop",
                   Parent="main",
                   MergeTarget="release/*",

                   Description = Lang(
                       "Main development branch. Contains all completed features.",
                       "شاخه توسعه اصلی. شامل تمام Featureهای تکمیل‌شده است."
                   ),

                   Rules = LangList(
                       new[]{
                           "Merge only feature branches.",
                           "Develop must always stay stable enough for release.",
                           "Sync regularly with main."
                       },
                       new[]{
                           "فقط featureها مرجع شوند.",
                           "Develop باید همیشه قابل انتشار باشد.",
                           "همیشه با main همگام‌سازی شود."
                       }
                   ),

                   Challenges = LangList(
                       new[]{
                           "Frequent merge conflicts.",
                           "Feature branches may diverge.",
                           "Large features create instability."
                       },
                       new[]{
                           "کانفلیکت‌های زیاد.",
                           "Featureها ممکن است با develop ناسازگار شوند.",
                           "Featureهای بزرگ ممکن است ناپایداری ایجاد کنند."
                       }
                   ),

                   Solutions = LangList(
                       new[]{
                           "Use CI/CD to test develop.",
                           "Keep feature branches short-lived.",
                           "Merge main into develop after hotfix."
                       },
                       new[]{
                           "تست develop با CI/CD.",
                           "Featureهای کوچک ایجاد کنید.",
                           "بعد از hotfix، main را به develop merge کنید."
                       }
                   )
               },

               //============================== FEATURE ==================================
               new GitFlowBranch
               {
                   Name="feature/*",
                   Display="Feature Branch",
                   Parent="develop",
                   MergeTarget="develop",

                   Description = Lang(
                       "Branch for developing a specific feature.",
                       "شاخه‌ای برای توسعه یک قابلیت خاص."
                   ),

                   Rules = LangList(
                       new[]{
                           "Branch from develop.",
                           "Merge only back into develop.",
                           "Commit small and meaningful changes."
                       },
                       new[]{
                           "از develop منشعب شود.",
                           "فقط به develop merge شود.",
                           "کامیت‌های کوچک و معنادار."
                       }
                   )
               },

               //============================== RELEASE ==================================
               new GitFlowBranch
               {
                   Name="release/*",
                   Display="Release Branch",
                   Parent="develop",
                   MergeTarget="main & develop",

                   Description = Lang(
                       "Branch created when preparing a new release version.",
                       "شاخه‌ای برای آماده‌سازی نسخه جدید."
                   )
               },

               //============================== HOTFIX ==================================
               new GitFlowBranch
               {
                   Name="hotfix/*",
                   Display="Hotfix Branch",
                   Parent="main",
                   MergeTarget="main & develop",

                   Description = Lang(
                       "Emergency fix branch created directly from main.",
                       "شاخه رفع باگ اضطراری که مستقیماً از main ساخته می‌شود."
                   )
               }
           };
    }

    private Dictionary<string, string> Lang(string en, string fa)
        => new() { { "en", en }, { "fa", fa } };

    private Dictionary<string, List<string>> LangList(IEnumerable<string> en, IEnumerable<string> fa)
        => new()
        {
               {"en", new List<string>(en)},
               {"fa", new List<string>(fa)}
        };

    // گرفتن شاخه‌ها بر اساس زبان سایت
    public List<GitFlowBranch> GetBranchesByLanguage(string lang)
    {
        var branches = GetBranches();
        foreach (var b in branches)
        {
            if (!b.Description.ContainsKey(lang)) lang = "en";
        }
        return branches;
    }

    /// <summary>
    /// تولید BranchPlan بر اساس BranchRequest
    /// </summary>
    public BranchPlan GenerateBranchPlan(BranchRequest req)
    {
        // اعتبارسنجی ساده
        if (req == null) throw new ArgumentNullException(nameof(req));
        if (string.IsNullOrWhiteSpace(req.Type)) req.Type = "feature";
        if (req.From == null || req.From.Count == 0)
        {
            // قوانین معمول gitflow: feature/release/hotfix از develop/main منشعب می‌شوند
            req.From = req.Type switch
            {
                "main" => new List<string> { "main" },
                "develop" => new List<string> { "develop" },
                "hotfix" => new List<string> { "main" },
                "release" => new List<string> { "develop" },
                _ => new List<string> { "develop" }
            };
        }

        var plan = new BranchPlan();
        plan.ReleaseNotes = req.Description ?? "";

        // نام‌گذاری شاخه براساس نوع
        string branchName = BuildBranchName(req);
        plan.BranchName = branchName;

        // ساخت دستورات عمومی
        var cmds = new List<string>();

        // ابتدا checkout به شاخه مرجع (اولین انتخاب) — اگر چند مرجع انتخاب شده، اولی فرض می‌شود
        string baseBranch = req.From.First();
        cmds.Add($"git fetch origin {baseBranch}");
        cmds.Add($"git checkout {baseBranch}");
        cmds.Add($"git pull origin {baseBranch}");

        // ساخت شاخه جدید از مرجع
        cmds.Add($"git checkout -b {branchName}");

        // اگر release و نیاز به تگ هست، محاسبه نسخه و دستور tag نهایی
        string suggestedTag = "";
        if (req.Type == "release")
        {
            // تعیین شماره نسخه قبلی: اگر PreviousVersionId پر باشد از versionService استفاده می‌کنیم
            VersionDetail prev = null;
            if (req.PreviousVersionId.HasValue)
            {
                prev = _versionService.GetVersion(req.PreviousVersionId.Value);
            }
            else
            {
                // اگر ID نداریم، از ورودی دستی استفاده کن
                prev = new VersionDetail { Major = req.PrevMajor, Minor = req.PrevMinor, Patch = req.PrevPatch, PreRelease = "" };
            }

            if (prev == null) throw new Exception("Previous version not found for release generation.");

            // انتخاب نوع تغییر: اگر چند انتخاب باشد، اولی را اولویت می‌دهیم (کاربر ممکن است بیش از یک تیک زده باشد)
            string changeType = req.ChangeTypes != null && req.ChangeTypes.Any() ? req.ChangeTypes[0].ToLower() : "patch";
            int major = prev.Major, minor = prev.Minor, patch = prev.Patch;
            switch (changeType)
            {
                case "major": major++; minor = 0; patch = 0; break;
                case "minor": minor++; patch = 0; break;
                default: patch++; break;
            }

            // اگر pre-release مشخص شده باشد، اضافه کن (rc.1, beta.1)
            string pre = req.PreReleaseLabel;
            if (!string.IsNullOrWhiteSpace(pre))
            {
                // اگر کاربر مثلاً rc وارد کرده، تولید شماره rc بر اساس زمان/تعداد موجود می‌تواند بهتر باشه.
                // برای سادگی: rc.1
                suggestedTag = $"{major}.{minor}.{patch}-{pre}.1";
            }
            else suggestedTag = $"{major}.{minor}.{patch}";

            plan.SuggestedTag = suggestedTag;

            // نمونه دستورات برای release: merge به main و develop (در gitflow معمولاً merge به main و tag و سپس merge به develop)
            cmds.Add($"# Prepare release {suggestedTag}");
            cmds.Add($"git add -A");
            cmds.Add($"git commit -m \"Prepare release {suggestedTag}\" || echo \"No changes to commit\"");

            // push branch if requested
            if (req.PushRemote)
            {
                cmds.Add($"git push -u origin {branchName}");
            }

            // merge to main
            cmds.Add($"git checkout main");
            cmds.Add($"git pull origin main");
            cmds.Add($"git merge --no-ff {branchName} -m \"Merge release {suggestedTag}\"");
            cmds.Add($"git tag -a {suggestedTag} -m \"Release {suggestedTag}\"");
            if (req.PushRemote)
            {
                cmds.Add($"git push origin main --tags");
            }

            // merge back to develop
            cmds.Add($"git checkout develop");
            cmds.Add($"git pull origin develop");
            cmds.Add($"git merge --no-ff main -m \"Merge release {suggestedTag} back to develop\"");
            if (req.PushRemote)
            {
                cmds.Add($"git push origin develop");
            }
        }
        else if (req.Type == "hotfix")
        {
            // hotfix from main -> merge to main and develop
            cmds.Add($"# Hotfix flow: finish and merge to main + develop");
            if (req.PushRemote) cmds.Add($"git push -u origin {branchName}");
            cmds.Add($"git checkout main");
            cmds.Add($"git pull origin main");
            cmds.Add($"git merge --no-ff {branchName} -m \"Merge hotfix {branchName}\"");
            // tag optional
            if (!string.IsNullOrWhiteSpace(req.PreReleaseLabel))
            {
                var tagLabel = $"{branchName}-{DateTime.UtcNow:yyyyMMddHHmm}";
                plan.SuggestedTag = tagLabel;
                cmds.Add($"git tag -a {tagLabel} -m \"hotfix {branchName}\"");
                if (req.PushRemote) cmds.Add($"git push origin main --tags");
            }
            cmds.Add($"git checkout develop");
            cmds.Add($"git pull origin develop");
            cmds.Add($"git merge --no-ff main -m \"Merge hotfix {branchName} back to develop\"");
            if (req.PushRemote) cmds.Add($"git push origin develop");
        }
        else
        {
            // generic feature/release/dev/main creation
            if (req.PushRemote)
            {
                cmds.Add($"git push -u origin {branchName}");
            }
            // If user specified merge targets (From list): we can create example merge commands
            if (req.From != null && req.From.Count > 0)
            {
                foreach (var target in req.From.Where(x => x != branchName))
                {
                    cmds.Add($"# To merge {branchName} into {target} when ready:");
                    cmds.Add($"git checkout {target}");
                    cmds.Add($"git pull origin {target}");
                    cmds.Add($"git merge --no-ff {branchName} -m \"Merge {branchName} into {target}\"");
                    if (req.PushRemote) cmds.Add($"git push origin {target}");
                }
            }
        }

        // Summary
        plan.Commands = cmds;
        plan.Summary = BuildSummary(req, plan);

        return plan;
    }

    /// <summary>
    /// اسم شاخه نهایی را از روی نوع و نام درخواست شده درست می‌کند.
    /// قوانین معمول gitflow:
    /// - feature/NAME
    /// - release/x.y.z (یا release/description)
    /// - hotfix/NAME
    /// - develop/main
    /// </summary>
    private string BuildBranchName(BranchRequest req)
    {
        string cleanName = CleanBranchSegment(req.Name);
        if (string.IsNullOrWhiteSpace(cleanName))
        {
            // fallback default names
            cleanName = req.Type switch
            {
                "feature" => "feature/auto",
                "release" => "release/auto",
                "hotfix" => "hotfix/auto",
                "develop" => "develop",
                "main" => "main",
                _ => "feature/auto"
            };
        }
        else
        {
            // ensure prefix
            if (req.Type == "feature")
                cleanName = $"feature/{cleanName}";
            else if (req.Type == "release")
            {
                // if name looks like version (1.2.3) use release/1.2.3
                if (Regex.IsMatch(cleanName, @"^\d+\.\d+\.\d+(-[A-Za-z0-9\.]+)?$"))
                    cleanName = $"release/{cleanName}";
                else
                    cleanName = $"release/{cleanName}";
            }
            else if (req.Type == "hotfix")
                cleanName = $"hotfix/{cleanName}";
            else if (req.Type == "develop")
                cleanName = $"develop";
            else if (req.Type == "main")
                cleanName = $"main";
        }

        return cleanName;
    }

    private string CleanBranchSegment(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return "";
        var t = s.Trim().Trim('/');
        t = Regex.Replace(t, @"\s+", "-");
        t = Regex.Replace(t, @"[^A-Za-z0-9-_.\/]", ""); 
        t = t.Replace("//", "/");
        return t;
    }


    private string BuildSummary(BranchRequest req, BranchPlan plan)
    {
        var lines = new List<string>();
        lines.Add($"Branch: {plan.BranchName}");
        lines.Add($"Type: {req.Type}");
        if (req.From != null && req.From.Any()) lines.Add($"Based on: {string.Join(", ", req.From)}");
        lines.Add($"Remote push: {(req.PushRemote ? "yes" : "no")}");
        if (!string.IsNullOrWhiteSpace(plan.SuggestedTag)) lines.Add($"Suggested tag: {plan.SuggestedTag}");
        if (!string.IsNullOrWhiteSpace(plan.ReleaseNotes)) lines.Add($"Notes: {plan.ReleaseNotes}");
        return string.Join(" | ", lines);
    }
}


public class VersionService : IVersionService
{
    private readonly List<VersionDetail> _versions = new();

    public VersionList GetAllVersions() => new VersionList();

    public VersionDetail GetVersion(int id) => _versions.FirstOrDefault(v => v.Id == id);

    public VersionDetail CreateVersion(VersionDetail newVersion)
    {
        newVersion.Id = _versions.Any() ? _versions.Max(v => v.Id) + 1 : 1;
        _versions.Add(newVersion);
        return newVersion;
    }

    // ایجاد نسخه بعدی با انتخاب نوع تغییر و pre-release
    public VersionDetail CreateNextVersion(int previousVersionId, string changeType, string preRelease = "", string description = "")
    {
        var prev = GetVersion(previousVersionId) ?? throw new Exception("Previous version not found.");

        int major = prev.Major;
        int minor = prev.Minor;
        int patch = prev.Patch;

        switch (changeType.ToLower())
        {
            case "major": major++; minor = 0; patch = 0; break;
            case "minor": minor++; patch = 0; break;
            case "patch": patch++; break;
        }

        var newVersion = new VersionDetail
        {
            Id = _versions.Any() ? _versions.Max(v => v.Id) + 1 : 1,
            Major = major,
            Minor = minor,
            Patch = patch,
            PreRelease = preRelease,
            ParentVersionId = previousVersionId, // شاخه‌بندی
            Description = new Dictionary<string, string> { { "en", description }, { "fa", description } },
            CreatedAt = DateTime.UtcNow
        };
        _versions.Add(newVersion);
        return newVersion;
    }

}

