namespace Core
{
    public class StatusCommandModel
    {
        public string TitleEn => "Show the Working Tree Status";
        public string TitleFa => "نمایش وضعیت درخت کاری";

        public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git status [options]</pre>
<h4>Examples</h4>
<pre>
git status                # Show status of working tree
git status -s             # Show status in short format
git status -b             # Show branch information
git status -u no          # Show no untracked files
</pre>

<h4>Options</h4>
<ul>
<li>-s : Short format</li>
<li>-b : Show branch information</li>
<li>-u : Show untracked files</li>
</ul>

<h4>What Does Git Status Do?</h4>
<p>The <strong>git status</strong> command shows the current status of the working directory and staging area. It tells you which changes have been staged, which files are modified but unstaged, and which files are untracked. It is an essential command for checking the status of your working tree.</p>

<h4>Common Use Cases</h4>
<ul>
    <li>To check which files have been modified and whether they have been staged for the next commit.</li>
    <li>To see the branch you are currently working on and whether it is ahead, behind, or has diverged from the remote branch.</li>
    <li>To quickly see if there are any untracked files that haven't been added to Git yet.</li>
</ul>

<h4>Comparison with Other Git Commands</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>Feature</th>
        <th>git status</th>
        <th>git diff</th>
    </tr>
    <tr>
        <td><strong>Purpose</strong></td>
        <td>Displays the current state of the working directory and staging area</td>
        <td>Shows the differences between the working directory and the index (or between commits)</td>
    </tr>
    <tr>
        <td><strong>Effect</strong></td>
        <td>Shows which files are modified, staged, or untracked</td>
        <td>Shows line-by-line changes in files</td>
    </tr>
    <tr>
        <td><strong>Details</strong></td>
        <td>Provides a summary of the repository's state</td>
        <td>Shows detailed changes made in the files</td>
    </tr>
</table>

<h4>In Simple Terms</h4>
<p>Think of <strong>git status</strong> as a quick overview of your Git repository. It lets you know what changes are staged, what has been modified but not staged, and which files are untracked, all without having to look at each file manually.</p>

<h4>Common Mistakes</h4>
<ul>
    <li>Confusing staged files with modified but unstaged files. Use `git diff` to check the specific changes in the files.</li>
    <li>Forgetting that untracked files are not yet under version control, and might need to be added with `git add` before committing.</li>
    <li>Assuming that the status output will show remote differences. For that, use `git fetch` and `git status` to compare your branch with the remote.</li>
</ul>

<h2>Best Practices</h2>
<ul>
    <li>Use <strong>git status</strong> regularly to keep track of your changes and to ensure you know which files are staged and which are not.</li>
    <li>Before committing, always check the status to make sure all the necessary files are staged and that you’re on the right branch.</li>
    <li>Use <strong>git status -s</strong> to get a concise view of changes when working on large repositories with many modified files.</li>
</ul>

<h2>Limitations</h2>
<ul>
    <li><strong>git status</strong> doesn’t show the actual content changes. For that, you need to use <strong>git diff</strong>.</li>
    <li>It doesn’t tell you the exact reason for a file being untracked; it just lists files that Git isn't currently tracking.</li>
</ul>

<h3>How to Use</h3>
<p>Simply run <pre>git status</pre> to view the current status of your working directory. For a more compact overview, use the <strong>-s</strong> flag. If you need to see branch information, use <strong>-b</strong>.</p>

<h2>Overview</h2>
<p>The <strong>git status</strong> command is your go-to tool for checking the current state of your working directory. It helps you quickly understand the status of tracked and untracked files, the current branch, and any staged or unstaged changes.</p>

<h4>Options</h4>
<ul>
    <li>-s : Short format, shows changes in a compact way</li>
    <li>-b : Show the current branch and its relationship to the remote branch</li>
    <li>-u : Show untracked files (or hide them)</li>
</ul>
";

        public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git status [گزینه‌ها]</pre>

<h4>مثال‌ها</h4>
<pre>
git status                # Show status of working tree
git status -s             # Show status in short format
git status -b             # Show branch information
git status -u no          # Show no untracked files
</pre>

<h4>گزینه‌ها</h4>
<ul>
<li>-s : فرمت خلاصه</li>
<li>-b : نمایش اطلاعات شاخه</li>
<li>-u : نمایش فایل‌های غیر رهگیری شده</li>
</ul>

<h4>دقیقاً چه می‌کند؟</h4>
<p>دستور <strong>git status</strong> وضعیت فعلی دایرکتوری کاری و ناحیه استیجینگ را نمایش می‌دهد. این دستور به شما می‌گوید که کدام تغییرات آماده‌ی کامیت هستند، کدام فایل‌ها تغییر کرده‌اند اما آماده‌ی کامیت نشده‌اند و کدام فایل‌ها غیر رهگیری شده‌اند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
    <li>برای بررسی اینکه کدام فایل‌ها تغییر کرده‌اند و آیا آن‌ها برای کامیت آماده هستند یا نه.</li>
    <li>برای مشاهده‌ی اطلاعات شاخه‌ای که در حال کار روی آن هستید و بررسی اینکه آیا شاخه از شاخه‌ی ریموت جلوتر، عقب‌تر یا جدا شده است.</li>
    <li>برای دیدن فایل‌های غیر رهگیری شده که هنوز به گیت اضافه نشده‌اند.</li>
</ul>

<h4>مقایسه با دستورات دیگر گیت</h4>
<table border='1' cellpadding='10'>
    <tr>
        <th>ویژگی</th>
        <th>git status</th>
        <th>git diff</th>
    </tr>
    <tr>
        <td><strong>هدف</strong></td>
        <td>نمایش وضعیت فعلی دایرکتوری کاری و ناحیه استیجینگ</td>
        <td>نمایش تفاوت‌ها بین دایرکتوری کاری و ایندکس (یا بین کامیت‌ها)</td>
    </tr>
    <tr>
        <td><strong>اثر</strong></td>
        <td>نمایش فایل‌های تغییر کرده، آماده کامیت شده، یا غیر رهگیری شده</td>
        <td>نمایش تغییرات خط به خط در فایل‌ها</td>
    </tr>
    <tr>
        <td><strong>جزئیات</strong></td>
        <td>خلاصه‌ای از وضعیت مخزن</td>
        <td>نمایش تغییرات دقیق انجام‌شده در فایل‌ها</td>
    </tr>
</table>

<h4>به زبان ساده</h4>
<p>دستور <strong>git status</strong> یک نمای کلی از وضعیت مخزن شما است. این دستور به شما می‌گوید که کدام تغییرات آماده‌ی کامیت هستند، کدام فایل‌ها تغییر کرده‌اند اما هنوز کامیت نشده‌اند و کدام فایل‌ها به گیت اضافه نشده‌اند.</p>

<h4>اشتباهات رایج</h4>
<ul>
    <li>مبهم بودن تفاوت بین فایل‌های آماده‌ی کامیت و فایل‌های تغییر کرده که هنوز استیج نشده‌اند. برای بررسی تغییرات دقیق‌تر از دستور <strong>git diff</strong> استفاده کنید.</li>
    <li>فراموش کردن اینکه فایل‌های غیر رهگیری شده هنوز تحت کنترل نسخه قرار نگرفته‌اند و باید با <strong>git add</strong> به گیت اضافه شوند.</li>
    <li>گمان اینکه خروجی دستور <strong>git status</strong> تفاوت‌های ریموت را هم نشان می‌دهد. برای این کار باید از <strong>git fetch</strong> و سپس از <strong>git status</strong> استفاده کنید.</li>
</ul>

<h2>بهترین شیوه‌ها</h2>
<ul>
    <li>به‌طور مرتب از دستور <strong>git status</strong> برای پیگیری وضعیت تغییرات خود استفاده کنید.</li>
    <li>قبل از کامیت کردن، حتماً وضعیت را بررسی کنید تا مطمئن شوید که همه‌ی فایل‌های لازم استیج شده‌اند و در شاخه‌ی درستی هستید.</li>
    <li>در مخزن‌های بزرگ که فایل‌های زیادی تغییر کرده‌اند، از <strong>git status -s</strong> برای نمایش وضعیت به صورت خلاصه استفاده کنید.</li>
</ul>

<h2>محدودیت‌ها</h2>
<ul>
    <li>دستور <strong>git status</strong> تغییرات محتویات فایل‌ها را نشان نمی‌دهد. برای این کار از دستور <strong>git diff</strong> استفاده کنید.</li>
    <li>این دستور فقط فایل‌های غیر رهگیری شده را نشان می‌دهد و اطلاعات بیشتری در مورد علت نادیده گرفتن فایل‌ها ارائه نمی‌دهد.</li>
</ul>

<h3>نحوه استفاده</h3>
<p>به سادگی دستور <pre>git status</pre> را اجرا کنید تا وضعیت فعلی دایرکتوری کاری خود را مشاهده کنید. برای مشاهده نمای خلاصه از گزینه <strong>-s</strong> استفاده کنید. اگر نیاز به مشاهده اطلاعات شاخه دارید، از گزینه <strong>-b</strong> استفاده کنید.</p>

<h2>نمای کلی</h2>
<p>دستور <strong>git status</strong> ابزاری است که وضعیت فعلی دایرکتوری کاری شما را نشان می‌دهد. این دستور به شما کمک می‌کند تا بفهمید که چه فایل‌هایی تغییر کرده‌اند، چه فایل‌هایی آماده کامیت هستند و کدام فایل‌ها هنوز تحت کنترل گیت قرار نگرفته‌اند.</p>

<h4>گزینه‌ها</h4>
<ul>
    <li>-s : فرمت خلاصه، نمایش تغییرات به صورت فشرده</li>
    <li>-b : نمایش شاخه جاری و وضعیت آن نسبت به شاخه ریموت</li>
    <li>-u : نمایش فایل‌های غیر رهگیری شده (یا عدم نمایش آن‌ها)</li>
</ul>
";

        public List<GitField> Fields { get; set; } = new List<GitField>
        {
            new GitField { Name="Short", LabelEn="Short Format (-s)", LabelFa="فرمت خلاصه (-s)", Type="checkbox" },
            new GitField { Name="Branch", LabelEn="Show Branch (-b)", LabelFa="نمایش شاخه (-b)", Type="checkbox" },
            new GitField { Name="Untracked", LabelEn="Show Untracked (-u)", LabelFa="نمایش غیر رهگیری شده (-u)", Type="checkbox" }
        };
    }
}
