
using Core;
using Service.Interfaces;
using System;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static System.Formats.Asn1.AsnWriter;

namespace Service.Services;

public class GitTagService : IGitTagService
{
    public string GenerateCommand(GitTagModel model)
    {
        if (model == null) throw new ArgumentNullException(nameof(model));
        if (string.IsNullOrWhiteSpace(model.TagName))
            return "# ERROR: TagName is required";

        var lines = new List<string>();

        // Checkout branch if provided
        if (!string.IsNullOrWhiteSpace(model.Branch))
            lines.Add($"git checkout {EscapeShell(model.Branch)}");

        string tagName = model.TagName;

        // Apply VersionBump if specified (patch / minor / major)
        if (!string.IsNullOrWhiteSpace(model.VersionBump))
        {
            var m = Regex.Match(tagName, @"v?(?<major>\d+)\.(?<minor>\d+)\.(?<patch>\d+)(?:-(?<pr>.+))?");
            if (m.Success)
            {
                int major = int.Parse(m.Groups["major"].Value);
                int minor = int.Parse(m.Groups["minor"].Value);
                int patch = int.Parse(m.Groups["patch"].Value);

                switch (model.VersionBump.ToLower())
                {
                    case "patch": patch += 1; break;
                    case "minor": minor += 1; patch = 0; break;
                    case "major": major += 1; minor = 0; patch = 0; break;
                }

                tagName = $"v{major}.{minor}.{patch}";
            }
        }

        // Build tag command
        var tagArgs = new List<string>();

        if (model.IsAnnotated)
            tagArgs.Add(model.UseGpgSign ? "-s" : "-a");

        if (model.ForceReplace)
            tagArgs.Add("-f");

        if (!string.IsNullOrWhiteSpace(model.MessageFile))
            tagArgs.Add($"-F {EscapeShell(model.MessageFile)}");
        else if (!string.IsNullOrWhiteSpace(model.Message))
            tagArgs.Add($"-m \"{EscapeQuotes(model.Message)}\"");
        else if (model.IsAnnotated)
            tagArgs.Add("-m \"Release created\"");

        if (!string.IsNullOrWhiteSpace(model.PreReleaseLabel))
            tagArgs.Add($"--prerelease {EscapeShell(model.PreReleaseLabel)}");

        var targetPart = !string.IsNullOrWhiteSpace(model.Target) ? " " + EscapeShell(model.Target) : "";

        var tagCmd = $"git tag {string.Join(" ", tagArgs)} {EscapeShell(tagName)}{targetPart}".Replace("  ", " ");
        lines.Add(tagCmd);

        if (model.PushAfter)
        {
            var pushCmd = model.ForceReplace
                ? $"git push origin --force refs/tags/{EscapeShell(tagName)}"
                : $"git push origin {EscapeShell(tagName)}";
            lines.Add(pushCmd);
        }

        model.GeneratedCommand = string.Join("\n", lines);
        return model.GeneratedCommand;
    }



    // Example semantic next tags
    public IEnumerable<string> SuggestSemanticNextTags(string currentTag)
    {
        if (string.IsNullOrWhiteSpace(currentTag))
            return new[] { "v0.1.0", "v1.0.0" };

        var m = Regex.Match(currentTag, @"v?(?<major>\d+)\.(?<minor>\d+)\.(?<patch>\d+)(?:-(?<pr>.+))?");
        if (!m.Success) return new[] { currentTag + "-next", currentTag + ".1" };

        int major = int.Parse(m.Groups["major"].Value);
        int minor = int.Parse(m.Groups["minor"].Value);
        int patch = int.Parse(m.Groups["patch"].Value);

        var nextPatch = $"v{major}.{minor}.{patch + 1}";
        var nextMinor = $"v{major}.{minor + 1}.0";
        var nextMajor = $"v{major + 1}.0.0";
        var nextPrerelease = $"v{major}.{minor}.{patch + 1}-rc.1";

        return new[] { nextPatch, nextMinor, nextMajor, nextPrerelease };
    }


    // -------------------------
    // Deep Descriptions (EN + FA)
    // All enterprise-level guidance lives here (long texts)
    // -------------------------
    public string GetDescriptionEN()
    {
        return @"<div class='git-tag-guide'>
    <h2>Git Tag — Ultra-Deep Enterprise Guide</h2>

    <p>
        A <strong>Git tag</strong> is an immutable, named pointer to a commit. In enterprise environments,
        tags serve as the <em>canonical release anchor</em> for CI/CD pipelines, artifact registries,
        compliance frameworks, and long-term auditability.
    </p>

    <h3>1) Types of Tags</h3>
    <ul>
        <li>
            <strong>Lightweight Tags</strong>
            <ul>
                <li>A simple reference stored in <code>refs/tags/&lt;tag&gt;</code></li>
                <li>No metadata, no message, no signature</li>
                <li>Use for internal, temporary markers</li>
            </ul>
        </li>

        <li>
            <strong>Annotated Tags</strong>
            <ul>
                <li>Stored as full tag objects</li>
                <li>Contains: tagger, date, message, optional GPG signature</li>
                <li><strong>Required</strong> for production releases</li>
            </ul>
        </li>
    </ul>

    <h3>2) Enterprise Release Workflows</h3>
    <p>Common patterns:</p>
    <ul>
        <li>Release branches: <code>release/1.2</code> → QA → final tag</li>
        <li>Direct tagging from <code>main</code> in CD models</li>
        <li>Hotfix flow: create hotfix branch → patch → tag (e.g. <code>v1.2.4-hotfix1</code>)</li>
    </ul>

    <h3>3) Tag Immutability & Governance</h3>
    <p>Tags <em>should be immutable</em>. Avoid re-tagging after push.</p>
    <ul>
        <li>Create a new version instead (e.g. <code>v1.0.0 → v1.0.1</code>)</li>
        <li>Follow approval workflow before force push</li>
        <li>Never rewrite production tags without audit log</li>
    </ul>

    <h3>4) Signed Tags</h3>
    <ul>
        <li>Use <code>-s</code> or <code>-u &lt;key&gt;</code></li>
        <li>Required for high-compliance companies (banks, medical, government)</li>
        <li>Keys stored in HSM/KMS systems</li>
    </ul>

    <h3>5) CI/CD Interaction</h3>
    <ul>
        <li>Tags trigger release pipelines</li>
        <li>Artifacts produced from the tagged commit</li>
        <li>Attach build metadata, changelog ID, checksum</li>
    </ul>

    <h3>6) Semantic Versioning</h3>
    <pre>
MAJOR.MINOR.PATCH
v1.2.3
v1.2.3-rc.1
v1.2.3+build.20240201
    </pre>

    <h3>7) Practical Commands</h3>
    <pre>
# lightweight
git tag v1.0.0

# annotated
git tag -a v1.0.0 -m ""Release v1.0.0""

# signed
git tag -s v1.0.0 - m ""Signed release""

# tag specific commit
git tag -a v1.0.0 9fceb02 - m ""Backport""

# push tag
git push origin v1.0.0
    </ pre >

    <h3> Warnings </h3>
    <ul>
        <li> Avoid rewriting pushed tags </ li >
        <li> Never store secrets in tag messages</ li >
        <li> Always connect tags to release notes </ li >
    </ul>
</div>

";
        }

    public string GetDescriptionFA()
    {
        return @"<div class='git-tag-guide'>
    <h2>راهنمای جامع و سازمانی Git Tag — سطح Enterprise</h2>

    <p>
        <strong>تگ در گیت</strong> یک اشاره‌گر نام‌دار و پایدار به یک commit است. در سازمان‌ها، تگ پایهٔ اصلی
        فرآیندهای انتشار، CI/CD، ثبت سوابق، امنیت و ارائهٔ نسخه‌های قابل پیگیری است.
    </p>

    <h3>۱) انواع تگ</h3>
    <ul>
        <li>
            <strong>تگ سبک (Lightweight)</strong>
            <ul>
                <li>فقط یک ref ساده است</li>
                <li>بدون پیام و متادیتا</li>
                <li>مناسب برای نشانه‌گذاری داخلی</li>
            </ul>
        </li>

        <li>
            <strong>تگ Annotated</strong>
            <ul>
                <li>حاوی تاریخ، پیام، اطلاعات سازنده</li>
                <li>امکان امضای GPG</li>
                <li>نسخه‌های سازمانی باید Annotated باشند</li>
            </ul>
        </li>
    </ul>

    <h3>۲) جریان‌های سازمانی انتشار</h3>
    <ul>
        <li>انتشار بر اساس شاخهٔ release/x.y</li>
        <li>تگ‌گذاری مستقیم روی <code>main</code> در مدل CD</li>
        <li>Hotfix: ایجاد شاخه → اعمال اصلاح → تگ</li>
    </ul>

    <h3>۳) تغییرناپذیری و حاکمیت تگ</h3>
    <p>تگ‌ها پس از انتشار نباید دوباره‌نویسی شوند.</p>
    <ul>
        <li>در صورت تغییر، نسخهٔ جدید بسازید</li>
        <li>Force push فقط با تأیید رسمی</li>
        <li>تگ‌های تولیدی باید audit شوند</li>
    </ul>

    <h3>۴) تگ‌های امضاشده</h3>
    <ul>
        <li>استفاده از <code>-s</code> یا <code>-u</code></li>
        <li>مورد نیاز در شرکت‌های با حساسیت بالا</li>
        <li>کلید باید در HSM/KMS نگه‌داری شود</li>
    </ul>

    <h3>۵) تعامل با CI/CD</h3>
    <ul>
        <li>تگ باعث اجرای Pipeline انتشار می‌شود</li>
        <li>Artifact باید از خود commit تگ‌شده ساخته شود</li>
        <li>شناسهٔ بیلد، شمارهٔ تیکت و checksum الزامی است</li>
    </ul>

    <h3>۶) نسخه‌گذاری Semver</h3>
    <pre>
MAJOR.MINOR.PATCH
v1.2.3
v1.2.3-rc.1
v1.2.3+build.20240201
    </pre>

    <h3>۷) دستورات کاربردی</h3>
    <pre>
git tag v1.0.0
git tag -a v1.0.0 -m ""انتشار""
git tag -s v1.0.0 -m ""انتشار امضاشده""
git tag -a v1.0.0 9fceb02 -m ""Backport""
git push origin v1.0.0
    </pre>

    <h3>هشدارها</h3>
    <ul>
        <li>هرگز تگ منتشرشده را بازنویسی نکنید</li>
        <li>پیام تگ نباید شامل اطلاعات حساس باشد</li>
        <li>تگ باید به Release Notes لینک شود</li>
    </ul>
</div>

";
        }

    // -------------------------
    // Helpers
    // -------------------------
    private string EscapeShell(string s)
    {
        if (string.IsNullOrEmpty(s)) return s;
        // naive escape for common shells; in practice use proper shell escaping libraries if executing
        return s.Replace("\"", "\\\"");
    }

    private string EscapeQuotes(string s)
    {
        return s?.Replace("\"", "\\\"");
    }
}
