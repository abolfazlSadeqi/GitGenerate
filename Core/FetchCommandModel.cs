namespace Core;

public class FetchCommandModel
{
    public string TitleEn => "Fetch Changes from Remote";
    public string TitleFa => "دریافت تغییرات از مخزن ریموت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git fetch [options] [<remote>] [<refspec>...]</pre>

<h4>Examples</h4>
<pre>
git fetch origin                      # Fetch changes from origin
git fetch --all                        # Fetch from all remotes
git fetch origin develop               # Fetch a specific branch
git fetch --prune                      # Remove deleted remote branches
git fetch --depth=1                    # Shallow fetch
</pre>

<h4>What Does It Do?</h4>
<p>The <code>git fetch</code> command downloads updates from a remote repository, including new branches, tags, and commits. However, it does not modify the working directory or merge any changes into the current branch. It merely updates your local repository with the latest changes from the remote.</p>

<h4>Common Use Cases</h4>
<ul>
  <li>Fetching changes from a specific remote repository.</li>
  <li>Fetching updates from all remotes in your configuration.</li>
  <li>Removing deleted remote branches from your local references.</li>
  <li>Performing shallow fetches when you need a limited history.</li>
</ul>

<h4>Limitations</h4>
<ul>
  <li>Does not merge changes into your current working branch. You must manually merge with <code>git merge</code>.</li>
  <li>Requires network access to the remote repository.</li>
  <li>Cannot fetch from private repositories without authentication.</li>
</ul>

<h4>Comparison with `git pull`</h4>
<p><code>git fetch</code> only downloads changes without merging them, while <code>git pull</code> automatically fetches changes and merges them into your current branch. Therefore, <code>git fetch</code> allows for more control, as you can review changes before merging.</p>

<h4>Options</h4>
<ul>
  <li>--all : Fetch from all remotes</li>
  <li>--prune : Remove deleted remote branches</li>
  <li>--dry-run : Show what would be fetched without actually fetching</li>
  <li>--quiet / -q : Suppress output</li>
  <li>--verbose / -v : Show detailed output</li>
  <li>--depth <n> : Limit the fetch to the last <code>n</code> commits (shallow fetch)</li>
  <li>--refmap <map> : Custom refspec mapping</li>
  <li><code><remote></code> : Specify a remote name (default is 'origin')</li>
  <li><code><refspec></code> : Specify a branch or tag to fetch</li>
</ul>

<h4>Best Practices</h4>
<ul>
  <li>Use <code>git fetch</code> regularly to stay up-to-date with remote changes, especially when working in collaborative environments.</li>
  <li>Use <code>--prune</code> to clean up your local references by removing remote branches that no longer exist.</li>
  <li>If you only need a recent commit history, use <code>--depth</code> for a shallow fetch to save bandwidth and time.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
  <li>Running <code>git fetch</code> without checking the status of your local repository, which may cause confusion when merging changes later.</li>
  <li>Using <code>git fetch --all</code> unnecessarily, especially when only working with a single remote repository, leading to unnecessary fetches.</li>
  <li>Forgetting to merge fetched changes after running <code>git fetch</code>, which can cause you to miss important updates.</li>
</ul>

<h2>Overview</h2>
<p>The <code>git fetch</code> command is essential for keeping your local repository synchronized with remote repositories. It allows you to download updates safely without altering your working directory, giving you full control over how and when to merge changes. It is particularly useful in multi-developer environments or when working with a large codebase.</p>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git fetch [گزینه‌ها] [<remote>] [<refspec>...]</pre>

<h4>مثال‌ها</h4>
<pre>
git fetch origin                      # Fetch changes from origin
git fetch --all                        # Fetch from all remotes
git fetch origin develop               # Fetch a specific branch
git fetch --prune                      # Remove deleted remote branches
git fetch --depth=1                    # Shallow fetch
</pre>

<h4>دقیقا چه می‌کند؟</h4>
<p>دستور <code>git fetch</code> تغییرات را از یک مخزن ریموت دانلود می‌کند، از جمله شاخه‌ها، تگ‌ها و کامیت‌های جدید. با این حال، این دستور هیچ تغییری در شاخه یا دایرکتوری کاری شما اعمال نمی‌کند و فقط مخزن محلی شما را با آخرین تغییرات ریموت به‌روزرسانی می‌کند.</p>

<h4>موارد کاربرد رایج</h4>
<ul>
  <li>دریافت تغییرات از یک مخزن ریموت خاص.</li>
  <li>دریافت به‌روزرسانی‌ها از تمام مخازن ریموت موجود در پیکربندی.</li>
  <li>حذف شاخه‌های حذف شده ریموت از مراجع محلی.</li>
  <li>انجام دریافت کم‌عمق برای محدود کردن تاریخچه دریافت شده.</li>
</ul>

<h4>مقایسه با `git pull`</h4>
<p>دستور <code>git fetch</code> فقط تغییرات را دانلود می‌کند و هیچ تغییری در شاخه کاری شما اعمال نمی‌کند. در حالی که <code>git pull</code> به‌طور خودکار تغییرات را دریافت کرده و آنها را در شاخه فعلی ادغام می‌کند. به این ترتیب، <code>git fetch</code> کنترل بیشتری را به شما می‌دهد، زیرا می‌توانید تغییرات را قبل از ادغام بررسی کنید.</p>

<h4>محدودیت‌ها</h4>
<ul>
  <li>تغییرات را به شاخه فعلی ادغام نمی‌کند. شما باید به صورت دستی از <code>git merge</code> برای ادغام استفاده کنید.</li>
  <li>نیاز به دسترسی به شبکه برای ارتباط با مخزن ریموت دارد.</li>
  <li>دریافت از مخازن خصوصی بدون احراز هویت امکان‌پذیر نیست.</li>
</ul>

<h4>گزینه‌ها</h4>
<ul>
  <li>--all : دریافت از همه مخازن ریموت</li>
  <li>--prune : حذف شاخه‌های حذف شده ریموت</li>
  <li>--dry-run : نمایش تغییراتی که دریافت می‌شوند بدون انجام واقعی</li>
  <li>--quiet / -q : مخفی کردن خروجی</li>
  <li>--verbose / -v : نمایش جزئیات</li>
  <li>--depth <n> : محدود کردن دریافت به آخرین <code>n</code> کامیت (دریافت کم‌عمق)</li>
  <li>--refmap <map> : نگاشت refspec سفارشی</li>
  <li><code><remote></code> : مشخص کردن نام مخزن ریموت (پیش‌فرض 'origin')</li>
  <li><code><refspec></code> : مشخص کردن شاخه یا تگ مورد نظر برای دریافت</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
  <li>از <code>git fetch</code> به‌طور منظم استفاده کنید تا از تغییرات ریموت آگاه باشید، مخصوصاً هنگام کار در محیط‌های چند نفره.</li>
  <li>از <code>--prune</code> برای پاکسازی مراجع محلی و حذف شاخه‌های حذف شده ریموت استفاده کنید.</li>
  <li>اگر تنها به تاریخچه اخیر نیاز دارید، از <code>--depth</code> برای دریافت کم‌عمق استفاده کنید تا در زمان و پهنای باند صرفه‌جویی شود.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
  <li>اجرای <code>git fetch</code> بدون بررسی وضعیت مخزن محلی که ممکن است منجر به سردرگمی هنگام ادغام تغییرات شود.</li>
  <li>استفاده غیرضروری از <code>git fetch --all</code> مخصوصاً زمانی که تنها با یک مخزن ریموت کار می‌کنید، که منجر به دریافت‌های غیر ضروری می‌شود.</li>
  <li>فراموش کردن ادغام تغییرات دریافتی بعد از اجرای <code>git fetch</code> که ممکن است باعث از دست دادن به‌روزرسانی‌ها شود.</li>
</ul>

<h2>نمای کلی</h2>
<p>دستور <code>git fetch</code> برای نگه داشتن مخزن محلی شما همگام با مخزن ریموت بسیار ضروری است. این دستور به شما این امکان را می‌دهد که تغییرات را بدون ایجاد تغییرات در دایرکتوری کاری خود دانلود کنید، که به شما این امکان را می‌دهد که به طور کامل کنترل کنید که چه زمانی و چگونه تغییرات را ادغام کنید.</p>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Remote", LabelEn="Remote Name", LabelFa="نام مخزن ریموت", Type="text", PlaceholderEn="origin", PlaceholderFa="origin" },
        new GitField { Name="RefSpec", LabelEn="RefSpec (branch/tag)", LabelFa="RefSpec (شاخه/تگ)", Type="text", PlaceholderEn="develop", PlaceholderFa="develop" },
        new GitField { Name="All", LabelEn="Fetch All Remotes (--all)", LabelFa="دریافت از همه مخازن (--all)", Type="checkbox" },
        new GitField { Name="Prune", LabelEn="Prune Deleted (--prune)", LabelFa="حذف شاخه‌های حذف شده (--prune)", Type="checkbox" },
        new GitField { Name="DryRun", LabelEn="Dry Run (--dry-run)", LabelFa="شبیه‌سازی (--dry-run)", Type="checkbox" },
        new GitField { Name="Quiet", LabelEn="Quiet (-q)", LabelFa="مخفی کردن خروجی (-q)", Type="checkbox" },
        new GitField { Name="Verbose", LabelEn="Verbose (-v)", LabelFa="نمایش جزئیات (-v)", Type="checkbox" },
        new GitField { Name="Depth", LabelEn="Depth (--depth)", LabelFa="تعداد کامیت (--depth)", Type="number", PlaceholderEn="1", PlaceholderFa="1" },
        new GitField { Name="RefMap", LabelEn="Custom RefMap (--refmap)", LabelFa="نگاشت RefMap (--refmap)", Type="text", PlaceholderEn="refs/heads/*:refs/remotes/origin/*", PlaceholderFa="refs/heads/*:refs/remotes/origin/*" }
    };
}
