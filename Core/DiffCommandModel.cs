namespace Core;

public class DiffCommandModel
{
    public string TitleEn => "View Differences";
    public string TitleFa => "مشاهده تفاوت‌ها";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git diff [options] [<commit>] [<path>]</pre>

<h4>What is Git Diff?</h4>
<p>The <strong>git diff</strong> command shows the differences between the working directory and the index, between commits, or between commits and the working directory. It helps you compare changes between commits or inspect changes made in the working directory and staged files.</p>

<h4>Examples</h4>
<pre>
# Show changes between the working directory and the index
git diff

# Show changes between a specific commit and the working directory
git diff <commit>

# Show changes between two commits
git diff <commit1> <commit2>

# Show changes for a specific file
git diff <commit> <file>

# Show changes in a specific file in the working directory
git diff <file>
</pre>

<h4>Limitations</h4>
<ul>
<li>Can be overwhelming for large files or many changes</li>
<li>Does not show changes in untracked files unless specified</li>
<li>Can show a lot of output if there are many differences</li>
</ul>

<h4>Options</h4>
<ul>
<li>-w : Ignore all white space when comparing</li>
<li>--color : Show colored output</li>
<li>--name-only : Show only the names of changed files</li>
<li>--stat : Show statistics for the changes (number of lines added/deleted)</li>
<li>--patch : Show the patch (changes) for each file</li>
<li>--cached : Show changes between the index and the last commit</li>
<li>--staged : Show staged changes</li>
<li>--no-index : Compare files that are not in the Git index</li>
<li>--diff-filter : Filter diffs based on file status (e.g., 'A' for added, 'M' for modified)</li>
</ul>

<h4>Use Cases</h4>
<ul>
    <li>Inspecting changes made to files between commits</li>
    <li>Reviewing staged changes before committing</li>
    <li>Checking changes made to the working directory before staging them</li>
    <li>Comparing different commits to understand how the code has evolved</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to specify a commit hash or file, which can lead to viewing unnecessary differences.</li>
    <li>Using the wrong options, such as `--staged` when intending to view changes in the working directory.</li>
    <li>Confusing the output of `git diff` with `git status`—`git diff` shows actual file content changes, whereas `git status` shows file status.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Always check the changes in your working directory before committing, especially in a large codebase.</li>
    <li>Use `git diff --cached` to inspect staged changes before finalizing your commit.</li>
    <li>Use the `--stat` option to get a quick overview of the number of changes made.</li>
    <li>For better clarity, enable `--color` for color-coded output that highlights changes more effectively.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Does not show changes in files that are ignored by Git.</li>
    <li>Can become cumbersome for very large repositories with a large number of changes.</li>
    <li>For untracked files, it is necessary to specify options such as `git diff --no-index` to compare them.</li>
</ul>

<h3>How to Use</h3>
<p>Git diff allows you to view changes in various ways, whether between commits, working directory and index, or staged and unstaged changes. It is a vital tool for reviewing and managing code changes before committing them.</p>

<h2>Overview</h2>
<p>In a collaborative development environment, using <strong>git diff</strong> enables you to review the differences between various states of your code, helping you identify what has been changed and ensuring you are fully aware of the changes before pushing or committing them.</p>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git diff [گزینه‌ها] [<کامیت>] [<مسیر>]</pre>

<h4>Git Diff چیست؟</h4>
<p>دستور <strong>git diff</strong> تفاوت‌ها را بین دایرکتوری کاری، ایندکس و کامیت‌ها نمایش می‌دهد. این دستور به شما کمک می‌کند تا تغییرات بین نسخه‌ها را بررسی کنید یا تغییرات اعمال‌شده در دایرکتوری کاری یا استیج‌شده را مشاهده کنید.</p>

<h4>مثال‌ها</h4>
<pre>

# Show changes between the working directory and the index
git diff

# Show changes between a specific commit and the working directory
git diff <commit>

# Show changes between two commits
git diff <commit1> <commit2>

# Show changes for a specific file
git diff <commit> <file>

# Show changes in a specific file in the working directory
git diff <file>
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>برای فایل‌های بزرگ یا تغییرات زیاد، ممکن است خروجی زیادی تولید کند</li>
<li>تغییرات در فایل‌های نادیده گرفته شده را نمایش نمی‌دهد مگر اینکه پرچم خاصی تعیین شود</li>
<li>اگر تفاوت‌های زیادی وجود داشته باشد، خروجی می‌تواند بسیار زیاد باشد</li>
</ul>

<h4>گزینه‌ها</h4>
<ul>
<li>-w : نادیده گرفتن تمامی فضاهای سفید هنگام مقایسه</li>
<li>--color : نمایش خروجی رنگی</li>
<li>--name-only : نمایش فقط نام فایل‌های تغییر یافته</li>
<li>--stat : نمایش آمار تغییرات (تعداد خطوط اضافه یا حذف شده)</li>
<li>--patch : نمایش تغییرات (پچ) برای هر فایل</li>
<li>--cached : نمایش تغییرات بین ایندکس و آخرین کامیت</li>
<li>--staged : نمایش تغییرات در حالت استیج شده</li>
<li>--no-index : مقایسه فایل‌ها در گیت ایندکس نشده</li>
<li>--diff-filter : فیلتر کردن تفاوت‌ها بر اساس وضعیت فایل (برای مثال، 'A' برای اضافه شده، 'M' برای تغییر یافته)</li>
</ul>

<h4>موارد کاربرد</h4>
<ul>
    <li>بررسی تغییرات اعمال‌شده در فایل‌ها بین کامیت‌ها</li>
    <li>بازبینی تغییرات استیج‌شده قبل از کامیت کردن</li>
    <li>چک کردن تغییرات دایرکتوری کاری قبل از استیج کردن آنها</li>
    <li>مقایسه کامیت‌های مختلف برای درک نحوه تکامل کد</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن مشخص کردن شناسه کامیت یا فایل، که ممکن است باعث مشاهده تفاوت‌های غیر ضروری شود.</li>
    <li>استفاده از گزینه‌های اشتباه مانند `--staged` وقتی که قصد مشاهده تغییرات دایرکتوری کاری را دارید.</li>
    <li>اشتباه گرفتن خروجی دستور <strong>git diff</strong> با <strong>git status</strong>—در حالی که <strong>git diff</strong> تفاوت‌های واقعی محتویات فایل‌ها را نشان می‌دهد، <strong>git status</strong> وضعیت فایل‌ها را نشان می‌دهد.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>همیشه تغییرات دایرکتوری کاری را قبل از کامیت بررسی کنید، مخصوصاً در کدبیس‌های بزرگ.</li>
    <li>از دستور `git diff --cached` برای بازبینی تغییرات استیج‌شده قبل از نهایی کردن کامیت استفاده کنید.</li>
    <li>از گزینه `--stat` برای مشاهده آمار سریع تعداد تغییرات انجام شده استفاده کنید.</li>
    <li>برای وضوح بهتر، از گزینه `--color` برای خروجی رنگی که تفاوت‌ها را به طور مؤثرتری برجسته می‌کند استفاده کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>تغییرات در فایل‌هایی که توسط گیت نادیده گرفته شده‌اند نمایش داده نمی‌شود.</li>
    <li>برای مخازن بسیار بزرگ با تعداد زیادی تغییرات، خروجی می‌تواند زیاد و دشوار برای بررسی باشد.</li>
    <li>برای فایل‌های نادیده گرفته شده، لازم است که از گزینه‌هایی مانند `git diff --no-index` برای مقایسه آنها استفاده کنید.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>Git diff به شما امکان می‌دهد تغییرات را به روش‌های مختلف مشاهده کنید، چه بین کامیت‌ها، دایرکتوری کاری و ایندکس، یا تغییرات استیج‌شده و نادیده گرفته‌شده. این ابزار برای بازبینی و مدیریت تغییرات کد قبل از کامیت کردن ضروری است.</p>

<h2>نمای کلی</h2>
<p>در یک محیط توسعه مشارکتی، استفاده از دستور <strong>git diff</strong> به شما این امکان را می‌دهد تا تفاوت‌ها بین وضعیت‌های مختلف کد خود را بازبینی کنید، که به شما کمک می‌کند تا تغییرات ایجاد شده را شناسایی کرده و مطمئن شوید که قبل از انتشار یا کامیت کردن، از آن‌ها آگاه هستید.</p>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Commit", LabelEn="Commit ID", LabelFa="شناسه کامیت", Type="text", PlaceholderEn="abc123", PlaceholderFa="abc123" },
        new GitField { Name="File", LabelEn="File", LabelFa="فایل", Type="text", PlaceholderEn="file.txt", PlaceholderFa="file.txt" },
        new GitField { Name="IgnoreWhitespace", LabelEn="Ignore Whitespace (-w)", LabelFa="نادیده گرفتن فضاهای سفید (-w)", Type="checkbox" },
        new GitField { Name="Color", LabelEn="Show Color (--color)", LabelFa="نمایش رنگ (--color)", Type="checkbox" },
        new GitField { Name="NameOnly", LabelEn="Name Only (--name-only)", LabelFa="فقط نام فایل‌ها (--name-only)", Type="checkbox" },
        new GitField { Name="Stat", LabelEn="Show Stat (--stat)", LabelFa="نمایش آمار (--stat)", Type="checkbox" },
        new GitField { Name="Patch", LabelEn="Show Patch (--patch)", LabelFa="نمایش پچ (--patch)", Type="checkbox" },
        new GitField { Name="Cached", LabelEn="Show Cached Changes (--cached)", LabelFa="نمایش تغییرات کش شده (--cached)", Type="checkbox" },
        new GitField { Name="Staged", LabelEn="Show Staged Changes (--staged)", LabelFa="نمایش تغییرات استیج شده (--staged)", Type="checkbox" },
        new GitField { Name="NoIndex", LabelEn="No Index (--no-index)", LabelFa="بدون ایندکس (--no-index)", Type="checkbox" },
        new GitField { Name="DiffFilter", LabelEn="Diff Filter (--diff-filter)", LabelFa="فیلتر تفاوت‌ها (--diff-filter)", Type="text", PlaceholderEn="A,M", PlaceholderFa="A,M" }
    };
}
