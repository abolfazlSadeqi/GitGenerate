namespace Core
{
    public class CleanCommandModel
    {
        public string TitleEn => "Clean Untracked Files";
        public string TitleFa => "پاکسازی فایل‌های غیر رهگیری شده";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git clean [options]</pre>
<h4>Examples</h4>
<pre>
git clean -n                # Show what will be removed
git clean -f                # Remove untracked files
git clean -fd               # Remove untracked files and directories
git clean -x                # Remove ignored files as well
git clean -fdx              # Remove untracked files and directories, including ignored files
</pre>

<h4>Limitations</h4>
<ul>
<li>Cannot remove files that are not untracked by Git</li>
<li>Dry-run only shows what will be removed, without actually performing the removal</li>
</ul>

<h4>What Does Git Clean Do?</h4>
<p>The <strong>git clean</strong> command is used to remove untracked files and directories from your working directory. This includes files that are not being tracked by Git (i.e., files that have not been added to the index), and optionally, files that are ignored by Git.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>Cleaning up build files, temporary files, or editor backup files that are no longer needed and are not tracked by Git.</li>
    <li>Removing ignored files (e.g., files listed in .gitignore) that clutter your working directory.</li>
    <li>Performing a cleanup after an aborted merge or rebase operation where untracked files may be left behind.</li>
</ul>

<h4>Comparison with Other Git Commands</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>git clean</th>
        <th>git reset</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Removes untracked files from the working directory</td>
        <td>Resets the state of the staging area and working directory to a specific commit</td>
    </tr>
    <tr>
        <td><strong>Effect</strong></td>
        <td>Deletes files and directories that are not tracked by Git (and optionally ignored files).</td>
        <td>Restores changes that were staged or committed but not pushed to the remote repository.</td>
    </tr>
    <tr>
        <td><strong>Files</strong></td>
        <td>Only works on untracked files (files not yet added to Git).</td>
        <td>Works on tracked files, affecting the working directory and staging area.</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p>Think of <strong>git clean</strong> as a way to clean up your working directory by removing files that Git isn't tracking (such as temporary files or files that you've explicitly told Git to ignore). It helps keep your repository clean and uncluttered.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Forgetting to use the <strong>-n</strong> option first to preview which files will be deleted.</li>
    <li>Using <strong>-f</strong> (force) without reviewing what will be removed, leading to accidental deletion of important untracked files.</li>
    <li>Using <strong>-x</strong> without realizing that it also removes files listed in `.gitignore`, which may be important for your development environment.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Always perform a dry-run first using <strong>-n</strong> to see which files will be deleted before actually running the command.</li>
    <li>Use <strong>-f</strong> with caution, especially when cleaning up ignored files, to avoid losing important data.</li>
    <li>If you're unsure, use <strong>git status</strong> to check which files are untracked before performing a clean-up.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li>Git clean cannot remove files that are tracked by Git, only those that are untracked.</li>
    <li>Files that are added to the `.gitignore` file may be removed if <strong>-x</strong> is used.</li>
</ul>

<h3>How to Use</h3>
<p>To clean your working directory and remove untracked files, use <pre>git clean -f</pre>. If you want to also remove directories, add the <strong>-d</strong> option. Use <strong>-n</strong> for a dry run to see which files will be removed without actually deleting them.</p>

<h2>Overview</h2>
<p>The <strong>git clean</strong> command is a powerful tool for cleaning up your working directory by removing untracked files and directories. It helps maintain a clean repository and prevent clutter from build artifacts or temporary files.</p>

<h4>Options</h4>
<ul>
    <li>-n : Dry-run, show what will be removed</li>
    <li>-f : Force removal of untracked files</li>
    <li>-d : Remove untracked directories</li>
    <li>-x : Remove ignored files as well</li>
    <li>-fd : Combination of force and directories</li>
</ul>";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git clean [گزینه‌ها]</pre>

<h4>مثال‌ها</h4>
<pre>
git clean -n                # Show what will be removed
git clean -f                # Remove untracked files
git clean -fd               # Remove untracked files and directories
git clean -x                # Remove ignored files as well
git clean -fdx              # Remove untracked files and directories, including ignored files
</pre>

<h4>محدودیت‌ها</h4>
<ul>
<li>نمی‌توان فایل‌هایی که توسط گیت رهگیری نشده‌اند را حذف کرد</li>
<li>Dry-run تنها فایل‌هایی که حذف خواهند شد را نمایش می‌دهد و هیچ‌گونه عملیاتی انجام نمی‌دهد</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git clean</strong> برای حذف فایل‌ها و دایرکتوری‌های غیررهگیری شده از دایرکتوری کاری شما استفاده می‌شود. این شامل فایل‌هایی است که تحت گیت رهگیری نمی‌شوند (یعنی فایل‌هایی که به ایندکس اضافه نشده‌اند) و به طور اختیاری، فایل‌هایی که گیت آن‌ها را نادیده می‌گیرد.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>پاکسازی فایل‌های ساخت، فایل‌های موقت یا فایل‌های پشتیبان ویرایشگری که دیگر نیازی به آن‌ها نیست و تحت گیت رهگیری نمی‌شوند.</li>
    <li>حذف فایل‌های نادیده گرفته‌شده (مثل فایل‌هایی که در `.gitignore` لیست شده‌اند) که محیط کاری شما را شلوغ کرده‌اند.</li>
    <li>انجام پاکسازی پس از یک عملیات ناموفق مانند مرج یا ریبیس که ممکن است فایل‌های غیر رهگیری شده را به جا بگذارد.</li>
</ul>

<h4>مقایسه با دستورات دیگر گیت</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>git clean</th>
        <th>git reset</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>حذف فایل‌های غیر رهگیری شده از دایرکتوری کاری</td>
        <td>بازنشانی وضعیت ایندکس و دایرکتوری کاری به یک کامیت خاص</td>
    </tr>
    <tr>
        <td><strong>اثر</strong></td>
        <td>حذف فایل‌ها و دایرکتوری‌هایی که تحت گیت رهگیری نمی‌شوند (و به طور اختیاری فایل‌های نادیده گرفته‌شده).</td>
        <td>بازگرداندن تغییرات انجام‌شده که هنوز کامیت یا ارسال به ریموت نشده‌اند.</td>
    </tr>
    <tr>
        <td><strong>فایل‌ها</strong></td>
        <td>فقط روی فایل‌های غیر رهگیری شده کار می‌کند (فایل‌هایی که هنوز به گیت اضافه نشده‌اند).</td>
        <td>روی فایل‌های رهگیری شده کار می‌کند و دایرکتوری کاری و ایندکس را تحت تاثیر قرار می‌دهد.</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>دستور <strong>git clean</strong> به زبان ساده ابزاری است که به شما کمک می‌کند تا فایل‌های غیر ضروری و غیر رهگیری شده را از محیط کاری خود حذف کنید. این دستور کمک می‌کند تا مخزن شما تمیز و مرتب باقی بماند.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>فراموش کردن استفاده از گزینه <strong>-n</strong> برای پیش‌نمایش فایل‌هایی که حذف خواهند شد.</li>
    <li>استفاده از گزینه <strong>-f</strong> (اجباری) بدون بررسی فایل‌های حذف‌شونده، که منجر به حذف تصادفی فایل‌های مهم می‌شود.</li>
    <li>استفاده از گزینه <strong>-x</strong> بدون آگاهی از اینکه این گزینه فایل‌های نادیده گرفته‌شده را نیز حذف می‌کند که ممکن است برای محیط توسعه شما ضروری باشند.</li>
</ul>

<h2>بهترین شیوه‌ها (Best Practices)</h2>
<ul>
    <li>همیشه قبل از اجرای دستور <strong>git clean</strong> با استفاده از <strong>-n</strong> یک شبیه‌سازی انجام دهید تا مطمئن شوید که فقط فایل‌های مورد نظر حذف می‌شوند.</li>
    <li>از گزینه <strong>-f</strong> با دقت استفاده کنید، به‌ویژه هنگام حذف فایل‌های نادیده گرفته‌شده، تا از دست دادن داده‌های مهم جلوگیری کنید.</li>
    <li>اگر مطمئن نیستید، از دستور <strong>git status</strong> برای بررسی فایل‌های غیر رهگیری شده قبل از اجرای پاکسازی استفاده کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>دستور <strong>git clean</strong> فقط می‌تواند فایل‌های غیر رهگیری شده را حذف کند، فایل‌های رهگیری شده نمی‌توانند حذف شوند.</li>
    <li>اگر از گزینه <strong>-x</strong> استفاده کنید، فایل‌های نادیده گرفته‌شده در <strong>.gitignore</strong> نیز حذف می‌شوند.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>برای پاکسازی دایرکتوری کاری و حذف فایل‌های غیر رهگیری شده، از دستور <pre>git clean -f</pre> استفاده کنید. اگر می‌خواهید دایرکتوری‌ها را هم حذف کنید، گزینه <strong>-d</strong> را اضافه کنید. برای شبیه‌سازی و مشاهده فایل‌هایی که حذف خواهند شد بدون انجام عملیات واقعی، از <strong>-n</strong> استفاده کنید.</p>

<h2>نمای کلی</h2>
<p>دستور <strong>git clean</strong> یک ابزار قدرتمند برای پاکسازی دایرکتوری کاری شما از فایل‌ها و دایرکتوری‌های غیر رهگیری شده است. این دستور کمک می‌کند تا مخزن شما تمیز و مرتب باقی بماند و از شلوغی فایل‌های موقت و غیر ضروری جلوگیری شود.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>-n : شبیه‌سازی، نمایش فایل‌هایی که پاک خواهند شد</li>
    <li>-f : حذف اجباری فایل‌های غیر رهگیری شده</li>
    <li>-d : حذف دایرکتوری‌های غیر رهگیری شده</li>
    <li>-x : حذف فایل‌های نادیده گرفته شده</li>
    <li>-fd : ترکیب حذف فایل‌ها و دایرکتوری‌ها</li>
</ul>
";

        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="DryRun", LabelEn="Dry Run (-n)", LabelFa="شبیه‌سازی (-n)", Type="checkbox" },
            new GitField { Name="Force", LabelEn="Force Removal (-f)", LabelFa="حذف اجباری (-f)", Type="checkbox" },
            new GitField { Name="Directories", LabelEn="Remove Directories (-d)", LabelFa="حذف دایرکتوری‌ها (-d)", Type="checkbox" },
            new GitField { Name="IgnoredFiles", LabelEn="Remove Ignored Files (-x)", LabelFa="حذف فایل‌های نادیده گرفته شده (-x)", Type="checkbox" }
        };
    }
}
