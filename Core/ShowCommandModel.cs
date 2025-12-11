namespace Core;

public class ShowCommandModel
{
    public string TitleEn => "Show Git Object";
    public string TitleFa => "نمایش شئ گیت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git show [options] [object]</pre>

<h4>Examples</h4>
<pre>
git show 1234abcd         # Show a commit by its hash
git show HEAD             # Show the latest commit
git show --stat           # Show commit with stat
git show --name-only      # Show files changed in the commit
</pre>

<h4>Options</h4>
<ul>
<li>--stat : Show commit with file changes statistics</li>
<li>--name-only : Show only file names changed in the commit</li>
<li>--name-status : Show file names with status (added, modified, deleted)</li>
<li>--patch : Show the patch (diff) for the commit</li>
<li>--pretty=<format> : Customize the commit message format</li>
</ul>

<h4>What It Does?</h4>
<p>The <strong>git show</strong> command is used to display information about a specific Git object, such as a commit, branch, or tag. This object can be identified by its unique hash. The command is most often used to view detailed information about a commit, including the files modified, the commit message, and the changes made (diff).</p>

<h4>Common Use Cases</h4>
<ul>
    <li>View details of a specific commit using its hash.</li>
    <li>View the latest commit information.</li>
    <li>Inspect the changes made in a commit (diff).</li>
    <li>Quickly check the file names affected by a commit.</li>
</ul>

<h4>Best Practices</h4>
<ul>
    <li>Use <strong>--stat</strong> to quickly view statistics about the changes in a commit.</li>
    <li>Use <strong>--name-only</strong> when you only care about which files were modified in the commit.</li>
    <li>Use <strong>--patch</strong> when you want to view the full diff of changes made in a commit.</li>
    <li>Use <strong>--pretty=<format></strong> to customize the format of the commit message when viewing the commit.</li>
</ul>

<h4>Limitations</h4>
<ul>
    <li>This command only shows information about a single Git object (one commit, branch, or tag) at a time.</li>
    <li>It does not modify any repository files or commits, it only provides information.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to specify a valid Git object (such as a commit hash or branch name) will result in an error.</li>
    <li>Using incorrect format for the <strong>--pretty</strong> option can lead to unexpected output.</li>
</ul>

<h2>Overview</h2>
<p>The <strong>git show</strong> command is an essential tool in Git for displaying detailed information about various Git objects. It's particularly useful for inspecting commit history and changes made to files.</p>
";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git show [گزینه‌ها] [شیء]</pre>

<h4>مثال‌ها</h4>
<pre>
git show 1234abcd         # Show a commit by its hash
git show HEAD             # Show the latest commit
git show --stat           # Show commit with stat
git show --name-only      # Show files changed in the commit
</pre>

<h4>گزینه‌ها</h4>
<ul>
<li>--stat : نمایش commit همراه با آمار تغییرات فایل‌ها</li>
<li>--name-only : نمایش فقط نام فایل‌های تغییر یافته</li>
<li>--name-status : نمایش نام فایل‌ها همراه با وضعیت (اضافه شده، ویرایش شده، حذف شده)</li>
<li>--patch : نمایش patch (diff) برای commit</li>
<li>--pretty=<format> : سفارشی‌سازی فرمت پیام commit</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git show</strong> برای نمایش اطلاعات مربوط به یک شیء گیت خاص (commit، branch، یا tag) استفاده می‌شود که با هش منحصر به فرد خود شناسایی می‌شود. این دستور بیشتر برای مشاهده جزئیات یک commit، از جمله فایل‌های تغییر یافته، پیام commit و تغییرات انجام شده (diff) استفاده می‌شود.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>مشاهده جزئیات یک commit خاص با استفاده از هش آن.</li>
    <li>مشاهده اطلاعات آخرین commit.</li>
    <li>بررسی تغییرات اعمال شده در یک commit (diff).</li>
    <li>بررسی سریع نام فایل‌های تغییر یافته در یک commit.</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
    <li>استفاده از <strong>--stat</strong> برای مشاهده سریع آمار تغییرات در commit.</li>
    <li>استفاده از <strong>--name-only</strong> زمانی که فقط به نام فایل‌های تغییر یافته نیاز دارید.</li>
    <li>استفاده از <strong>--patch</strong> زمانی که می‌خواهید تغییرات دقیق در commit را مشاهده کنید.</li>
    <li>استفاده از <strong>--pretty=<format></strong> برای سفارشی‌سازی فرمت نمایش پیام commit.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
    <li>این دستور تنها اطلاعات مربوط به یک شیء گیت (مثلاً یک commit، branch یا tag) را نمایش می‌دهد.</li>
    <li>این دستور هیچ‌گونه تغییری در فایل‌ها یا commits موجود در مخزن ایجاد نمی‌کند؛ فقط اطلاعات را نمایش می‌دهد.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن تعیین یک شیء گیت معتبر (مثل هش commit یا نام شاخه) منجر به خطا خواهد شد.</li>
    <li>استفاده از فرمت نادرست برای گزینه <strong>--pretty</strong> می‌تواند باعث خروجی غیرمنتظره شود.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <strong>git show</strong> ابزاری بسیار مفید برای نمایش اطلاعات دقیق درباره اشیاء گیت مختلف است. این دستور به ویژه برای مشاهده تاریخچه commitها و تغییرات اعمال شده در فایل‌ها کاربرد دارد.</p>
";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Object", LabelEn="Git Object (commit/hash)", LabelFa="شیء گیت (commit/hash)", Type="text", PlaceholderEn="1234abcd", PlaceholderFa="1234abcd", IsRequired=true },
        new GitField { Name="Stat", LabelEn="Show Stat (--stat)", LabelFa="نمایش آمار (--stat)", Type="checkbox" },
        new GitField { Name="NameOnly", LabelEn="Show Name Only (--name-only)", LabelFa="نمایش نام فایل‌ها (--name-only)", Type="checkbox" },
        new GitField { Name="NameStatus", LabelEn="Show Name and Status (--name-status)", LabelFa="نمایش نام و وضعیت (--name-status)", Type="checkbox" },
        new GitField { Name="Patch", LabelEn="Show Patch (--patch)", LabelFa="نمایش patch (--patch)", Type="checkbox" }
    };
}
