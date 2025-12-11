namespace Core;

public class GitHookModel
{
    public string TitleEn => "Git Hooks - Enterprise Level Best Practices";
    public string TitleFa => "هوک‌های گیت - بهترین شیوه‌های سطح سازمانی (Enterprise)";

    public string TabOverviewEn => @"<h2>What Are Git Hooks?</h2>
<p>
Git Hooks are scripts that run automatically in response to specific Git lifecycle events
(<strong>commit</strong>, <strong>push</strong>, <strong>merge</strong>, <strong>checkout</strong>, etc).
They help large teams enforce standards, automate workflows, prevent mistakes, and ensure code quality.
</p>

<h3>Why Enterprise Teams Use Hooks</h3>
<ul>
<li>Prevent bad code before it enters the repository</li>
<li>Automate repetitive workflows to boost productivity</li>
<li>Enforce commit message and branch policies</li>
<li>Prevent pushing sensitive data or secrets</li>
<li>Run tests before merge/push operations</li>
<li>Enforce CI/CD compliance and security rules</li>
<li>Standardize quality checks across teams & departments</li>
</ul>

<h3>Local Hooks vs Server Hooks</h3>
<table class='table table-bordered'>
<tr><th>Local Hooks</th><th>Server Hooks</th></tr>
<tr><td>Run on developer machine</td><td>Run on central Git server</td></tr>
<tr><td>Used for linting, formatting, commit validation</td><td>Used for CI/CD, policy enforcement, security</td></tr>
<tr><td>Not shared automatically</td><td>Shared across the entire company</td></tr>
<tr><td>Require versioning tool (Husky, Lefthook)</td><td>Always versioned</td></tr>
</table>";

    public string TabOverviewFa => @"<h2>Git Hook چیست؟</h2>
<p>
هوک‌های گیت اسکریپت‌هایی هستند که هنگام اجرای عملیات مختلف Git مانند 
<strong>commit</strong>، <strong>push</strong>، <strong>merge</strong>، <strong>checkout</strong> و ... 
به صورت خودکار اجرا می‌شوند.  
در پروژه‌های سازمانی (Enterprise)، استفاده از آن‌ها ضروری است.
</p>

<h3>چرا تیم‌های بزرگ از هوک استفاده می‌کنند؟</h3>
<ul>
<li>جلوگیری از ورود کد بی‌کیفیت به مخزن</li>
<li>خودکارسازی وظایف تکراری</li>
<li>اجباری کردن فرمت پیام Commit</li>
<li>جلوگیری از آپلود اشتباهی اطلاعات حساس</li>
<li>اجرای تست‌ها قبل از push یا merge</li>
<li>هماهنگی با CI/CD و امنیت</li>
<li>ایجاد هماهنگی بین تیم‌ها و واحدهای سازمان</li>
</ul>

<h3>تفاوت هوک‌های محلی و سروری</h3>
<table class='table table-bordered'>
<tr><th>هوک محلی</th><th>هوک سمت سرور</th></tr>
<tr><td>روی سیستم توسعه‌دهنده اجرا می‌شود</td><td>روی سرور مرکزی Git اجرا می‌شود</td></tr>
<tr><td>برای lint، format، validation مناسب است</td><td>برای CI/CD و سیاست‌های امنیتی ضروری است</td></tr>
<tr><td>به صورت خودکار به اشتراک گذاشته نمی‌شود</td><td>برای همه اعضای تیم مشترک است</td></tr>
<tr><td>نیازمند ابزار versioning مثل Husky</td><td>بدون ابزار خارجی نسخه‌بندی می‌شود</td></tr>
</table>";

    public string TabActivationEn => @"<h2>How to Activate a Git Hook</h2>
<p>Hooks live inside the <code>.git/hooks</code> folder.</p>

<ol>
<li>Go to: <code>.git/hooks/</code></li>
<li>Rename the file you want (ex: <code>pre-commit.sample</code> → <code>pre-commit</code>)</li>
<li>Make it executable: <code>chmod +x pre-commit</code></li>
<li>Write your script in it</li>
</ol>

<h3>Example: Very simple hook</h3>
<pre>
#!/bin/sh
echo ""Running Git Hook...""
</pre>

<h3>Using Modern Hook Managers</h3>
<ul>
<li><strong>Husky</strong> (best for JS/Node teams)</li>
<li><strong>Lefthook</strong> (best for multi-language teams)</li>
<li><strong>pre-commit</strong> (best for Python teams)</li>
<li><strong>Overcommit</strong> (Ruby teams)</li>
</ul>";

    public string TabActivationFa => @"<h2>چطور Git Hook را فعال کنیم؟</h2>
<p>هوک‌ها داخل مسیر <code>.git/hooks</code> قرار دارند.</p>

<ol>
<li>به مسیر <code>.git/hooks</code> بروید</li>
<li>فایل نمونه را rename کنید (<code>pre-commit.sample</code> → <code>pre-commit</code>)</li>
<li>فایل را اجرایی کنید: <code>chmod +x pre-commit</code></li>
<li>کد اسکریپت را داخل آن بنویسید</li>
</ol>

<h3>نمونه ساده:</h3>
<pre>
#!/bin/sh
echo ""Pre-commit اجرا شد...""
</pre>

<h3>ابزارهای مدرن مدیریت هوک‌ها</h3>
<ul>
<li><strong>Husky</strong> – بهترین برای تیم‌های JavaScript</li>
<li><strong>Lefthook</strong> – بهترین برای تیم‌های چندزبانه</li>
<li><strong>pre-commit</strong> – محبوب برای Python</li>
<li><strong>Overcommit</strong> – مناسب برای Ruby</li>
</ul>";

    public string TabAllHooksEn => @"
<h2>Complete List of All Git Hooks + Professional Usage</h2>
<p>This is the most complete and enterprise-grade explanation of Git hooks available.</p>

<style>
.tablex{width:100%;border-collapse:collapse;}
.tablex th,.tablex td{border:1px solid #ccc;padding:8px;}
.tablex th{background:#0d6efd;color:#fff;}
.tablex tr:nth-child(even){background:#f6f9ff;}
</style>

<table class='tablex'>
<tr><th>Hook</th><th>Event</th><th>Usage</th><th>Enterprise Notes</th></tr>

<tr><td>pre-commit</td><td>Before commit</td><td>Lint, format, security checks</td><td>Must be fast</td></tr>
<tr><td>prepare-commit-msg</td><td>Before editor launches</td><td>Add templates, insert Jira ID</td><td>Great for company workflows</td></tr>
<tr><td>commit-msg</td><td>After writing commit message</td><td>Validate Conventional Commit</td><td>Stops invalid commits</td></tr>
<tr><td>post-commit</td><td>After commit</td><td>Notify, analytics</td><td>Non-blocking</td></tr>

<tr><td>pre-push</td><td>Before push</td><td>Run tests, prevent pushing to main</td><td>Safe for heavy tasks</td></tr>
<tr><td>pre-rebase</td><td>Before rebase</td><td>Block rebase on protected branches</td><td>Critical in enterprise repos</td></tr>
<tr><td>post-rewrite</td><td>After amend/rebase</td><td>Recalculate logs</td><td>Useful for analytics</td></tr>

<tr><td>post-merge</td><td>After merge</td><td>Install dependencies, rebuild</td><td>Excellent for onboarding</td></tr>
<tr><td>post-checkout</td><td>After switching branch</td><td>Switch configs/env</td><td>Used in monorepos</td></tr>

<tr><td>pre-receive</td><td>Server: before accepting push</td><td>Security, policy checks</td><td>Enterprise-critical</td></tr>
<tr><td>post-receive</td><td>Server: after accepting push</td><td>Trigger CI/CD</td><td>Core for deployments</td></tr>
<tr><td>update</td><td>Server: update refs</td><td>Validate branch-by-branch</td><td>Mandatory in regulated systems</td></tr>

<tr><td>fsmonitor-watchman</td><td>Performance hook</td><td>Improve Git speed</td><td>Used in huge codebases</td></tr>
<tr><td>pre-auto-gc</td><td>Before garbage collection</td><td>Cleanup tasks</td><td>Rare but useful</td></tr>
</table>";

    public string TabAllHooksFa => @"
<h2>فهرست کامل تمام هوک‌های Git + توضیح سازمانی</h2>

<style>
.tablex{width:100%;border-collapse:collapse;}
.tablex th,.tablex td{border:1px solid #ccc;padding:8px;}
.tablex th{background:#0d6efd;color:#fff;}
.tablex tr:nth-child(even){background:#f1f7ff;}
</style>

<table class='tablex'>
<tr><th>هوک</th><th>زمان اجرا</th><th>کاربرد</th><th>نکات حرفه‌ای</th></tr>

<tr><td>pre-commit</td><td>قبل از commit</td><td>Lint, Format, امنیت</td><td>سریع باشد</td></tr>
<tr><td>prepare-commit-msg</td><td>قبل از باز شدن ویرایشگر</td><td>درج شماره تیکت</td><td>ضروری در Jira/DevOps</td></tr>
<tr><td>commit-msg</td><td>بعد از نوشتن پیام</td><td>اعتبارسنجی پیام</td><td>خطا → توقف commit</td></tr>
<tr><td>post-commit</td><td>بعد از commit</td><td>ثبت، اعلان</td><td>غیرمسدودکننده</td></tr>

<tr><td>pre-push</td><td>قبل از push</td><td>تست‌ها، جلوگیری از push روی main</td><td>مناسب کارهای سنگین</td></tr>
<tr><td>pre-rebase</td><td>قبل از rebase</td><td>کنترل شاخه‌ها</td><td>حیاتی</td></tr>
<tr><td>post-rewrite</td><td>بعد از rebase</td><td>آپدیت لاگ</td><td></td></tr>

<tr><td>post-merge</td><td>بعد از merge</td><td>Install، Build</td><td>عالی برای monorepo</td></tr>
<tr><td>post-checkout</td><td>بعد از checkout</td><td>لود تنظیمات</td><td></td></tr>

<tr><td>pre-receive</td><td>سروری</td><td>امنیت و سیاست‌ها</td><td>سازمانی</td></tr>
<tr><td>post-receive</td><td>سروری</td><td>CI/CD</td><td>DevOps</td></tr>
<tr><td>update</td><td>سروری</td><td>اعتبارسنجی refs</td><td></td></tr>

<tr><td>fsmonitor-watchman</td><td>افزایش سرعت</td><td>بهبود کارایی</td><td>پروژه‌های خیلی بزرگ</td></tr>
<tr><td>pre-auto-gc</td><td>قبل از GC</td><td>پاکسازی</td><td></td></tr>
</table>";

    public string TabMistakesEn => @"<h2>Common Developer Mistakes</h2>
<ul>
<li>Hooks running too slow → developers disable them</li>
<li>Not versioning hooks → inconsistent team workflows</li>
<li>Using OS-specific code (bad for mixed teams)</li>
<li>Hardcoding paths</li>
<li>Not logging hook outputs</li>
<li>Putting CI responsibilities inside local hooks</li>
<li>Scanning entire repository instead of staged files</li>
</ul>";

    public string TabMistakesFa => @"<h2>اشتباهات رایج توسعه‌دهندگان</h2>
<ul>
<li>کند بودن هوک‌ها → توسعه‌دهنده آن را غیرفعال می‌کند</li>
<li>نسخه‌بندی نکردن → عدم هماهنگی بین تیم</li>
<li>کد وابسته به سیستم‌عامل (ویندوز/لینوکس)</li>
<li>Hardcode مسیرها</li>
<li>عدم ثبت خروجی خطا</li>
<li>قرار دادن وظایف CI داخل هوک‌ها</li>
<li>اسکن کردن کل پروژه به‌جای فایل‌های staged</li>
</ul>";

    public string TabBestEn => @"<h2>Enterprise Best Practices</h2>
<ul>
<li>Hooks must be <strong>fast</strong></li>
<li>Keep all hooks <strong>versioned</strong> using Husky/Lefthook</li>
<li>Always use <code>exit 1</code> on failure</li>
<li>Use <strong>pre-commit</strong> for quality checks</li>
<li>Use <strong>pre-push</strong> for tests</li>
<li>Use <strong>commit-msg</strong> to enforce Conventional Commits</li>
<li>Keep logs for auditing in large companies</li>
<li>Use cross-platform tools (Node, Python)</li>
<li>Document every hook inside README</li>
<li>Never rely solely on hooks — always have CI/CD</li>
</ul>";

    public string TabBestFa => @"<h2>بهترین شیوه‌های سازمانی</h2>
<ul>
<li>هوک‌ها باید <strong>سریع</strong> باشند</li>
<li>نسخه‌بندی با Husky/Lefthook</li>
<li>خطا → <code>exit 1</code></li>
<li>استفاده از pre-commit برای کیفیت کد</li>
<li>استفاده از pre-push برای تست‌ها</li>
<li>استفاده از commit-msg برای استاندارد Commit</li>
<li>ثبت لاگ‌ها برای سیستم‌های سازمانی</li>
<li>استفاده از اسکریپت‌های Cross-platform</li>
<li>مستندسازی دقیق تمامی هوک‌ها</li>
<li>تکیه نکردن صرفاً به هوک‌ها؛ CI ضروری است</li>
</ul>";

    public string TabExamplesEn => @"
<h2>Real world hook examples</h2>

<h3>1) Pre-commit (JS Lint + Prevent Secrets)</h3>
<pre>
#!/bin/sh
files=$(git diff --cached --name-only --diff-filter=ACM)

echo ""Running ESLint...""
npx eslint $files || exit 1

if grep -R ""AWS_SECRET"" $files ; then
  echo ""Secret detected! Commit blocked.""
  exit 1
fi
</pre>

<h3>2) commit-msg (Conventional Commit)</h3>
<pre>
#!/bin/sh
msg=$(cat $1)
pattern='^(feat|fix|docs|style|refactor|test|chore)(\(.+\))?: .+'
echo $msg | grep -Eq ""$pattern"" || {
    echo ""Invalid commit message""
    exit 1
}
</pre>";

    public string TabExamplesFa => @"
<h2>نمونه‌های واقعی هوک‌ها</h2>

<h3>۱) pre-commit (بررسی Lint + جلوگیری از Secrets)</h3>
<pre>
#!/bin/sh
files=$(git diff --cached --name-only --diff-filter=ACM)

echo ""اجرای ESLint...""
npx eslint $files || exit 1

if grep -R ""AWS_SECRET"" $files ; then
  echo ""Secret یافت شد! Commit مسدود شد.""
  exit 1
fi
</pre>

<h3>۲) commit-msg (اعتبارسنجی پیام Conventional Commit)</h3>
<pre>
#!/bin/sh
msg=$(cat $1)
pattern='^(feat|fix|docs|style|refactor|test|chore)(\(.+\))?: .+'
echo $msg | grep -Eq ""$pattern"" || {
    echo ""فرمت پیام معتبر نیست!""
    exit 1
}
</pre>";
}
