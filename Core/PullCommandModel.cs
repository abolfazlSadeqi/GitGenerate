namespace Core;

public class PullCommandModel
{
    public string TitleEn => "Pull Changes from Remote";
    public string TitleFa => "دریافت و ادغام تغییرات از مخزن ریموت";

    public string GuideHtmlEn => @"
<h3>Usage</h3>
<pre>git pull [options] [<remote>] [<branch>]</pre>

<h4>Examples</h4>
<pre>
git pull origin                      # Pull changes from origin
git pull --rebase                     # Rebase instead of merge
git pull --all                        # Pull from all remotes
git pull origin develop               # Pull a specific branch
git pull --verbose                    # Show detailed output
</pre>

<h4>What Does It Do?</h4>
<p>The <code>git pull</code> command is used to fetch changes from a remote repository and automatically merge them into the current branch. It combines two commands in one: <code>git fetch</code> followed by <code>git merge</code>, making it a convenient way to update your local branch with the latest changes from the remote repository. Additionally, you can control how the merge is performed (e.g., using rebase instead of merge).</p>

<h4>Common Use Cases</h4>
<ul>
  <li>Updating your local branch with changes from the remote repository.</li>
  <li>Collaborating with others by merging changes into your current branch.</li>
  <li>Using <code>--rebase</code> to keep a linear history by rebasing your local commits on top of the fetched changes.</li>
  <li>Pulling from multiple remotes at once using <code>--all</code>.</li>
</ul>

<h4>Limitations</h4>
<ul>
  <li>Automatically merges changes into the current branch, which might result in merge conflicts.</li>
  <li>Requires network access to the remote repository.</li>
  <li>Cannot pull from private repositories without authentication.</li>
  <li>Conflicts may require manual resolution.</li>
</ul>

<h4>Comparison with `git fetch`</h4>
<p>While both <code>git pull</code> and <code>git fetch</code> download changes from a remote repository, the key difference is that <code>git pull</code> automatically merges the changes into your local branch, whereas <code>git fetch</code> only downloads the changes without modifying your working directory. This makes <code>git pull</code> more convenient for quickly updating your branch, but it also comes with the risk of conflicts that require manual resolution.</p>

<h4>Options</h4>
<ul>
  <li>--rebase : Rebase local commits instead of merging</li>
  <li>--no-rebase : Disable rebase and perform a normal merge</li>
  <li>--all : Pull from all remotes</li>
  <li>--verbose / -v : Show detailed output</li>
  <li>--quiet / -q : Suppress output</li>
  <li>--ff-only : Only allow fast-forward merges (no merge commits)</li>
  <li>--no-ff : Create a merge commit even with fast-forward merges</li>
  <li>--commit : Create a merge commit (default behavior)</li>
  <li>--no-commit : Perform the merge but do not commit it</li>
  <li><code><remote></code> : Specify remote name (default is 'origin')</li>
  <li><code><branch></code> : Specify the branch to pull</li>
</ul>

<h4>Best Practices</h4>
<ul>
  <li>Use <code>git pull --rebase</code> to maintain a clean, linear history and avoid unnecessary merge commits.</li>
  <li>Always review your changes before pulling, especially in collaborative environments, to avoid conflicts.</li>
  <li>Regularly use <code>git pull --verbose</code> to keep track of the changes being merged into your branch.</li>
  <li>If you need to pull from multiple remotes, use <code>--all</code>, but be cautious as this may pull from unexpected remotes.</li>
  <li>When working in teams, ensure you commit your local changes before pulling to avoid unnecessary merge conflicts.</li>
</ul>

<h4>Common Mistakes</h4>
<ul>
  <li>Pulling without first committing or stashing local changes, leading to conflicts.</li>
  <li>Not checking for potential conflicts before pulling changes, which can disrupt your local work.</li>
  <li>Using <code>git pull</code> when <code>git fetch</code> would be more appropriate, as it gives you more control over the merging process.</li>
</ul>

<h2>Overview</h2>
<p>In summary, <code>git pull</code> is a powerful command that allows you to quickly update your local branch by downloading and merging changes from a remote repository. However, you should be aware of its limitations, especially when it comes to merge conflicts, and use it responsibly in combination with other Git commands like <code>git fetch</code> and <code>git rebase</code> to maintain a clean and manageable history.</p>";

    public string GuideHtmlFa => @"
<h3>استفاده</h3>
<pre>git pull [گزینه‌ها] [<remote>] [<branch>]</pre>

<h4>مثال‌ها</h4>
<pre>
git pull origin                      # Pull changes from origin
git pull --rebase                     # Rebase instead of merge
git pull --all                        # Pull from all remotes
git pull origin develop               # Pull a specific branch
git pull --verbose                    # Show detailed output
</pre>

<h4>دقیقا چه می‌کند؟</h4>
<p>دستور <code>git pull</code> برای دریافت تغییرات از مخزن ریموت و ادغام خودکار آن‌ها با شاخه فعلی استفاده می‌شود. این دستور در واقع ترکیبی از دو دستور <code>git fetch</code> و <code>git merge</code> است که باعث می‌شود به‌طور سریع تغییرات ریموت را به شاخه محلی خود منتقل کنید. همچنین می‌توانید رفتار ادغام را کنترل کنید (مثلاً استفاده از <code>rebase</code> به‌جای <code>merge</code>).</p>

<h4>موارد کاربرد رایج</h4>
<ul>
  <li>به‌روزرسانی شاخه محلی با تغییرات جدید از مخزن ریموت.</li>
  <li>ادغام تغییرات با شاخه فعلی برای همکاری با دیگران.</li>
  <li>استفاده از <code>--rebase</code> برای حفظ تاریخچه خطی با rebase کردن کامیت‌های محلی به‌روی تغییرات دریافت‌شده.</li>
  <li>دریافت تغییرات از چندین مخزن با استفاده از <code>--all</code>.</li>
</ul>

<h4>محدودیت‌ها</h4>
<ul>
  <li>تغییرات را به‌صورت خودکار به شاخه فعلی ادغام می‌کند که ممکن است باعث بروز تضاد (conflict) شود.</li>
  <li>نیاز به دسترسی به شبکه برای ارتباط با مخزن ریموت دارد.</li>
  <li>دریافت از مخازن خصوصی بدون احراز هویت امکان‌پذیر نیست.</li>
  <li>در صورت بروز تضاد، نیاز به حل دستی خواهد بود.</li>
</ul>

<h4>مقایسه با `git fetch`</h4>
<p>در حالی که هر دو دستور <code>git pull</code> و <code>git fetch</code> تغییرات را از مخزن ریموت دریافت می‌کنند، تفاوت اصلی در این است که <code>git pull</code> تغییرات را به‌طور خودکار به شاخه محلی شما ادغام می‌کند، در حالی که <code>git fetch</code> فقط تغییرات را دریافت می‌کند بدون اینکه چیزی در دایرکتوری کاری شما تغییر کند. این امر باعث می‌شود که <code>git pull</code> سریع‌تر و راحت‌تر باشد، اما خطر تضادهایی را که نیاز به حل دستی دارند به همراه دارد.</p>

<h4>گزینه‌ها</h4>
<ul>
  <li>--rebase : استفاده از rebase به‌جای merge برای ادغام تغییرات</li>
  <li>--no-rebase : غیرفعال کردن rebase و انجام یک merge عادی</li>
  <li>--all : دریافت از همه مخازن</li>
  <li>--verbose / -v : نمایش جزئیات</li>
  <li>--quiet / -q : مخفی کردن خروجی</li>
  <li>--ff-only : فقط انجام fast-forward merge</li>
  <li>--no-ff : ایجاد یک merge commit حتی در صورت امکان fast-forward</li>
  <li>--commit : ایجاد merge commit (رفتار پیش‌فرض)</li>
  <li>--no-commit : انجام merge بدون commit</li>
  <li><code><remote></code> : مشخص کردن نام ریموت (پیش‌فرض 'origin')</li>
  <li><code><branch></code> : مشخص کردن شاخه‌ای که می‌خواهید دریافت کنید</li>
</ul>

<h4>بهترین شیوه‌ها</h4>
<ul>
  <li>از <code>git pull --rebase</code> استفاده کنید تا تاریخچه خطی حفظ شود و از ایجاد merge commit‌های اضافی جلوگیری شود.</li>
  <li>قبل از انجام pull، تغییرات خود را بررسی کنید تا از بروز تضادهای ناخواسته جلوگیری کنید.</li>
  <li>از <code>git pull --verbose</code> برای مشاهده دقیق‌تر تغییرات استفاده کنید.</li>
  <li>در صورتی که نیاز دارید از چندین ریموت دریافت کنید، از <code>--all</code> استفاده کنید، اما مراقب باشید که از ریموت‌های غیرمنتظره تغییرات دریافت نکنید.</li>
  <li>در هنگام کار با تیم، حتماً قبل از pull کردن تغییرات محلی خود را commit کنید تا از بروز تضادهای غیرضروری جلوگیری کنید.</li>
</ul>

<h4>اشتباهات رایج</h4>
<ul>
  <li>قبل از انجام <code>git pull</code> تغییرات محلی خود را commit یا stash نکرده‌اید، که باعث بروز تضاد می‌شود.</li>
  <li>قبل از pull کردن تغییرات جدید، تضادهای احتمالی را بررسی نکرده‌اید.</li>
  <li>از <code>git pull</code> در حالی که <code>git fetch</code> گزینه بهتری است استفاده می‌کنید، زیرا <code>git fetch</code کنترل بیشتری بر روی روند ادغام به شما می‌دهد.</li>
</ul>

<h2>نمای کلی</h2>
<p>در نهایت، <code>git pull</code> یک دستور قدرتمند است که به شما این امکان را می‌دهد که به‌طور سریع و کارآمد شاخه محلی خود را به‌روزرسانی کنید. اما باید از محدودیت‌های آن و احتمال بروز تضاد آگاه باشید و از آن با احتیاط استفاده کنید، مخصوصاً در شرایط همکاری تیمی که ممکن است تغییرات زیاد و پیچیده‌ای به‌وجود آید.</p>";

    public List<GitField> Fields { get; set; } = new List<GitField>
    {
        new GitField { Name="Remote", LabelEn="Remote Name", LabelFa="نام ریموت", Type="text", PlaceholderEn="origin", PlaceholderFa="origin" },
        new GitField { Name="Branch", LabelEn="Branch", LabelFa="شاخه", Type="text", PlaceholderEn="develop", PlaceholderFa="شاخه" },
        new GitField { Name="Rebase", LabelEn="Rebase (--rebase)", LabelFa="rebase (--rebase)", Type="checkbox" },
        new GitField { Name="NoRebase", LabelEn="No Rebase (--no-rebase)", LabelFa="غیرفعال کردن rebase (--no-rebase)", Type="checkbox" },
        new GitField { Name="All", LabelEn="Pull All Remotes (--all)", LabelFa="دریافت از همه مخازن (--all)", Type="checkbox" },
        new GitField { Name="Verbose", LabelEn="Verbose (-v)", LabelFa="نمایش جزئیات (-v)", Type="checkbox" },
        new GitField { Name="Quiet", LabelEn="Quiet (-q)", LabelFa="مخفی کردن خروجی (-q)", Type="checkbox" },
        new GitField { Name="FfOnly", LabelEn="Fast-Forward Only (--ff-only)", LabelFa="فقط fast-forward (--ff-only)", Type="checkbox" },
        new GitField { Name="NoFf", LabelEn="No Fast-Forward (--no-ff)", LabelFa="غیرفعال کردن fast-forward (--no-ff)", Type="checkbox" },
        new GitField { Name="Commit", LabelEn="Create Commit (--commit)", LabelFa="ایجاد commit (--commit)", Type="checkbox" },
        new GitField { Name="NoCommit", LabelEn="No Commit (--no-commit)", LabelFa="بدون commit (--no-commit)", Type="checkbox" }
    };
}
