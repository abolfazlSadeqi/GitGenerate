using System;
using System.Collections.Generic;

namespace Core
{
    public class GitStandardsModel
    {
        public string Language { get; set; } = "EN"; // "EN" or "FA"
        public List<GitStandardsTab> Tabs { get; set; } = new List<GitStandardsTab>();

        public GitStandardsModel()
        {
            // populate the ~20 tabs (EN / FA content)
            Tabs.Add(new GitStandardsTab
            {
                Id = "commit-standards",
                TitleEn = "Commit Standards",
                TitleFa = "استانداردهای کامیت",
                ContentEn = @"<h3>Purpose</h3>
<p>Commit messages are the primary human-readable history of a repository. Strict standards increase traceability, enable automated changelogs, and help reviewers.</p>
<h4>Core Rules (EN)</h4>
<ul>
<li>Use <strong>Conventional Commits</strong> style: <code>type(scope?): subject</code></li>
<li>Types: <code>feat</code>, <code>fix</code>, <code>chore</code>, <code>docs</code>, <code>refactor</code>, <code>perf</code>, <code>test</code>, <code>build</code>, <code>ci</code>, <code>revert</code></li>
<li>Subject: present-tense, no trailing period, max 72 chars recommended</li>
<li>Body: wrap at 72 chars, explain WHY (not only WHAT)</li>
<li>Footer: reference issues, breaking changes: <code>BREAKING CHANGE: ...</code></li>
</ul>
<h4>Examples</h4>
<pre>feat(auth): add JWT expiration check

fix(api): handle null user when calling /me

docs(readme): add upgrade notes for v2</pre>
<h4>Why enforce?</h4>
<p>Automation (releases, changelogs), better reviews, easier bisecting and auditing.</p>",
                ContentFa = @"<h3>هدف</h3>
<p>پیام‌های کامیت تاریخچهٔ قابل خواندن توسط انسانِ مخزن هستند. استاندارد قوی قابل ردیابی بودن را افزایش می‌دهد، ساخت خودکار چَنج‌لاگ را ممکن می‌سازد و فرآیند بررسی را ساده می‌کند.</p>
<h4>قوانین اصلی (فارسی)</h4>
<ul>
<li>از قالب <strong>Conventional Commits</strong> استفاده کنید: <code>type(scope?): subject</code></li>
<li>Typeها: <code>feat</code>, <code>fix</code>, <code>chore</code>, <code>docs</code>, <code>refactor</code>, <code>perf</code>, <code>test</code>, <code>build</code>, <code>ci</code>, <code>revert</code></li>
<li>Subject: زمان حال، بدون نقطهٔ پایانی، حداکثر ۷۲ کاراکتر پیشنهاد می‌شود</li>
<li>بدنه: در ۷۲ کاراکتر شکست بزنید، دلیل را توضیح دهید نه فقط چه چیزی تغییر کرده</li>
<li>فوتر: ارجاع به issueها و تغییرات breaking: <code>BREAKING CHANGE: ...</code></li>
</ul>
<h4>مثال‌ها</h4>
<pre>feat(auth): افزودن بررسی انقضای JWT

fix(api): هندل کردن null برای user در endpoint /me

docs(readme): افزودن نکات ارتقا به نسخهٔ v2</pre>
<h4>چرا اجرا؟</h4>
<p>برای خودکارسازی انتشار، بهتر شدن بررسی‌ها و آسان‌تر شدن ردگیری و حسابرسی تاریخچه.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "branching-standards",
                TitleEn = "Branching Standards",
                TitleFa = "استانداردهای شاخه‌بندی",
                ContentEn = @"<h4>Overview</h4>
<p>Define types of branches and naming rules: main, develop, feature/, hotfix/, release/.</p>
<h4>Naming</h4>
<ul>
<li><code>main</code> — production-ready</li>
<li><code>develop</code> — integration branch (optional)</li>
<li><code>feature/ISSUE-123-add-login</code></li>
<li><code>hotfix/v1.2.1</code></li>
<li><code>release/1.2.0</code></li>
</ul>
<h4>Rules</h4>
<ul>
<li>Protect main with branch protection rules (require PR, status checks, signed commits optional)</li>
<li>Short-lived feature branches (<= 2 weeks)</li>
<li>Use PRs for any merge into main/release</li>
</ul>",
                ContentFa = @"<h4>نمای کلی</h4>
<p>انواع شاخه و قوانین نام‌گذاری: main، develop، feature/، hotfix/، release/ را تعریف کنید.</p>
<h4>نام‌گذاری</h4>
<ul>
<li><code>main</code> — آمادهٔ تولید</li>
<li><code>develop</code> — شاخهٔ یکپارچه‌سازی (اختیاری)</li>
<li><code>feature/ISSUE-123-add-login</code></li>
<li><code>hotfix/v1.2.1</code></li>
<li><code>release/1.2.0</code></li>
</ul>
<h4>قوانین</h4>
<ul>
<li>محافظت از main با قوانین branch protection (PR اجباری، چک‌های وضعیت)</li>
<li>شاخه‌های feature کوتاه‌مدت (<= ۲ هفته)</li>
<li>هر merge به main/release باید از طریق PR باشد</li>
</ul>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "pull-requests",
                TitleEn = "Pull Requests & Reviews",
                TitleFa = "Pull Request و بازبینی‌ها",
                ContentEn = @"<h4>PR Templates</h4>
<p>Always use PR templates: description, testing steps, checklist, linked issues.</p>
<h4>Review Rules</h4>
<ul>
<li>Require at least 1-2 approvals depending on impact</li>
<li>Run CI checks and ensure green before merging</li>
<li>Small PRs (<200 lines) preferred</li>
</ul>
<h4>Labels & Branches</h4>
<p>Use labels: bug, enhancement, docs, chore. Use WIP label for in-progress PRs.</p>",
                ContentFa = @"<h4>قالب‌های PR</h4>
<p>همیشه از قالب PR استفاده کنید: توضیحات، مراحل تست، چک‌لیست، issueهای مرتبط.</p>
<h4>قوانین بازبینی</h4>
<ul>
<li>نیاز به ۱–۲ تأیید بر اساس اثرگذاری</li>
<li>اجرای CI و موفقیت قبل از merge</li>
<li>PRهای کوچک (<۲۰۰ خط) ترجیح داده شوند</li>
</ul>
<h4>لیبل‌ها و شاخه‌ها</h4>
<p>از لیبل‌ها استفاده کنید: bug، enhancement، docs، chore. از لیبل WIP برای در‌حال‌توسعه استفاده کنید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "merge-strategies",
                TitleEn = "Merge Strategies",
                TitleFa = "استراتژی‌های Merge",
                ContentEn = @"<h4>Common Strategies</h4>
<ul>
<li><strong>Merge commit</strong>: preserves branch history; use for release merges.</li>
<li><strong>Squash merge</strong>: collapses feature branch into single commit; good for small changes.</li>
<li><strong>Rebase and merge</strong>: keeps linear history; use with caution for shared branches.</li>
</ul>
<h4>Policy</h4>
<p>Protect main: require PR, CI, and one of (squash | merge) as per repo policy. Avoid force-push on shared branches.</p>",
                ContentFa = @"<h4>استراتژی‌های رایج</h4>
<ul>
<li><strong>Merge commit</strong>: تاریخچهٔ شاخه را حفظ می‌کند؛ مناسب برای mergeهای release.</li>
<li><strong>Squash merge</strong>: همه تغییرات شاخه را به یک کامیت تبدیل می‌کند؛ برای تغییرات کوچک مناسب است.</li>
<li><strong>Rebase and merge</strong>: تاریخچهٔ خطی ایجاد می‌کند؛ در شاخه‌های مشترک با احتیاط استفاده شود.</li>
</ul>
<h4>سیاست</h4>
<p>main را محافظت کنید: PR، CI و انتخاب روش merge مطابق سیاست سازمان. از force-push روی شاخه‌های مشترک خودداری کنید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "tagging-releases",
                TitleEn = "Tagging & Releases",
                TitleFa = "تگ‌گذاری و ریلیز",
                ContentEn = @"<h4>Annotated vs Lightweight</h4>
<p>Use annotated (+signed) tags for production releases to include metadata and signatures.</p>
<h4>Versioning</h4>
<p>Adopt SemVer: MAJOR.MINOR.PATCH. Use pre-release identifiers: -rc, -beta, and build metadata +build.<date>.</p>
<h4>Release Process</h4>
<ul>
<li>Tag from a release commit or CI artifact</li>
<li>Attach checksums and release notes</li>
<li>Store artifacts in immutable artifact registry</li>
</ul>",
                ContentFa = @"<h4>Annotated در مقابل Lightweight</h4>
<p>برای ریلیزهای تولید از تگ‌های annotated (و امضا شده) استفاده کنید تا متادیتا و امضا ذخیره شود.</p>
<h4>نسخه‌گذاری</h4>
<p>از SemVer استفاده کنید: MAJOR.MINOR.PATCH. برای پیش‌انتشارها از -rc و -beta و برای متادیتای بیلد از +build.<date> استفاده کنید.</p>
<h4>فرآیند ریلیز</h4>
<ul>
<li>تگ از کامیت ریلیز یا artifact ساخته شده توسط CI</li>
<li>ضمیمه کردن checksum و release notes</li>
<li>ذخیرهٔ artifactها در ریجستری غیرقابل تغییر</li>
</ul>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "ci-cd",
                TitleEn = "CI / CD Integration",
                TitleFa = "یکپارچه‌سازی CI/CD",
                ContentEn = @"<h4>Key Principles</h4>
<ul>
<li>Build from a tagged commit or immutable artifact</li>
<li>Do not trust unverified user tags — create release tags in CI or via release managers</li>
<li>Embed commit SHA and build metadata in artifacts</li>
</ul>
<h4>Checks</h4>
<p>Require unit tests, linting, security scans, and license checks on PRs and release pipelines.</p>",
                ContentFa = @"<h4>اصول کلیدی</h4>
<ul>
<li>بیلد از تگ یا artifact غیرقابل تغییر انجام شود</li>
<li>تگ‌های ایجادشده توسط کاربران تاییدنشده قابل اعتماد نباشند — تگ نهایی توسط CI یا release manager ساخته شود</li>
<li>SHA کامیت و متادیتای بیلد را در artifactها درج کنید</li>
</ul>
<h4>چک‌ها</h4>
<p>اجرای تست‌ها، lint، اسکن امنیتی و بررسی لایسنس در PR و pipelineهای ریلیز ضروری است.</p>"
            });

          
            Tabs.Add(new GitStandardsTab
            {
                Id = "gitignore-lfs",
                TitleEn = "Repo Hygiene (.gitignore / LFS)",
                TitleFa = "  (.gitignore / LFS)",
                ContentEn = @"<h4>.gitignore</h4>
<p>Maintain repo-level and global .gitignore. Avoid committing build outputs and secrets.</p>
<h4>Git LFS</h4>
<p>Use Git LFS for large binaries; set size thresholds in repo policy.</p>",
                ContentFa = @"<h4>.gitignore</h4>
<p>.gitignore سطح مخزن و سراسری را نگه دارید. از commit کردن خروجی‌های build و اسرار خودداری کنید.</p>
<h4>Git LFS</h4>
<p>برای فایل‌های بزرگ از Git LFS استفاده کنید؛ آستانهٔ اندازه‌ها را در سیاست مخزن تعیین کنید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "hooks-automation",
                TitleEn = "Hooks & Automation",
                TitleFa = "Hooks & Automation",
                ContentEn = @"<h4>Client Hooks</h4>
<p>Pre-commit hooks for linting, formatting and basic secret scanning. Provide a common hooks repo.</p>
<h4>Server Hooks</h4>
<p>Server-side hooks for policy enforcement: deny force-push, ensure commit signature, check branch names.</p>",
                ContentFa = @"<h4>هوک‌های کلاینت</h4>
<p>هوک‌های pre-commit برای lint، فرمتینگ و اسکن اولیهٔ اسرار. یک repo مشترک برای هوک‌ها فراهم کنید.</p>
<h4>هوک‌های سرور</h4>
<p>هوک‌های سرور برای اعمال سیاست: جلوگیری از force-push، اطمینان از امضای کامیت، بررسی نام شاخه‌ها.</p>"
            });


            Tabs.Add(new GitStandardsTab
            {
                Id = "merge-vs-rebase",
                TitleEn = "Rebase vs Merge (Detailed)",
                TitleFa = "Rebase در برابر Merge (توضیحات کامل)",
                ContentEn = @"<h4>Merge</h4>
<p>Creates a merge commit that preserves the branch topology. Pros: history of how branches were integrated; cons: more complex history.</p>
<h4>Rebase</h4>
<p>Rewrites commits onto another base producing linear history. Pros: clean linear history; cons: rewrites hashes — avoid on public/shared branches.</p>
<h4>When to use which</h4>
<ul>
<li>Use merge commits for release branches and where history of integration is important</li>
<li>Use rebase for local cleanups before PR to keep history linear</li>
<li>Never rebase shared branches without coordination</li>
</ul>
<h4>Examples</h4>
<pre># merge
git checkout main
git merge feature/foo

# rebase
git checkout feature/foo
git rebase main
git checkout main
git merge --ff-only feature/foo</pre>",
                ContentFa = @"<h4>Merge</h4>
<p>یک کامیت merge ایجاد می‌کند که توپولوژی شاخه را حفظ می‌کند. مزایا: تاریخچهٔ ادغام واضح؛ معایب: تاریخچه پیچیده‌تر.</p>
<h4>Rebase</h4>
<p>کامیت‌ها را روی یک بیس دیگر بازنویسی می‌کند و تاریخچهٔ خطی می‌سازد. مزایا: تاریخچهٔ تمیز؛ معایب: بازنویسی هش‌ها — در شاخه‌های عمومی باید احتیاط شود.</p>
<h4>چه زمانی از هرکدام استفاده کنیم</h4>
<ul>
<li>برای شاخه‌های ریلیز و جایی که تاریخچهٔ ادغام مهم است از merge استفاده کنید</li>
<li>برای پاک‌سازی محلی قبل از PR از rebase استفاده کنید تا تاریخچه خطی شود</li>
<li>هرگز بدون هماهنگی شاخه‌های مشترک را rebase نکنید</li>
</ul>
<h4>مثال‌ها</h4>
<pre># merge
git checkout main
git merge feature/foo

# rebase
git checkout feature/foo
git rebase main
git checkout main
git merge --ff-only feature/foo</pre>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "large-repos",
                TitleEn = "Monorepo & Large Repos",
                TitleFa = "Monorepo و مخازن بزرگ",
                ContentEn = @"<h4>Considerations</h4>
<ul>
<li>Per-package versioning or directory-based releases</li>
<li>Shallow clones and sparse-checkout for CI</li>
<li>Split CI to run only impacted modules</li>
</ul>",
                ContentFa = @"<h4>نکات</h4>
<ul>
<li>نسخه‌بندی در سطح پکیج یا انتشار مبتنی بر دایرکتوری</li>
<li>استفاده از shallow clone و sparse-checkout در CI</li>
<li>تقسیم CI برای اجرای فقط ماژول‌های تحت تاثیر</li>
</ul>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "branch-protection",
                TitleEn = "Branch Protection",
                TitleFa = "محافظت از شاخه",
                ContentEn = @"<h4>Rules</h4>
<ul>
<li>Require PR reviews</li>
<li>Require passing CI checks</li>
<li>Restrict who can push or merge</li>
<li>Optional: require signed commits</li>
</ul>",
                ContentFa = @"<h4>قوانین</h4>
<ul>
<li>پرداختن به PR و بررسی‌ها</li>
<li>نیاز به عبور CI</li>
<li>محدود کردن افراد مجاز برای push/merge</li>
<li>اختیاری: نیاز به کامیت‌های امضا شده</li>
</ul>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "changelog",
                TitleEn = "Changelog & Release Notes",
                TitleFa = "چَنج‌لاگ و Release Notes",
                ContentEn = @"<h4>Auto-generation</h4>
<p>Use Conventional Commit messages to auto-generate changelogs. Ensure PR descriptions and issue links are present.</p>",
                ContentFa = @"<h4>تولید خودکار</h4>
<p>از Conventional Commits برای تولید خودکار چَنج‌لاگ استفاده کنید. توضیحات PR و لینک issueها را درج کنید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "review-checklist",
                TitleEn = "Code Review Checklist",
                TitleFa = "چک‌لیست بررسی کد",
                ContentEn = @"<ul>
<li>Does the change have tests?</li>
<li>Is API backwards-compatible?</li>
<li>Is documentation updated?</li>
<li>Are security concerns addressed?</li>
</ul>",
                ContentFa = @"<ul>
<li>آیا تغییر تست دارد؟</li>
<li>آیا API سازگار با گذشته است؟</li>
<li>آیا مستندات بروز شده اند؟</li>
<li>مسائل امنیتی بررسی شده؟</li>
</ul>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "automation-ci",
                TitleEn = "Automation: Housekeeping & CI",
                TitleFa = "اتوماسیون: نگهداری و CI",
                ContentEn = @"<p>Automate dependency updates, formatters, and periodic maintenance tasks with bots (dependabot, renovate).</p>",
                ContentFa = @"<p>به‌روزرسانی وابستگی‌ها، فرمترها و نگهداری دوره‌ای را با ربات‌ها اتوماتیک کنید (dependabot, renovate).</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "best-practices",
                TitleEn = "Best Practices Summary",
                TitleFa = "خلاصه بهترین شیوه‌ها",
                ContentEn = @"<ul>
<li>Small commits, meaningful messages</li>
<li>Protected branches and required CI</li>
<li>Automate what can be automated</li>
<li>Keep secrets out of repo</li>
</ul>",
                ContentFa = @"<ul>
<li>کامیت‌های کوچک و پیام‌های معنادار</li>
<li>شاخه‌های محافظت‌شده و CI اجباری</li>
<li>اتوماسیون برای آنچه قابل اتومات است</li>
<li>محرمانه‌ها از مخزن دور باشند</li>
</ul>"
            });

            // add more tabs if you want (hooks, LFS details, signing, etc.)
            Tabs.Add(new GitStandardsTab
            {
                Id = "hooks-details",
                TitleEn = "Client & Server Hooks",
                TitleFa = "هوک‌های کلاینت و سرور",
                ContentEn = @"<p>Distribute standard pre-commit hooks, use pre-push and server-side enforcement for policy. Store hooks in repo and provide installer script.</p>",
                ContentFa = @"<p>هوک‌های استاندارد pre-commit را توزیع کنید، از pre-push و اعمال سروری برای پیاده‌سازی سیاست استفاده کنید. هوک‌ها را در مخزن نگه دارید و اسکریپت نصب ارائه دهید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "signing",
                TitleEn = "Signing (GPG / SSH)",
                TitleFa = "امضا (GPG / SSH)",
                ContentEn = @"<p>When required, sign commits and tags. Central key management recommended. CI verifying signatures improves supply-chain security.</p>",
                ContentFa = @"<p>در صورت نیاز، کامیت‌ها و تگ‌ها را امضا کنید. مدیریت مرکزی کلیدها توصیه می‌شود. CI بررسی امضاها را برای امنیت زنجیره تامین تقویت می‌کند.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "access-control",
                TitleEn = "Access & Roles",
                TitleFa = "دسترسی و نقش‌ها",
                ContentEn = @"<p>Define roles: Reader, Developer, Release Manager, Admin. Apply least-privilege and review access periodically.</p>",
                ContentFa = @"<p>نقش‌ها را تعریف کنید: خواننده، توسعه‌دهنده، مدیر ریلیز، ادمین. اصل حداقل دسترسی را اجرا و دسترسی را دوره‌ای بررسی کنید.</p>"
            });

            Tabs.Add(new GitStandardsTab
            {
                Id = "repo-structure",
                TitleEn = "Repository Structure",
                TitleFa = "ساختار مخزن",
                ContentEn = @"<p>Define standard directories (src/, tests/, docs/, scripts/, ci/) and enforce with templates.</p>",
                ContentFa = @"<p>دایرکتوری‌های استاندارد را تعریف کنید (src/, tests/, docs/, scripts/, ci/) و با قالب‌ها اعمال کنید.</p>"
            });
        }
    }

    public class GitStandardsTab
    {
        public string Id { get; set; }
        public string TitleEn { get; set; }
        public string TitleFa { get; set; }
        public string ContentEn { get; set; }
        public string ContentFa { get; set; }
    }
    


}
