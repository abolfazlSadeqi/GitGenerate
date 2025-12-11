namespace Core;

public class ArchiveCommandModel
{
    public string TitleEn => "Create Archive from Git Repository";
    public string TitleFa => "ایجاد آرشیو از مخزن گیت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git archive [options] <commit> [files]</pre>

<h4>Examples</h4>
<pre>
git archive --format=zip HEAD > archive.zip   # Create a ZIP archive of the current commit
git archive --format=tar HEAD > archive.tar   # Create a TAR archive of the current commit
git archive --prefix=project/ HEAD > project.tar  # Create a TAR archive with prefix
</pre>

<h4>What It Does?</h4>
<p>The <strong>git archive</strong> command is used to create an archive (such as a .zip or .tar file) from a specific commit, branch, or tag in a Git repository. This is particularly useful for distributing or sharing a snapshot of the project without exposing the entire Git history.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Creating an archive of the latest commit to share or distribute.</li>
    <li>Creating an archive from a specific branch or tag for release or backup purposes.</li>
    <li>Creating an archive with a specific prefix to organize files within the archive.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use the <strong>--prefix</strong> option to organize files within the archive, especially for larger projects.</li>
    <li>Ensure the commit, branch, or tag specified is the one you want to archive, as the archive will reflect the exact state of the repository at that point in time.</li>
    <li>Choose the archive format based on the use case (e.g., .zip for easier distribution, .tar for more flexibility in extraction).</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>Cannot include files that are untracked by Git (use <strong>git add</strong> to track the files first).</li>
    <li>Does not preserve the Git history; it only includes the files in the specified commit, branch, or tag.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to specify the correct commit, branch, or tag to create the archive from.</li>
    <li>Not using the <strong>--prefix</strong> option when creating an archive for distribution, leading to all files being placed at the root level.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git archive</strong> command allows you to package up files from a specific commit, branch, or tag into an archive file. This can be useful for creating distributions or backups of your project at a specific point in time. It does not include Git history, only the state of the files in the specified commit.</p>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git archive [گزینه‌ها] <commit> [فایل‌ها]</pre>

<h4>مثال‌ها</h4>
<pre>
git archive --format=zip HEAD > archive.zip   # Create a ZIP archive of the current commit
git archive --format=tar HEAD > archive.tar   # Create a TAR archive of the current commit
git archive --prefix=project/ HEAD > project.tar  # Create a TAR archive with prefix
</pre>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git archive</strong> برای ایجاد یک آرشیو (مثل فایل .zip یا .tar) از یک commit، شاخه یا تگ خاص در مخزن گیت استفاده می‌شود. این دستور به ویژه برای ایجاد نسخه‌های پشتیبان یا توزیع پروژه‌ها مفید است، زیرا می‌توان نسخه‌ای از پروژه را بدون تاریخچه گیت استخراج و به اشتراک گذاشت.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>ایجاد یک آرشیو از آخرین commit برای اشتراک‌گذاری یا توزیع.</li>
    <li>ایجاد یک آرشیو از یک شاخه یا تگ خاص برای انتشار یا پشتیبان‌گیری.</li>
    <li>ایجاد یک آرشیو با پیشوند خاص برای سازماندهی فایل‌ها در داخل آرشیو.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>استفاده از گزینه <strong>--prefix</strong> برای سازماندهی فایل‌ها در داخل آرشیو، به ویژه برای پروژه‌های بزرگ.</li>
    <li>اطمینان حاصل کنید که commit، شاخه یا تگ انتخابی همان چیزی باشد که می‌خواهید آرشیو کنید، زیرا آرشیو وضعیت دقیق مخزن را در آن نقطه زمانی منعکس خواهد کرد.</li>
    <li>فرمت آرشیو را با توجه به کاربرد مورد نظر انتخاب کنید (مثلاً .zip برای توزیع آسان‌تر، .tar برای انعطاف‌پذیری بیشتر در استخراج).</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>فایل‌هایی که توسط گیت رهگیری نمی‌شوند را نمی‌توان در آرشیو قرار داد (ابتدا باید از دستور <strong>git add</strong> برای رهگیری فایل‌ها استفاده کنید).</li>
    <li>تاریخچه گیت در آرشیو حفظ نمی‌شود؛ فقط فایل‌ها در commit، شاخه یا تگ مشخص‌شده گنجانده می‌شوند.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن مشخص کردن commit، شاخه یا تگ صحیح برای ایجاد آرشیو.</li>
    <li>عدم استفاده از گزینه <strong>--prefix</strong> هنگام ایجاد آرشیو برای توزیع، که باعث می‌شود همه فایل‌ها در سطح ریشه آرشیو قرار گیرند.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git archive</strong> به شما این امکان را می‌دهد که فایل‌ها را از یک commit، شاخه یا تگ خاص در مخزن گیت به یک فایل آرشیو بسته‌بندی کنید. این ابزار برای ایجاد نسخه‌های پشتیبان یا توزیع پروژه در یک نقطه زمانی خاص مفید است. توجه داشته باشید که تاریخچه گیت در آرشیو گنجانده نمی‌شود و فقط وضعیت فایل‌ها در commit یا تگ مشخص‌شده ذخیره می‌شود.</p>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Commit", LabelEn="Commit/Branch/Tag", LabelFa="Commit/شاخه/تگ", Type="text", PlaceholderEn="HEAD", PlaceholderFa="HEAD", IsRequired=true },
        new GitField { Name="Format", LabelEn="Format (--format)", LabelFa="فرمت (--format)", Type="text", PlaceholderEn="zip", PlaceholderFa="zip" },
        new GitField { Name="Prefix", LabelEn="Prefix (--prefix)", LabelFa="پیشوند (--prefix)", Type="text", PlaceholderEn="project/", PlaceholderFa="project/" },
        new GitField { Name="Output", LabelEn="Output File (--output)", LabelFa="فایل خروجی (--output)", Type="text", PlaceholderEn="archive.zip", PlaceholderFa="archive.zip" }
    };
}
